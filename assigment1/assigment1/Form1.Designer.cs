namespace assigment1
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
            this.txtdayofweek = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtdaymonth = new System.Windows.Forms.TextBox();
            this.txtnamemonth = new System.Windows.Forms.TextBox();
            this.showdata = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.dayofweek = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.dayofmonth = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.dateoutlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdayofweek
            // 
            this.txtdayofweek.Location = new System.Drawing.Point(557, 39);
            this.txtdayofweek.Name = "txtdayofweek";
            this.txtdayofweek.Size = new System.Drawing.Size(159, 22);
            this.txtdayofweek.TabIndex = 0;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(557, 140);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(159, 22);
            this.txtyear.TabIndex = 1;
            // 
            // txtdaymonth
            // 
            this.txtdaymonth.Location = new System.Drawing.Point(557, 112);
            this.txtdaymonth.Name = "txtdaymonth";
            this.txtdaymonth.Size = new System.Drawing.Size(159, 22);
            this.txtdaymonth.TabIndex = 2;
            // 
            // txtnamemonth
            // 
            this.txtnamemonth.Location = new System.Drawing.Point(557, 80);
            this.txtnamemonth.Name = "txtnamemonth";
            this.txtnamemonth.Size = new System.Drawing.Size(159, 22);
            this.txtnamemonth.TabIndex = 3;
            // 
            // showdata
            // 
            this.showdata.Location = new System.Drawing.Point(234, 343);
            this.showdata.Name = "showdata";
            this.showdata.Size = new System.Drawing.Size(107, 36);
            this.showdata.TabIndex = 4;
            this.showdata.Text = "showdata";
            this.showdata.UseVisualStyleBackColor = true;
            this.showdata.Click += new System.EventHandler(this.showdata_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(405, 343);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(89, 36);
            this.clear.TabIndex = 5;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // dayofweek
            // 
            this.dayofweek.AutoSize = true;
            this.dayofweek.Location = new System.Drawing.Point(130, 56);
            this.dayofweek.Name = "dayofweek";
            this.dayofweek.Size = new System.Drawing.Size(113, 16);
            this.dayofweek.TabIndex = 6;
            this.dayofweek.Text = "enterdayofthewek";
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Location = new System.Drawing.Point(130, 86);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(136, 16);
            this.month.TabIndex = 7;
            this.month.Text = "enternameofthemonth";
            // 
            // dayofmonth
            // 
            this.dayofmonth.AutoSize = true;
            this.dayofmonth.Location = new System.Drawing.Point(130, 112);
            this.dayofmonth.Name = "dayofmonth";
            this.dayofmonth.Size = new System.Drawing.Size(116, 16);
            this.dayofmonth.TabIndex = 8;
            this.dayofmonth.Text = "enter of day month";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(130, 138);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(88, 16);
            this.year.TabIndex = 9;
            this.year.Text = "enter the year";
            // 
            // dateoutlabel
            // 
            this.dateoutlabel.AutoSize = true;
            this.dateoutlabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dateoutlabel.Location = new System.Drawing.Point(207, 282);
            this.dateoutlabel.Name = "dateoutlabel";
            this.dateoutlabel.Size = new System.Drawing.Size(343, 16);
            this.dateoutlabel.TabIndex = 10;
            this.dateoutlabel.Text = "                                                                                 " +
    "                               \r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateoutlabel);
            this.Controls.Add(this.year);
            this.Controls.Add(this.dayofmonth);
            this.Controls.Add(this.month);
            this.Controls.Add(this.dayofweek);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.showdata);
            this.Controls.Add(this.txtnamemonth);
            this.Controls.Add(this.txtdaymonth);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtdayofweek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdayofweek;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtdaymonth;
        private System.Windows.Forms.TextBox txtnamemonth;
        private System.Windows.Forms.Button showdata;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label dayofweek;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label dayofmonth;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label dateoutlabel;
    }
}

