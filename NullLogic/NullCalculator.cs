using System;
using System.Composition;
using ILogic;

namespace NullLogic
{
    [Export(typeof(ICalculatorLogic))]
    public class NullCalculator : ICalculatorLogic
    {
        private readonly decimal _multipler = 0;

        public decimal Add(decimal a, decimal b)
        {
            return a * b * _multipler;
        }
    }
}
