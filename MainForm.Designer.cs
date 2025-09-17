/*
 * Created by SharpDevelop.
 * User: Valik
 * Date: 17.09.2025
 * Time: 21:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace StudyEnglish
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(423, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "RusWord";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(46, 96);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(142, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Word1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(259, 96);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(142, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Word2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(46, 168);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(142, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Word3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(259, 168);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(142, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "Word4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(46, 225);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Good:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(259, 225);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Bad:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 272);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StudyEnglish";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Shown += new System.EventHandler(this.MainFormShown);
			this.ResumeLayout(false);

		}
	}
}
