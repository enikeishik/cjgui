/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 13.11.2018
 * Time: 13:42
 * 
 * @copyright   Copyright (C) 2018 Enikeishik <enikeishik@gmail.com>. All rights reserved.
 * @author      Enikeishik <enikeishik@gmail.com>
 * @license     GNU General Public License version 2 or later; see LICENSE.txt
 */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace CJGui
{
    /// <summary>
    /// Description of ListBoxForm.
    /// </summary>
    public partial class ListBoxForm : Form
    {
        protected readonly List<string> items;
        
        protected ListBoxForm()
        {
            InitializeComponent();
        }
        
        public ListBoxForm(List<string> items)
            : this()
        {
            this.items = items;
        }
        
        void AddClick(object sender, EventArgs e)
        {
            var ret = Interaction.InputBox("", "Add new value");
            if (ret != "") {
                values.Items.Add(ret);
            }
        }
        
        void EditClick(object sender, EventArgs e)
        {
            if (values.SelectedItems.Count == 0) {
                return;
            }
            var val = values.SelectedItem.ToString();
            var ret = Interaction.InputBox(val, "Edit value", val);
            values.Items.Insert(values.SelectedIndex, ret);
            values.Items.Remove(values.SelectedItem);
        }
        
        void RemoveClick(object sender, EventArgs e)
        {
            if (values.SelectedItems.Count == 0) {
                return;
            }
            values.Items.Remove(values.SelectedItems[0]);
        }
        
        void CloseClick(object sender, EventArgs e)
        {
            Close();
        }
        
        void ThisFormClosing(object sender, FormClosingEventArgs e)
        {
            items.Clear();
            items.Capacity = values.Items.Count;
            foreach (var item in values.Items) {
                items.Add(item.ToString());
            }
        }
        
        void ThisFormLoad(object sender, EventArgs e)
        {
            if (items.Count == 0) {
                return;
            }
            
            foreach (var itm in items) {
                values.Items.Add(itm);
            }
        }
    }
}
