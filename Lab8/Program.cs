public class Program
{
    private static void Main(string[] args)
    {
        PalinDromerAnalizer.Setup();
        try
        {
            var userInput = Console.ReadLine();
            var palinDromeSize = int.Parse(Console.ReadLine()); 
            PalinDromerAnalizer.ViewPalidromes(PalinDromerAnalizer.GetPalinDromes(userInput, palinDromeSize));
        }
        catch (Exception ex)
        {
            Console.WriteLine("помилка");
        }

    }
}