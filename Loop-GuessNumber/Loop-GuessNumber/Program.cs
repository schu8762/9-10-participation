
//@author Jacob Schuller

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Please enter the minimum for your random number");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the maximum for your random number");
            int max = Convert.ToInt32(Console.ReadLine());

            //if we wanted to generate a random number each ITERATION then put loop here
            int generated = rand.Next(min, max+1);//max is exclusive so add 1 to the max (1, 101)
                Console.WriteLine(generated); //Cheating here to see what # the computer generates so we can see if our below code is working
            int answerAsInteger = 0;    //we defined AsInteger here so it is already defined - said it was 0 cause it never will be but we still can define it here


             //start loop here so we can convert the "answer" to integer everytime and so we can get their answer everytime *ReadLine*
            while(answerAsInteger != generated)
            { 
            Console.WriteLine($"Guess a number between {min} and {max}");
                string answer = Console.ReadLine();
                while (Int32.TryParse(answer, out answerAsInteger) == false)
                    { Console.WriteLine("Invalid input please try again");
                    Console.WriteLine($"Guess a number between {min} and {max}");
                    answer = Console.ReadLine();
                }








               //-testingabove answerAsInteger = Convert.ToInt32(answer); //making sure that whatever they input makes since to us (comparing apples to oranges) to convert it to integer so we can do math

                //int.TryParse(answer, out answerAsInteger);
                if (answerAsInteger == generated)
                {
                    Console.WriteLine("Congrats");
                }
                else
                {
                    if (answerAsInteger < generated)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("sorry too low");
                    }
                    else
                            { Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("too high");
                    }
                    
                
                    Console.WriteLine("Sorry, try again");
                }













                    Console.ReadKey();
                }
            
        }
    }
}
