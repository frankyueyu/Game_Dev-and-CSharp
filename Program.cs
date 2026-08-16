using System;
using System.IO;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main()
    {
        // string path = "test.txt";

        // File.WriteAllText(path, "Hello!");

        // Console.WriteLine(File.GetCreationTime(path));

        // File.SetCreationTime(path, new DateTime(9999, 1, 1));

        // Console.WriteLine(File.GetCreationTime(path));

        // int[] messyList = [3, 1, 4, 1, 5];
        // Sort.SortDescending(5, messyList);

        // string test = "1234";
        // int converted = DumbConvert.ToIntThirtyTwo(test);
        // Console.WriteLine(converted);
        // Console.WriteLine(converted.GetType());

        List<List<string>> letters = [[], []];
        string newLetter = "";

        for (int i = 0; i < letters.Count; i++)
        {   
            while (true)
            {
                Console.Write("Enter letter: ");
                newLetter = Console.ReadLine();

                if (newLetter == "stop")
                {
                    break;
                }
                letters[i].Add(newLetter);
            }

            Console.WriteLine(letters[i]);
        }

        Console.WriteLine(letters);
        Console.Write("done\ncontinue? (yes/no) ");
        if (Console.ReadLine() == "yes")
        {
            string[][] arrayLetters = [[.. letters[0]], [.. letters[1]]];
            char[][] arrayChars = [[.. arrayLetters[0].Select(s => s[0])],
                            [.. arrayLetters[0].Select(s => s[0])]];
            
            Console.WriteLine("Enter morse: ");
            Code.MorseToKeyboardSection(Console.ReadLine(), arrayChars[0], arrayChars[1]);
        }
    }
}