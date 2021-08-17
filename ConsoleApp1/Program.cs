using System;
using System.IO;
using System.Reflection;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use DefaultCalculator
            var defaultCalculator = new DefaultCalculator();
            Console.WriteLine($"Default calculator result: {defaultCalculator.Calculate(null)}");

            // Load and use CanadaTaxCalculator
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var canadaCalculator = Assembly.LoadFile($"{path}\\CustomLibrary.dll");
            Console.WriteLine(canadaCalculator);
            var ctcType = canadaCalculator.GetType("CustomLibrary.CanadaTaxCalculator");
            Console.WriteLine(ctcType);
            var ctc = (ICalculateTax)Activator.CreateInstance(ctcType, null);
            Console.WriteLine(ctc.Calculate(null));
        }
    }
}
