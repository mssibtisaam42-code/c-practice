using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ass
{
    public partial class Form1 : Form
    {
        // File Path
        private string filePath = Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.Desktop
            ),
            "myfile.txt"
        );

        public Form1()
        {
            InitializeComponent();
        }

        private void btndeleteitem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                MessageBox.Show("Selected item deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select an item first.");
            }
        }

        // 2. DELETE FILE BUTTON
        private void btndeletefile_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);

                listBox1.Items.Clear();

                MessageBox.Show("File deleted successfully.");
            }
            else
            {
                MessageBox.Show("File does not exist.");
            }
        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {
                string text = string.Join(
                    Environment.NewLine,
                    listBox1.Items.Cast<object>()
                );

                File.WriteAllText(filePath, text);

                MessageBox.Show("Text saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnstream_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                listBox1.Items.Clear();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }
                }

                MessageBox.Show("File read successfully.");
            }
            else
            {
                MessageBox.Show("File does not exist. Save text first.");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //Application;
            this.Close();
        }
    }
    }

    
    

