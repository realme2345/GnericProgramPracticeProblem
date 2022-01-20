using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems.FindMax
{
    /// <summary>
    /// Find Maximum Value
    /// </summary>
     class FindMaximumValue
    {
        public static int DisplayMax(int first, int second, int third)
        {
            if(( first.CompareTo(second)>0) && (first.CompareTo(second) > 0))
             {
                //Console.WriteLine("first number is maximum");
                return first;
             }
         
            else if ( ( second.CompareTo(first)>0)&& ( second.CompareTo(third) > 0))
            {
              // Console.WriteLine ("Second number is maximum");
               return second;

            }
            else if(( third.CompareTo(first)>0) && ( third.CompareTo(second) > 0))
            {
               // Console.WriteLine(("third number is maximum"));
                return third;
            }
            else
            {
               // Console.WriteLine("2 or 3 is equal");
                return 0;
            }

        }
    }
}
