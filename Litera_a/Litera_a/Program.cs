internal class Program
{
    private static void Main(string[] args)
    {
        string file = @"C:\test\test_kaj_s_oli_w.txt";
        string name = File.ReadAllText(file);       
            int A = LiczA(name, 'a');
        Console.WriteLine(A);
    }

    static int LiczA(string text, char a)
    {
        int iloscA = 0;
        foreach (char c in text)
        {
            if(c == a)
            {
                iloscA++;
            }
        }
        return iloscA;
    }
}