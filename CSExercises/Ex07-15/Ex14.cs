using System;
namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double a, b, c, s,A ;
            Console.WriteLine ("Enter the value A:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value B:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value C:");
            c = Convert.ToDouble(Console.ReadLine());
            s = (a + b + c) / 2;
            A = Math.Sqrt( s* (s - a)*(s - b)*(s - c));
            Console.Write("Value of A is ");
            Console.WriteLine(A);


        }
    }
}