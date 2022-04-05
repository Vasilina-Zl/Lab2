using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter stconventer = new Converter();

            stconventer.valuteFromChange = "UAH";
            stconventer.valuteToChange = "USD";
            stconventer.changeSum = 30;


            stconventer.Calculate(stconventer.valuteFromChange, stconventer.changeSum) ;
            Console.WriteLine($"Отримана сума:{Math.Round(stconventer.compareSum, 2)}");


        }
    }
}