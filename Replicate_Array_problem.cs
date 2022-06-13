using System;

const int MAX = 10;
const int MIN = 0;

// Get a integer from the user in the range [MIN, MAX]
// Make a new integer array based on that input

// Fill the original array with user specified integers. Use AskForNumber in a loop

int[] copy = ReplicateArray(original);

// Verify original and replicated array are the same
for (int index = 0; index < size; ++index)
	Console.WriteLine($"Original {original[index],-4}  {copy[index],4} Copy");

/// <summary>
/// Replicates (deep copies) the incoming array
/// </summary>
/// <param name="original">The array to be replicated</param>
/// <returns>A deep copy of the original array</returns>
int[] ReplicateArray(int[] original)
{
	throw new NotImplementedException();
}

/// <summary>
/// Asks the user for a number. Will crash if the user input is not convertible to an int (throw exception?)
/// </summary>
/// <param name="text">Text to prompt the user</param>
/// <returns>The user input as an integer</returns>
int AskForNumber(string text)
{
	throw new NotImplementedException();
}

/// <summary>
/// Asks the user for a number within a certain range [min, max]. If the number is not in the range, re-prompt the user for a new number.
/// Will crash if the user input is not convertible to an int (throw exception?)
/// </summary>
/// <param name="text">Text to prompt the user</param>
/// <param name="min">Smallest permissible value</param>
/// <param name="max">Largest permissible value</param>
/// <returns>The user input as an integer</returns>
int AskForNumberInRange(string text, int min, int max)
{
	// Use AskForNumber to help
	throw new NotImplementedException();
}
