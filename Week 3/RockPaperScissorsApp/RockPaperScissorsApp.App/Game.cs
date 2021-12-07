using System;

namespace RockPaperScissorsApp.App
{
    public class Game
    {
        protected int myPoints = 0;
        protected int computerPoints = 0;


        public string Summary
        {
            get
            {
                return $"\nPlayer: {myPoints} \nComputer: {computerPoints}";
            }
        }

        public void PlayRound()
        {
            Console.WriteLine("Choose your fighter: \n1: Rock \n2: Paper \n3: Scisscors");
            int myFighter = 0;
            Random rnd = new Random();
            int computerFighter;
            while (true)
            {
                computerFighter = rnd.Next(1, 4);
                Console.WriteLine(computerFighter); //Test to see what computer has selected
                string? myEntry = Console.ReadLine();
                bool parseEntry = int.TryParse(myEntry, out myFighter);
                if (parseEntry == true)
                {
                    if (((myFighter == 1) || (myFighter == 2) || (myFighter == 3)) && (computerFighter != myFighter))
                        break;
                    else if (((myFighter == 1) || (myFighter == 2) || (myFighter == 3)) && (computerFighter == myFighter))
                        Console.WriteLine("Draw! Choose a new fighter!");
                    else
                        Console.WriteLine("Invalid entry. Try again.");
                }
            }
            int results = RoundResults(myFighter, computerFighter);
            switch (results)
            {
                case 1:
                    Console.WriteLine("You win!");
                    myPoints++;
                    break;
                case 0:
                    Console.WriteLine("You Lose...");
                    computerPoints++;
                    break;
            }
        }

        public int RoundResults(int myFighter, int computerFighter)
        {
            string myChoice = "";
            if (myFighter == 1)
                myChoice = "Rock";
            else if (myFighter == 2)
                myChoice = "Paper";
            else if (myFighter == 3)
                myChoice = "Scissors";

            string computerChoice = "";
            if (computerFighter == 1)
                computerChoice = "Rock";
            else if (computerFighter == 2)
                computerChoice = "Paper";
            else if (computerFighter == 3)
                computerChoice = "Scissors";

            Console.WriteLine($"\nPlayer: {myChoice} \nVS \nComputer: {computerChoice}");
            if (myFighter == 1)
            {
                if (computerFighter == 3)
                    return 1;
                else
                    return 0;
            }

            else if (myFighter == 2)
            {
                if (computerFighter == 1)
                    return 1;
                else
                    return 0;
            }

            else
            {
                if (computerFighter == 2)
                    return 1;
                else
                    return 0;
            }
        }
    }
}