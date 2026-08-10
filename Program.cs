using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "test.txt";

        File.WriteAllText(path, "Hello!");

        Console.WriteLine(File.GetCreationTime(path));

        File.SetCreationTime(path, new DateTime(9999, 1, 1));

        Console.WriteLine(File.GetCreationTime(path));
    }
}