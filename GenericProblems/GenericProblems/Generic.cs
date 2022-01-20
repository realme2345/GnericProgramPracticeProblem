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
    internal class Generic
    {
        /// <summary>
        /// converts to print
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void ToPrint<T>(T[] array)
        {
            Console.WriteLine("Iterating Over a array");
            foreach (var elemnt in array)
            {
                Console.Write("  " + elemnt);
            }
            Console.WriteLine();
        }

    }
}
