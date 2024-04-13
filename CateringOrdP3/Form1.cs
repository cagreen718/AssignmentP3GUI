using static System.Net.Mime.MediaTypeNames;
using System.Globalization;

namespace CateringOrdP3
{
    public partial class Form1 : Form
    {
        decimal GorCheese = 49.99m;
        decimal PinWheel = 59.99m;
        decimal Veg = 29.99m;
        decimal Saus = 49.99m;
        decimal Frui = 29.99m;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            rBtnCheese.Checked = false;
            rBtnFruit.Checked = false;
            rBtnPay.Checked = false;
            rBtnPre.Checked = false;
            rBtnSausage.Checked = false;
            rBtnVeggie.Checked = false;
            rBtnWraps.Checked = false;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void bttnCalculate_Click(object sender, EventArgs e)
        {//source:  https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-8.0

            //Source: https://stackoverflow.com/questions/20270547/c-sharp-calculating-decimal-numbers-from-textboxes

            decimal dePre = Convert.ToDecimal(textBox1.Text);
            decimal deDuct = Decimal.Multiply(0.05m, dePre);
            decimal fullDect = Decimal.Divide(deDuct, 10m);
            
            // Input Validation
            if (rBtnWraps.Checked && rBtnPre.Checked)
            {
                decimal WrapSec = PinWheel - fullDect;
                textBox2.Text = WrapSec.ToString();
            }
            if (rBtnWraps.Checked && rBtnPay.Checked)
            {
                decimal WrapChec = PinWheel - fullDect;
                textBox2.Text = WrapChec.ToString();
            }
            if (rBtnCheese.Checked && rBtnPre.Checked)
            {
                decimal GorSec = GorCheese - fullDect;
                textBox2.Text = GorSec.ToString();
            }
            if (rBtnCheese.Checked && rBtnPay.Checked)
            {
                decimal GorChec = GorCheese - fullDect;
                textBox2.Text = GorChec.ToString();
            }
            if (rBtnVeggie.Checked && rBtnPre.Checked)
            {
                decimal VegSec = Veg - fullDect;
                textBox2.Text = VegSec.ToString();
            }
            if (rBtnVeggie.Checked && rBtnPay.Checked)
            {
                decimal VegChec = Veg - fullDect;
                textBox2.Text = VegChec.ToString();
            }
            if (rBtnSausage.Checked && rBtnPre.Checked)
            {
                decimal SausSec = Saus - fullDect;
                textBox2.Text = SausSec.ToString();
            }
            if (rBtnSausage.Checked && rBtnPay.Checked)
            {
                decimal SausChec = Saus - fullDect;
                textBox2.Text = SausChec.ToString();
            }
            if (rBtnFruit.Checked && rBtnPre.Checked)
            {
                decimal FruiSec = Frui - fullDect;
                textBox2.Text = FruiSec.ToString();
            }
            if (rBtnFruit.Checked && rBtnPay.Checked)
            {
                decimal FruiChec = Frui - fullDect;
                textBox2.Text = FruiChec.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox2.Focus();
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
