namespace FinanceCalculatorUi
{
    partial class PaymentAmount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentAmount));
            this.Label_Principal = new System.Windows.Forms.Label();
            this.TextBox_Principal = new System.Windows.Forms.TextBox();
            this.TextBox_Interest = new System.Windows.Forms.TextBox();
            this.Label_Interest = new System.Windows.Forms.Label();
            this.TextBox_Periods = new System.Windows.Forms.TextBox();
            this.Label_Periods = new System.Windows.Forms.Label();
            this.Button_Calculate = new System.Windows.Forms.Button();
            this.Label_PaymentAmount = new System.Windows.Forms.Label();
            this.TextBox_PaymentAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label_Principal
            // 
            this.Label_Principal.AutoSize = true;
            this.Label_Principal.Location = new System.Drawing.Point(24, 15);
            this.Label_Principal.Name = "Label_Principal";
            this.Label_Principal.Size = new System.Drawing.Size(89, 13);
            this.Label_Principal.TabIndex = 0;
            this.Label_Principal.Text = "Principal Amount:";
            // 
            // TextBox_Principal
            // 
            this.TextBox_Principal.Location = new System.Drawing.Point(119, 12);
            this.TextBox_Principal.Name = "TextBox_Principal";
            this.TextBox_Principal.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Principal.TabIndex = 1;
            // 
            // TextBox_Interest
            // 
            this.TextBox_Interest.Location = new System.Drawing.Point(119, 38);
            this.TextBox_Interest.Name = "TextBox_Interest";
            this.TextBox_Interest.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Interest.TabIndex = 5;
            // 
            // Label_Interest
            // 
            this.Label_Interest.AutoSize = true;
            this.Label_Interest.Location = new System.Drawing.Point(42, 41);
            this.Label_Interest.Name = "Label_Interest";
            this.Label_Interest.Size = new System.Drawing.Size(71, 13);
            this.Label_Interest.TabIndex = 4;
            this.Label_Interest.Text = "Interest Rate:";
            // 
            // TextBox_Periods
            // 
            this.TextBox_Periods.Location = new System.Drawing.Point(119, 64);
            this.TextBox_Periods.Name = "TextBox_Periods";
            this.TextBox_Periods.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Periods.TabIndex = 7;
            // 
            // Label_Periods
            // 
            this.Label_Periods.AutoSize = true;
            this.Label_Periods.Location = new System.Drawing.Point(16, 67);
            this.Label_Periods.Name = "Label_Periods";
            this.Label_Periods.Size = new System.Drawing.Size(97, 13);
            this.Label_Periods.TabIndex = 6;
            this.Label_Periods.Text = "Number of Periods:";
            // 
            // Button_Calculate
            // 
            this.Button_Calculate.Location = new System.Drawing.Point(80, 116);
            this.Button_Calculate.Name = "Button_Calculate";
            this.Button_Calculate.Size = new System.Drawing.Size(75, 23);
            this.Button_Calculate.TabIndex = 8;
            this.Button_Calculate.Text = "Calculate";
            this.Button_Calculate.UseVisualStyleBackColor = true;
            this.Button_Calculate.Click += new System.EventHandler(this.Button_Calculate_Click);
            // 
            // Label_PaymentAmount
            // 
            this.Label_PaymentAmount.AutoSize = true;
            this.Label_PaymentAmount.Location = new System.Drawing.Point(23, 93);
            this.Label_PaymentAmount.Name = "Label_PaymentAmount";
            this.Label_PaymentAmount.Size = new System.Drawing.Size(90, 13);
            this.Label_PaymentAmount.TabIndex = 9;
            this.Label_PaymentAmount.Text = "Payment Amount:";
            // 
            // TextBox_PaymentAmount
            // 
            this.TextBox_PaymentAmount.Location = new System.Drawing.Point(119, 90);
            this.TextBox_PaymentAmount.Name = "TextBox_PaymentAmount";
            this.TextBox_PaymentAmount.ReadOnly = true;
            this.TextBox_PaymentAmount.Size = new System.Drawing.Size(100, 20);
            this.TextBox_PaymentAmount.TabIndex = 10;
            // 
            // PaymentAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 149);
            this.Controls.Add(this.TextBox_PaymentAmount);
            this.Controls.Add(this.Label_PaymentAmount);
            this.Controls.Add(this.Button_Calculate);
            this.Controls.Add(this.TextBox_Periods);
            this.Controls.Add(this.Label_Periods);
            this.Controls.Add(this.TextBox_Interest);
            this.Controls.Add(this.Label_Interest);
            this.Controls.Add(this.TextBox_Principal);
            this.Controls.Add(this.Label_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentAmount";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Payment Amount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Principal;
        private System.Windows.Forms.TextBox TextBox_Principal;
        private System.Windows.Forms.TextBox TextBox_Interest;
        private System.Windows.Forms.Label Label_Interest;
        private System.Windows.Forms.TextBox TextBox_Periods;
        private System.Windows.Forms.Label Label_Periods;
        private System.Windows.Forms.Button Button_Calculate;
        private System.Windows.Forms.Label Label_PaymentAmount;
        private System.Windows.Forms.TextBox TextBox_PaymentAmount;
    }
}