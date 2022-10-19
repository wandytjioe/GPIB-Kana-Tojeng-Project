/*
 * Created by SharpDevelop.
 * User: zXinGG
 * Date: 8/31/2019
 * Time: 12:01 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GPIB
{
	partial class FormLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.textusername = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textpassword = new System.Windows.Forms.TextBox();
			this.labelsalah = new System.Windows.Forms.Label();
			this.btnlogin = new System.Windows.Forms.Button();
			this.btnbatal = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(35, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textusername
			// 
			this.textusername.Location = new System.Drawing.Point(97, 94);
			this.textusername.Name = "textusername";
			this.textusername.Size = new System.Drawing.Size(159, 20);
			this.textusername.TabIndex = 1;
			this.textusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextusernameKeyPress);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(36, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textpassword
			// 
			this.textpassword.Location = new System.Drawing.Point(97, 120);
			this.textpassword.Name = "textpassword";
			this.textpassword.PasswordChar = '*';
			this.textpassword.Size = new System.Drawing.Size(159, 20);
			this.textpassword.TabIndex = 3;
			this.textpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextpasswordKeyPress);
			// 
			// labelsalah
			// 
			this.labelsalah.ForeColor = System.Drawing.Color.Red;
			this.labelsalah.Location = new System.Drawing.Point(97, 68);
			this.labelsalah.Name = "labelsalah";
			this.labelsalah.Size = new System.Drawing.Size(159, 23);
			this.labelsalah.TabIndex = 4;
			this.labelsalah.Text = "Username atau Password salah!";
			this.labelsalah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelsalah.Visible = false;
			// 
			// btnlogin
			// 
			this.btnlogin.Location = new System.Drawing.Point(181, 146);
			this.btnlogin.Name = "btnlogin";
			this.btnlogin.Size = new System.Drawing.Size(75, 23);
			this.btnlogin.TabIndex = 5;
			this.btnlogin.Text = "Login";
			this.btnlogin.UseVisualStyleBackColor = true;
			this.btnlogin.Click += new System.EventHandler(this.BtnloginClick);
			// 
			// btnbatal
			// 
			this.btnbatal.Location = new System.Drawing.Point(97, 146);
			this.btnbatal.Name = "btnbatal";
			this.btnbatal.Size = new System.Drawing.Size(75, 23);
			this.btnbatal.TabIndex = 6;
			this.btnbatal.Text = "Batal";
			this.btnbatal.UseVisualStyleBackColor = true;
			this.btnbatal.Click += new System.EventHandler(this.BtnbatalClick);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.ControlBox = false;
			this.Controls.Add(this.btnbatal);
			this.Controls.Add(this.btnlogin);
			this.Controls.Add(this.labelsalah);
			this.Controls.Add(this.textpassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textusername);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormLogin";
			this.Load += new System.EventHandler(this.FormLoginLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnbatal;
		private System.Windows.Forms.Button btnlogin;
		private System.Windows.Forms.Label labelsalah;
		private System.Windows.Forms.TextBox textpassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textusername;
		private System.Windows.Forms.Label label1;
	}
}
