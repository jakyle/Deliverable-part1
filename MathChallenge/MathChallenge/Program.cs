using System;
using System.Linq;

namespace NumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            // I wasnt sure if this is good practice to declare all of my variables at the begenning of the program, but 
            // I feel like it makes the code less cluttered since we know what type is being used early on.
            int[] num1;
            int[] num2;
            int[] newNum;
            ConsoleKey answer;
            string userInput1;
            string userInput2;
            bool isLengthAndNumber = false;
            NumberChallenge challenge = new NumberChallenge();
            // I decided that starting out with a long console message that describes
            // what we are doing gives the user a higher chance of inputing the correct information. 
            Console.WriteLine("We are going to figure out if the sum of each place (ones, tens, hundreds...) are completely equal!");
            Console.WriteLine("So insert two sets of positive whole numbers, both of equal length...");
            while (!isLengthAndNumber)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a positive whole number");
                userInput1 = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Please enter a second positive whole number of equal length.");
                userInput2 = Console.ReadLine();
                Console.WriteLine();
                // I don't think the user should have to go through several differnt
                // prompts, so I wanted to check that all conditions  are being met and if they get it wrong,
                // I have a general message that gives the  user a hint on what he could have "possibly" gotten wrong. 
                if ((userInput1.All(char.IsDigit) && userInput2.All(char.IsDigit)) && (userInput1.Length == userInput2.Length))
                {
                    // conditions met so I thought it wise to call the challenge class I created to store and convert the user inputed numbers               
                    num1 = challenge.ConvertToNumArry(userInput1);
                    num2 = challenge.ConvertToNumArry(userInput2);
                    newNum = challenge.SumNumsArray(num1, num2);

                    if (challenge.AreAllNumsEqual(newNum))
                    {
                        Console.WriteLine("True! each placeholder equals the same number! good job :)");
                    }
                    else
                    {
                        Console.WriteLine("False! some or all of the Places are different numbers!");
                    }
                    // I think if the user gets it wrong or right, user should have the choice to play again. also I put an empty Console.WriteLine
                    // to put space between the previous line and this one, makes it easier on the eyes I think. 
                    Console.WriteLine();
                    Console.WriteLine("Would you like to try again?... press (Y or N)");
                    answer = Console.ReadKey().Key;
                    Console.WriteLine();
                    if (answer != ConsoleKey.Y)
                    {
                        isLengthAndNumber = true;
                    }
                }
                else
                {
                    // just trying to be as explicit as possible to the user why he is being told to enter the number again.
                    Console.WriteLine("Invalid input, either the length(s) of your number(s) do not match or you did not enter all positive whole numbers.");
                }
            }
        }
    }
}