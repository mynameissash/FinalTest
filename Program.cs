string[] FilterStringArray(string[] inputArray)
{
    int filteredArrayLength = CountStringsLengthLessThanThree(inputArray);
    string[] filteredArray = new string[filteredArrayLength];

    int filteredWordsCounter = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            filteredArray[filteredWordsCounter] = inputArray[i];
            filteredWordsCounter++;
        }
    }

    return filteredArray;
}

int CountStringsLengthLessThanThree(string[] inputArray)
{
    int stringsLengthLessThanThreeSount = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3) {
            stringsLengthLessThanThreeSount++;
        }
    }

    return stringsLengthLessThanThreeSount;
}

Console.WriteLine("Введите строки через пробел");
string wordsString = Console.ReadLine();

string[] words = wordsString.Split(" ");
string[] filteredWordsArray = FilterStringArray(words);

Console.WriteLine("Строки длиной меньше 3:");
Console.WriteLine("[{0}]", string.Join(", ", filteredWordsArray));