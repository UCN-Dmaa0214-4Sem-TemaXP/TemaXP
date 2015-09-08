namespace TemaXP.GUI {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabArt = new System.Windows.Forms.TabPage();
            this.artTab1 = new TemaXP.GUI.ArtTab();
            this.tabAuction = new System.Windows.Forms.TabPage();
            this.auctionTab1 = new TemaXP.GUI.AuctionTab();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabArt.SuspendLayout();
            this.tabAuction.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1091, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabArt);
            this.tabControl.Controls.Add(this.tabAuction);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1091, 430);
            this.tabControl.TabIndex = 1;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // tabArt
            // 
            this.tabArt.Controls.Add(this.artTab1);
            this.tabArt.Location = new System.Drawing.Point(4, 25);
            this.tabArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabArt.Name = "tabArt";
            this.tabArt.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabArt.Size = new System.Drawing.Size(1083, 401);
            this.tabArt.TabIndex = 0;
            this.tabArt.Text = "Kunst";
            this.tabArt.UseVisualStyleBackColor = true;
            // 
            // artTab1
            // 
            this.artTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artTab1.Location = new System.Drawing.Point(4, 4);
            this.artTab1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.artTab1.Name = "artTab1";
            this.artTab1.Size = new System.Drawing.Size(1075, 393);
            this.artTab1.TabIndex = 0;
            // 
            // tabAuction
            // 
            this.tabAuction.Controls.Add(this.auctionTab1);
            this.tabAuction.Location = new System.Drawing.Point(4, 25);
            this.tabAuction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAuction.Name = "tabAuction";
            this.tabAuction.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAuction.Size = new System.Drawing.Size(1083, 401);
            this.tabAuction.TabIndex = 1;
            this.tabAuction.Text = "Auktion";
            this.tabAuction.UseVisualStyleBackColor = true;
            // 
            // auctionTab1
            // 
            this.auctionTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auctionTab1.Location = new System.Drawing.Point(4, 4);
            this.auctionTab1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.auctionTab1.Name = "auctionTab1";
            this.auctionTab1.Size = new System.Drawing.Size(1075, 393);
            this.auctionTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 458);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "UCN Kunstklub";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabArt.ResumeLayout(false);
            this.tabAuction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabArt;
        private System.Windows.Forms.TabPage tabAuction;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private ArtTab artTab1;
        private AuctionTab auctionTab1;
    }
}