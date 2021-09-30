using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 10;

            Console.Write("Try to guess my favorite number");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess <= favoriteNumber)  
            {
                Console.WriteLine("too low!!");
            }
            else if (userGuess >= favoriteNumber) 
            {
                Console.WriteLine("too high!");

            }
            else 
            {
                Console.WriteLine("Nevermind");
            }            
            
             
                      

            
        }
    }
}
