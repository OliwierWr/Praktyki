internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(dane_losowe());
    }

    static string dane_losowe()
    {
        string[] imie = ["Ania", "Kasia", "Basia", "Zosia"];
        string[] nazwisko = ["Kowalska", "Nowak"];
        
        string filePath = @"C:\test\losowe.txt";
        StreamWriter sw = new StreamWriter(filePath + "users_" + DateTime.Now.ToString("yyyy_MM_ddhh_mm_ss") + ".txt");
        for (int i = 1;i <= 100;i++)
            {
            Random rnd = new Random();
            int imie_id = rnd.Next(0, 4);
            int naziwsko_id = rnd.Next(0, 1);
            int rok = rnd.Next(1990, 2001);

             Console.WriteLine("Lp: " + i + " Imie: " + imie[imie_id] + " Naziwsko: " + nazwisko[naziwsko_id] + " rok: " + rok);
            
            sw.Write("Lp: " + i + " Imie: " + imie[imie_id] + " Naziwsko: " + nazwisko[naziwsko_id] + " rok: " + rok+"\n");



        }
        sw.Close();
        
        
        return "";
        
    }
}