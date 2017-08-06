namespace FinanceCalculatorUi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Calculations = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_FutureValue = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_PresentValue = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_PaymentAmount = new System.Windows.Forms.ToolStripMenuItem();
            this.Label_Instructions = new System.Windows.Forms.Label();
            this.MenuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip_Main
            // 
            this.MenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Calculations});
            this.MenuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Main.Name = "MenuStrip_Main";
            this.MenuStrip_Main.Size = new System.Drawing.Size(373, 24);
            this.MenuStrip_Main.TabIndex = 0;
            this.MenuStrip_Main.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Calculations
            // 
            this.ToolStripMenuItem_Calculations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_FutureValue,
            this.ToolStripMenuItem_PresentValue,
            this.ToolStripMenuItem_PaymentAmount});
            this.ToolStripMenuItem_Calculations.Name = "ToolStripMenuItem_Calculations";
            this.ToolStripMenuItem_Calculations.Size = new System.Drawing.Size(84, 20);
            this.ToolStripMenuItem_Calculations.Text = "Calculations";
            // 
            // ToolStripMenuItem_FutureValue
            // 
            this.ToolStripMenuItem_FutureValue.Name = "ToolStripMenuItem_FutureValue";
            this.ToolStripMenuItem_FutureValue.Size = new System.Drawing.Size(168, 22);
            this.ToolStripMenuItem_FutureValue.Text = "Future Value";
            this.ToolStripMenuItem_FutureValue.Click += new System.EventHandler(this.ToolStripMenuItem_FutureValue_Click);
            // 
            // ToolStripMenuItem_PresentValue
            // 
            this.ToolStripMenuItem_PresentValue.Name = "ToolStripMenuItem_PresentValue";
            this.ToolStripMenuItem_PresentValue.Size = new System.Drawing.Size(168, 22);
            this.ToolStripMenuItem_PresentValue.Text = "Present Value";
            this.ToolStripMenuItem_PresentValue.Click += new System.EventHandler(this.ToolStripMenuItem_PresentValue_Click);
            // 
            // ToolStripMenuItem_PaymentAmount
            // 
            this.ToolStripMenuItem_PaymentAmount.Name = "ToolStripMenuItem_PaymentAmount";
            this.ToolStripMenuItem_PaymentAmount.Size = new System.Drawing.Size(168, 22);
            this.ToolStripMenuItem_PaymentAmount.Text = "Payment Amount";
            this.ToolStripMenuItem_PaymentAmount.Click += new System.EventHandler(this.ToolStripMenuItem_PaymentAmount_Click);
            // 
            // Label_Instructions
            // 
            this.Label_Instructions.AutoSize = true;
            this.Label_Instructions.Location = new System.Drawing.Point(101, 50);
            this.Label_Instructions.Name = "Label_Instructions";
            this.Label_Instructions.Size = new System.Drawing.Size(175, 13);
            this.Label_Instructions.TabIndex = 1;
            this.Label_Instructions.Text = "Choose calculations from the menu.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 93);
            this.Controls.Add(this.Label_Instructions);
            this.Controls.Add(this.MenuStrip_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip_Main;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(393, 136);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(393, 136);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Finance Calculator";
            this.MenuStrip_Main.ResumeLayout(false);
            this.MenuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Calculations;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_PresentValue;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_FutureValue;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_PaymentAmount;
        private System.Windows.Forms.Label Label_Instructions;
    }
}

