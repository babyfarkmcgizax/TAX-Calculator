using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAX_Calculator
{
    class Tax
    {
        // Object - to pass tax rate as percentage.
        // Rate stores in Private variable.
        // Added a getter for now public rate value.
        public double rate { get; } = 0.0;
        private string value;

        public Tax(double rate)
        {
            this.value = rate.ToString() + "%";
            this.rate = rate;
        }

        // Method - Calcucate, takes price and returns price with TAX added
        public double calculate(double price)
        {
            return price + price * (this.rate / 100);
        }

        // Method - ToString (overrides) returns new string value variable
        public override string ToString()
        {
            return this.value;
        }
    }
}
