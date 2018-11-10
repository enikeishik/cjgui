/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 09.11.2018
 * Time: 11:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CJGui
{
	partial class AuthorsForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader name;
		private System.Windows.Forms.ColumnHeader email;
		private System.Windows.Forms.ColumnHeader homepage;
		private System.Windows.Forms.ColumnHeader role;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button remove;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.Button edit;
		
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.name = new System.Windows.Forms.ColumnHeader();
			this.email = new System.Windows.Forms.ColumnHeader();
			this.homepage = new System.Windows.Forms.ColumnHeader();
			this.role = new System.Windows.Forms.ColumnHeader();
			this.add = new System.Windows.Forms.Button();
			this.remove = new System.Windows.Forms.Button();
			this.close = new System.Windows.Forms.Button();
			this.edit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.name,
			this.email,
			this.homepage,
			this.role});
			this.listView1.FullRowSelect = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(12, 12);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(360, 272);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.DoubleClick += new System.EventHandler(this.EditClick);
			// 
			// name
			// 
			this.name.Text = "name";
			this.name.Width = 110;
			// 
			// email
			// 
			this.email.Text = "email";
			this.email.Width = 80;
			// 
			// homepage
			// 
			this.homepage.Text = "homepage";
			this.homepage.Width = 80;
			// 
			// role
			// 
			this.role.Text = "role";
			this.role.Width = 80;
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(12, 290);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(75, 23);
			this.add.TabIndex = 1;
			this.add.Text = "add";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.AddClick);
			// 
			// remove
			// 
			this.remove.Location = new System.Drawing.Point(297, 290);
			this.remove.Name = "remove";
			this.remove.Size = new System.Drawing.Size(75, 23);
			this.remove.TabIndex = 3;
			this.remove.Text = "remove";
			this.remove.UseVisualStyleBackColor = true;
			this.remove.Click += new System.EventHandler(this.RemoveClick);
			// 
			// close
			// 
			this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.close.Location = new System.Drawing.Point(12, 326);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(360, 23);
			this.close.TabIndex = 4;
			this.close.Text = "close";
			this.close.UseVisualStyleBackColor = true;
			this.close.Click += new System.EventHandler(this.CloseClick);
			// 
			// edit
			// 
			this.edit.Location = new System.Drawing.Point(157, 290);
			this.edit.Name = "edit";
			this.edit.Size = new System.Drawing.Size(75, 23);
			this.edit.TabIndex = 2;
			this.edit.Text = "edit";
			this.edit.UseVisualStyleBackColor = true;
			this.edit.Click += new System.EventHandler(this.EditClick);
			// 
			// AuthorsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.close;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.edit);
			this.Controls.Add(this.close);
			this.Controls.Add(this.remove);
			this.Controls.Add(this.add);
			this.Controls.Add(this.listView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "AuthorsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Authors";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThisFormClosing);
			this.Load += new System.EventHandler(this.ThisFormLoad);
			this.ResumeLayout(false);

		}
	}
}
