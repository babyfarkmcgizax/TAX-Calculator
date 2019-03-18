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
    public partial class settings : Form
    {
        private Form1 parent;

        public settings()
        {
            InitializeComponent();
        }

        // Method - Set new rate
        public void set_rate(double rate)
        {
            textBox1.Text = rate.ToString();
        }

        // Settings form needs to be aware of it's parent Form1
        public void set_parent(Form1 f)
        {
            this.parent = f;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            {
                this.parent.update_rate(Convert.ToDouble(textBox1.Text));
                this.Close();
            }
        }
    }
}
