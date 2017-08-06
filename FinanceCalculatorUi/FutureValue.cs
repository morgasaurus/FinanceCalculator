using FinanceCalculationLibrary;
using System;
using System.Windows.Forms;

namespace FinanceCalculatorUi
{
    public partial class FutureValue : Form
    {
        public FutureValue()
        {
            InitializeComponent();
        }

        private void Button_Calculate_Click(object sender, EventArgs e)
        {
            decimal principal = 0m;
            decimal payment = 0m;
            decimal interest = 0m;
            decimal periods = 0;

            bool success =
                decimal.TryParse(TextBox_Principal.Text, out principal) &&
                decimal.TryParse(TextBox_Payment.Text, out payment) &&
                decimal.TryParse(TextBox_Interest.Text, out interest) &&
                decimal.TryParse(TextBox_Periods.Text, out periods);

            if (!success)
            {
                App.ShowError("Invalid input");
                return;
            }

            TextBox_FutureValue.Text = decimal.Round(Calculate.FutureValue(principal, payment, interest, periods), 2, MidpointRounding.AwayFromZero).ToString("0.00");
        }
    }
}
