/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 09.11.2018
 * Time: 15:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CJGui
{
	partial class AuthorForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.TextBox email;
		private System.Windows.Forms.TextBox homepage;
		private System.Windows.Forms.TextBox role;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.Button cancel;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.TextBox();
			this.email = new System.Windows.Forms.TextBox();
			this.homepage = new System.Windows.Forms.TextBox();
			this.role = new System.Windows.Forms.TextBox();
			this.save = new System.Windows.Forms.Button();
			this.cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "name";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "email";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "homepage";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "role";
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(118, 6);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(154, 20);
			this.name.TabIndex = 1;
			// 
			// email
			// 
			this.email.Location = new System.Drawing.Point(118, 29);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(154, 20);
			this.email.TabIndex = 2;
			// 
			// homepage
			// 
			this.homepage.Location = new System.Drawing.Point(118, 52);
			this.homepage.Name = "homepage";
			this.homepage.Size = new System.Drawing.Size(154, 20);
			this.homepage.TabIndex = 3;
			// 
			// role
			// 
			this.role.Location = new System.Drawing.Point(118, 75);
			this.role.Name = "role";
			this.role.Size = new System.Drawing.Size(154, 20);
			this.role.TabIndex = 4;
			// 
			// save
			// 
			this.save.Location = new System.Drawing.Point(12, 104);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(75, 23);
			this.save.TabIndex = 5;
			this.save.Text = "save";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.SaveClick);
			// 
			// cancel
			// 
			this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancel.Location = new System.Drawing.Point(197, 104);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(75, 23);
			this.cancel.TabIndex = 6;
			this.cancel.Text = "cancel";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.CancelClick);
			// 
			// AuthorForm
			// 
			this.AcceptButton = this.save;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancel;
			this.ClientSize = new System.Drawing.Size(284, 136);
			this.ControlBox = false;
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.save);
			this.Controls.Add(this.role);
			this.Controls.Add(this.homepage);
			this.Controls.Add(this.email);
			this.Controls.Add(this.name);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AuthorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AuthorForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
