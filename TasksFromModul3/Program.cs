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
            foreach (Colors color in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine($"{color}: {(int)color}");
            }
        }
    }
            enum Colors 
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }        
    
}

