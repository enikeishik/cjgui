/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 10.11.2018
 * Time: 13:14
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
	/// Description of RequiresForm.
	/// </summary>
	public partial class RequiresForm : Form
	{
		protected readonly Dictionary<string, string> require;
		
		protected RequiresForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public RequiresForm(Dictionary<string, string> require)
		{
			this.require = require;
			InitializeComponent();
		}
		
		void CloseClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void AddClick(object sender, EventArgs e)
		{
			var reqItem = new Dictionary<string, string>(1);
			
			var form = new RequireForm(reqItem);
			if (form.ShowDialog(this) == DialogResult.Cancel) {
				return;
			}
			
			var item = new ListViewItem(reqItem.Keys.ToList().First());
			item.SubItems.Add(reqItem.Values.ToList().First());
			listView1.Items.Add(item);
		}
		
		void EditClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count == 0) {
				return;
			}
			
			var item = listView1.SelectedItems[0];
			var reqItem = new Dictionary<string, string>(1);
			reqItem.Add(item.Text, item.SubItems[1].Text);
			
			var form = new RequireForm(reqItem);
			if (form.ShowDialog(this) == DialogResult.Cancel) {
				return;
			}
			
			item.Text = reqItem.Keys.ToList().First();
			item.SubItems[1].Text = reqItem.Values.ToList().First();
		}
		
		void RemoveClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count == 0) {
				return;
			}
			var item = listView1.SelectedItems[0];
			listView1.Items.Remove(item);
		}
		
		void ThisFormClosing(object sender, FormClosingEventArgs e)
		{
			require.Clear();
			
			foreach (ListViewItem item in listView1.Items) {
				if (!require.ContainsKey(item.SubItems[0].Text)) {
					require.Add(item.SubItems[0].Text, item.SubItems[1].Text);
				}
			}
		}
		
		void ThisFormLoad(object sender, EventArgs e)
		{
			if (require == null) {
				return;
			}
			
			foreach (var reqItem in require) {
				ListViewItem item = listView1.Items.Add(reqItem.Key);
				item.SubItems.Add(reqItem.Value);
			}
		}
	}
}
