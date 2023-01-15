namespace MuistipeliApp
{
    partial class FrmGameInfoMultiPlayer
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
            this.nudCardCount = new System.Windows.Forms.NumericUpDown();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.lblCardCount = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbPlayer2Name = new System.Windows.Forms.ComboBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.cmbPlayer1Name = new System.Windows.Forms.ComboBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCardCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudCardCount
            // 
            this.nudCardCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCardCount.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCardCount.Location = new System.Drawing.Point(208, 124);
            this.nudCardCount.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudCardCount.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudCardCount.Name = "nudCardCount";
            this.nudCardCount.Size = new System.Drawing.Size(53, 29);
            this.nudCardCount.TabIndex = 3;
            this.nudCardCount.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudCardCount.ValueChanged += new System.EventHandler(this.nudCardCount_ValueChanged);
            this.nudCardCount.Leave += new System.EventHandler(this.nudCardCount_Leave);
            // 
            // nudRows
            // 
            this.nudRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRows.Location = new System.Drawing.Point(208, 183);
            this.nudRows.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(53, 29);
            this.nudRows.TabIndex = 4;
            this.nudRows.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudRows.Leave += new System.EventHandler(this.nudRows_Leave);
            // 
            // lblCardCount
            // 
            this.lblCardCount.AutoSize = true;
            this.lblCardCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardCount.Location = new System.Drawing.Point(24, 126);
            this.lblCardCount.Name = "lblCardCount";
            this.lblCardCount.Size = new System.Drawing.Size(161, 24);
            this.lblCardCount.TabIndex = 2;
            this.lblCardCount.Text = "How many cards?";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.Location = new System.Drawing.Point(24, 185);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(155, 24);
            this.lblRows.TabIndex = 3;
            this.lblRows.Text = "How many rows?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbPlayer2Name);
            this.panel1.Controls.Add(this.lblPlayer2);
            this.panel1.Controls.Add(this.cmbPlayer1Name);
            this.panel1.Controls.Add(this.lblPlayer1);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.lblRows);
            this.panel1.Controls.Add(this.nudCardCount);
            this.panel1.Controls.Add(this.lblCardCount);
            this.panel1.Controls.Add(this.nudRows);
            this.panel1.Location = new System.Drawing.Point(24, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 294);
            this.panel1.TabIndex = 4;
            // 
            // cmbPlayer2Name
            // 
            this.cmbPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlayer2Name.FormattingEnabled = true;
            this.cmbPlayer2Name.Location = new System.Drawing.Point(119, 65);
            this.cmbPlayer2Name.Name = "cmbPlayer2Name";
            this.cmbPlayer2Name.Size = new System.Drawing.Size(142, 32);
            this.cmbPlayer2Name.TabIndex = 2;
            this.cmbPlayer2Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPlayer2Name_KeyPress);
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(24, 68);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(77, 24);
            this.lblPlayer2.TabIndex = 7;
            this.lblPlayer2.Text = "Player 2";
            // 
            // cmbPlayer1Name
            // 
            this.cmbPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlayer1Name.FormattingEnabled = true;
            this.cmbPlayer1Name.Location = new System.Drawing.Point(119, 11);
            this.cmbPlayer1Name.Name = "cmbPlayer1Name";
            this.cmbPlayer1Name.Size = new System.Drawing.Size(142, 32);
            this.cmbPlayer1Name.TabIndex = 1;
            this.cmbPlayer1Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPlayer1Name_KeyPress);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(24, 14);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(77, 24);
            this.lblPlayer1.TabIndex = 5;
            this.lblPlayer1.Text = "Player 1";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(101, 241);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 34);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmGameInfoMultiPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 334);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmGameInfoMultiPlayer";
            this.Text = "Game Info";
            ((System.ComponentModel.ISupportInitialize)(this.nudCardCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCardCount;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.NumericUpDown nudCardCount;
        public System.Windows.Forms.NumericUpDown nudRows;
        public System.Windows.Forms.ComboBox cmbPlayer1Name;
        private System.Windows.Forms.Label lblPlayer1;
        public System.Windows.Forms.ComboBox cmbPlayer2Name;
        private System.Windows.Forms.Label lblPlayer2;
    }
}