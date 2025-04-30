// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
internal class Prog
{
    static void Main(string[] args)
    {
        Tanulo diak1 = new Tanulo();
        Console.WriteLine(diak1.szulev);

        if (diak1.szulev == 2010)
        {
            Console.WriteLine("OK");
        }

        Console.ReadKey();
    }
}