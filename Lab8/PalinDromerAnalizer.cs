﻿using System.Text;
using System.Text.RegularExpressions;

public static class PalinDromerAnalizer
{

    public static List<string> GetPalinDromes(string userInput, int PalinDromeSize) //PalinDromeSize - n by condition
    {
        var result = new List<string>();
        var validString = Regex.Replace(userInput, @"[a-zA-ZА-Яа-яІіЇїЄє\s]", "");
        var words = validString.Split(' ');
        foreach (var item in words)
        {
            string reverseWord = ReverseString(item);
            if (item == reverseWord)
            {

                if (item.Length == PalinDromeSize)
                {
                    result.Add(reverseWord);
                }
            }
        }
        return result;
    }

    public static string ReverseString(string word)
    {
        var chars = word.ToCharArray();
        chars = chars.Reverse().ToArray();
        return new string(chars);
    }

    public static void Setup()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.UTF8;
    }




    public static void ViewPalidromes(List<string> palindromes)
    {
        Console.WriteLine("Список палідромів");
        foreach (var item in palindromes)
        {
            Console.WriteLine(item);
        }
    }
}