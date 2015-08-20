using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string [] args)
        {
            double A, B;
            //B = A * A;


      
            Console.WriteLine("enter A");
            A = Convert.ToDouble(Console.ReadLine());
            B = A * A;
            Console.Write("Square of double no\t");
            Console.WriteLine(B);
        }
    }
}
