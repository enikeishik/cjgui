/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 09.11.2018
 * Time: 11:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CJGui
{
	/// <summary>
	/// Description of Authors.
	/// </summary>
	public partial class AuthorsForm : Form
	{
		protected readonly Data data;
		
		protected AuthorsForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public AuthorsForm(Data data)
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
			Author newAuthor = new Author();
			
			AuthorForm form = new AuthorForm(newAuthor);
			if (form.ShowDialog(this) == DialogResult.Cancel) {
				return;
			}
			
			var item = new ListViewItem(newAuthor.name);
			item.SubItems.Add(newAuthor.email);
			item.SubItems.Add(newAuthor.homepage);
			item.SubItems.Add(newAuthor.role);
			listView1.Items.Add(item);
		}
		
		void EditClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count == 0) {
				return;
			}
			
			var item = listView1.SelectedItems[0];
			Author editAuthor = new Author(
				item.Text, 
				item.SubItems[1].Text, 
				item.SubItems[2].Text, 
				item.SubItems[3].Text
			);
			
			AuthorForm form = new AuthorForm(editAuthor);
			if (form.ShowDialog(this) == DialogResult.Cancel) {
				return;
			}
			
			item.Text = editAuthor.name;
			item.SubItems[1].Text = editAuthor.email;
			item.SubItems[2].Text = editAuthor.homepage;
			item.SubItems[3].Text = editAuthor.role;
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
			data.authors.Clear();
			
			foreach (ListViewItem item in listView1.Items) {
				data.authors.Add(new Author(
					item.SubItems[0].Text, 
					item.SubItems[1].Text, 
					item.SubItems[2].Text, 
					item.SubItems[3].Text
				));
			}
		}
		
		void ThisFormLoad(object sender, EventArgs e)
		{
			if (data.authors == null) {
				return;
			}
			
			foreach (Author author in data.authors) {
				ListViewItem item = listView1.Items.Add(author.name);
				item.SubItems.Add(author.email);
				item.SubItems.Add(author.homepage);
				item.SubItems.Add(author.role);
			}
		}
	}
}
