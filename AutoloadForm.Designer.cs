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
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button removeClassmap;
		private System.Windows.Forms.Button addClassmap;
		private System.Windows.Forms.ListBox lbxClassmap;
		private System.Windows.Forms.Button removeFiles;
		private System.Windows.Forms.Button addFiles;
		private System.Windows.Forms.ListBox lbxFiles;
		private System.Windows.Forms.Button removeExclude;
		private System.Windows.Forms.Button addExclude;
		private System.Windows.Forms.ListBox lbxExclude;
		
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.removeClassmap = new System.Windows.Forms.Button();
			this.addClassmap = new System.Windows.Forms.Button();
			this.lbxClassmap = new System.Windows.Forms.ListBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.removeFiles = new System.Windows.Forms.Button();
			this.addFiles = new System.Windows.Forms.Button();
			this.lbxFiles = new System.Windows.Forms.ListBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.removeExclude = new System.Windows.Forms.Button();
			this.addExclude = new System.Windows.Forms.Button();
			this.lbxExclude = new System.Windows.Forms.ListBox();
			this.psr_4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// close
			// 
			this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.close.Location = new System.Drawing.Point(12, 466);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(560, 23);
			this.close.TabIndex = 18;
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
			this.psr_4.Size = new System.Drawing.Size(354, 226);
			this.psr_4.TabIndex = 16;
			this.psr_4.TabStop = false;
			this.psr_4.Text = "PSR-4";
			// 
			// editPsr_4
			// 
			this.editPsr_4.Location = new System.Drawing.Point(143, 197);
			this.editPsr_4.Name = "editPsr_4";
			this.editPsr_4.Size = new System.Drawing.Size(75, 23);
			this.editPsr_4.TabIndex = 3;
			this.editPsr_4.Text = "edit";
			this.editPsr_4.UseVisualStyleBackColor = true;
			this.editPsr_4.Click += new System.EventHandler(this.EditPsrClick);
			// 
			// removePsr_4
			// 
			this.removePsr_4.Location = new System.Drawing.Point(273, 197);
			this.removePsr_4.Name = "removePsr_4";
			this.removePsr_4.Size = new System.Drawing.Size(75, 23);
			this.removePsr_4.TabIndex = 4;
			this.removePsr_4.Text = "remove";
			this.removePsr_4.UseVisualStyleBackColor = true;
			this.removePsr_4.Click += new System.EventHandler(this.RemovePsrClick);
			// 
			// addPsr_4
			// 
			this.addPsr_4.Location = new System.Drawing.Point(6, 197);
			this.addPsr_4.Name = "addPsr_4";
			this.addPsr_4.Size = new System.Drawing.Size(75, 23);
			this.addPsr_4.TabIndex = 2;
			this.addPsr_4.Text = "add";
			this.addPsr_4.UseVisualStyleBackColor = true;
			this.addPsr_4.Click += new System.EventHandler(this.AddPsrClick);
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
			this.lvwPsr_4.Size = new System.Drawing.Size(342, 172);
			this.lvwPsr_4.TabIndex = 1;
			this.lvwPsr_4.UseCompatibleStateImageBehavior = false;
			this.lvwPsr_4.View = System.Windows.Forms.View.Details;
			this.lvwPsr_4.DoubleClick += new System.EventHandler(this.EditPsrClick);
			// 
			// package
			// 
			this.package.Text = "package";
			this.package.Width = 200;
			// 
			// version
			// 
			this.version.Text = "version";
			this.version.Width = 130;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.editPsr_0);
			this.groupBox1.Controls.Add(this.removePsr_0);
			this.groupBox1.Controls.Add(this.addPsr_0);
			this.groupBox1.Controls.Add(this.lvwPsr_0);
			this.groupBox1.Location = new System.Drawing.Point(12, 244);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(354, 195);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "PSR-0";
			// 
			// editPsr_0
			// 
			this.editPsr_0.Location = new System.Drawing.Point(143, 166);
			this.editPsr_0.Name = "editPsr_0";
			this.editPsr_0.Size = new System.Drawing.Size(75, 23);
			this.editPsr_0.TabIndex = 7;
			this.editPsr_0.Text = "edit";
			this.editPsr_0.UseVisualStyleBackColor = true;
			this.editPsr_0.Click += new System.EventHandler(this.EditPsrClick);
			// 
			// removePsr_0
			// 
			this.removePsr_0.Location = new System.Drawing.Point(273, 166);
			this.removePsr_0.Name = "removePsr_0";
			this.removePsr_0.Size = new System.Drawing.Size(75, 23);
			this.removePsr_0.TabIndex = 8;
			this.removePsr_0.Text = "remove";
			this.removePsr_0.UseVisualStyleBackColor = true;
			this.removePsr_0.Click += new System.EventHandler(this.RemovePsrClick);
			// 
			// addPsr_0
			// 
			this.addPsr_0.Location = new System.Drawing.Point(6, 166);
			this.addPsr_0.Name = "addPsr_0";
			this.addPsr_0.Size = new System.Drawing.Size(75, 23);
			this.addPsr_0.TabIndex = 6;
			this.addPsr_0.Text = "add";
			this.addPsr_0.UseVisualStyleBackColor = true;
			this.addPsr_0.Click += new System.EventHandler(this.AddPsrClick);
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
			this.lvwPsr_0.Size = new System.Drawing.Size(342, 141);
			this.lvwPsr_0.TabIndex = 5;
			this.lvwPsr_0.UseCompatibleStateImageBehavior = false;
			this.lvwPsr_0.View = System.Windows.Forms.View.Details;
			this.lvwPsr_0.DoubleClick += new System.EventHandler(this.EditPsrClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "package";
			this.columnHeader1.Width = 200;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "version";
			this.columnHeader2.Width = 130;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.removeClassmap);
			this.groupBox2.Controls.Add(this.addClassmap);
			this.groupBox2.Controls.Add(this.lbxClassmap);
			this.groupBox2.Location = new System.Drawing.Point(378, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(194, 140);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Classmap";
			// 
			// removeClassmap
			// 
			this.removeClassmap.Location = new System.Drawing.Point(113, 111);
			this.removeClassmap.Name = "removeClassmap";
			this.removeClassmap.Size = new System.Drawing.Size(75, 23);
			this.removeClassmap.TabIndex = 11;
			this.removeClassmap.Text = "remove";
			this.removeClassmap.UseVisualStyleBackColor = true;
			this.removeClassmap.Click += new System.EventHandler(this.RemoveClick);
			// 
			// addClassmap
			// 
			this.addClassmap.Location = new System.Drawing.Point(6, 111);
			this.addClassmap.Name = "addClassmap";
			this.addClassmap.Size = new System.Drawing.Size(75, 23);
			this.addClassmap.TabIndex = 10;
			this.addClassmap.Text = "add";
			this.addClassmap.UseVisualStyleBackColor = true;
			this.addClassmap.Click += new System.EventHandler(this.AddClick);
			// 
			// lbxClassmap
			// 
			this.lbxClassmap.FormattingEnabled = true;
			this.lbxClassmap.Location = new System.Drawing.Point(6, 19);
			this.lbxClassmap.Name = "lbxClassmap";
			this.lbxClassmap.Size = new System.Drawing.Size(182, 82);
			this.lbxClassmap.TabIndex = 9;
			this.lbxClassmap.DoubleClick += new System.EventHandler(this.EditClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.removeFiles);
			this.groupBox3.Controls.Add(this.addFiles);
			this.groupBox3.Controls.Add(this.lbxFiles);
			this.groupBox3.Location = new System.Drawing.Point(378, 158);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 140);
			this.groupBox3.TabIndex = 19;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Files";
			// 
			// removeFiles
			// 
			this.removeFiles.Location = new System.Drawing.Point(116, 111);
			this.removeFiles.Name = "removeFiles";
			this.removeFiles.Size = new System.Drawing.Size(75, 23);
			this.removeFiles.TabIndex = 14;
			this.removeFiles.Text = "remove";
			this.removeFiles.UseVisualStyleBackColor = true;
			this.removeFiles.Click += new System.EventHandler(this.RemoveClick);
			// 
			// addFiles
			// 
			this.addFiles.Location = new System.Drawing.Point(9, 111);
			this.addFiles.Name = "addFiles";
			this.addFiles.Size = new System.Drawing.Size(75, 23);
			this.addFiles.TabIndex = 13;
			this.addFiles.Text = "add";
			this.addFiles.UseVisualStyleBackColor = true;
			this.addFiles.Click += new System.EventHandler(this.AddClick);
			// 
			// lbxFiles
			// 
			this.lbxFiles.FormattingEnabled = true;
			this.lbxFiles.Location = new System.Drawing.Point(9, 19);
			this.lbxFiles.Name = "lbxFiles";
			this.lbxFiles.Size = new System.Drawing.Size(182, 82);
			this.lbxFiles.TabIndex = 12;
			this.lbxFiles.DoubleClick += new System.EventHandler(this.EditClick);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.removeExclude);
			this.groupBox4.Controls.Add(this.addExclude);
			this.groupBox4.Controls.Add(this.lbxExclude);
			this.groupBox4.Location = new System.Drawing.Point(378, 304);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(200, 135);
			this.groupBox4.TabIndex = 20;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Exclude files from classmaps";
			// 
			// removeExclude
			// 
			this.removeExclude.Location = new System.Drawing.Point(116, 106);
			this.removeExclude.Name = "removeExclude";
			this.removeExclude.Size = new System.Drawing.Size(75, 23);
			this.removeExclude.TabIndex = 17;
			this.removeExclude.Text = "remove";
			this.removeExclude.UseVisualStyleBackColor = true;
			this.removeExclude.Click += new System.EventHandler(this.RemoveClick);
			// 
			// addExclude
			// 
			this.addExclude.Location = new System.Drawing.Point(9, 106);
			this.addExclude.Name = "addExclude";
			this.addExclude.Size = new System.Drawing.Size(75, 23);
			this.addExclude.TabIndex = 16;
			this.addExclude.Text = "add";
			this.addExclude.UseVisualStyleBackColor = true;
			this.addExclude.Click += new System.EventHandler(this.AddClick);
			// 
			// lbxExclude
			// 
			this.lbxExclude.FormattingEnabled = true;
			this.lbxExclude.Location = new System.Drawing.Point(9, 18);
			this.lbxExclude.Name = "lbxExclude";
			this.lbxExclude.Size = new System.Drawing.Size(182, 82);
			this.lbxExclude.TabIndex = 15;
			this.lbxExclude.DoubleClick += new System.EventHandler(this.EditClick);
			// 
			// AutoloadForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.close;
			this.ClientSize = new System.Drawing.Size(584, 501);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
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
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
