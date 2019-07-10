﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calculator.Tests.OneArgument
{
    [TestFixture]
    public class PowerCalculatorTests
    {
        [Test]
        public void PowerCalculatorTest()
        {
            var calculator = new calculator.OneArgument.PowerCalculator();
            double actual = calculator.Calculate(2);
            Assert.AreEqual(4, actual);
        }

    }
}