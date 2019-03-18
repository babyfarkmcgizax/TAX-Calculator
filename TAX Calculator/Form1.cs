using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAX_Calculator
{
    public partial class Form1 : Form
    {
        // Private variable of Tax (instance of Tax class)
        private Tax tax_calc = new Tax(20);

        public Form1()
        {
            InitializeComponent();
            this.rate_changed();
        }

        // Display Tax Rate
        private void rate_changed()
        {
            toolStripStatusLabel1.Text = "Tax rate: " + tax_calc;
        }

        // Enter Key pressed - Event - Number in 1st text box using Tax object to calc new price.
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.update();
            }
        }

        // Button Click - Event - Number in 1st text box using Tax object to calc new price.
        private void button1_Click(object sender, EventArgs e)
        {
            this.update();
        }

        private void update()
        {
            // String converted to double and calculated using Tax class.
            double price = Convert.ToDouble(textBox1.Text);
            // New price String converted to double.
            double new_price = this.tax_calc.calculate(price);
            // Display new price in 2nd text box.
            textBox2.Text = new_price.ToString();
        }

        // Set tax rate using settings form
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings s = new settings();
            s.set_parent(this);
            s.set_rate(this.tax_calc.rate);
            s.Show();
        }

        // GUI is uncoupled from logic of calculations.
        // GUI can be changed without breaking calculations.
        // Tax class can be refactored without breaking GUI.
    }
}