using Lab8;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
    private static bool stop;

    private static void Main(string[] args)
    {
        try
        {
            do
            {
                ConsoleSetup();
                WriteActionList();
                var action = Console.ReadLine();
                string userInput;
                switch (int.Parse(action ?? string.Empty))
                {
                    case 1:
                        userInput = GetUserInput("Введить текст з палиндромами");
                        Console.WriteLine("Введить к-сть букв n");
                        ViewPalinDromes(PalinDromerAnalizer.GetPalinDromes(userInput, int.Parse(Console.ReadLine())));
                        break;
                    case 2:
                        userInput = GetUserInput("Введiть текст з windows & macOS") ?? "";
                        ViewOsResult(OSAnalyzer.FoundPartsWithWindowsMacOS(userInput));
                        break;
                    default:
                        Console.WriteLine("Допустимо 1 або 2");
                        break;
                }
                CheckForStop();
            }
            while (!stop);
        }
        catch (Exception ex)
        {
            Console.WriteLine("помилка");
        }

    }

    private static string GetUserInput(string textToUser)
    {
        Console.WriteLine(textToUser);
        var userInput = Console.ReadLine();
        return userInput;
    }

    private static void ViewOsResult(MatchCollection matches)
    {
        foreach (var item in matches)
        {
            Console.WriteLine(item.ToString());           
        }
    }

    private static void WriteActionList()
    {
        Console.WriteLine("Оберiть дiю\n");
        Console.WriteLine("1. Знайти палiндроми");
        Console.WriteLine("2. Знайти количество виндоус");
    }

    private static void ViewPalinDromes(List<string> list)
    {
        Console.WriteLine("Список палідромів");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    private static void ConsoleSetup()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.ResetColor();
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.UTF8;
    }

    private static void CheckForStop()
    {
        Console.WriteLine("Escape - зупинка, будь яка кнопка продовжити");
        if (Console.ReadKey().Key == ConsoleKey.Escape)
        {
            stop = true;
        }
    }
}