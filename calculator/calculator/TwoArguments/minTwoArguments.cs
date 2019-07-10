﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.TwoArguments
{
    class MinTwoArguments:ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
           return Math.Min(firstValue,secondValue);
        }
    }
}
