using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMetaTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            calculatorTest peg = new calculatorTest();
            Stopwatch stopwatch = new Stopwatch();
            string parseString = "x";
            Console.WriteLine("Type in math expression to solve (Enter to end)");
            while (!parseString.ToLower().Equals(""))
            {
                Console.Write(": ");
                parseString = Console.ReadLine();
                if (!parseString.Equals(""))
                {
                    stopwatch.Reset();
                    stopwatch.Start();
                    var result = peg.GetMatch(parseString, peg.Expression);
                    stopwatch.Stop();
                    if (result.Success)
                    {
                        Console.WriteLine("Result: " + result.Result);
                    }
                    else
                    {
                        Console.WriteLine("Error: " + result.Error);
                    }
                    Console.WriteLine("Time (ms): " + stopwatch.ElapsedMilliseconds);
                }
            }

        }
    }
}
