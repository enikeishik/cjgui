/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 10.11.2018
 * Time: 8:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CJGui
{
	partial class SupportForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.TextBox wiki;
		private System.Windows.Forms.TextBox forum;
		private System.Windows.Forms.TextBox issues;
		private System.Windows.Forms.TextBox email;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox irc;
		private System.Windows.Forms.TextBox source;
		private System.Windows.Forms.TextBox docs;
		private System.Windows.Forms.TextBox rss;
		
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
			this.cancel = new System.Windows.Forms.Button();
			this.save = new System.Windows.Forms.Button();
			this.wiki = new System.Windows.Forms.TextBox();
			this.forum = new System.Windows.Forms.TextBox();
			this.issues = new System.Windows.Forms.TextBox();
			this.email = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.irc = new System.Windows.Forms.TextBox();
			this.source = new System.Windows.Forms.TextBox();
			this.docs = new System.Windows.Forms.TextBox();
			this.rss = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cancel
			// 
			this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancel.Location = new System.Drawing.Point(197, 226);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(75, 23);
			this.cancel.TabIndex = 16;
			this.cancel.Text = "cancel";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.CancelClick);
			// 
			// save
			// 
			this.save.Location = new System.Drawing.Point(12, 226);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(75, 23);
			this.save.TabIndex = 15;
			this.save.Text = "save";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.SaveClick);
			// 
			// wiki
			// 
			this.wiki.Location = new System.Drawing.Point(118, 75);
			this.wiki.Name = "wiki";
			this.wiki.Size = new System.Drawing.Size(154, 20);
			this.wiki.TabIndex = 14;
			// 
			// forum
			// 
			this.forum.Location = new System.Drawing.Point(118, 52);
			this.forum.Name = "forum";
			this.forum.Size = new System.Drawing.Size(154, 20);
			this.forum.TabIndex = 12;
			// 
			// issues
			// 
			this.issues.Location = new System.Drawing.Point(118, 29);
			this.issues.Name = "issues";
			this.issues.Size = new System.Drawing.Size(154, 20);
			this.issues.TabIndex = 10;
			// 
			// email
			// 
			this.email.Location = new System.Drawing.Point(118, 6);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(154, 20);
			this.email.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 13;
			this.label4.Text = "wiki";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "forum";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "issues";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "email";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 101);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "irc";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 124);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 18;
			this.label6.Text = "source";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 147);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 19;
			this.label7.Text = "docs";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(12, 170);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 20;
			this.label8.Text = "rss";
			// 
			// irc
			// 
			this.irc.Location = new System.Drawing.Point(118, 98);
			this.irc.Name = "irc";
			this.irc.Size = new System.Drawing.Size(154, 20);
			this.irc.TabIndex = 21;
			// 
			// source
			// 
			this.source.Location = new System.Drawing.Point(118, 121);
			this.source.Name = "source";
			this.source.Size = new System.Drawing.Size(154, 20);
			this.source.TabIndex = 22;
			// 
			// docs
			// 
			this.docs.Location = new System.Drawing.Point(118, 144);
			this.docs.Name = "docs";
			this.docs.Size = new System.Drawing.Size(154, 20);
			this.docs.TabIndex = 23;
			// 
			// rss
			// 
			this.rss.Location = new System.Drawing.Point(118, 167);
			this.rss.Name = "rss";
			this.rss.Size = new System.Drawing.Size(154, 20);
			this.rss.TabIndex = 24;
			// 
			// SupportForm
			// 
			this.AcceptButton = this.save;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancel;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.ControlBox = false;
			this.Controls.Add(this.rss);
			this.Controls.Add(this.docs);
			this.Controls.Add(this.source);
			this.Controls.Add(this.irc);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.save);
			this.Controls.Add(this.wiki);
			this.Controls.Add(this.forum);
			this.Controls.Add(this.issues);
			this.Controls.Add(this.email);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SupportForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Support";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
