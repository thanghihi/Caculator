using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    public class Calculation
    {
        private double a;
        private double b;
        public Calculation(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public double Execute(string CalSymbol)
        {
            double result = 0;
            switch (CalSymbol)
            {
                case "+":
                    result = this.a + this.b;
                    break;
                case "-":
                    result = this.a - this.b;
                    break;
                case "*":
                    result = this.a * this.b;
                    break;
                case "/":
                    result = this.a / this.b;
                    break;
            }
            return result;
        }

    }
}
