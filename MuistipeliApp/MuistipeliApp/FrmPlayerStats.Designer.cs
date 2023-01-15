namespace MuistipeliApp
{
    partial class FrmPlayerStats
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
            this.components = new System.ComponentModel.Container();
            this.lblPlayerStats = new System.Windows.Forms.Label();
            this.lbPlayerStats = new System.Windows.Forms.ListBox();
            this.cmsDeletePlayer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveExit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHowToDelete = new System.Windows.Forms.Label();
            this.cmsDeletePlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerStats
            // 
            this.lblPlayerStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayerStats.AutoSize = true;
            this.lblPlayerStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerStats.Location = new System.Drawing.Point(115, 33);
            this.lblPlayerStats.Name = "lblPlayerStats";
            this.lblPlayerStats.Size = new System.Drawing.Size(291, 44);
            this.lblPlayerStats.TabIndex = 0;
            this.lblPlayerStats.Text = "Player Statistics";
            // 
            // lbPlayerStats
            // 
            this.lbPlayerStats.ContextMenuStrip = this.cmsDeletePlayer;
            this.lbPlayerStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerStats.FormattingEnabled = true;
            this.lbPlayerStats.ItemHeight = 20;
            this.lbPlayerStats.Location = new System.Drawing.Point(50, 142);
            this.lbPlayerStats.Name = "lbPlayerStats";
            this.lbPlayerStats.Size = new System.Drawing.Size(445, 204);
            this.lbPlayerStats.TabIndex = 1;
            // 
            // cmsDeletePlayer
            // 
            this.cmsDeletePlayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePlayerToolStripMenuItem});
            this.cmsDeletePlayer.Name = "cmsDeletePlayer";
            this.cmsDeletePlayer.Size = new System.Drawing.Size(182, 26);
            // 
            // deletePlayerToolStripMenuItem
            // 
            this.deletePlayerToolStripMenuItem.Name = "deletePlayerToolStripMenuItem";
            this.deletePlayerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deletePlayerToolStripMenuItem.ShowShortcutKeys = false;
            this.deletePlayerToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.deletePlayerToolStripMenuItem.Text = "Delete selected player";
            this.deletePlayerToolStripMenuItem.Click += new System.EventHandler(this.deletePlayerToolStripMenuItem_Click);
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveExit.Location = new System.Drawing.Point(97, 368);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(101, 44);
            this.btnSaveExit.TabIndex = 2;
            this.btnSaveExit.Text = "Save and exit";
            this.btnSaveExit.UseVisualStyleBackColor = true;
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Location = new System.Drawing.Point(341, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 44);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHowToDelete
            // 
            this.lblHowToDelete.AutoSize = true;
            this.lblHowToDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowToDelete.Location = new System.Drawing.Point(47, 111);
            this.lblHowToDelete.Name = "lblHowToDelete";
            this.lblHowToDelete.Size = new System.Drawing.Size(191, 17);
            this.lblHowToDelete.TabIndex = 4;
            this.lblHowToDelete.Text = "(Right click to delete players)";
            // 
            // FrmPlayerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 451);
            this.Controls.Add(this.lblHowToDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveExit);
            this.Controls.Add(this.lbPlayerStats);
            this.Controls.Add(this.lblPlayerStats);
            this.MinimumSize = new System.Drawing.Size(580, 400);
            this.Name = "FrmPlayerStats";
            this.Text = "Statistics";
            this.Resize += new System.EventHandler(this.FrmPlayerStats_Resize);
            this.cmsDeletePlayer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerStats;
        private System.Windows.Forms.ListBox lbPlayerStats;
        private System.Windows.Forms.Button btnSaveExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ContextMenuStrip cmsDeletePlayer;
        private System.Windows.Forms.ToolStripMenuItem deletePlayerToolStripMenuItem;
        private System.Windows.Forms.Label lblHowToDelete;
    }
}