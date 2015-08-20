using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            double X, y;
            Console.WriteLine("Enter the x :");
            X = Convert.ToDouble(Console.ReadLine());
            //  y = 2 *(X * X) - 4 * X + 3;
            y =  2* (Math.Pow(X, 2)) - 4 * X + 3;
            Console.WriteLine(y);


            
        }
    }
}
