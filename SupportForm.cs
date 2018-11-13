/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 10.11.2018
 * Time: 8:54
 * 
 * @copyright   Copyright (C) 2018 Enikeishik <enikeishik@gmail.com>. All rights reserved.
 * @author      Enikeishik <enikeishik@gmail.com>
 * @license     GNU General Public License version 2 or later; see LICENSE.txt
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
			InitializeComponent();
		}
		
		public SupportForm(Support support)
			: this()
		{
			this.support = support;
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
