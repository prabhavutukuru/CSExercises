using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            double TF,TF1;

            Console.WriteLine("Enter the value:");
            TF = Convert.ToDouble(Console.ReadLine());
            TF1 = Math.Round(TF,1);
            Console.WriteLine(TF1);
        }
    }
}
