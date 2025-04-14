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
            string MyName = "Computer";
            Console.WriteLine("Привет, человек");
            Console.WriteLine("Меня зовут {0}", MyName);
            Console.Write("А как тебя зовут? ");
            string YourName = Console.ReadLine();
            Console.Write("Рад встрече, {0} ", YourName);
        }
    }
        
    
}

