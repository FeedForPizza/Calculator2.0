﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2._0
{
    public abstract class CalculatorBase
    {

        public abstract int Add(int x, int y);

        public abstract int Substract(int x, int y);
        public abstract Int64 Multiply(int x, int y);
        public abstract float Divide(int x, int y);

    }
}
