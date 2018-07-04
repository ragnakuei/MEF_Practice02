using System;
using System.Linq;
using ILogic;
using MEF_Practice02.EF;

namespace MEF_Practice02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入 Type:");
            var type   = Console.ReadLine();
            var typeId = type.ToInt();

            var dbContext = MEFDbContext.CreateInstance();
            var fileName  = dbContext.TypeAssemblyFiles
                                     ?.FirstOrDefault(t => t.TypeId == typeId)
                                     ?.FileName;

            var calculatorLogic = new AssemblyLoader(fileName).Get<ICalculatorLogic>();
            var result = calculatorLogic.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}