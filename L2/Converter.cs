using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
	internal class Converter
	{
        public double purchaseUSD = 27.8500;
        public double saleUSD = 28.0500;

        public double purchaseEUR = 31.7150;
        public double saleEUR = 32.0500;

        public double purchaseRUB = 0.3570;
        public double saleRUB = 0.3720;

        public double compareSum = 0;
        public string valuteToChange;
        public string valuteFromChange;
        public double changeSum;


        public double Calculate(string valuteFromChange, double changeSum)
        {
            if (valuteFromChange == "UAH")
            {
                return CalculateIf1(valuteToChange, changeSum);
            }
            else if (valuteFromChange == "USD")
            {
                return FunctionToSale(saleUSD);
            }
            else if (valuteFromChange == "EUR")
            {
                return FunctionToSale(saleEUR);
            }
            else if (valuteFromChange == "RUB")
            {
                return FunctionToSale(saleRUB);
            }
            else
            {
                return 0;
            }
        }

        public double CalculateIf1(string valuteToChange, double changeSum)
        {
            if (valuteToChange == "USD")
            {
                return FunctionToPurchase(purchaseUSD);
            }
            else if (valuteToChange == "EUR")
            {
                return FunctionToPurchase(purchaseEUR);
            }
            else if (valuteToChange == "RUB")
            {
                return FunctionToPurchase(purchaseRUB);
            }
            else
            {
                return 0;
            }
           
        }

        public double FunctionToSale(double saleSomething)
        {
            compareSum = changeSum * saleSomething;
            return compareSum;
        }


        public double FunctionToPurchase(double purchaseSomething)
        {
            compareSum = changeSum / purchaseSomething;
            return compareSum;
        }
    }
}
