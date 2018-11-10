/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 10.11.2018
 * Time: 8:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CJGui
{
	/// <summary>
	/// Description of SupportForm.
	/// </summary>
	public partial class SupportForm : Form
	{
		protected Support support;
		
		protected SupportForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public SupportForm(Support support)
		{
			this.support = support;
			InitializeComponent();
			if (support.email != null) {
				issues.Text = support.email;
				forum.Text = support.forum;
				wiki.Text = support.wiki;
				irc.Text = support.irc;
				source.Text = support.source;
				docs.Text = support.docs;
				rss.Text = support.rss;
			}
		}
		
		void CancelClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
		
		void SaveClick(object sender, EventArgs e)
		{
			support.email = email.Text;
			support.issues = issues.Text;
			support.forum = forum.Text;
			support.wiki = wiki.Text;
			support.irc = irc.Text;
			support.source = source.Text;
			support.docs = docs.Text;
			support.rss = rss.Text;
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
