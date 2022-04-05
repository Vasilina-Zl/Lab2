using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace L1
{

	class Program
	{
		static void Main(string[] args)
		{
			Address first = new Address();

			first.Index = 03217;
			first.Country = "Ukraine";
			first.City = "Kyiv";
			first.Street = "Polova street";
			first.House = 45;
			first.Apartment = 3;

			Console.WriteLine($"Index: {first.Index} | Country: {first.Country} |" +
				$" City: {first.City} | Street: {first.Street} | House: {first.House} | Apartment: {first.Apartment}");

		}
	}
}