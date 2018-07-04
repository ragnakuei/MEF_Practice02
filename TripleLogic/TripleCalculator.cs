using System;
using System.Composition;
using ILogic;

namespace TripleLogic
{
    [Export(typeof(ICalculatorLogic))]
    public class TripleCalculator : ICalculatorLogic
    {
        private readonly decimal _multipler = 3;

        public decimal Add(decimal a, decimal b)
        {
            return a * b * _multipler;
        }
    }
}
