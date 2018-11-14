/*
 * CJGui
 * Composer JSON file GUI
 *
 * Created by SharpDevelop.
 * User: Enikeishik
 * Date: 14.11.2018
 * Time: 12:28
 * 
 * @copyright   Copyright (C) 2018 Enikeishik <enikeishik@gmail.com>. All rights reserved.
 * @author      Enikeishik <enikeishik@gmail.com>
 * @license     GNU General Public License version 2 or later; see LICENSE.txt
 */
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CJGui
{
    /// <summary>
    /// Description of ScriptsForm.
    /// </summary>
    public partial class ScriptsForm : Form
    {
        protected readonly Scripts scripts;
        
        protected ScriptsForm()
        {
            InitializeComponent();
        }
        
        public ScriptsForm(Scripts scripts)
            : this()
        {
            this.scripts = scripts;
            
            if (this.scripts.pre_install_cmd == null) {
                this.scripts.pre_install_cmd = new StrArr();
            }
            if (this.scripts.post_install_cmd == null) {
                this.scripts.post_install_cmd = new StrArr();
            }
            if (this.scripts.pre_update_cmd == null) {
                this.scripts.pre_update_cmd = new StrArr();
            }
            if (this.scripts.post_update_cmd == null) {
                this.scripts.post_update_cmd = new StrArr();
            }
            if (this.scripts.post_status_cmd == null) {
                this.scripts.post_status_cmd = new StrArr();
            }
            if (this.scripts.pre_archive_cmd == null) {
                this.scripts.pre_archive_cmd = new StrArr();
            }
            if (this.scripts.post_archive_cmd == null) {
                this.scripts.post_archive_cmd = new StrArr();
            }
            if (this.scripts.pre_autoload_dump == null) {
                this.scripts.pre_autoload_dump = new StrArr();
            }
            if (this.scripts.post_autoload_dump == null) {
                this.scripts.post_autoload_dump = new StrArr();
            }
            if (this.scripts.post_root_package_install == null) {
                this.scripts.post_root_package_install = new StrArr();
            }
            if (this.scripts.post_create_project_cmd == null) {
                this.scripts.post_create_project_cmd = new StrArr();
            }
            if (this.scripts.custom == null) {
                this.scripts.custom = new Dictionary<string, StrArr>();
            }
        }
        
        void CloseClick(object sender, EventArgs e)
        {
            Close();
        }
        
        void StrArrFieldEnter(object sender, EventArgs e)
        {
            var formControl = (Control) sender;
            
            var dataField = (StrArr) scripts.GetType().GetField(formControl.Name).GetValue(scripts);
            
            if (dataField == null) {
                dataField = new StrArr();
            }
            
            var form = new ListBoxForm(dataField.Values);
            form.ShowDialog();
            
            formControl.Text = dataField.ToString().Trim(new [] {'"'});
            scripts.GetType().GetField(formControl.Name).SetValue(scripts, dataField);
            
            ((Control) sender).Parent.SelectNextControl(ActiveControl, true, true, true, true);
        }
    }
}
