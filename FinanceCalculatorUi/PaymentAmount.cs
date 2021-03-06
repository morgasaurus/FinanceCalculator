﻿using FinanceCalculationLibrary;
using System;
using System.Windows.Forms;

namespace FinanceCalculatorUi
{
    public partial class PaymentAmount : Form
    {
        public PaymentAmount()
        {
            InitializeComponent();
        }

        private void Button_Calculate_Click(object sender, EventArgs e)
        {
            decimal principal = 0m;
            decimal interest = 0m;
            decimal periods = 0;

            bool success =
                decimal.TryParse(TextBox_Principal.Text, out principal) &&
                decimal.TryParse(TextBox_Interest.Text, out interest) &&
                decimal.TryParse(TextBox_Periods.Text, out periods);

            if (!success)
            {
                App.ShowError("Invalid input");
                return;
            }

            TextBox_PaymentAmount.Text = decimal.Round(Calculate.PaymentAmount(principal, interest, periods), 2, MidpointRounding.AwayFromZero).ToString("0.00");
        }
    }
}
