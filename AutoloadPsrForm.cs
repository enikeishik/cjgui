/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 12.11.2018
 * Time: 13:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace CJGui
{
	/// <summary>
	/// Description of AutoloadPsrForm.
	/// </summary>
	public partial class AutoloadPsrForm : Form
	{
		protected Dictionary<string, StrArr> psrItem;
		
		protected AutoloadPsrForm()
		{
			InitializeComponent();
		}
		
		public AutoloadPsrForm(Dictionary<string, StrArr> psrItem)
			: this()
		{
			this.psrItem = psrItem;
		}
		
		void RemoveClick(object sender, EventArgs e)
		{
			if (values.SelectedItems.Count == 0) {
				return;
			}
			values.SelectedItems.Remove(values.SelectedItems[0]);
		}
		
		void AddClick(object sender, EventArgs e)
		{
			var ret = Interaction.InputBox("", "Add new value");
			values.Items.Add(ret);
		}
		
		void CloseClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ThisFormClosing(object sender, FormClosingEventArgs e)
		{
			psrItem.Clear();
			var list = new List<string>(values.Items.Count);
			foreach (var item in values.Items) {
				list.Add(item.ToString());
			}
			psrItem.Add(key.Text, new StrArr(list));
		}
		
		void ThisFormLoad(object sender, EventArgs e)
		{
			if (psrItem.Count == 0) {
				return;
			}
			
			key.Text = psrItem.Keys.ToList().First();
			var vals = psrItem.Values.ToList();
			foreach (var v in vals) {
				values.Items.Add(v);
			}
		}
	}
}
