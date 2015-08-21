using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            double M, D, TF;
            Console.WriteLine("Enter the distance : D");
            D = Convert.ToDouble(Console.ReadLine());
            M= 2.40;
           // D = Convert.ToDouble (Console.ReadLine());
           

            TF = M + D * 0.4;
            
            Console.WriteLine("Total Fair is : {0:0.00}", TF);
            
        }
    }
}
