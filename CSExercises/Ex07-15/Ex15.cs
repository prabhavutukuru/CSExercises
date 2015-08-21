using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int number, remainder, sum = 0;
            Console.Write("enter number");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = number; i > 0;i=i/10)
                {
                remainder = i % 10;
                sum = sum + remainder * remainder * remainder;
}
            if (sum == number)
            {
                Console.Write("Entered number is an Armstrong Number");


            }
            else
                Console.Write("Entered number is not an Armstrong Number");
        }
    }
}