/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 10.11.2018
 * Time: 8:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CJGui
{
	/// <summary>
	/// Description of SupportsForm.
	/// </summary>
	public partial class SupportsForm : Form
	{
		protected readonly Data data;
		
		protected SupportsForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public SupportsForm(Data data)
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
			Support newSupport = new Support();
			
			SupportForm form = new SupportForm(newSupport);
			if (form.ShowDialog(this) == DialogResult.Cancel) {
				return;
			}
			
			var item = new ListViewItem(newSupport.email);
			item.SubItems.Add(newSupport.issues);
			item.SubItems.Add(newSupport.forum);
			item.SubItems.Add(newSupport.wiki);
			item.SubItems.Add(newSupport.irc);
			item.SubItems.Add(newSupport.source);
			item.SubItems.Add(newSupport.docs);
			item.SubItems.Add(newSupport.rss);
			listView1.Items.Add(item);
		}
		
		void EditClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count == 0) {
				return;
			}
			
			var item = listView1.SelectedItems[0];
			Support editSupport = new Support(
				item.SubItems[0].Text, 
				item.SubItems[1].Text, 
				item.SubItems[2].Text, 
				item.SubItems[3].Text, 
				item.SubItems[4].Text, 
				item.SubItems[5].Text, 
				item.SubItems[6].Text,
				item.SubItems[7].Text
			);
			
			SupportForm form = new SupportForm(editSupport);
			if (form.ShowDialog(this) == DialogResult.Cancel) {
				return;
			}
			
			item.Text = editSupport.email;
			item.SubItems[1].Text = editSupport.issues;
			item.SubItems[2].Text = editSupport.forum;
			item.SubItems[3].Text = editSupport.wiki;
			item.SubItems[4].Text = editSupport.irc;
			item.SubItems[5].Text = editSupport.source;
			item.SubItems[6].Text = editSupport.docs;
			item.SubItems[7].Text = editSupport.rss;
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
			data.support.Clear();
			
			foreach (ListViewItem item in listView1.Items) {
				data.support.Add(new Support(
					item.SubItems[0].Text, 
					item.SubItems[1].Text, 
					item.SubItems[2].Text, 
					item.SubItems[3].Text, 
					item.SubItems[4].Text, 
					item.SubItems[5].Text, 
					item.SubItems[6].Text, 
					item.SubItems[7].Text
				));
			}
		}
		
		void ThisFormLoad(object sender, EventArgs e)
		{
			if (data.support == null) {
				return;
			}
			
			foreach (Support support in data.support) {
				ListViewItem item = listView1.Items.Add(support.email);
				item.SubItems.Add(support.issues);
				item.SubItems.Add(support.forum);
				item.SubItems.Add(support.wiki);
				item.SubItems.Add(support.irc);
				item.SubItems.Add(support.source);
				item.SubItems.Add(support.docs);
				item.SubItems.Add(support.rss);
			}
		}
	}
}
