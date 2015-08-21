using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            double TF, TF1;

            Console.WriteLine("Enter the value:");
            TF = Convert.ToDouble(Console.ReadLine());
            TF1 = Math.Ceiling((TF*10)/10);
            Console.WriteLine(TF1);
        }
    }
}
