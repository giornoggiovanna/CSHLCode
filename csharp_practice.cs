using System.Text;
using System;
					
public class Password
{
	
	string userPassword;
	
	public void Main()
	{
		
		Console.WriteLine("What is your password?  Type \"Suggest\" to get a suggested password");
		userPassword = Console.ReadLine();
		
		if(userPassword.Equals("Suggest"))
		{
		
			userPassword = SuggestNewPassword();
			
		}
		
		Console.WriteLine(userPassword);
	
		
	}
	
	string SuggestNewPassword()
	{
		int length = 11;
      
      StringBuilder str_build = new StringBuilder();  
      Random random = new Random();  

      char letter;  

      for (int i = 0; i < length; i++)
      {
        double flt = random.NextDouble();
        int shift = Convert.ToInt32(Math.Floor(25 * flt));
        letter = Convert.ToChar(shift + 65);
        str_build.Append(letter);  
      }  	
		string p_suggest = str_build.ToString();
		
		return p_suggest;		
	}
	
	bool checkPassword(string password)
	{
	
		if(password.Length == 11)
		{
			
			if(password.Contains())
			   {
				   
			   }
			
		}else return false;
		
	}
}