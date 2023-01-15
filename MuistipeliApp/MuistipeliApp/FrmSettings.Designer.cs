namespace MuistipeliApp
{
    partial class FrmSettings
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
            this.lblMusic = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblSFX = new System.Windows.Forms.Label();
            this.lblCardBack = new System.Windows.Forms.Label();
            this.pbPointerArrow = new System.Windows.Forms.PictureBox();
            this.pbCardBack3 = new System.Windows.Forms.PictureBox();
            this.pbCardBack2 = new System.Windows.Forms.PictureBox();
            this.pbCardBack1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveExit = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnSFX = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPointerArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardBack3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardBack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardBack1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusic.Location = new System.Drawing.Point(35, 87);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(81, 26);
            this.lblMusic.TabIndex = 0;
            this.lblMusic.Text = "Music: ";
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.Location = new System.Drawing.Point(33, 22);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(143, 39);
            this.lblSettings.TabIndex = 1;
            this.lblSettings.Text = "Settings";
            // 
            // lblSFX
            // 
            this.lblSFX.AutoSize = true;
            this.lblSFX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSFX.Location = new System.Drawing.Point(241, 87);
            this.lblSFX.Name = "lblSFX";
            this.lblSFX.Size = new System.Drawing.Size(61, 26);
            this.lblSFX.TabIndex = 2;
            this.lblSFX.Text = "SFX:";
            // 
            // lblCardBack
            // 
            this.lblCardBack.AutoSize = true;
            this.lblCardBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardBack.Location = new System.Drawing.Point(35, 157);
            this.lblCardBack.Name = "lblCardBack";
            this.lblCardBack.Size = new System.Drawing.Size(120, 26);
            this.lblCardBack.TabIndex = 3;
            this.lblCardBack.Text = "Card Back:";
            // 
            // pbPointerArrow
            // 
            this.pbPointerArrow.Image = global::MuistipeliApp.Properties.Resources.pointerArrow;
            this.pbPointerArrow.Location = new System.Drawing.Point(12, 317);
            this.pbPointerArrow.Name = "pbPointerArrow";
            this.pbPointerArrow.Size = new System.Drawing.Size(43, 41);
            this.pbPointerArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPointerArrow.TabIndex = 7;
            this.pbPointerArrow.TabStop = false;
            // 
            // pbCardBack3
            // 
            this.pbCardBack3.Image = global::MuistipeliApp.Properties.Resources.back3;
            this.pbCardBack3.InitialImage = null;
            this.pbCardBack3.Location = new System.Drawing.Point(290, 209);
            this.pbCardBack3.Name = "pbCardBack3";
            this.pbCardBack3.Size = new System.Drawing.Size(91, 102);
            this.pbCardBack3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCardBack3.TabIndex = 6;
            this.pbCardBack3.TabStop = false;
            this.pbCardBack3.Click += new System.EventHandler(this.pbCardBack3_Click);
            // 
            // pbCardBack2
            // 
            this.pbCardBack2.Image = global::MuistipeliApp.Properties.Resources.back2;
            this.pbCardBack2.InitialImage = null;
            this.pbCardBack2.Location = new System.Drawing.Point(164, 209);
            this.pbCardBack2.Name = "pbCardBack2";
            this.pbCardBack2.Size = new System.Drawing.Size(91, 102);
            this.pbCardBack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCardBack2.TabIndex = 5;
            this.pbCardBack2.TabStop = false;
            this.pbCardBack2.Click += new System.EventHandler(this.pbCardBack2_Click);
            // 
            // pbCardBack1
            // 
            this.pbCardBack1.Image = global::MuistipeliApp.Properties.Resources.back1;
            this.pbCardBack1.InitialImage = null;
            this.pbCardBack1.Location = new System.Drawing.Point(36, 209);
            this.pbCardBack1.Name = "pbCardBack1";
            this.pbCardBack1.Size = new System.Drawing.Size(91, 102);
            this.pbCardBack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCardBack1.TabIndex = 4;
            this.pbCardBack1.TabStop = false;
            this.pbCardBack1.Click += new System.EventHandler(this.pbCardBack1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(270, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 36);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveExit.Location = new System.Drawing.Point(40, 392);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(118, 36);
            this.btnSaveExit.TabIndex = 7;
            this.btnSaveExit.Text = "Save and exit";
            this.btnSaveExit.UseVisualStyleBackColor = true;
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusic.Location = new System.Drawing.Point(108, 87);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(50, 26);
            this.btnMusic.TabIndex = 5;
            this.btnMusic.Text = "ON";
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnSFX
            // 
            this.btnSFX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSFX.Location = new System.Drawing.Point(298, 87);
            this.btnSFX.Name = "btnSFX";
            this.btnSFX.Size = new System.Drawing.Size(50, 26);
            this.btnSFX.TabIndex = 6;
            this.btnSFX.Text = "ON";
            this.btnSFX.UseVisualStyleBackColor = true;
            this.btnSFX.Click += new System.EventHandler(this.btnSFX_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 457);
            this.Controls.Add(this.btnSFX);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnSaveExit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbPointerArrow);
            this.Controls.Add(this.pbCardBack3);
            this.Controls.Add(this.pbCardBack2);
            this.Controls.Add(this.pbCardBack1);
            this.Controls.Add(this.lblCardBack);
            this.Controls.Add(this.lblSFX);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.lblMusic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSettings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pbPointerArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardBack3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardBack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardBack1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblSFX;
        private System.Windows.Forms.Label lblCardBack;
        private System.Windows.Forms.PictureBox pbCardBack1;
        private System.Windows.Forms.PictureBox pbCardBack2;
        private System.Windows.Forms.PictureBox pbCardBack3;
        private System.Windows.Forms.PictureBox pbPointerArrow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveExit;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnSFX;
    }
}