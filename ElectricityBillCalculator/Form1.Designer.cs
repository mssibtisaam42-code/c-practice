namespace ElectricityBillCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCustomer = new TextBox();
            txtPrevious = new TextBox();
            txtCurrent = new TextBox();
            txtUnitPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCalculate = new Button();
            txtlbl2 = new Label();
            txtlbl3 = new Label();
            txtlbl1 = new Label();
            txtusage = new Label();
            txttax = new Label();
            txttotal = new Label();
            SuspendLayout();
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(640, 48);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(125, 27);
            txtCustomer.TabIndex = 0;
            // 
            // txtPrevious
            // 
            txtPrevious.Location = new Point(640, 90);
            txtPrevious.Name = "txtPrevious";
            txtPrevious.Size = new Size(125, 27);
            txtPrevious.TabIndex = 1;
            // 
            // txtCurrent
            // 
            txtCurrent.Location = new Point(640, 124);
            txtCurrent.Name = "txtCurrent";
            txtCurrent.Size = new Size(125, 27);
            txtCurrent.TabIndex = 2;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(640, 157);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(125, 27);
            txtUnitPrice.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 64);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 4;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(218, 97);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 5;
            label2.Text = "Previous Reading";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(219, 131);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 6;
            label3.Text = "Current Reading";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(218, 171);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 7;
            label4.Text = "Price Per Unit ($)";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(304, 230);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(229, 46);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate Bill";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtlbl2
            // 
            txtlbl2.AutoSize = true;
            txtlbl2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtlbl2.Location = new Point(270, 331);
            txtlbl2.Name = "txtlbl2";
            txtlbl2.Size = new Size(50, 20);
            txtlbl2.TabIndex = 10;
            txtlbl2.Text = "lblTax";
            // 
            // txtlbl3
            // 
            txtlbl3.AutoSize = true;
            txtlbl3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtlbl3.Location = new Point(270, 365);
            txtlbl3.Name = "txtlbl3";
            txtlbl3.Size = new Size(61, 20);
            txtlbl3.TabIndex = 11;
            txtlbl3.Text = "lblTotal";
            // 
            // txtlbl1
            // 
            txtlbl1.AutoSize = true;
            txtlbl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtlbl1.Location = new Point(270, 300);
            txtlbl1.Name = "txtlbl1";
            txtlbl1.Size = new Size(69, 20);
            txtlbl1.TabIndex = 9;
            txtlbl1.Text = "lblUsage";
            txtlbl1.Click += label5_Click_1;
            // 
            // txtusage
            // 
            txtusage.AutoSize = true;
            txtusage.BackColor = SystemColors.ButtonHighlight;
            txtusage.BorderStyle = BorderStyle.FixedSingle;
            txtusage.Location = new Point(451, 299);
            txtusage.Name = "txtusage";
            txtusage.Size = new Size(195, 22);
            txtusage.TabIndex = 12;
            txtusage.Text = "                                              \r\n";
            // 
            // txttax
            // 
            txttax.AutoSize = true;
            txttax.BackColor = SystemColors.ButtonHighlight;
            txttax.BorderStyle = BorderStyle.FixedSingle;
            txttax.Location = new Point(451, 331);
            txttax.Name = "txttax";
            txttax.Size = new Size(167, 22);
            txttax.TabIndex = 13;
            txttax.Text = "                                       \r\n";
            // 
            // txttotal
            // 
            txttotal.AutoSize = true;
            txttotal.BackColor = SystemColors.ButtonHighlight;
            txttotal.BorderStyle = BorderStyle.FixedSingle;
            txttotal.Location = new Point(451, 365);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(223, 22);
            txttotal.TabIndex = 14;
            txttotal.Text = "                                                     \r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txttotal);
            Controls.Add(txttax);
            Controls.Add(txtusage);
            Controls.Add(txtlbl1);
            Controls.Add(txtlbl3);
            Controls.Add(txtlbl2);
            Controls.Add(btnCalculate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtCurrent);
            Controls.Add(txtPrevious);
            Controls.Add(txtCustomer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomer;
        private TextBox txtPrevious;
        private TextBox txtCurrent;
        private TextBox txtUnitPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCalculate;
        private Label txtlbl2;
        private Label txtlbl3;
        private Label txtlbl1;
        private Label txtusage;
        private Label txttax;
        private Label txttotal;
    }
}
