namespace FinanceCalculatorUi
{
    partial class PresentValue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentValue));
            this.Label_Principal = new System.Windows.Forms.Label();
            this.TextBox_Principal = new System.Windows.Forms.TextBox();
            this.TextBox_Payment = new System.Windows.Forms.TextBox();
            this.Label_Payment = new System.Windows.Forms.Label();
            this.TextBox_Interest = new System.Windows.Forms.TextBox();
            this.Label_Interest = new System.Windows.Forms.Label();
            this.TextBox_Periods = new System.Windows.Forms.TextBox();
            this.Label_Periods = new System.Windows.Forms.Label();
            this.Button_Calculate = new System.Windows.Forms.Button();
            this.Label_PresentValue = new System.Windows.Forms.Label();
            this.TextBox_PresentValue = new System.Windows.Forms.TextBox();
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
            // TextBox_Payment
            // 
            this.TextBox_Payment.Location = new System.Drawing.Point(119, 38);
            this.TextBox_Payment.Name = "TextBox_Payment";
            this.TextBox_Payment.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Payment.TabIndex = 3;
            // 
            // Label_Payment
            // 
            this.Label_Payment.AutoSize = true;
            this.Label_Payment.Location = new System.Drawing.Point(23, 41);
            this.Label_Payment.Name = "Label_Payment";
            this.Label_Payment.Size = new System.Drawing.Size(90, 13);
            this.Label_Payment.TabIndex = 2;
            this.Label_Payment.Text = "Payment Amount:";
            // 
            // TextBox_Interest
            // 
            this.TextBox_Interest.Location = new System.Drawing.Point(119, 64);
            this.TextBox_Interest.Name = "TextBox_Interest";
            this.TextBox_Interest.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Interest.TabIndex = 5;
            // 
            // Label_Interest
            // 
            this.Label_Interest.AutoSize = true;
            this.Label_Interest.Location = new System.Drawing.Point(42, 67);
            this.Label_Interest.Name = "Label_Interest";
            this.Label_Interest.Size = new System.Drawing.Size(71, 13);
            this.Label_Interest.TabIndex = 4;
            this.Label_Interest.Text = "Interest Rate:";
            // 
            // TextBox_Periods
            // 
            this.TextBox_Periods.Location = new System.Drawing.Point(119, 90);
            this.TextBox_Periods.Name = "TextBox_Periods";
            this.TextBox_Periods.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Periods.TabIndex = 7;
            // 
            // Label_Periods
            // 
            this.Label_Periods.AutoSize = true;
            this.Label_Periods.Location = new System.Drawing.Point(16, 93);
            this.Label_Periods.Name = "Label_Periods";
            this.Label_Periods.Size = new System.Drawing.Size(97, 13);
            this.Label_Periods.TabIndex = 6;
            this.Label_Periods.Text = "Number of Periods:";
            // 
            // Button_Calculate
            // 
            this.Button_Calculate.Location = new System.Drawing.Point(81, 142);
            this.Button_Calculate.Name = "Button_Calculate";
            this.Button_Calculate.Size = new System.Drawing.Size(75, 23);
            this.Button_Calculate.TabIndex = 8;
            this.Button_Calculate.Text = "Calculate";
            this.Button_Calculate.UseVisualStyleBackColor = true;
            this.Button_Calculate.Click += new System.EventHandler(this.Button_Calculate_Click);
            // 
            // Label_PresentValue
            // 
            this.Label_PresentValue.AutoSize = true;
            this.Label_PresentValue.Location = new System.Drawing.Point(37, 119);
            this.Label_PresentValue.Name = "Label_PresentValue";
            this.Label_PresentValue.Size = new System.Drawing.Size(76, 13);
            this.Label_PresentValue.TabIndex = 9;
            this.Label_PresentValue.Text = "Present Value:";
            // 
            // TextBox_PresentValue
            // 
            this.TextBox_PresentValue.Location = new System.Drawing.Point(119, 116);
            this.TextBox_PresentValue.Name = "TextBox_PresentValue";
            this.TextBox_PresentValue.ReadOnly = true;
            this.TextBox_PresentValue.Size = new System.Drawing.Size(100, 20);
            this.TextBox_PresentValue.TabIndex = 10;
            // 
            // PresentValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 177);
            this.Controls.Add(this.TextBox_PresentValue);
            this.Controls.Add(this.Label_PresentValue);
            this.Controls.Add(this.Button_Calculate);
            this.Controls.Add(this.TextBox_Periods);
            this.Controls.Add(this.Label_Periods);
            this.Controls.Add(this.TextBox_Interest);
            this.Controls.Add(this.Label_Interest);
            this.Controls.Add(this.TextBox_Payment);
            this.Controls.Add(this.Label_Payment);
            this.Controls.Add(this.TextBox_Principal);
            this.Controls.Add(this.Label_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(256, 220);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(256, 220);
            this.Name = "PresentValue";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Future Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Principal;
        private System.Windows.Forms.TextBox TextBox_Principal;
        private System.Windows.Forms.TextBox TextBox_Payment;
        private System.Windows.Forms.Label Label_Payment;
        private System.Windows.Forms.TextBox TextBox_Interest;
        private System.Windows.Forms.Label Label_Interest;
        private System.Windows.Forms.TextBox TextBox_Periods;
        private System.Windows.Forms.Label Label_Periods;
        private System.Windows.Forms.Button Button_Calculate;
        private System.Windows.Forms.Label Label_PresentValue;
        private System.Windows.Forms.TextBox TextBox_PresentValue;
    }
}