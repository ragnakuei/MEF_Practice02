using System;
using System.Linq;
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

            
        }
    }
}