/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 09.11.2018
 * Time: 15:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CJGui
{
	/// <summary>
	/// Description of AuthorForm.
	/// </summary>
	public partial class AuthorForm : Form
	{
		protected Author author;
		
		protected AuthorForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public AuthorForm(Author author)
		{
			this.author = author;
			InitializeComponent();
			if (author.name != null) {
				name.Text = author.name;
				email.Text = author.email;
				homepage.Text = author.homepage;
				role.Text = author.role;
			}
		}
		
		void CancelClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
		
		void SaveClick(object sender, EventArgs e)
		{
			author.name = name.Text;
			author.email = email.Text;
			author.homepage = homepage.Text;
			author.role = role.Text;
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
