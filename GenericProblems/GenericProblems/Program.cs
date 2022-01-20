using GenericProblems.FindMax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = { 10, 20, 30, 40 };
            double[] doublearray = { 10.20, 30.2, 40.40, 20.22 };
            char[] chararray = { 'H', 'E', 'L', 'L', 'O' };
            //PrintArray.ToPrint(intarray );
            //PrintArray.ToPrint(doublearray );
            //PrintArray.ToPrint(chararray );
            //Console.WriteLine("Printing arrays with generic method");
            //Generic.ToPrint(intarray);
            //Generic.ToPrint(doublearray);
            // Generic.ToPrint(chararray);
            int first = 10, second = 20, third = 30;
            double x = 10.3, y = 40.3, z = 22.2;
            Console.  WriteLine("The Max value is {0} of {1},{2},{3}",FindMaximumValue.DisplayMax(first , second, third),first,second,third);
            Console.WriteLine("The Max value is {0} of {1},{2},{3}", FindMaximumFloat.DisplayMax(x, y, z), x, y, z);

        }
    }
}
