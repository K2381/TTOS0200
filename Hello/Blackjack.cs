using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
namespace JAMK.IT
{
    class BlackJack
    {
      public static void BJ()
        {
            string Number;
            int theirNumber;
            Random rnd;
            while (true)
            {
                System.Console.WriteLine("*** BlackJack! ***");
                System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
                //reading and converting 
                Number = Console.ReadLine();
                if (Number == "x")
                    break;
                else
                {
                    theirNumber = Convert.ToInt32(Number);
                }
                
                //comparing that given umber is valid
                rnd = new Random();
                int MyNumber = rnd.Next(10, 21);
                if (theirNumber < 1 || theirNumber > 21)
                {
                    Console.WriteLine("The given number is out of limits, try again.");
                }
                else
                {
                    //comparing
                    if (theirNumber >= MyNumber && theirNumber <= 21)
                    {
                        System.Console.WriteLine("You win.");
                        System.Console.WriteLine("My number was: " + MyNumber);
                    }
                    else
                    {
                        System.Console.WriteLine("You lose.");
                        System.Console.WriteLine("My number was: " + MyNumber);
                    }
                }
                
            }
        }
    }
}