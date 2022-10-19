/*
 * Created by SharpDevelop.
 * User: zXinGG
 * Date: 10/20/2019
 * Time: 2:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GPIB
{
	partial class DataKelurga
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
			this.KeluargadataGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.textCari = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.KeluargadataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// KeluargadataGridView
			// 
			this.KeluargadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.KeluargadataGridView.Location = new System.Drawing.Point(12, 35);
			this.KeluargadataGridView.Name = "KeluargadataGridView";
			this.KeluargadataGridView.Size = new System.Drawing.Size(1040, 593);
			this.KeluargadataGridView.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Cari";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textCari
			// 
			this.textCari.Location = new System.Drawing.Point(42, 9);
			this.textCari.Name = "textCari";
			this.textCari.Size = new System.Drawing.Size(175, 20);
			this.textCari.TabIndex = 7;
			this.textCari.TextChanged += new System.EventHandler(this.TextCariTextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 634);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 35);
			this.button1.TabIndex = 9;
			this.button1.Text = "Export to Excel";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// DataKelurga
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 681);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textCari);
			this.Controls.Add(this.KeluargadataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DataKelurga";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DataKelurga";
			this.Load += new System.EventHandler(this.DataKelurgaLoad);
			((System.ComponentModel.ISupportInitialize)(this.KeluargadataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textCari;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView KeluargadataGridView;
	}
}
