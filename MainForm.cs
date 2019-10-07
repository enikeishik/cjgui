/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 07.11.2018
 * Time: 15:44
 * 
 * @copyright   Copyright (C) 2018 Enikeishik <enikeishik@gmail.com>. All rights reserved.
 * @author      Enikeishik <enikeishik@gmail.com>
 * @license     GNU General Public License version 2 or later; see LICENSE.txt
 */
using System;
using System.Windows.Forms;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace CJGui
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        protected const int PADDING = 4;
        
        protected string[] requiredFields = {"name", "description", "type"};
        
        protected readonly Data data;
        
        public MainForm()
        {
            InitializeComponent();
            
            data = new Data();
            
            type.SelectedIndex = 0;
            prefer_stable.Checked = data.prefer_stable;
            abandoned.Checked = data.abandoned;
        }
        
        protected string FormatJson(string json)
        {
            return json
                .Replace("{", "{\r\n    ")
                .Replace("[", "[\r\n    ")
                .Replace("]", "\r\n]")
                .Replace("}", "\r\n}");
        }
        
        protected string EscapeSpecialChars(string str)
        {
            return str.Replace("\\", "\\\\").Replace("\"", "\\\"");
        }
        
        protected string FixName(string name)
        {
            return name.Replace('_', '-');
        }
        
        protected string FixStrArr(string str)
        {
            if (str.IndexOf("\"[") == 0 && str.LastIndexOf("]\"") == (str.Length - 2))
                return str.Trim(new [] {'"'});
            
            return str;
        }
        
        protected string GetObjectJson(object obj)
        {
            string ret = "{";
            var fields = obj.GetType().GetFields();
            foreach (var field in fields) {
                var val = field.GetValue(obj).ToString();
                
                if (val == "")
                    continue;
                
                ret += "\"" + field.Name + "\":\"" + EscapeSpecialChars(val) + "\",";
            }
            return ret.Substring(0, ret.Length - 1) + "}";
        }
        
        protected string GetStringJson(string str)
        {
            return "\"" + EscapeSpecialChars(str) + "\"";
        }
        
        protected string GetItemFieldsJson(object item)
        {
            if (item is string)
                return GetStringJson((string) item);
            
            return GetObjectJson(item);
        }
        
        protected string[] GetItemsJsonStrings<T>(string name, List<T> itemsList, string pad, int level)
        {
            var items = new string[itemsList.Count + 2];
            items[0] = pad + "\"" + FixName(name) + "\": [";
            items[items.Length - 1] = pad + "],";
            pad = "".PadLeft(++level * PADDING);
            int i = 0;
            foreach (var item in itemsList)
                items[++i] = pad + GetItemFieldsJson(item) + ",";
            
            var lastItem = items[items.Length - 2];
            items[items.Length - 2] = lastItem.Substring(0, lastItem.Length - 1);
            return items;
        }
        
        protected string[] GetItemsJsonStrings<TVal>(string name, Dictionary<string, TVal> itemsDict, string pad, int level, bool raw = false)
        {
            var items = new string[itemsDict.Count + 2];
            items[0] = pad + "\"" + FixName(name) + "\": {";
            items[items.Length - 1] = pad + "},";
            pad = "".PadLeft(++level * PADDING);
            int i = 0;
            foreach (var item in itemsDict) {
                //TODO: modify GetItemFieldsJson to walk through string(value)|object(fields)
                //items[++i] = pad + GetItemFieldsJson(item.Value) + ",";
                if (raw)
                    items[++i] = pad + "\"" + item.Key + "\":" + FixStrArr(item.Value.ToString()) + ",";
                else
                    items[++i] = pad + "\"" + item.Key + "\":\"" + EscapeSpecialChars(item.Value.ToString()) + "\",";
            }
            var lastItem = items[items.Length - 2];
            items[items.Length - 2] = lastItem.Substring(0, lastItem.Length - 1);
            return items;
        }
        
        protected string[] GetValFormated(string name, object val, string pad, int level)
        {
            //TODO: temporary stub
            if (name == "repositories" || name == "config") {
                if ((string) val == "")
                    return new string[0];
                
                return new [] { pad + "\"" + FixName(name) + "\":" + (string) val + "," };
            }
            
            if (val is string) {
                if ((string) val == "")
                    return new string[0];
                
                return new [] { pad + "\"" + FixName(name) + "\":\"" + EscapeSpecialChars((string) val) + "\"," };
            }
            
            if (val is bool)
                return new [] { pad + "\"" + FixName(name) + "\":\"" + val.ToString().ToLower() + "\"," };
            
            if (val is Dictionary<string, string>) {
                var dict = (Dictionary<string, string>) val;
                if (dict.Count > 0)
                    return GetItemsJsonStrings<string>(name, dict, pad, level);
                
                return new string[] {};
            }
            
            if (val is Dictionary<string, StrArr>) {
                var dict = (Dictionary<string, StrArr>) val;
                if (dict.Count > 0)
                    return GetItemsJsonStrings<StrArr>(name, dict, pad, level, true);
                
                return new string[] {};
            }
            
            if (val is List<string>) {
                var list = (List<string>) val;
                if (list.Count > 0)
                    return GetItemsJsonStrings<string>(name, list, pad, level);
                
                return new string[] {};
            }
            
            if (val is StrArr) {
                if (((StrArr) val).Values.Count == 0)
                    return new string[0];
                
                return new [] {pad + "\"" + FixName(name) + "\":" + val};
            }
            
            if (name == "authors")
                return GetItemsJsonStrings<Author>(name, (List<Author>) val, pad, level);
            
            if (val != null) {
                return new [] {
                    pad + "\"" + FixName(name) + "\": {",
                    GetFormatedStringFromObject(val, level).TrimEnd(new [] {'\r', '\n'})
                };
            }
            return new string[] {};
        }
        
        protected string GetFormatedStringFromObject(object obj, int level = 0)
        {
            string pad = "".PadLeft(level * PADDING);
            
            var sb = new StringBuilder();
            if (level == 0)
                sb.AppendLine(pad + "{");
            
            pad = "".PadLeft(++level * PADDING);
            
            var fields = obj.GetType().GetFields();
            foreach(var field in fields) {
                if (field.GetValue(obj) == null)
                    continue;
                
                foreach (var s in GetValFormated(field.Name, field.GetValue(obj), pad, level))
                    sb.AppendLine(s);
            }
            
            pad = "".PadLeft(--level * PADDING);
            sb.AppendLine(pad + "}");
            
            string jsonString = sb.ToString();
            int pos = jsonString.LastIndexOf(',');
            if (pos != -1)
                jsonString = jsonString.Substring(0, pos) + jsonString.Substring(pos + 1);
            
            return jsonString;
        }
        
        protected void UpdateJson()
        {
//            var serializer = new JavaScriptSerializer();
//            //using Newtonsoft.Json - conflict
//            json.Text = JToken.Parse(serializer.Serialize(data)).ToString(Formatting.Indented);
//            //Correct, but not nice JSON
//            json.Text = FormatJson(serializer.Serialize(data));
            //Nice, but may be not correct JSON
            json.Text = GetFormatedStringFromObject(data);
        }
        
        void FieldChanged(object sender, EventArgs e)
        {
            if (sender is MainForm) {
                UpdateJson();
                return;
            }
            
            var ctrl = (Control) sender;
            data.GetType().GetField(ctrl.Name).SetValue(
                data, 
                ctrl.Text != "" ? ctrl.Text : null
            );
            
            UpdateJson();
        }
        
        void SelectJson(object sender, EventArgs e)
        {
            TextBox tb = ((TextBox) sender);
            tb.SelectionStart = 0;
            tb.SelectionLength = tb.Text.Length;
        }
        
        void FieldValidating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var ctrl = (Control) sender;
            if (requiredFields.Contains(ctrl.Name))
                e.Cancel = ctrl.Text == "";
        }
        
        void AuthorsEnter(object sender, EventArgs e)
        {
            if (data.authors == null)
                data.authors = new List<Author>();
            
            var form = new AuthorsForm(data);
            form.ShowDialog();
            
            authors.Text = "";
            if (data.authors.Count == 0) {
                data.authors = null;
            } else {
                foreach (Author author in data.authors) {
                    authors.Text += author.name + ", ";
                }
                authors.Text = authors.Text.Substring(0, authors.Text.Length - 2);
            }
            
            UpdateJson();
            
            ((Control) sender).Parent.SelectNextControl(ActiveControl, true, true, true, true);
        }
        
        void SupportsEnter(object sender, EventArgs e)
        {
            if (data.support == null)
                data.support = new Support();
            
            var form = new SupportForm(data.support);
            form.ShowDialog();
            
            supports.Text = "";
            if (data.support.email == "")
                data.support = null;
            else
                supports.Text += data.support.email;
            
            UpdateJson();
            
            ((Control) sender).Parent.SelectNextControl(ActiveControl, true, true, true, true);
        }
        
        void DictFieldEnter(object sender, EventArgs e)
        {
            var formControl = (Control) sender;
            
            var dataField = (Dictionary<string, string>) data.GetType().GetField(formControl.Name).GetValue(data);
            
            if (dataField == null)
                dataField = new Dictionary<string, string>();
            
            var form = new PackagesForm(dataField);
            form.ShowDialog();
            
            formControl.Text = "";
            if (dataField.Count == 0) {
                dataField = null;
            } else {
                foreach (var item in dataField)
                    formControl.Text += item.Key + ", ";
                
                formControl.Text = formControl.Text.Substring(0, formControl.Text.Length - 2);
            }
            data.GetType().GetField(formControl.Name).SetValue(data, dataField);
            
            UpdateJson();
            
            formControl.Parent.SelectNextControl(ActiveControl, true, true, true, true);
        }
        
        void AutoloadEnter(object sender, EventArgs e)
        {
            var formControl = (Control) sender;
            
            var dataField = (Autoload) data.GetType().GetField(formControl.Name).GetValue(data);
    
            if (dataField == null)
                dataField = new Autoload();
            
            var form = new AutoloadForm(dataField);
            form.ShowDialog();
            
            formControl.Text = "";
            
            if (dataField.psr_4.Keys.Count > 0)
                formControl.Text += ", PSR-4";
            
            if (dataField.psr_0.Keys.Count > 0)
                formControl.Text += ", PSR-0";
            
            if (dataField.classmap.Count > 0)
                formControl.Text += ", Classmap";
            
            if (dataField.files.Count > 0)
                formControl.Text += ", Files";
            
            if (dataField.exclude_from_classmap.Count > 0)
                formControl.Text += ", Excluded from classmap";
            
            if (formControl.Text.Length > 0)
                formControl.Text = formControl.Text.Substring(2);
            
            data.GetType().GetField(formControl.Name).SetValue(data, dataField);
            
            UpdateJson();
            
            formControl.Parent.SelectNextControl(ActiveControl, true, true, true, true);
        }
        
        void Prefer_stableClick(object sender, EventArgs e)
        {
            data.prefer_stable = prefer_stable.Checked;
            UpdateJson();
        }
        
        void AbandonedClick(object sender, EventArgs e)
        {
            data.abandoned = abandoned.Checked;
            UpdateJson();
        }
        
        void BinEnter(object sender, EventArgs e)
        {
            var formControl = (Control) sender;
            
            var dataField = (StrArr) data.GetType().GetField(formControl.Name).GetValue(data);
            
            if (dataField == null)
                dataField = new StrArr();
            
            
            var form = new ListBoxForm(dataField.Values);
            form.ShowDialog();
            
            formControl.Text = dataField.ToString().Trim(new [] {'"'});
            data.GetType().GetField(formControl.Name).SetValue(data, dataField);
            
            UpdateJson();
            
            ((Control) sender).Parent.SelectNextControl(ActiveControl, true, true, true, true);
        }
        
        void Non_feature_branchesEnter(object sender, EventArgs e)
        {
            var formControl = (Control) sender;
            
            var dataField = (List<string>) data.GetType().GetField(formControl.Name).GetValue(data);
            
            if (dataField == null)
                dataField = new List<string>();
            
            
            var form = new ListBoxForm(dataField);
            form.ShowDialog();
            
            formControl.Text = (new StrArr(dataField)).ToString().Trim(new [] {'"'});
            data.GetType().GetField(formControl.Name).SetValue(data, dataField);
            
            UpdateJson();
            
            ((Control) sender).Parent.SelectNextControl(ActiveControl, true, true, true, true);
        }
        
        void ArchiveEnter(object sender, EventArgs e)
        {
            var formControl = (Control) sender;
            
            var dataField = (Archive) data.GetType().GetField(formControl.Name).GetValue(data);
            
            if (dataField == null)
                dataField = new Archive();
            
            
            var form = new ListBoxForm(dataField.exclude);
            form.ShowDialog();
            
            formControl.Text = (new StrArr(dataField.exclude)).ToString().Trim(new [] {'"'});
            data.GetType().GetField(formControl.Name).SetValue(data, dataField);
            
            UpdateJson();
            
            ((Control) sender).Parent.SelectNextControl(ActiveControl, true, true, true, true);
        }
        
        void ScriptsEnter(object sender, EventArgs e)
        {
            var formControl = (Control) sender;
            
            var dataField = (Scripts) data.GetType().GetField(formControl.Name).GetValue(data);
            
            if (dataField == null)
                dataField = new Scripts();
            
            
            var form = new ScriptsForm(dataField);
            form.ShowDialog();
            
            foreach (var fld in dataField.GetType().GetFields()) {
                bool empty = true;
                if (fld.Name != "custom")
                    empty = ((StrArr) fld.GetValue(dataField)).Values.Count == 0;
                else
                    empty = ((Dictionary<string, StrArr>) fld.GetValue(dataField)).Count == 0;
                
                if (!empty)
                    formControl.Text += ", " + FixName(fld.Name);
            }
            
            if (formControl.Text.Length > 0)
                formControl.Text = formControl.Text.Substring(2);
            
            data.GetType().GetField(formControl.Name).SetValue(data, dataField);
            
            UpdateJson();
            
            ((Control) sender).Parent.SelectNextControl(ActiveControl, true, true, true, true);
        }
    }
}
