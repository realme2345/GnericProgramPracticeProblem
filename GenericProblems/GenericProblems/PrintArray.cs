using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems
{
    /// <summary>
    /// Generic method
    /// </summary>
    internal class PrintArray
    {
        /// <summary>
        ///   Converts to print.
        /// </summary>
        /// <param name="intarray"></param>
        /// accessmodifier return type methodName<T>
        public static void ToPrint(int [] intarray)
        {
            Console.WriteLine("Iterating Over a array");
            foreach( int elemnt in intarray)
            {
                Console. Write("  " + elemnt);
            }
        }
        public static  void ToPrint(double[] doublearray)
        {
            Console.WriteLine("\nIterating Over a array");
            foreach (double elemnt in doublearray)
            {
                Console.Write(" " + elemnt);
            }
        }
        public  static void ToPrint(char[] chararray)
        {
            Console.WriteLine("\nIterating Over a array");
            foreach (char elemnt in chararray)
            {
                Console.Write(elemnt);
            }
        }
    }
}
