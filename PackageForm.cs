/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 10.11.2018
 * Time: 13:28
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
