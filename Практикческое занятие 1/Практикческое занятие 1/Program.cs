using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практикческое_занятие_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача ввести нужную собаку с клавиатуры");
            User sasha = new User();
            sasha.SetInfo();
            sasha.GetInfo();
        }

    }
}

