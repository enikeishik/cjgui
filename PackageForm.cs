/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 10.11.2018
 * Time: 13:28
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
	/// Description of PackageForm.
	/// </summary>
	public partial class PackageForm : Form
	{
		protected Dictionary<string, string> require;
		
		protected PackageForm()
		{
			InitializeComponent();
		}
		
		public PackageForm(Dictionary<string, string> require)
		{
			this.require = require;
			InitializeComponent();
			if (require.Count > 0) {
				package.Text = require.Keys.ToList().First();
				version.Text = require.Values.ToList().First();
			}
		}
		
		void CancelClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
		
		void SaveClick(object sender, EventArgs e)
		{
			require.Clear();
			require.Add(package.Text, version.Text);
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
