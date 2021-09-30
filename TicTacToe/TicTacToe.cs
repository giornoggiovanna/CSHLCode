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

                while(!tttGL.gameEnd)
                {

                tttGL.getPlayerPosition();
                
                }
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

        int i;

        int [] positions = new int[9];
        
        string [] placements = new string[9];

        public bool userOneTurn;
        public bool gameEnd;

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
                else if (positions[i] == 0) placements[i] = (" _ ");

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

        }


    }

    class AILogic
    {


    }
}
