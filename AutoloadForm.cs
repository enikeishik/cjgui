/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 12.11.2018
 * Time: 13:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace CJGui
{
	/// <summary>
	/// Description of AutoloadForm.
	/// </summary>
	public partial class AutoloadForm : Form
	{
		protected readonly Autoload autoload;
		
		protected AutoloadForm()
		{
			InitializeComponent();
		}
		
		public AutoloadForm(Autoload autoload)
			: this()
		{
			this.autoload = autoload;
		}
		
		void CloseClick(object sender, EventArgs e)
		{
			Close();
		}
		
		protected ListView GetListView(string group)
		{
			return (ListView) Controls.Find("lvw" + group, true)[0];
		}
		
		void AddPsrClick(object sender, EventArgs e)
		{
			var aItem = new Dictionary<string, StrArr>(1);
			
			var form = new AutoloadPsrForm(aItem);
			form.ShowDialog(this);
			
			var item = new ListViewItem(aItem.Keys.First());
			item.SubItems.Add(aItem.Values.First().Value.Trim(new [] {'"'}));
			var listView = GetListView(((Control) sender).Name.Substring("add".Length));
			listView.Items.Add(item);
		}
		
		void EditPsrClick(object sender, EventArgs e)
		{
			ListView listView;
			if (sender is Button) {
				listView = GetListView(((Control) sender).Name.Substring("edit".Length));
			} else {
				listView = (ListView) sender;
			}
			
			if (listView.SelectedItems.Count == 0) {
				return;
			}
			
			var item = listView.SelectedItems[0];
			var aItem = new Dictionary<string, StrArr>(1);
			aItem.Add(item.Text, new StrArr(item.SubItems[1].Text));
			
			var form = new AutoloadPsrForm(aItem);
			form.ShowDialog(this);
			
			item.Text = aItem.Keys.First();
			item.SubItems[1].Text = aItem.Values.First().ToString().Trim(new [] {'"'});
		}
		
		void RemovePsrClick(object sender, EventArgs e)
		{
			var listView = GetListView(((Control) sender).Name.Substring("remove".Length));
			
			if (listView.SelectedItems.Count == 0) {
				return;
			}
			var item = listView.SelectedItems[0];
			listView.Items.Remove(item);
		}
		
		protected ListBox GetListBox(string group)
		{
			return (ListBox) Controls.Find("lbx" + group, true)[0];
		}
		
		void AddClick(object sender, EventArgs e)
		{
			var ret = Interaction.InputBox("", "Add new value");
			if (ret != "") {
				var listBox = GetListBox(((Control) sender).Name.Substring("add".Length));
				listBox.Items.Add(ret);
			}
		}
		
		void EditClick(object sender, EventArgs e)
		{
			ListBox listBox;
			if (sender is Button) {
				listBox = GetListBox(((Control) sender).Name.Substring("edit".Length));
			} else {
				listBox = (ListBox) sender;
			}
			
			if (listBox.SelectedItems.Count == 0) {
				return;
			}
			
			var val = listBox.SelectedItem.ToString();
			var ret = Interaction.InputBox(val, "Edit value", val);
			listBox.Items.Insert(listBox.SelectedIndex, ret);
			listBox.Items.Remove(listBox.SelectedItem);
		}
		
		void RemoveClick(object sender, EventArgs e)
		{
			var listBox = GetListBox(((Control) sender).Name.Substring("remove".Length));
			if (listBox.SelectedItems.Count == 0) {
				return;
			}
			listBox.Items.Remove(listBox.SelectedItem);
		}
		
		void ThisFormClosing(object sender, FormClosingEventArgs e)
		{
			autoload.psr_4 = new Dictionary<string, StrArr>(lvwPsr_4.Items.Count);
			foreach (ListViewItem item in lvwPsr_4.Items) {
				List<string> list = new List<string>(item.SubItems.Count);
				for (var i = 1; i < item.SubItems.Count; i++) {
					list.Add(item.SubItems[i].Text);
				}
				autoload.psr_4.Add(item.Text, new StrArr(list));
			}
			
			autoload.psr_0 = new Dictionary<string, StrArr>(lvwPsr_0.Items.Count);
			foreach (ListViewItem item in lvwPsr_0.Items) {
				List<string> list = new List<string>(item.SubItems.Count);
				for (var i = 1; i < item.SubItems.Count; i++) {
					list.Add(item.SubItems[i].Text);
				}
				autoload.psr_0.Add(item.Text, new StrArr(list));
			}
			
			autoload.classmap = new List<string>((IEnumerable<string>) lbxClassmap.Items.Cast<string>());
			autoload.files = new List<string>((IEnumerable<string>) lbxFiles.Items.Cast<string>());
			autoload.exclude_from_classmap = new List<string>((IEnumerable<string>) lbxExclude.Items.Cast<string>());
		}
		
		void ThisFormLoad(object sender, EventArgs e)
		{
			if (autoload == null) {
				return;
			}
			
			if (autoload.psr_4 != null) {
				foreach (var itm in autoload.psr_4) {
					var lvwItm = lvwPsr_4.Items.Add(itm.Key);
					lvwItm.SubItems.Add(itm.Value.ToString().Trim(new [] {'"'}));
				}
			}
			
			if (autoload.psr_0 != null) {
				foreach (var itm in autoload.psr_0) {
					var lvwItm = lvwPsr_0.Items.Add(itm.Key);
					lvwItm.SubItems.Add(itm.Value.ToString().Trim(new [] {'"'}));
				}
			}
			
			if (autoload.classmap != null) {
				foreach (var itm in autoload.classmap) {
					lbxClassmap.Items.Add(itm);
				}
			}
			
			if (autoload.files != null) {
				foreach (var itm in autoload.files) {
					lbxFiles.Items.Add(itm);
				}
			}
			
			if (autoload.exclude_from_classmap != null) {
				foreach (var itm in autoload.exclude_from_classmap) {
					lbxExclude.Items.Add(itm);
				}
			}
		}
	}
}
