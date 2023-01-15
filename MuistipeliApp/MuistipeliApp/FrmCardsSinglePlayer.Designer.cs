namespace MuistipeliApp
{
    partial class FrmCardsSinglePlayer
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
            this.pnlCards = new System.Windows.Forms.Panel();
            this.pnlNames = new System.Windows.Forms.Panel();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.tmrCheckMatch = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrGameTime = new System.Windows.Forms.Timer(this.components);
            this.pnlNames.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCards
            // 
            this.pnlCards.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlCards.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlCards.Location = new System.Drawing.Point(45, 209);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(684, 326);
            this.pnlCards.TabIndex = 0;
            // 
            // pnlNames
            // 
            this.pnlNames.Controls.Add(this.lblPlayer1Score);
            this.pnlNames.Controls.Add(this.lblPlayer1Name);
            this.pnlNames.Controls.Add(this.lblPlayer1);
            this.pnlNames.Location = new System.Drawing.Point(45, 26);
            this.pnlNames.Name = "pnlNames";
            this.pnlNames.Size = new System.Drawing.Size(684, 157);
            this.pnlNames.TabIndex = 1;
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.Location = new System.Drawing.Point(20, 71);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(68, 20);
            this.lblPlayer1Score.TabIndex = 7;
            this.lblPlayer1Score.Text = "Score: 0";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Name.Location = new System.Drawing.Point(20, 42);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(65, 20);
            this.lblPlayer1Name.TabIndex = 6;
            this.lblPlayer1Name.Text = "Player 1";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(20, 13);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(52, 20);
            this.lblPlayer1.TabIndex = 5;
            this.lblPlayer1.Text = "Player";
            // 
            // tmrCheckMatch
            // 
            this.tmrCheckMatch.Interval = 500;
            this.tmrCheckMatch.Tick += new System.EventHandler(this.tmrCheckMatch_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(774, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblTime
            // 
            this.tsslblTime.Name = "tsslblTime";
            this.tsslblTime.Size = new System.Drawing.Size(45, 17);
            this.tsslblTime.Text = "Time: 0";
            // 
            // tmrGameTime
            // 
            this.tmrGameTime.Enabled = true;
            this.tmrGameTime.Interval = 1000;
            this.tmrGameTime.Tick += new System.EventHandler(this.tmrGameTime_Tick);
            // 
            // FrmCardsSinglePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 604);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlNames);
            this.Controls.Add(this.pnlCards);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FrmCardsSinglePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find a Match";
            this.Load += new System.EventHandler(this.FrmCards_Load);
            this.Resize += new System.EventHandler(this.Frm8cards_Resize);
            this.pnlNames.ResumeLayout(false);
            this.pnlNames.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel pnlNames;
        private System.Windows.Forms.Timer tmrCheckMatch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblTime;
        private System.Windows.Forms.Timer tmrGameTime;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblPlayer1;
    }
}

