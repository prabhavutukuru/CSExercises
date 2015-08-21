using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            string str;
            char gen;
            Console.WriteLine("Enter the Name");
            str =(string) Console.ReadLine(); 
            Console.WriteLine(" Gender");
            gen=(char)Console.Read(); 
           if (gen=='M')
            { 
                Console.WriteLine("Good Morning Mr" + str);
            }
            else
                Console.WriteLine("Goodmorning Ms " + str);





            
        }
    }
}