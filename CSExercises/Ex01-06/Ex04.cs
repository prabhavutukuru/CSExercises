using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            double A, B;
           Console.Write("Enter A :");
            A = Convert.ToDouble(Console.ReadLine());
            B =    Math.Sqrt(A);
            
            Console.WriteLine(B);
        }
    }
}
