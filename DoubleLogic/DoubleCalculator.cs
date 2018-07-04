using System;
using System.Composition;
using ILogic;

namespace DoubleLogic
{
    [Export(typeof(ICalculatorLogic))]
    public class DoubleCalculator : ICalculatorLogic
    {
        private readonly decimal _multipler = 2;

        public decimal Add(decimal a, decimal b)
        {
            return a * b * _multipler;
        }
    }
}
