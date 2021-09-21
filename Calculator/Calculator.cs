using System;
					
public class Calculator
{
	
	static float valueOne;
	static float valueTwo;
	
	static float answer;
	
	static string inputOne;
	static string inputTwo;
	static string operation;
	
	
	
	static public void Main()
	{
		
		Console.WriteLine("What is your first number?");
		inputOne = Console.ReadLine();
						  
		Console.WriteLine("What is your second number?");
		inputTwo = Console.ReadLine();
		
		Console.WriteLine("What is your operation?");
		operation = Console.ReadLine();
		
		valueOne = Convert.ToSingle(inputOne);
		valueTwo = Convert.ToSingle(inputTwo);
		
		if(operation.Equals("Addition"))
		{

			answer = addNumbers(valueOne, valueTwo);
			Console.WriteLine($"Your answer is: {answer}");

		}
		if(operation.Equals("Subtraction"))
		{

			answer = subtractNumbers(valueOne, valueTwo);
			Console.WriteLine($"Your answer is: {answer}");

		}
		if(operation.Equals("Multiplication"))
		{

			answer = multiplyNumbers(valueOne, valueTwo);
			Console.WriteLine($"Your answer is: {answer}");

		}
		if(operation.Equals("Division"))
		{

			answer = divideNumbers(valueOne, valueTwo);
			Console.WriteLine($"Your answer is: {answer}"); 

		}else answer = 0;

		
	}

    static public float addNumbers(float a, float b)
	{ 
		return a+b; 
	}
	
	static public float subtractNumbers (float a, float b)
	{
		return a-b;
	}
	
	static public float multiplyNumbers (float a, float b)
	{
		return a*b;
	}
	
	static  public float divideNumbers (float a, float b)
	{
		return a/b;	
	}
}
