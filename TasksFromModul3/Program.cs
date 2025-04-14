using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksFromModul3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
           string name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введите вашу дату рождения: ");
            var birthday = Console.ReadLine();
        }

    }
    
        
    
}

