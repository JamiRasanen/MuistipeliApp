﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuistipeliApp
{
    public partial class myMessageBox : Form
    {
        public myMessageBox(string text, string title)
        {
            InitializeComponent();
            lblText.Text = text;
            this.Text = title;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
