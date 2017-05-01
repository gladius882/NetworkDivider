/*
 * Created by SharpDevelop.
 * User: Patryk
 * Date: 2017-04-30
 * Time: 16:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NetworkDivider
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripProgram;
		private System.Windows.Forms.ToolStripMenuItem toolStripExit;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem iPConverterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem binToDecToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem decToBinToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem getMaskFromIPToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem getBroadcastToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem commonNetworkToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addressClassesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutAuthorToolStripMenuItem;
		
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripProgram = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iPConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.binToDecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.decToBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.getMaskFromIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.getBroadcastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.commonNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addressClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripProgram,
			this.toolsToolStripMenuItem,
			this.infoToolStripMenuItem,
			this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(564, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripProgram
			// 
			this.toolStripProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripExit});
			this.toolStripProgram.Name = "toolStripProgram";
			this.toolStripProgram.Size = new System.Drawing.Size(65, 20);
			this.toolStripProgram.Text = "Program";
			// 
			// toolStripExit
			// 
			this.toolStripExit.Name = "toolStripExit";
			this.toolStripExit.Size = new System.Drawing.Size(152, 22);
			this.toolStripExit.Text = "Exit";
			this.toolStripExit.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.iPConverterToolStripMenuItem,
			this.getMaskFromIPToolStripMenuItem,
			this.getBroadcastToolStripMenuItem,
			this.commonNetworkToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// iPConverterToolStripMenuItem
			// 
			this.iPConverterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.binToDecToolStripMenuItem,
			this.decToBinToolStripMenuItem});
			this.iPConverterToolStripMenuItem.Name = "iPConverterToolStripMenuItem";
			this.iPConverterToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.iPConverterToolStripMenuItem.Text = "IP Converter";
			// 
			// binToDecToolStripMenuItem
			// 
			this.binToDecToolStripMenuItem.Name = "binToDecToolStripMenuItem";
			this.binToDecToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.binToDecToolStripMenuItem.Text = "Bin to dec";
			// 
			// decToBinToolStripMenuItem
			// 
			this.decToBinToolStripMenuItem.Name = "decToBinToolStripMenuItem";
			this.decToBinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.decToBinToolStripMenuItem.Text = "Dec to bin";
			// 
			// getMaskFromIPToolStripMenuItem
			// 
			this.getMaskFromIPToolStripMenuItem.Name = "getMaskFromIPToolStripMenuItem";
			this.getMaskFromIPToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.getMaskFromIPToolStripMenuItem.Text = "Check mask";
			// 
			// getBroadcastToolStripMenuItem
			// 
			this.getBroadcastToolStripMenuItem.Name = "getBroadcastToolStripMenuItem";
			this.getBroadcastToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.getBroadcastToolStripMenuItem.Text = "Check broadcast";
			this.getBroadcastToolStripMenuItem.Click += new System.EventHandler(this.GetBroadcastToolStripMenuItemClick);
			// 
			// commonNetworkToolStripMenuItem
			// 
			this.commonNetworkToolStripMenuItem.Name = "commonNetworkToolStripMenuItem";
			this.commonNetworkToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.commonNetworkToolStripMenuItem.Text = "Common network";
			// 
			// infoToolStripMenuItem
			// 
			this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.addressClassesToolStripMenuItem});
			this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
			this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.infoToolStripMenuItem.Text = "Info";
			// 
			// addressClassesToolStripMenuItem
			// 
			this.addressClassesToolStripMenuItem.Name = "addressClassesToolStripMenuItem";
			this.addressClassesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.addressClassesToolStripMenuItem.Text = "Address classes";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.helpToolStripMenuItem,
			this.aboutAuthorToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutAuthorToolStripMenuItem
			// 
			this.aboutAuthorToolStripMenuItem.Name = "aboutAuthorToolStripMenuItem";
			this.aboutAuthorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutAuthorToolStripMenuItem.Text = "About author";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 341);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "NetworkDivider";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
