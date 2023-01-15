namespace MuistipeliApp
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.btn1Player = new System.Windows.Forms.Button();
            this.btn2Players = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnPlayerStats = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.WMPmusic = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.WMPmusic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1Player
            // 
            this.btn1Player.Location = new System.Drawing.Point(86, 109);
            this.btn1Player.Name = "btn1Player";
            this.btn1Player.Size = new System.Drawing.Size(141, 38);
            this.btn1Player.TabIndex = 0;
            this.btn1Player.Text = "1 Player";
            this.btn1Player.UseVisualStyleBackColor = true;
            this.btn1Player.Click += new System.EventHandler(this.btn1Player_Click);
            // 
            // btn2Players
            // 
            this.btn2Players.Location = new System.Drawing.Point(86, 175);
            this.btn2Players.Name = "btn2Players";
            this.btn2Players.Size = new System.Drawing.Size(141, 38);
            this.btn2Players.TabIndex = 1;
            this.btn2Players.Text = "2 Players";
            this.btn2Players.UseVisualStyleBackColor = true;
            this.btn2Players.Click += new System.EventHandler(this.btn2Players_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(86, 240);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(141, 38);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPlayerStats
            // 
            this.btnPlayerStats.Location = new System.Drawing.Point(86, 300);
            this.btnPlayerStats.Name = "btnPlayerStats";
            this.btnPlayerStats.Size = new System.Drawing.Size(141, 38);
            this.btnPlayerStats.TabIndex = 3;
            this.btnPlayerStats.Text = "Player stats";
            this.btnPlayerStats.UseVisualStyleBackColor = true;
            this.btnPlayerStats.Click += new System.EventHandler(this.btnPlayerStats_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(86, 363);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(141, 38);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.Location = new System.Drawing.Point(59, 29);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(188, 39);
            this.lblMainMenu.TabIndex = 5;
            this.lblMainMenu.Text = "Main menu";
            // 
            // WMPmusic
            // 
            this.WMPmusic.Enabled = true;
            this.WMPmusic.Location = new System.Drawing.Point(48, 415);
            this.WMPmusic.Name = "WMPmusic";
            this.WMPmusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPmusic.OcxState")));
            this.WMPmusic.Size = new System.Drawing.Size(226, 23);
            this.WMPmusic.TabIndex = 6;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 450);
            this.Controls.Add(this.WMPmusic);
            this.Controls.Add(this.lblMainMenu);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlayerStats);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btn2Players);
            this.Controls.Add(this.btn1Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMainMenu";
            this.Text = "Find a match";
            ((System.ComponentModel.ISupportInitialize)(this.WMPmusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1Player;
        private System.Windows.Forms.Button btn2Players;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnPlayerStats;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblMainMenu;
        private AxWMPLib.AxWindowsMediaPlayer WMPmusic;
    }
}