/*
 * Created by SharpDevelop.
 * User: zXinGG
 * Date: 10/19/2019
 * Time: 12:20 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GPIB
{
	partial class DataPelkat
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
			this.PelkatdataGridView = new System.Windows.Forms.DataGridView();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textCari = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PelkatdataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// PelkatdataGridView
			// 
			this.PelkatdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PelkatdataGridView.Location = new System.Drawing.Point(13, 40);
			this.PelkatdataGridView.Name = "PelkatdataGridView";
			this.PelkatdataGridView.Size = new System.Drawing.Size(1039, 588);
			this.PelkatdataGridView.TabIndex = 0;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"SEMUA PELKAT",
									"PA",
									"PT",
									"GP",
									"PKP",
									"PKB",
									"PKLU"});
			this.comboBox1.Location = new System.Drawing.Point(13, 13);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(193, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.TextChanged += new System.EventHandler(this.ComboBox1TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(847, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Cari";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textCari
			// 
			this.textCari.Location = new System.Drawing.Point(877, 12);
			this.textCari.Name = "textCari";
			this.textCari.Size = new System.Drawing.Size(175, 20);
			this.textCari.TabIndex = 5;
			this.textCari.TextChanged += new System.EventHandler(this.TextCariTextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 634);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 35);
			this.button1.TabIndex = 7;
			this.button1.Text = "Export to Excel";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// DataPelkat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 681);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textCari);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.PelkatdataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DataPelkat";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DataPelkat";
			this.Load += new System.EventHandler(this.DataPelkatLoad);
			((System.ComponentModel.ISupportInitialize)(this.PelkatdataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textCari;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataGridView PelkatdataGridView;
	}
}
