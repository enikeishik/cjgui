/*
 * Created by SharpDevelop.
 * User: pl
 * Date: 12.11.2018
 * Time: 13:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CJGui
{
	partial class AutoloadPsrForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.TextBox key;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox values;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button remove;
		
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
			this.key = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.values = new System.Windows.Forms.ListBox();
			this.add = new System.Windows.Forms.Button();
			this.remove = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// close
			// 
			this.close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.close.Location = new System.Drawing.Point(12, 146);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(260, 23);
			this.close.TabIndex = 5;
			this.close.Text = "close";
			this.close.UseVisualStyleBackColor = true;
			this.close.Click += new System.EventHandler(this.CloseClick);
			// 
			// key
			// 
			this.key.Location = new System.Drawing.Point(93, 6);
			this.key.Name = "key";
			this.key.Size = new System.Drawing.Size(179, 20);
			this.key.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 23);
			this.label2.TabIndex = 21;
			this.label2.Text = "value(s)";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 23);
			this.label1.TabIndex = 19;
			this.label1.Text = "key";
			// 
			// values
			// 
			this.values.FormattingEnabled = true;
			this.values.Location = new System.Drawing.Point(93, 32);
			this.values.Name = "values";
			this.values.Size = new System.Drawing.Size(179, 69);
			this.values.TabIndex = 2;
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(93, 107);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(75, 23);
			this.add.TabIndex = 3;
			this.add.Text = "add";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.AddClick);
			// 
			// remove
			// 
			this.remove.Location = new System.Drawing.Point(197, 107);
			this.remove.Name = "remove";
			this.remove.Size = new System.Drawing.Size(75, 23);
			this.remove.TabIndex = 4;
			this.remove.Text = "remove";
			this.remove.UseVisualStyleBackColor = true;
			this.remove.Click += new System.EventHandler(this.RemoveClick);
			// 
			// AutoloadPsrForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.close;
			this.ClientSize = new System.Drawing.Size(284, 181);
			this.ControlBox = false;
			this.Controls.Add(this.remove);
			this.Controls.Add(this.add);
			this.Controls.Add(this.values);
			this.Controls.Add(this.key);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.close);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AutoloadPsrForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PSR";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThisFormClosing);
			this.Load += new System.EventHandler(this.ThisFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
