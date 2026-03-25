using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SchechkaII.Sprint1.Task0.V14.Lib;
namespace Tyuiu.SchechkaII.Sprint1.Task0.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = DataService.Calculate();


            Console.WriteLine("2 * 3 * 3 + 7 = {0}", result);


            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
