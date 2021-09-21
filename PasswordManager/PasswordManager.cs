using System;
using System.Text;

namespace PasswordManager
{
    class PasswordInputer
    {

        

        static string userInput;

        static void Main()
        {

            Console.WriteLine("Create a new password");
            userInput = Console.ReadLine();

            if(userInput.Equals("Quit"))
            {

                Console.WriteLine("Quiting...");

                return;
            }


        }


        
        

    }

    class PasswordChecker
    {

        char[] numbers = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',};

        bool CheckPassword(string p)
        {

            int l = p.Length
            
            for(int i = 0, i > l, i++)
            {



            }


        }


    }

    class PasswordGenerator
    {





    }
}
