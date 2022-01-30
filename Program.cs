// See https://aka.ms/new-console-template for more information
using System;

namespace Unit02.Cards
{
    public class Program
    {
        // Random num = new Random();
        // int _num = num.Next(1, 13);
        private static readonly Random num = new Random();
        int _num = num.Next(1, 13);
        public string _guess = "";
        int _points = 300;

        public void Main()
        {
            currentCard();
            getGuess();
            checkGuess();
            restart();
        }
        public void currentCard()
        {
            //display current randomized number
            Console.Write($"The card is: {_num}");
            //get guess from user. Is the card higher or lower.
            
        }
        public void getGuess()
        {
            //ask guess if they think hte next card is higher or lower. 
            Console.WriteLine("Higher or lower? [h/l] ");
            string _guess = Console.ReadLine();
        }

        public void checkGuess()
        {
            // public int newNum = Console.WriteLine($"Next card was: {_num}");
            //if then statement to add(+100) or subtract(-75) from points
            if (((0 < _num) && (_guess == "h")) || ((0 > _num) & (_guess == "l"))) 
            {
                _points = _points - 75;
            }
            else
            {
                _points = _points + 100;
            }
            //display new points
            Console.WriteLine($"Your score is: {_points}");
        }

        public void restart ()
        {
            //if then statement to ask if user want to go again.
            // if so, call beinning function again, if not, bye bye.
            Console.WriteLine("Play again? [y/m] ");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Bye Bye");
            }
             
        }

    }
}




