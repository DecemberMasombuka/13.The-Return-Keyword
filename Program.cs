using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.The_Return_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Print the fucntion result
            Console.WriteLine(cube(3));
            Console.ReadLine();
        }

        //Declare a return function
        static int cube(int number)
        {
            int result = number * number * number;
                return result;
        }
    }
   
}