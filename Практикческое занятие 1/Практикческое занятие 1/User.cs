using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикческое_занятие_1
{
    class User
    {
        public string Name { get; set; }
        public string Poroda { get; set; }
        public double Age { get; set; }

        public User()
        {
            Name = null;
            Poroda = null;
            Age = 0;
        }

        public User(string name, string poroda, double age)
        {
            Name = name;
            Poroda = poroda;
            Age = age;
        }

        public void SetInfo()
        {
            Console.WriteLine("Введите имя собаки :");
            Name = Console.ReadLine();

            Console.WriteLine("Введите породу собаки ");
            Poroda = Console.ReadLine();
            Console.WriteLine("Введите возраст собаки");
            Age = double.Parse(Console.ReadLine());
        }


        public void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Порода: {Poroda}");
            Console.WriteLine($"Возраст: {Age}");
            Console.ReadKey();
        }
    }
}
