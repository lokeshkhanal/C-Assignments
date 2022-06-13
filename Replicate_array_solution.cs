using System;

const int MIN = 0;
const int MAX = 10;

int size = AskForNumberInRange("Enter the array size: ", MIN, MAX);
int[] original = new int[size];

int[] test = new int[size];

// Fill the original array with user specified integers
for (int item = 0; item < size; ++item)
{
    int number = AskForNumber("Enter a number: ");
    original[item] = number;
}

int[] copy = ReplicateArray(original);

// Verify original and replicated array are the same
for (int index = 0; index < size; ++index)
	Console.WriteLine($"Original {original[index],-4}  {copy[index], 4} Copy");

/// <summary>
/// Replicates (deep copies) the incoming array
/// </summary>
/// <param name="original">The array to be replicated</param>
/// <returns>A deep copy of the original array</returns>
int[] ReplicateArray(int[] original)
{
	int size = original.Length;
	int[] copyArray = new int[size];
	for (int i = 0; i < size; ++i)
	{
		copyArray[i] = original[i];
	}
	return copyArray;
}

/// <summary>
/// Asks the user for a number. Will crash if the user input is not convertible to an int (throw exception?)
/// </summary>
/// <param name="text">Text to prompt the user</param>
/// <returns>The user input as an integer</returns>
int AskForNumber(string text)
{
#if true
	// No exception handling
	Console.Write(text + " ");
	int number = Convert.ToInt32(Console.ReadLine());
	return number;
#else
	// Exception handling
    bool validInput = false;
	int number = 0;
    while (!validInput)
	{
		Console.Write(text + " ");
		string input = Console.ReadLine();
		try
		{
			number = Convert.ToInt32(input);
			validInput = true;
		}
		catch (FormatException e)
		{
			Console.Error.WriteLine($"Unable to parse input {input}.");
		}
		catch (OverflowException f)
		{
			Console.Error.WriteLine($"{input} is too large of a number.");
		}
	}
    return number;
#endif
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
	
#if false
	// Using a while(true) loop - not recommended
	while (true)
    {
        int number = AskForNumber(text);
        if (number >= min && number <= max)
            return number;
        Console.Error.WriteLine($"{number} is not in the specified range. Try again.");
    }
#else
	int number = AskForNumber(text);
	while (number < min || number > max)
	{
        Console.Error.WriteLine($"{number} is not in the specified range. Try again.");
		number = AskForNumber(text);
	}
	return number;
#endif
}
