using System;

class Program
{
    static void Main()
    {
        int summa = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Skriv in heltal nummer {i}: ");
            int tal = int.Parse(Console.ReadLine());
            summa += tal;
        }

        Console.WriteLine($"Summan av de inmatade talen är: {summa}");
    }
}
