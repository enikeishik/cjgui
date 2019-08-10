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
namespace CJGui
{
    partial class ScriptsForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pre_install_cmd;
        private System.Windows.Forms.TextBox post_install_cmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pre_update_cmd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox post_update_cmd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox post_status_cmd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pre_archive_cmd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox post_archive_cmd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pre_autoload_dump;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox post_autoload_dump;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox post_root_package_install;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox post_create_project_cmd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox custom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button close;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pre_install_cmd = new System.Windows.Forms.TextBox();
            this.post_install_cmd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pre_update_cmd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.post_update_cmd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.post_status_cmd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pre_archive_cmd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.post_archive_cmd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pre_autoload_dump = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.post_autoload_dump = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.post_root_package_install = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.post_create_project_cmd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.custom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "pre-install-cmd";
            // 
            // pre_install_cmd
            // 
            this.pre_install_cmd.Location = new System.Drawing.Point(146, 6);
            this.pre_install_cmd.Name = "pre_install_cmd";
            this.pre_install_cmd.ReadOnly = true;
            this.pre_install_cmd.Size = new System.Drawing.Size(226, 20);
            this.pre_install_cmd.TabIndex = 1;
            this.pre_install_cmd.TabStop = false;
            this.pre_install_cmd.Enter += new System.EventHandler(this.StrArrFieldEnter);
            // 
            // post_install_cmd
            // 
            this.post_install_cmd.Location = new System.Drawing.Point(146, 29);
            this.post_install_cmd.Name = "post_install_cmd";
            this.post_install_cmd.ReadOnly = true;
            this.post_install_cmd.Size = new System.Drawing.Size(226, 20);
            this.post_install_cmd.TabIndex = 3;
            this.post_install_cmd.TabStop = false;
            this.post_install_cmd.Enter += new System.EventHandler(this.StrArrFieldEnter);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "post-install-cmd";
            // 
            // pre_update_cmd
            // 
            this.pre_update_cmd.Location = new System.Drawing.Point(146, 52);
            this.pre_update_cmd.Name = "pre_update_cmd";
            this.pre_update_cmd.ReadOnly = true;
            this.pre_update_cmd.Size = new System.Drawing.Size(226, 20);
            this.pre_update_cmd.TabIndex = 5;
            this.pre_update_cmd.TabStop = false;
            this.pre_update_cmd.Enter += new System.EventHandler(this.StrArrFieldEnter);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "pre-update-cmd";
            // 
            // post_update_cmd
            // 
            this.post_update_cmd.Location = new System.Drawing.Point(146, 75);
            this.post_update_cmd.Name = "post_update_cmd";
            this.post_update_cmd.ReadOnly = true;
            this.post_update_cmd.Size = new System.Drawing.Size(226, 20);
            this.post_update_cmd.TabIndex = 7;
            this.post_update_cmd.TabStop = false;
            this.post_update_cmd.Enter += new System.EventHandler(this.StrArrFieldEnter);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "post-update-cmd";
            // 
            // post_status_cmd
            // 
            this.post_status_cmd.Location = new System.Drawing.Point(146, 98);
            this.post_status_cmd.Name = "post_status_cmd";
            this.post_status_cmd.ReadOnly = true;
            this.post_status_cmd.Size = new System.Drawing.Size(226, 20);
            this.post_status_cmd.TabIndex = 9;
            this.post_status_cmd.TabStop = false;
            this.post_status_cmd.Enter += new System.EventHandler(this.StrArrFieldEnter);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "post-status-cmd";
            // 
            // pre_archive_cmd
            // 
            this.pre_archive_cmd.Location = new System.Drawing.Point(146, 121);
            this.pre_archive_cmd.Name = "pre_archive_cmd";
            this.pre_archive_cmd.ReadOnly = true;
            this.pre_archive_cmd.Size = new System.Drawing.Size(226, 20);
            this.pre_archive_cmd.TabIndex = 11;
            this.pre_archive_cmd.TabStop = false;
            this.pre_archive_cmd.Enter += new System.EventHandler(this.StrArrFieldEnter);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "pre-archive-cmd";
            // 
            // post_archive_cmd
            // 
            this.post_archive_cmd.Location = new System.Drawing.Point(146, 144);
            this.post_archive_cmd.Name = "post_archive_cmd";
            this.post_archive_cmd.ReadOnly = true;
            this.post_archive_cmd.Size = new System.Drawing.Size(226, 20);
            this.post_archive_cmd.TabIndex = 13;
            this.post_archive_cmd.TabStop = false;
            this.post_archive_cmd.Enter += new System.EventHandler(this.StrArrFieldEnter);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "post-archive-cmd";
            // 
            // pre_autoload_dump
            // 
            this.pre_autoload_dump.Location = new System.Drawing.Point(146, 167);
            this.pre_autoload_dump.Name = "pre_autoload_dump";
            this.pre_autoload_dump.ReadOnly = true;
            this.pre_autoload_dump.Size = new System.Drawing.Size(226, 20);
            this.pre_autoload_dump.TabIndex = 15;
            this.pre_autoload_dump.TabStop = false;
            this.pre_autoload_dump.Enter += new System.EventHandler(this.StrArrFieldEnter);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "pre-autoload-dump";
            // 
            // post_autoload_dump
            // 
            this.post_autoload_dump.Location = new System.Drawing.Point(146, 190);
            this.post_autoload_dump.Name = "post_autoload_dump";
            this.post_autoload_dump.ReadOnly = true;
            this.post_autoload_dump.Size = new System.Drawing.Size(226, 20);
            this.post_autoload_dump.TabIndex = 17;
            this.post_autoload_dump.TabStop = false;
            this.post_autoload_dump.Enter += new System.EventHandler(this.StrArrFieldEnter);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "post-autoload-dump";
            // 
            // post_root_package_install
            // 
            this.post_root_package_install.Location = new System.Drawing.Point(146, 213);
            this.post_root_package_install.Name = "post_root_package_install";
            this.post_root_package_install.ReadOnly = true;
            this.post_root_package_install.Size = new System.Drawing.Size(226, 20);
            this.post_root_package_install.TabIndex = 19;
            this.post_root_package_install.TabStop = false;
            this.post_root_package_install.Enter += new System.EventHandler(this.StrArrFieldEnter);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "post-root-package-install";
            // 
            // post_create_project_cmd
            // 
            this.post_create_project_cmd.Location = new System.Drawing.Point(146, 236);
            this.post_create_project_cmd.Name = "post_create_project_cmd";
            this.post_create_project_cmd.ReadOnly = true;
            this.post_create_project_cmd.Size = new System.Drawing.Size(226, 20);
            this.post_create_project_cmd.TabIndex = 21;
            this.post_create_project_cmd.TabStop = false;
            this.post_create_project_cmd.Enter += new System.EventHandler(this.StrArrFieldEnter);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(12, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "post-create-project-cmd";
            // 
            // custom
            // 
            this.custom.Location = new System.Drawing.Point(146, 259);
            this.custom.Name = "custom";
            this.custom.ReadOnly = true;
            this.custom.Size = new System.Drawing.Size(226, 20);
            this.custom.TabIndex = 23;
            this.custom.TabStop = false;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "custom";
            // 
            // close
            // 
            this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close.Location = new System.Drawing.Point(12, 326);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(360, 23);
            this.close.TabIndex = 25;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            // 
            // ScriptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.close;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.close);
            this.Controls.Add(this.custom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.post_create_project_cmd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.post_root_package_install);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.post_autoload_dump);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pre_autoload_dump);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.post_archive_cmd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pre_archive_cmd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.post_status_cmd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.post_update_cmd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pre_update_cmd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.post_install_cmd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pre_install_cmd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScriptsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scripts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
