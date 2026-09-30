namespace ElectricityBillCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Creating Variables
                string customerName;
                double previousReading, currentReading, pricePerUnit, electricityUsage,
                       electricityCharge, taxAmount, totalBill;

                // Constant Variables
                const double taxPercentage = 0.07;
                const double fixedCharge = 5;

                // Assigning Variables
                customerName = txtCustomer.Text;
                previousReading = double.Parse(txtPrevious.Text);
                currentReading = double.Parse(txtCurrent.Text);
                pricePerUnit = double.Parse(txtUnitPrice.Text);

                // Calculating Electricity Usage
                electricityUsage = currentReading - previousReading;

                // Calculating Electricity Charge
                electricityCharge = electricityUsage * pricePerUnit;

                // Calculating Tax Amount
                taxAmount = electricityCharge * taxPercentage;

                // Calculating Total Bill
                totalBill = electricityCharge + taxAmount + fixedCharge;

                // Displaying Results
                txtusage.Text = electricityUsage.ToString("0");
                txttax.Text = "$" + taxAmount.ToString("0.00");
                txttotal.Text = "$" + totalBill.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("invalid error");
            }
        }  
        

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
