using System;

namespace TicTacToe
{
    class Program
    {
        
        static string TTTBoard = 
        (
            @"
                |     | 
             -------------
                |     |  
             -------------
                |     | 
                
            "
        );

        static void Main(string[] args)
        {
            
            Console.WriteLine("Would you like to play with a friend or against an AI?");
            string userAnswer = Console.ReadLine();

            if(userAnswer.Contains("AI"))
            {

                Console.WriteLine("AI is currently in the proces of being made, sorry");
                return;

            }
            if(userAnswer.Contains("Friend"))
            {

                GameLogic tttGL = new GameLogic();

                tttGL.userOneTurn = true;
                Console.WriteLine(TTTBoard);
                Console.WriteLine("Place your X by typing the position using 1-9, going from left to right starting at the top left.");

                tttGL.getPlayerPosition();
                tttGL.printBoard();
                tttGL.printBoard();
            }

        }
    
    }

    class GameLogic
    {

        // string userOnePosition;
        // string userTwoPosition;
        // string newBoard =
        // (
        //     @"
        //         |     | 
        //      -------------
        //         |     |  
        //      -------------
        //         |     | 
                
        //     "
        // );

        int [] positions = new int[9];
        
        string [] placements = new string[9];

        public bool userOneTurn;

        public void getPlayerPosition()
        {

            if (userOneTurn)
            {

                var userOneInput = int.Parse(Console.ReadLine());

                positions[userOneInput - 1] = 1;
            }
            else 
            {
                var userTwoInput = int.Parse(Console.ReadLine());

                positions[userTwoInput - 1] = 2;


            }

        }

        public void updateBoard()
        {

            int pl = positions.Length; 

            for (int i = 0; i > pl; i++)
            {

                if(positions[i] == 1)
                {

                    placements[i] = ("X");

                }
                if(positions[i] == 2)
                {

                    placements[i] = ("Y");

                }
                else placements[i] = ("_");


            }

        }

        public void printBoard()
        {

            for(int i = 0; i == 9; i += 3)
            {

                Console.WriteLine($"{placements[i]}|{placements[i+1]}|{placements[i+2]}" );

                if(i >= 6) break;
                else
                {
                Console.Write(Environment.NewLine);
                Console.WriteLine("-------------");
                }

            }

        }

    }

    class AILogic
    {



    }
}
