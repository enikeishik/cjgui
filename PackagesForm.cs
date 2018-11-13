/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 10.11.2018
 * Time: 13:14
 * 
 * @copyright   Copyright (C) 2018 Enikeishik <enikeishik@gmail.com>. All rights reserved.
 * @author      Enikeishik <enikeishik@gmail.com>
 * @license     GNU General Public License version 2 or later; see LICENSE.txt
 */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace CJGui
{
	/// <summary>
	/// Description of PackagesForm.
	/// </summary>
	public partial class PackagesForm : Form
	{
		protected readonly Dictionary<string, string> require;
		
		protected PackagesForm()
		{
			InitializeComponent();
		}
		
		public PackagesForm(Dictionary<string, string> require)
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
			
			var form = new PackageForm(reqItem);
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
			
			var form = new PackageForm(reqItem);
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
