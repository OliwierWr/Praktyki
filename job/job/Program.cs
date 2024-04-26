using System.IO.Pipes;

internal class Program
{
    private static void Main(string[] args)
    {
        string file = @"C:\test\praca.txt";
        string name = File.ReadAllText(file);
        Console.WriteLine(zamiana(name));


    }
    static string zamiana(String namee)
    {
        var text = namee.Replace("praca","job");
        return text;
    }
}