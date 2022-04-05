using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User Vasylyna = new User("teri@gmail.com", "Vasylyna", "Zlenko", 19, DateTime.Now);


            Console.WriteLine("Анкета 1:\n" +
                $"Логiн: {Vasylyna.Login}\n" +
                $"Iм'я: {Vasylyna.Name}\n" +
                $"Прiзвище: {Vasylyna.LastName}\n" +
                $"Вiк: {Vasylyna.Age}\n" +
                $"Час створення анкети: {Vasylyna.Once}");


            Console.WriteLine(" \n" +
                "===============\n" +
                " ");

            User Jane = new User("aaaaa@gmail.com", "Jane", "Lock", 13, DateTime.Now);


            Console.WriteLine("Анкета 2:\n" +
                $"Логiн: {Jane.Login}\n" +
                $"Iм'я: {Jane.Name}\n" +
                $"Прiзвище: {Jane.LastName}\n" +
                $"Вiк: {Jane.Age}\n" +
                $"Час створення анкети: {Jane.Once}");
            Console.ReadKey();


        }
    }
}