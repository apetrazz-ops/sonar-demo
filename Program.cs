using System;
using System.IO;

class Program
{
    // Campo non usato (code smell)
    static string? _cachedPath = null;

    static void Main(string[] args)
    {
        Console.WriteLine("Sonar demo starting...");

        // Variabile mai usata (code smell)
        var neverUsed = DateTime.Now;

        // Magic numbers / logica inutile (code smell)
        int result = Add(10, 20);
        Console.WriteLine("Result: " + result);

        // Possibile bug: eccezione se non ci sono argomenti
        Console.WriteLine("First arg length: " + args[0].Length);

        // Leak di risorsa: stream non chiuso/disposto
        FileStream fs = new FileStream("demo.txt", FileMode.OpenOrCreate);
        fs.WriteByte(42);
        // fs.Dispose() mancante

        Console.WriteLine("Done.");
    }

    static int Add(int a, int b)
    {
        if (a == 0)
        {
            return b;
        }
        else
        {
            return a + b;
        }
    }
}
