using System;

namespace TicTacToe
{
    class Board
    {   

        //Private Variables

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

        //Main method
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

                while(!tttGL.gameEnd)
                {

                tttGL.getPlayerPosition();
                
                }

                if(tttGL.gameEnd) Console.WriteLine("The game has ended. No one won.");
            }

        }
    
    }

    class GameLogic
    {

        //Private Variables

        int i;

        bool blankSpace = false;

        //Private Arrays

        int [] positions = new int[9];
        
        string [] placements = new string[9];

        //Public Variables

        public bool userOneTurn;
        public bool gameEnd;

        //Getting the position that the player has chosen
        public void getPlayerPosition()
        {

            if (userOneTurn)
            {
                Console.WriteLine("It is player one's turn");

                var userOneInput = int.Parse(Console.ReadLine());

                if(positions[userOneInput - 1] != 2)
                {
                    
                positions[userOneInput - 1] = 1;
                
                }

            }
            else 
            {
                Console.WriteLine("It is player two's turn");

                var userTwoInput = int.Parse(Console.ReadLine());

                if(positions[userTwoInput - 1] != 1)
                {

                positions[userTwoInput - 1] = 2;
                
                }

            }

            updateBoard();

        }

        //Updating the board to show that position
        public void updateBoard()
        {   

            int pl = positions.Length; 

            for (i = 0; i < pl; i++)
            {

                
                if(positions[i] == 1)
                {

                    placements[i] = (" X ");


                }
                else if(positions[i] == 2)
                {

                    placements[i] = (" O ");

                }
                else if (positions[i] == 0) 
                {

                placements[i] = (" _ ");

                blankSpace = true;

                }
                Console.Write(placements[i]);

                if(i != 2 || i !=5) Console.Write("|");


                if(i == 2 ||  i == 5)
                {
                    Console.Write(System.Environment.NewLine);
                    Console.WriteLine("-----------");
                }

            }

            Console.Write(System.Environment.NewLine);

            userOneTurn = !userOneTurn;

            if(!blankSpace)
            {

                gameEnd = true;

            }else blankSpace = false;

        }


        public void CheckForWins()
    {

        

    }

    }

    class AILogic
    {


    }
}
