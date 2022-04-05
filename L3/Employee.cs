using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3
{
	internal class Employee
	{
		string name;
		string lastName;
		string position;
		int experience;


		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		public string Position
		{
			get { return position; }
			set { position = value; }
		}
		public int Experience
		{
			get { return experience; }
			set { experience = value; }
		}

		public Employee(string Name, string LastName, string Position, int Experience)
		{
			name = Name;
			lastName = LastName;
			position = Position;
			experience = Experience;
		}



		public int Salary()
		{
			int salary;
			if (position == "Boss")
			{
				salary = 10000;
				return salary;
			}
			else if (position == "Worker")
			{
				salary = 7000;
				return salary;
			}
			else
			{
				salary = 3000;
				return salary;
			}
		}
		public double Oklad()
		{
			int salary, exp, finalSalary;
			salary = Salary();
			exp = experience;
			finalSalary = salary * exp;
			return finalSalary;
		}

		public double Tax()
		{
			double tax, procent, fs;
			fs = Oklad();
			procent = 0.18;
			tax = fs * procent;
			return tax;
		}


	}
}
