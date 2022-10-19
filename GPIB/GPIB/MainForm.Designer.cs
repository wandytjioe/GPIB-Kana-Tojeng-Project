/*
 * Created by SharpDevelop.
 * User: zXinGG
 * Date: 8/30/2019
 * Time: 10:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GPIB
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.inputEditHapusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataSektorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sektorIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pelkatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataKeluargaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGolDarahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataUltahKelahiranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataUltahPernikahanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.menuToolStripMenuItem,
									this.dataSektorToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(704, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.loginToolStripMenuItem,
									this.logoutToolStripMenuItem,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// loginToolStripMenuItem
			// 
			this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
			this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.loginToolStripMenuItem.Text = "Login";
			this.loginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItemClick);
			// 
			// logoutToolStripMenuItem
			// 
			this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.logoutToolStripMenuItem.Text = "Logout";
			this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.exitToolStripMenuItem.Text = "Keluar";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.inputEditHapusToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// inputEditHapusToolStripMenuItem
			// 
			this.inputEditHapusToolStripMenuItem.Name = "inputEditHapusToolStripMenuItem";
			this.inputEditHapusToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.inputEditHapusToolStripMenuItem.Text = "Input, Edit & Hapus";
			this.inputEditHapusToolStripMenuItem.Click += new System.EventHandler(this.InputEditHapusToolStripMenuItemClick);
			// 
			// dataSektorToolStripMenuItem
			// 
			this.dataSektorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.sektorIToolStripMenuItem,
									this.pelkatToolStripMenuItem,
									this.dataKeluargaToolStripMenuItem,
									this.dataGolDarahToolStripMenuItem,
									this.dataUltahKelahiranToolStripMenuItem,
									this.dataUltahPernikahanToolStripMenuItem});
			this.dataSektorToolStripMenuItem.Name = "dataSektorToolStripMenuItem";
			this.dataSektorToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.dataSektorToolStripMenuItem.Text = "Query";
			// 
			// sektorIToolStripMenuItem
			// 
			this.sektorIToolStripMenuItem.Name = "sektorIToolStripMenuItem";
			this.sektorIToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.sektorIToolStripMenuItem.Text = "Data Sektor";
			this.sektorIToolStripMenuItem.Click += new System.EventHandler(this.SektorIToolStripMenuItemClick);
			// 
			// pelkatToolStripMenuItem
			// 
			this.pelkatToolStripMenuItem.Name = "pelkatToolStripMenuItem";
			this.pelkatToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.pelkatToolStripMenuItem.Text = "Data Pelkat";
			this.pelkatToolStripMenuItem.Click += new System.EventHandler(this.PelkatToolStripMenuItemClick);
			// 
			// dataKeluargaToolStripMenuItem
			// 
			this.dataKeluargaToolStripMenuItem.Name = "dataKeluargaToolStripMenuItem";
			this.dataKeluargaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.dataKeluargaToolStripMenuItem.Text = "Data Keluarga";
			this.dataKeluargaToolStripMenuItem.Click += new System.EventHandler(this.DataKeluargaToolStripMenuItemClick);
			// 
			// dataGolDarahToolStripMenuItem
			// 
			this.dataGolDarahToolStripMenuItem.Name = "dataGolDarahToolStripMenuItem";
			this.dataGolDarahToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.dataGolDarahToolStripMenuItem.Text = "Data Gol. Darah";
			this.dataGolDarahToolStripMenuItem.Click += new System.EventHandler(this.DataGolDarahToolStripMenuItemClick);
			// 
			// dataUltahKelahiranToolStripMenuItem
			// 
			this.dataUltahKelahiranToolStripMenuItem.Name = "dataUltahKelahiranToolStripMenuItem";
			this.dataUltahKelahiranToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.dataUltahKelahiranToolStripMenuItem.Text = "Data Ultah Kelahiran";
			this.dataUltahKelahiranToolStripMenuItem.Click += new System.EventHandler(this.DataUltahKelahiranToolStripMenuItemClick);
			// 
			// dataUltahPernikahanToolStripMenuItem
			// 
			this.dataUltahPernikahanToolStripMenuItem.Name = "dataUltahPernikahanToolStripMenuItem";
			this.dataUltahPernikahanToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.dataUltahPernikahanToolStripMenuItem.Text = "Data Ultah Pernikahan";
			this.dataUltahPernikahanToolStripMenuItem.Click += new System.EventHandler(this.DataUltahPernikahanToolStripMenuItemClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(680, 654);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 681);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GPIB";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem dataUltahPernikahanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dataUltahKelahiranToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dataGolDarahToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dataKeluargaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pelkatToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem sektorIToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem dataSektorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inputEditHapusToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
