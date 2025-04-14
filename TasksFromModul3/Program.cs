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
            DaysOfWeek MyFavoriteDay;

            MyFavoriteDay = DaysOfWeek.Friday;

            Console.WriteLine(MyFavoriteDay);
        }
    }
            enum DaysOfWeek : byte
        {
            Tuesday,
            Monday,
            Wednesday,
            Friday
        }        
    
}

