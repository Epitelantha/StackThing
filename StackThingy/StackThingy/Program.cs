using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstInLastOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a stack to hold the inputs
            Stack<int> stackthing = new Stack<int>();

            //Tell the user what to do
            Console.WriteLine("Input the first element");
            //Convert the user's input to an int 
            int input = Convert.ToInt32(Console.ReadLine());
            //Push the input to the stack
            stackthing.Push(input);

            //Repeat twice more
            Console.WriteLine("Input the second element");
            input = Convert.ToInt32(Console.ReadLine());
            stackthing.Push(input);

            Console.WriteLine("Input the last element");
            input = Convert.ToInt32(Console.ReadLine());
            stackthing.Push(input);

            //Using a foreach loop the stack can be written to the user
            foreach (int c in stackthing) {
                Console.Write(c + " ");
            }
            //Require the user to input something to end the program, forcing it to not close too fast
            Console.ReadLine();
        }
    }
}
