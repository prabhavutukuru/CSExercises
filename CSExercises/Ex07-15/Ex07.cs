using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            int s;
           // double h, t;

            Console.WriteLine("enter salary:");
            s = Convert.ToInt32(Console.ReadLine());
           // h = Convert.ToDouble(Console.ReadLine());
           // t = Convert.ToDouble(Console.ReadLine());
            double TS = s + (0.1) * s + (0.03) * s;
            Console.WriteLine(TS);


        }
    }
}