﻿namespace calculator.TwoArguments
{
    class AdditionCalculator:ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}