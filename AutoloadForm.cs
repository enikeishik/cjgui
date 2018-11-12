/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 12.11.2018
 * Time: 13:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

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
		
		protected ListView GetList(string group)
		{
			return (ListView) Controls.Find("lvw" + group, true)[0];
		}
		
		void AddClick(object sender, EventArgs e)
		{
			var aItem = new Dictionary<string, StrArr>(1);
			
			var form = new AutoloadPsrForm(aItem);
			form.ShowDialog(this);
			
			var item = new ListViewItem(aItem.Keys.ToList().First());
			item.SubItems.Add(aItem.Values.ToList().First().Value);
			var listView = GetList(((Control) sender).Name.Substring("add".Length));
			listView.Items.Add(item);
		}
		
		void EditClick(object sender, EventArgs e)
		{
			var listView = GetList(((Control) sender).Name.Substring("edit".Length));
			
			if (listView.SelectedItems.Count == 0) {
				return;
			}
			
			var item = listView.SelectedItems[0];
			var aItem = new Dictionary<string, string>(1);
			aItem.Add(item.Text, item.SubItems[1].Text);
			
			var form = new PackageForm(aItem);
			form.ShowDialog(this);
			
			item.Text = aItem.Keys.ToList().First();
			item.SubItems[1].Text = aItem.Values.ToList().First();
		}
		
		void RemoveClick(object sender, EventArgs e)
		{
			var listView = GetList(((Control) sender).Name.Substring("remove".Length));
			
			if (listView.SelectedItems.Count == 0) {
				return;
			}
			var item = listView.SelectedItems[0];
			listView.Items.Remove(item);
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
		}
		
		void ThisFormLoad(object sender, EventArgs e)
		{
		}
	}
}
