﻿/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 12.11.2018
 * Time: 13:54
 * 
 * @copyright   Copyright (C) 2018 Enikeishik <enikeishik@gmail.com>. All rights reserved.
 * @author      Enikeishik <enikeishik@gmail.com>
 * @license     GNU General Public License version 2 or later; see LICENSE.txt
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
        
        void AddClick(object sender, EventArgs e)
        {
            var ret = Interaction.InputBox("", "Add new value");
            if (ret != "")
                values.Items.Add(ret);
        }
        
        void EditClick(object sender, EventArgs e)
        {
            if (values.SelectedItems.Count == 0)
                return;
            
            var val = values.SelectedItem.ToString();
            var ret = Interaction.InputBox(val, "Edit value", val);
            values.Items.Insert(values.SelectedIndex, ret);
            values.Items.Remove(values.SelectedItem);
        }
        
        void RemoveClick(object sender, EventArgs e)
        {
            if (values.SelectedItems.Count == 0)
                return;
            
            values.Items.Remove(values.SelectedItems[0]);
        }
        
        void CloseClick(object sender, EventArgs e)
        {
            Close();
        }
        
        void ThisFormClosing(object sender, FormClosingEventArgs e)
        {
            psrItem.Clear();
            var list = new List<string>(values.Items.Count);
            
            foreach (var item in values.Items)
                list.Add(item.ToString());
            
            psrItem.Add(key.Text, new StrArr(list));
        }
        
        void ThisFormLoad(object sender, EventArgs e)
        {
            if (psrItem.Count == 0)
                return;
            
            key.Text = psrItem.Keys.First();
            var vals = psrItem.Values.ToList();
            
            foreach (var v in vals)
                values.Items.Add(v.ToString().Trim(new [] {'"'}));
        }
    }
}
