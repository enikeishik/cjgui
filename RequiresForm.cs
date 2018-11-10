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
		protected readonly Data data;
		
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
		
		public RequiresForm(Data data)
		{
			this.data = data;
			InitializeComponent();
		}
		
		void CloseClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void AddClick(object sender, EventArgs e)
		{
			var require = new Dictionary<string, string>(1);
			
			var form = new RequireForm(require);
			if (form.ShowDialog(this) == DialogResult.Cancel) {
				return;
			}
			
			var item = new ListViewItem(require.Keys.ToList().First());
			item.SubItems.Add(require.Values.ToList().First());
			listView1.Items.Add(item);
		}
		
		void EditClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count == 0) {
				return;
			}
			
			var item = listView1.SelectedItems[0];
			var require = new Dictionary<string, string>(1);
			require.Add(item.Text, item.SubItems[1].Text);
			
			var form = new RequireForm(require);
			if (form.ShowDialog(this) == DialogResult.Cancel) {
				return;
			}
			
			item.Text = require.Keys.ToList().First();
			item.SubItems[1].Text = require.Values.ToList().First();
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
			data.require.Clear();
			
			foreach (ListViewItem item in listView1.Items) {
				data.require.Add(item.SubItems[0].Text, item.SubItems[1].Text);
			}
		}
		
		void ThisFormLoad(object sender, EventArgs e)
		{
			if (data.require == null) {
				return;
			}
			
			foreach (var req in data.require) {
				ListViewItem item = listView1.Items.Add(req.Key);
				item.SubItems.Add(req.Value);
			}
		}
	}
}
