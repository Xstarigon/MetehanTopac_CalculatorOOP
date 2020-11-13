using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetehanTopac_CalculatorOOP.Classes
{
    class Calculator
    {
        public double input1 { get; set; }
        public double input2 { get; set; }

        public double Addition(double input1, double input2)
        {
            return input1 + input2;
        }
        public double Subtraction(double input1, double input2)
        {
            return input1 - input2;
        }
        public double Multiplication(double input1, double input2)
        {
            return input1 * input2;
        }
        public double Division(double input1, double input2)
        {
            return input1 / input2;
        }
        public double Power(double input1, double input2)
        {
            return Math.Pow(input1, input2);
        }


    }
}
