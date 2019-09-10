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
            
                int guess = rand.Next(1, 11);

                Console.WriteLine("Guess a number between 1 - 10");
                string answer = Console.ReadLine();
                int answerAsInteger = Convert.ToInt32(answer);
                
                //int.TryParse(answer, out answerAsInteger);
                       

                while (answerAsInteger != guess)
                {
                    Console.WriteLine("Do you want to try again");
                    string again = Console.ReadLine();

                if (again == "yes")
                {
                    int guess2 = rand.Next(1, 11);
                    Console.WriteLine("Guess a number between 1 - 10");
                   string answer2 = Console.ReadLine();
                    int answer2AsInteger = Convert.ToInt32(answer2);
                   
                    if (answer2AsInteger = guess2)
                    { Console.WriteLine("congrats"); }
                
                    


                        
               

                    
                
            
          



                Console.ReadKey();

            
        }
    }
}
