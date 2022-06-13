/*
Some code is below. Do the following three tasks. You can write your solution directly in the textbook or upload it as a .txt (not .cs) file. Please ensure it is properly formatted (indenting, etc.).

1. Improve the AskForNumber by returning -1 if the incoming string argument cannot be converted to an int. Hint: Convert.ToInt32 throws an exception if it cannot convert its argument to a string. Use a try/catch block in the appropriate location.
2. Add complete XML documentation to the GuessGame method. Ensure you include all the tags.
3. There is a bug in this code. Explain what the bug is and fix it.
------------------------------------------------------------------------------------------------
*/
/*using System;
var lokesh = "lokesh";
var lokesh ="khanal";
int [] arr= new int [1,2,3,4,5];
foreach (int num in arr)
if (num.Equals (1))
{
	
}
{
	
}

const int number = 5;
const int maxGuesses = 3;

bool isWinner = GuessingGame(number, maxGuesses);

bool GuessingGame(int numberToGuess, int maxGuesses)
{
	int number = AskForNumber("Guess a number.");
	int guesses = 0;
	while (number != numberToGuess && ++guesses < maxGuesses)
	{
		Console.WriteLine("That guess is not correct, try again.");
		AskForNumber($"Guess a new number. You have used {guesses} of {maxGuesses} guesses");
	}
	if (guesses < maxGuesses)
	{
		Console.WriteLine("Congratulations, you guessed the correct number.");
	}
	else
	{
		Console.WriteLine("You ran out of guesses!");
	}
	return guesses <= maxGuesses;
}

/// <summary>
/// Asks the user for a number. Will crash if the user input is not convertible to an int (throw exception?)
/// </summary>
/// <param name="text">Text to prompt the user</param>
/// <returns>The user input as an integer</returns>
int AskForNumber(string text)
{
	Console.Write(text + " ");
	int number = Convert.ToInt32(Console.ReadLine());
	return number;
}*/
using System;



const int number = 5;

const int maxGuesses = 3;



bool isWinner = GuessingGame(number, maxGuesses);



bool GuessingGame(int numberToGuess, int maxGuesses)

{

	int number = AskForNumber("Guess a number.");

	int guesses = 0;

	while (number != numberToGuess && ++guesses < maxGuesses)

	{

		Console.WriteLine("That guess is not correct, try again.");

		AskForNumber($"Guess a new number. You have used {guesses} of {maxGuesses} guesses");

	}

	if (guesses < maxGuesses)

	{

		Console.WriteLine("Congratulations, you guessed the correct number.");

	}

	else

	{

		Console.WriteLine("You ran out of guesses!");

	}

	return guesses <= maxGuesses;

}



/// <summary>

/// Asks the user for a number. Will crash if the user input is not convertible to an int (throw exception?)

/// </summary>

/// <param name="text">Text to prompt the user</param>

/// <returns>The user input as an integer</returns>

int AskForNumber(string text)

{
	try
{
	
	Console.Write(text + " ");

	int number = Convert.ToInt32(Console.ReadLine());

	return number;
}
catch (Exception e)
{
	Console.WriteLine(e.Message);
	
	throw;
}


}