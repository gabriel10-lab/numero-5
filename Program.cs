while(true)
{    
    Console.WriteLine("--- Fluxograma da engenharia ---");

    Console.WriteLine("esta se movendo? (S/N)");

    ConsoleKey pressione = Console.ReadKey(true).Key;

    if (pressione == ConsoleKey.S)
    {
        Console.WriteLine("deveria?");
        ConsoleKey pressione2 = Console.ReadKey(true).Key;

        if (pressione2 == ConsoleKey.S)
        {
            Console.WriteLine("é isso ai!");
        }
        else if (pressione2 == ConsoleKey.N)
        {
            Console.WriteLine("use silver");
        }
        else
        {
            Console.WriteLine("opcao invalida");
        }
    }
    else if (pressione == ConsoleKey.N)
    {
        Console.WriteLine("deveria?");
        ConsoleKey pressione2 = Console.ReadKey(true).Key;

        if (pressione2 == ConsoleKey.S)
        {
            Console.WriteLine("use WD-40");
        }
        else if (pressione2 == ConsoleKey.N)
        {
            Console.WriteLine("é isso ai!");
        }
        else
        {
            Console.WriteLine("opcao invalida");
        }
    }
    else
    {
        Console.WriteLine("opcao invalida");
    }
}