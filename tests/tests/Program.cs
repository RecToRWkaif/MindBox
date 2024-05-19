using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindBox_Library;

namespace tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculate Circles's Area!!!!
            double result = AreaFigures.CirclesArea(5);



            //Calculate Triangle's Area!!!!
            //double result = AreaFigures.TrianglesArea(5,10,7);




            //-------------------------------------------------
            //Console|

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(result);
            Console.ResetColor();

            Console.ReadLine();


        }
    }
}
