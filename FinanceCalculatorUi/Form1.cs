﻿using System;
using System.Windows.Forms;

namespace FinanceCalculatorUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_FutureValue_Click(object sender, EventArgs e)
        {
            new FutureValue().Show();
        }
    }
}
