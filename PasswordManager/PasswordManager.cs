// using System;
// using System.Text;

// namespace PasswordManager
// {
//     class PasswordInputer
//     {

        

//         static string userInput;

//         static void Main()
//         {

//             Console.WriteLine("Create a new password");
//             userInput = Console.ReadLine();

//             if(userInput.Equals("Quit"))
//             {

//                 Console.WriteLine("Quiting...");

//                 return;
//             }


//         }


        
        

//     }

//     class PasswordChecker
//     {

//         char[] numbers = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',};

//         ref bool CheckPassword(string p)
//         {
    
//             ref bool a;

//             foreach(char c in numbers)
//             {

//                 a = CheckForNumber(c, p);

//                 if(a) break;

                
//             }
            

//             return ref a;

//         }

//         bool CheckForNumber(char c, string s)
//         {

//             if(s.Contains(c)) return true;
//             else return false;

//         }

//     }

//     class PasswordGenerator
//     {





//     }
// }
