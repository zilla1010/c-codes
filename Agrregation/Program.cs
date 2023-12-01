using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("write a sentence ");
        string word = Console.ReadLine();
        
        Console.WriteLine("write a word  from the sentence ");
        int count = 0;
        string sub = Console.ReadLine();
        int index = word.IndexOf(sub);

        while (index != -1)
        {
            count++;
            index = word.IndexOf(sub , index+ 1);

        }
       
        Console.WriteLine($"the word {sub} occured {count} times");





    }
}