using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLib;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new FizzBuzzApp(new List<string>() { "1", "3", "5", "", "15", "A", "23" }, 3, 5);
            var result = app.Execute();

            result.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
