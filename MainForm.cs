/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 07.11.2018
 * Time: 15:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			data = new Data();
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
		
		protected string GetItemFieldsJson(object item)
		{
			string ret = "{";
			var fields = item.GetType().GetFields();
			foreach (var field in fields) {
				var val = field.GetValue(item).ToString();
				if (val == "") {
					continue;
				}
				ret += "\"" + field.Name + "\":\"" + EscapeSpecialChars(val) + "\",";
			}
			return ret.Substring(0, ret.Length - 1) + "}";
		}
		
		protected string[] GetListItemsJsonStrings<T>(string name, List<T> itemsList, string pad, int level)
		{
			var items = new string[itemsList.Count + 2];
			items[0] = pad + "\"" + FixName(name) + "\": [";
			items[items.Length - 1] = pad + "],";
			pad = "".PadLeft(++level * PADDING);
			int i = 0;
			foreach (var item in itemsList) {
				items[++i] = pad + GetItemFieldsJson(item) + ",";
			}
			var lastItem = items[items.Length - 2];
			items[items.Length - 2] = lastItem.Substring(0, lastItem.Length - 1);
			return items;
		}
		
		protected string[] GetValFormated(string name, object val, string pad, int level)
		{
			if (val is string) {
				if ((string) val == "") {
					return new string[0];
				}
				return new [] { pad + "\"" + FixName(name) + "\":\"" + EscapeSpecialChars((string) val) + "\"," };
			}
			
			if (val is bool) {
				return new [] { pad + "\"" + FixName(name) + "\":\"" + val.ToString().ToLower() + "\"," };
			}
			
			if (name == "authors") {
				return GetListItemsJsonStrings<Author>(name, (List<Author>) val, pad, level);
			}
			
			if (name == "support") {
				return GetListItemsJsonStrings<Support>(name, (List<Support>) val, pad, level);
			}
			
			if (name == "require" && data.require != null && data.require.Count > 0) {
				var items = new string[data.require.Count + 2];
				items[0] = pad + "\"" + FixName(name) + "\": {";
				items[items.Length - 1] = pad + "},";
				pad = "".PadLeft(++level * PADDING);
				int i = 0;
				foreach (var req in data.require) {
					items[++i] = pad + "\"" + req.Key + "\":\"" + EscapeSpecialChars(req.Value) + "\",";
				}
				var lastItem = items[items.Length - 2];
				items[items.Length - 2] = lastItem.Substring(0, lastItem.Length - 1);
				return items;
			}
			
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
			if (level == 0) {
				sb.AppendLine(pad + "{");
			}
			pad = "".PadLeft(++level * PADDING);
			
			var fields = obj.GetType().GetFields();
			foreach(var field in fields) {
				if (field.GetValue(obj) == null) {
					continue;
				}
				foreach (var s in GetValFormated(field.Name, field.GetValue(obj), pad, level)) {
					sb.AppendLine(s);
				}
			}
			
			pad = "".PadLeft(--level * PADDING);
			sb.AppendLine(pad + "}");
			
			string jsonString = sb.ToString();
			int pos = jsonString.LastIndexOf(',');
			if (pos != -1) {
				jsonString = jsonString.Substring(0, pos) + jsonString.Substring(pos + 1);
			}
			
			return jsonString;
		}
		
		protected void UpdateJson()
		{
//			var serializer = new JavaScriptSerializer();
//			//using Newtonsoft.Json - conflict
//			json.Text = JToken.Parse(serializer.Serialize(data)).ToString(Formatting.Indented);
//			//Correct, but not nice JSON
//			json.Text = FormatJson(serializer.Serialize(data));
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
			if (requiredFields.Contains(ctrl.Name)) {
				e.Cancel = ctrl.Text == "";
			}
		}
		
		void AuthorsEnter(object sender, EventArgs e)
		{
			if (data.authors == null) {
				data.authors = new List<Author>();
			}
			
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
			if (data.support == null) {
				data.support = new List<Support>();
			}
			
			var form = new SupportsForm(data);
			form.ShowDialog();
			
			supports.Text = "";
			if (data.support.Count == 0) {
				data.support = null;
			} else {
				foreach (Support support in data.support) {
					supports.Text += support.email + ", ";
				}
				supports.Text = supports.Text.Substring(0, supports.Text.Length - 2);
			}
			
			UpdateJson();
			
			((Control) sender).Parent.SelectNextControl(ActiveControl, true, true, true, true);
		}
		
		void RequiresEnter(object sender, EventArgs e)
		{
			if (data.require == null) {
				data.require = new Dictionary<string, string>();
			}
			
			var form = new RequiresForm(data);
			form.ShowDialog();
			
			requires.Text = "";
			if (data.require.Count == 0) {
				data.require = null;
			} else {
				foreach (var req in data.require) {
					requires.Text += req.Key + ", ";
				}
				requires.Text = requires.Text.Substring(0, requires.Text.Length - 2);
			}
			
			UpdateJson();
			
			((Control) sender).Parent.SelectNextControl(ActiveControl, true, true, true, true);
		}
	}
}
