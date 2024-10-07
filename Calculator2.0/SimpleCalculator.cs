using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2._0
{
    public class SimpleCalculator : CalculatorBase
    {
        public override int Add(int x, int y)
        {
            return x + y;
        }
        public override int Substract(int x, int y)
        {
            return x - y;
        }
        public override Int64 Multiply(int x, int y)
        {
            return (long)x * y;
        }
        public override float Divide(int x, int y)
        {
            return (float)x / (float)y;
        }
    }
}
