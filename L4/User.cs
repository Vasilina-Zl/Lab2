using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4
{
	internal class User
	{
		string login;
		string name;
		string lastName;
		int age;
		private DateTime once;

		 public DateTime Once
		{
			get { return once; }
			set { Once = value; }
		}


		public string Login
		{
			get { return login; }
			set { login = value; }
		}

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

		public int Age
		{
			get { return age; }
			set { age = value; }
		}


		public User(string Login, string Name, string LastName, int Age, DateTime Once)
		{
			login = Login;
			name = Name;
			lastName = LastName;
			age = Age;
			once = Once;

		}
	}
}
