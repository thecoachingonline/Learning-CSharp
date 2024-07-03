namespace MyConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        // ทักทายผู้ใช้งาน
        string strRead = "";
        Console.Write("Please insert your name: ");
        strRead = Console.ReadLine();
        Console.WriteLine("🙏 Hello! Mr./Mss. " + strRead);
        Console.WriteLine(" Now = " + DateTime.Now.ToString());
        Console.WriteLine(" Date -> " + DateTime.Now.ToShortDateString());
        Console.WriteLine(" Time -> " + DateTime.Now.ToShortTimeString());
        Console.WriteLine(" Date = " + DateTime.Now.Date.ToString());
        Console.WriteLine(" Today = " + DateTime.Today.ToString());
        Console.WriteLine(" Day = " + DateTime.Now.Day.ToString());
        Console.WriteLine(" Month = " + DateTime.Now.Month.ToString());
        Console.WriteLine(" Year = " + DateTime.Now.Year.ToString());
        Console.WriteLine();
        Console.WriteLine("Press any key to exit program");
        Console.ReadLine();
    }
}