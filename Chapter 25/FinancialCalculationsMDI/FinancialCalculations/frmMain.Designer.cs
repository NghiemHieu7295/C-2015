namespace FinancialCalculations
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewFutureValue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewDepreciation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFutureValue = new System.Windows.Forms.ToolStripButton();
            this.btnDepreciation = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewFutureValue,
            this.mnuNewDepreciation,
            this.mnuClose,
            this.toolStripSeparator1,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuNewFutureValue
            // 
            this.mnuNewFutureValue.Name = "mnuNewFutureValue";
            this.mnuNewFutureValue.Size = new System.Drawing.Size(141, 22);
            this.mnuNewFutureValue.Text = "Future Value";
            this.mnuNewFutureValue.Click += new System.EventHandler(this.mnuNewFutureValue_Click);
            // 
            // mnuNewDepreciation
            // 
            this.mnuNewDepreciation.Name = "mnuNewDepreciation";
            this.mnuNewDepreciation.Size = new System.Drawing.Size(141, 22);
            this.mnuNewDepreciation.Text = "Depreciation";
            this.mnuNewDepreciation.Click += new System.EventHandler(this.mnuNewDepreciation_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(141, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(141, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCascade,
            this.mnuTileVertical,
            this.mnuTileHorizontal});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // mnuCascade
            // 
            this.mnuCascade.Name = "mnuCascade";
            this.mnuCascade.Size = new System.Drawing.Size(152, 22);
            this.mnuCascade.Text = "Cascade";
            this.mnuCascade.Click += new System.EventHandler(this.mnuCascade_Click);
            // 
            // mnuTileVertical
            // 
            this.mnuTileVertical.Name = "mnuTileVertical";
            this.mnuTileVertical.Size = new System.Drawing.Size(152, 22);
            this.mnuTileVertical.Text = "Tile Vertical";
            this.mnuTileVertical.Click += new System.EventHandler(this.mnuTileVertical_Click);
            // 
            // mnuTileHorizontal
            // 
            this.mnuTileHorizontal.Name = "mnuTileHorizontal";
            this.mnuTileHorizontal.Size = new System.Drawing.Size(152, 22);
            this.mnuTileHorizontal.Text = "Tile Horizontal";
            this.mnuTileHorizontal.Click += new System.EventHandler(this.mnuTileHorizontal_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolbar});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // mnuToolbar
            // 
            this.mnuToolbar.Name = "mnuToolbar";
            this.mnuToolbar.Size = new System.Drawing.Size(152, 22);
            this.mnuToolbar.Text = "Toolbar";
            this.mnuToolbar.Click += new System.EventHandler(this.mnuToolbar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFutureValue,
            this.btnDepreciation});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFutureValue
            // 
            this.btnFutureValue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFutureValue.Image = ((System.Drawing.Image)(resources.GetObject("btnFutureValue.Image")));
            this.btnFutureValue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFutureValue.Name = "btnFutureValue";
            this.btnFutureValue.Size = new System.Drawing.Size(23, 22);
            this.btnFutureValue.Text = "toolStripButton1";
            this.btnFutureValue.Click += new System.EventHandler(this.btnFutureValue_Click);
            // 
            // btnDepreciation
            // 
            this.btnDepreciation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDepreciation.Image = ((System.Drawing.Image)(resources.GetObject("btnDepreciation.Image")));
            this.btnDepreciation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDepreciation.Name = "btnDepreciation";
            this.btnDepreciation.Size = new System.Drawing.Size(23, 22);
            this.btnDepreciation.Text = "toolStripButton2";
            this.btnDepreciation.Click += new System.EventHandler(this.btnDepreciation_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 480);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Calculations";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNewFutureValue;
        private System.Windows.Forms.ToolStripMenuItem mnuNewDepreciation;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTileVertical;
        private System.Windows.Forms.ToolStripMenuItem mnuTileHorizontal;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFutureValue;
        private System.Windows.Forms.ToolStripButton btnDepreciation;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuToolbar;
    }
}

