namespace ass
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
            this.btndeleteitem = new System.Windows.Forms.Button();
            this.btndeletefile = new System.Windows.Forms.Button();
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnstream = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btndeleteitem
            // 
            this.btndeleteitem.Location = new System.Drawing.Point(121, 73);
            this.btndeleteitem.Name = "btndeleteitem";
            this.btndeleteitem.Size = new System.Drawing.Size(142, 44);
            this.btndeleteitem.TabIndex = 0;
            this.btndeleteitem.Text = "delete items";
            this.btndeleteitem.UseVisualStyleBackColor = true;
            this.btndeleteitem.Click += new System.EventHandler(this.btndeleteitem_Click);
            // 
            // btndeletefile
            // 
            this.btndeletefile.Location = new System.Drawing.Point(121, 146);
            this.btndeletefile.Name = "btndeletefile";
            this.btndeletefile.Size = new System.Drawing.Size(142, 29);
            this.btndeletefile.TabIndex = 1;
            this.btndeletefile.Text = "delete file";
            this.btndeletefile.UseVisualStyleBackColor = true;
            this.btndeletefile.Click += new System.EventHandler(this.btndeletefile_Click);
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(121, 236);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(89, 29);
            this.btnwrite.TabIndex = 2;
            this.btnwrite.Text = "write all ";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnstream
            // 
            this.btnstream.Location = new System.Drawing.Point(322, 73);
            this.btnstream.Name = "btnstream";
            this.btnstream.Size = new System.Drawing.Size(140, 44);
            this.btnstream.TabIndex = 3;
            this.btnstream.Text = "streamreader";
            this.btnstream.UseVisualStyleBackColor = true;
            this.btnstream.Click += new System.EventHandler(this.btnstream_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(339, 158);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(89, 29);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(542, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 324);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnstream);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.btndeletefile);
            this.Controls.Add(this.btndeleteitem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndeleteitem;
        private System.Windows.Forms.Button btndeletefile;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnstream;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox listBox1;
    }
}

