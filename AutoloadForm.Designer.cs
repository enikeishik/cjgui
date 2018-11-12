/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 12.11.2018
 * Time: 13:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CJGui
{
	partial class AutoloadForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.GroupBox psr_4;
		private System.Windows.Forms.ListView lvwPsr_4;
		private System.Windows.Forms.ColumnHeader package;
		private System.Windows.Forms.ColumnHeader version;
		private System.Windows.Forms.Button editPsr_4;
		private System.Windows.Forms.Button removePsr_4;
		private System.Windows.Forms.Button addPsr_4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button editPsr_0;
		private System.Windows.Forms.Button removePsr_0;
		private System.Windows.Forms.Button addPsr_0;
		private System.Windows.Forms.ListView lvwPsr_0;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		
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
			this.close = new System.Windows.Forms.Button();
			this.psr_4 = new System.Windows.Forms.GroupBox();
			this.editPsr_4 = new System.Windows.Forms.Button();
			this.removePsr_4 = new System.Windows.Forms.Button();
			this.addPsr_4 = new System.Windows.Forms.Button();
			this.lvwPsr_4 = new System.Windows.Forms.ListView();
			this.package = new System.Windows.Forms.ColumnHeader();
			this.version = new System.Windows.Forms.ColumnHeader();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.editPsr_0 = new System.Windows.Forms.Button();
			this.removePsr_0 = new System.Windows.Forms.Button();
			this.addPsr_0 = new System.Windows.Forms.Button();
			this.lvwPsr_0 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.psr_4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// close
			// 
			this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.close.Location = new System.Drawing.Point(12, 426);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(360, 23);
			this.close.TabIndex = 14;
			this.close.Text = "close";
			this.close.UseVisualStyleBackColor = true;
			this.close.Click += new System.EventHandler(this.CloseClick);
			// 
			// psr_4
			// 
			this.psr_4.Controls.Add(this.editPsr_4);
			this.psr_4.Controls.Add(this.removePsr_4);
			this.psr_4.Controls.Add(this.addPsr_4);
			this.psr_4.Controls.Add(this.lvwPsr_4);
			this.psr_4.Location = new System.Drawing.Point(12, 12);
			this.psr_4.Name = "psr_4";
			this.psr_4.Size = new System.Drawing.Size(360, 140);
			this.psr_4.TabIndex = 16;
			this.psr_4.TabStop = false;
			this.psr_4.Text = "PSR-4";
			// 
			// editPsr_4
			// 
			this.editPsr_4.Location = new System.Drawing.Point(143, 111);
			this.editPsr_4.Name = "editPsr_4";
			this.editPsr_4.Size = new System.Drawing.Size(75, 23);
			this.editPsr_4.TabIndex = 3;
			this.editPsr_4.Text = "edit";
			this.editPsr_4.UseVisualStyleBackColor = true;
			this.editPsr_4.Click += new System.EventHandler(this.EditClick);
			// 
			// removePsr_4
			// 
			this.removePsr_4.Location = new System.Drawing.Point(279, 111);
			this.removePsr_4.Name = "removePsr_4";
			this.removePsr_4.Size = new System.Drawing.Size(75, 23);
			this.removePsr_4.TabIndex = 4;
			this.removePsr_4.Text = "remove";
			this.removePsr_4.UseVisualStyleBackColor = true;
			this.removePsr_4.Click += new System.EventHandler(this.RemoveClick);
			// 
			// addPsr_4
			// 
			this.addPsr_4.Location = new System.Drawing.Point(6, 111);
			this.addPsr_4.Name = "addPsr_4";
			this.addPsr_4.Size = new System.Drawing.Size(75, 23);
			this.addPsr_4.TabIndex = 2;
			this.addPsr_4.Text = "add";
			this.addPsr_4.UseVisualStyleBackColor = true;
			this.addPsr_4.Click += new System.EventHandler(this.AddClick);
			// 
			// lvwPsr_4
			// 
			this.lvwPsr_4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.package,
			this.version});
			this.lvwPsr_4.FullRowSelect = true;
			this.lvwPsr_4.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvwPsr_4.HideSelection = false;
			this.lvwPsr_4.Location = new System.Drawing.Point(6, 19);
			this.lvwPsr_4.MultiSelect = false;
			this.lvwPsr_4.Name = "lvwPsr_4";
			this.lvwPsr_4.Size = new System.Drawing.Size(348, 86);
			this.lvwPsr_4.TabIndex = 1;
			this.lvwPsr_4.UseCompatibleStateImageBehavior = false;
			this.lvwPsr_4.View = System.Windows.Forms.View.Details;
			this.lvwPsr_4.DoubleClick += new System.EventHandler(this.EditClick);
			// 
			// package
			// 
			this.package.Text = "package";
			this.package.Width = 220;
			// 
			// version
			// 
			this.version.Text = "version";
			this.version.Width = 120;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.editPsr_0);
			this.groupBox1.Controls.Add(this.removePsr_0);
			this.groupBox1.Controls.Add(this.addPsr_0);
			this.groupBox1.Controls.Add(this.lvwPsr_0);
			this.groupBox1.Location = new System.Drawing.Point(12, 158);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(360, 140);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "PSR-0";
			// 
			// editPsr_0
			// 
			this.editPsr_0.Location = new System.Drawing.Point(143, 111);
			this.editPsr_0.Name = "editPsr_0";
			this.editPsr_0.Size = new System.Drawing.Size(75, 23);
			this.editPsr_0.TabIndex = 3;
			this.editPsr_0.Text = "edit";
			this.editPsr_0.UseVisualStyleBackColor = true;
			this.editPsr_0.Click += new System.EventHandler(this.EditClick);
			// 
			// removePsr_0
			// 
			this.removePsr_0.Location = new System.Drawing.Point(279, 111);
			this.removePsr_0.Name = "removePsr_0";
			this.removePsr_0.Size = new System.Drawing.Size(75, 23);
			this.removePsr_0.TabIndex = 4;
			this.removePsr_0.Text = "remove";
			this.removePsr_0.UseVisualStyleBackColor = true;
			this.removePsr_0.Click += new System.EventHandler(this.RemoveClick);
			// 
			// addPsr_0
			// 
			this.addPsr_0.Location = new System.Drawing.Point(6, 111);
			this.addPsr_0.Name = "addPsr_0";
			this.addPsr_0.Size = new System.Drawing.Size(75, 23);
			this.addPsr_0.TabIndex = 2;
			this.addPsr_0.Text = "add";
			this.addPsr_0.UseVisualStyleBackColor = true;
			this.addPsr_0.Click += new System.EventHandler(this.AddClick);
			// 
			// lvwPsr_0
			// 
			this.lvwPsr_0.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1,
			this.columnHeader2});
			this.lvwPsr_0.FullRowSelect = true;
			this.lvwPsr_0.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvwPsr_0.HideSelection = false;
			this.lvwPsr_0.Location = new System.Drawing.Point(6, 19);
			this.lvwPsr_0.MultiSelect = false;
			this.lvwPsr_0.Name = "lvwPsr_0";
			this.lvwPsr_0.Size = new System.Drawing.Size(348, 86);
			this.lvwPsr_0.TabIndex = 1;
			this.lvwPsr_0.UseCompatibleStateImageBehavior = false;
			this.lvwPsr_0.View = System.Windows.Forms.View.Details;
			this.lvwPsr_0.DoubleClick += new System.EventHandler(this.EditClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "package";
			this.columnHeader1.Width = 220;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "version";
			this.columnHeader2.Width = 120;
			// 
			// AutoloadForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.close;
			this.ClientSize = new System.Drawing.Size(384, 461);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.psr_4);
			this.Controls.Add(this.close);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "AutoloadForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Autoload";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThisFormClosing);
			this.Load += new System.EventHandler(this.ThisFormLoad);
			this.psr_4.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
