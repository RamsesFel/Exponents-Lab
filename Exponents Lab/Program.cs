while (true)
{
    Console.WriteLine("Enter an integer");
    int num = int.Parse(Console.ReadLine());
    if (num <= 0 || num >= 1290)
    {
        Console.WriteLine("Invalid input");
        continue;
    }

    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{i} \t");
        Console.Write($"{SquareNumber(i)} \t");
        Console.Write($"{CubedNumber(i)} \n");
    }
    Console.WriteLine("Would you like to enter another integer? y/n");
    string choice = Console.ReadLine();
    if (choice == "n")
    {
        break;
    }



    static int SquareNumber(int x)
    {
        return x * x;
    }

    static int CubedNumber(int x)
    {
        return x * x * x;
    }
}