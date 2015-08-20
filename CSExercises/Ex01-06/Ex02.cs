using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            int A, B;
                Console.Write("Enter a number :  ");
            A = Convert.ToInt32(Console.ReadLine()); 
            B = A * A;
            Console.WriteLine("square of  A is {0}", B);
        }
    }
}




