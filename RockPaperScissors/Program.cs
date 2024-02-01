using System;

namespace RockPaperScissors
{

    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCpu;
            int randomNum;
            bool playagain = true;

        while(playagain)
        {
            int playerScore = 0 ;
            int CpuScore = 0;
        

            while(playerScore < 3 &&  CpuScore < 3)
         {

            
            Console.WriteLine("Choose Rock, Paper or Sciccors");
            inputPlayer = Console.ReadLine();

            Random r = new Random();

            randomNum = r.Next(1,4);

           switch (randomNum)
           {
            case 1:
                inputCpu = "Rock";
                Console.WriteLine("CPU chose Rock.");
                if(inputPlayer == "Rock" )
                {
                    Console.WriteLine("DRAW!");
                }
                else if(inputPlayer == "Paper")
                {
                    Console.WriteLine("You Win!");
                    playerScore += 1;
                }
                else
                {
                    Console.WriteLine("You Lose!");
                    CpuScore += 1;
                }
                break;
            case 2:
                inputCpu = "Paper";
                Console.WriteLine("CPU chose Paper.");
                 if(inputPlayer == "Paper" )
                {
                    Console.WriteLine("DRAW!");
                }
                else if(inputPlayer == "Sciccors")
                {
                    Console.WriteLine("You Win!");
                    playerScore += 1;
                }
                else
                {
                    Console.WriteLine("You Lose!");
                    CpuScore += 1;
                }
                break;
            case 3:
                inputCpu = "Sciccors";
                Console.WriteLine("CPU chose Sciccors.");
                if(inputPlayer == "Sciccors" )
                {
                    Console.WriteLine("DRAW!");
                }
                else if(inputPlayer == "Rock")
                {
                    Console.WriteLine("You Win!");
                    playerScore += 1;
                }
                else
                {
                    Console.WriteLine("You Lose!");
                    CpuScore += 1;
                }
                break;
            default:
                Console.WriteLine("Invalid Response");
                break;
           }


         }
         
            if(playerScore == 3)
            {
             Console.WriteLine("You Won the game !!");
            }
            else
            {
             Console.WriteLine("CPU won the game !!");
            }
          
            Console.WriteLine("Do you want to play again?(y/n)");
            string redo = Console.ReadLine();
            if(redo == "y")
            {
                playagain = true;
            }
            else
            {
                playagain = false; 
            }
        }


    }


    




    }


}