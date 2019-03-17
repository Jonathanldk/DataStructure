using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HomeExerciseThree
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User");

            while (true)
            {
                Console.WriteLine("Write down one number");

                string input1 = Console.ReadLine();

           
                Console.WriteLine("Write down a second number");

                string input2 = Console.ReadLine();


                Console.WriteLine("Write down a third number");
            
                string input3 = Console.ReadLine();


                Stack mystack = new Stack();
                mystack.Push(input1);
                mystack.Push(input2);
                mystack.Push(input3);

                foreach (Object obj in mystack)
                {
                    Console.WriteLine(obj);
                }
            }  
        }
    }
}
