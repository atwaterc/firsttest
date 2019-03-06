using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheFood
{
    class Program
    {
        static void Main(string[] args)
        {
            //methods created outside main as to keep main method as clean as possible
            var foodUserWillGuess = AddFood();
            guessTheFood(foodUserWillGuess);
            Console.ReadKey();
            
        }

        /// <summary>
        /// method is used to allow user to guess the randomly selected food from AddFood() method
        /// </summary>
        /// <param name="foodToGuess"></param>
        static void guessTheFood(string foodToGuess)
        {
            //create variable for max food
            var maxGuesses = 3;

            Console.WriteLine("A random food from the above list has been picked.  You have 3 guesses to pick the correct one.");

            //loop through user guesses until user has maxed out guesses
            while(maxGuesses > 0)
            {
                Console.Write("Your guess?: ");
                var guess = Console.ReadLine();

                if (guess.Equals(foodToGuess))
                {
                    Console.WriteLine("Congrats! You guessed correctly!");
                    return;
                }
                else
                {
                    //reduce amount of guesses user has left
                    maxGuesses--;
                    if (maxGuesses != 0)
                    {
                        Console.WriteLine("Incorrect guess! You only have {0} guesses remaining! Try Again", maxGuesses);
                    }
                    else
                    {
                        //if user guesses all 3 times incorrectly, display correct answer
                        Console.WriteLine("You're all out of guesses! The correct answer was {0}!!", foodToGuess);
                        return;
                    }
                } 
            }

        }

        /// <summary>
        /// Method is used to populate a List of foods, display that List of foods and return a randomly selected food
        /// </summary>
        /// <returns></returns>
        static string AddFood()
        {
            //create list of specified foods
            List<string> food = new List<string> {"Pizza", "Pasta", "Salmon", "Steak", "Miso" };

            var foodNum = 0;

            Console.WriteLine("This is the list of foods you may choose from: ");

            //foreach loop to iterate through list of food
            foreach (var name in food)
            {
                foodNum++;
                Console.WriteLine("{0}. {1}", foodNum, name);             
            }

            //create new random object to pick random item from list
            Random random = new Random();

            //picks a random number based on the size of food List
            var randomFood = random.Next(food.Count);

            //returns food at random index
            return food[randomFood];
        }
    }
    
}
