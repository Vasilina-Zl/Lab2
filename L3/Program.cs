using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3
{
	public class Program
	{
		public static void Main(string[] args)
		{

			Employee firstEmp = new Employee("Lina", "Zlenko", "Boss", 3);


			double oklad = firstEmp.Oklad();
			double tax = firstEmp.Tax();
			Console.WriteLine($"Name: {firstEmp.Name}; Прiзвище: {firstEmp.LastName}; Посада: {firstEmp.Position}; Оклад: {oklad}; Податковий збiр: {tax}");

			Employee secondEmp = new Employee("Vasia", "Pupkin", "Worker", 4);



			double soklad = secondEmp.Oklad();
			double stax = secondEmp.Tax();
			Console.WriteLine($"Iм'я: {secondEmp.Name}; Прiзвище: {secondEmp.LastName}; Посада: {secondEmp.Position}; Оклад: {soklad}; Податковий збiр: {stax}");
			Console.ReadKey();

		}
	}
}