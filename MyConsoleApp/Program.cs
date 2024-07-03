namespace MyConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        // ทักทายผู้ใช้งาน
        string strRead = "";
        Console.Write("Please insert your name: ");
        strRead = Console.ReadLine();
        Console.WriteLine("Hello! Mr./Mss. " + strRead);
        Console.WriteLine(" Date -> " + DateTime.Now.ToShortDateString());
        Console.WriteLine(" Time -> " + DateTime.Now.ToShortTimeString());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press any key to exit program");
        Console.ReadLine();
    }
}