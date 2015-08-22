using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            string str;
            char gen;
            int age;
            Console.WriteLine("Enter name");
            str = (string)Console.ReadLine();
            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enter gender");
            gen = (char)Console.Read();

           

            if (age >= 40 )
            {
                if (gen == 'M')
                {

                    Console.WriteLine("Good Morning Uncle" + str);
                }



                else


                {

                    Console.WriteLine("Good MOrning Aunty" + str);

                }
            }
            else if (gen == 'M')
            {
                Console.WriteLine("good morning Mr." + str);

            }
            else
            {
                Console.WriteLine("good morning Ms." + str);
            } 
        }

            

        }
    }
