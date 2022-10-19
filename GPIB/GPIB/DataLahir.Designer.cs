/*
 * Created by SharpDevelop.
 * User: zXinGG
 * Date: 10/22/2019
 * Time: 5:20 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GPIB
{
	partial class DataLahir
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.LahirdataGridView = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.LahirdataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"Januari",
									"Februari",
									"Maret",
									"April",
									"Mei",
									"Juni",
									"Juli",
									"Agustus",
									"September",
									"Oktober",
									"November",
									"Desember"});
			this.comboBox1.Location = new System.Drawing.Point(13, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(193, 21);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.TextChanged += new System.EventHandler(this.ComboBox1TextChanged);
			// 
			// LahirdataGridView
			// 
			this.LahirdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.LahirdataGridView.Location = new System.Drawing.Point(13, 39);
			this.LahirdataGridView.Name = "LahirdataGridView";
			this.LahirdataGridView.Size = new System.Drawing.Size(1039, 589);
			this.LahirdataGridView.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 634);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 35);
			this.button1.TabIndex = 6;
			this.button1.Text = "Export to Excel";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// DataLahir
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 681);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.LahirdataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DataLahir";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DataLahir";
			this.Load += new System.EventHandler(this.DataLahirLoad);
			((System.ComponentModel.ISupportInitialize)(this.LahirdataGridView)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView LahirdataGridView;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}
