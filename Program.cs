namespace ArrayAssignment;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hur stor vill du att listan ska vara?");
        int size = int.Parse(Console.ReadLine()!);
        int [] antal = new int[size];
        Console.WriteLine($"Listan har {antal.Length} platser.");
        
        for (int number = 0; number < antal.Length; number++)
        {
            Console.WriteLine($"Skriv in ett tal för plats {number + 1}:");
            antal[number] = int.Parse(Console.ReadLine()!);
        }

        for (int number = 0; number < antal.Length; number++)
        {
            Console.WriteLine($"Plats {number + 1} har värdet: {antal[number]}");
        }

        Console.WriteLine($"Summan av talen är: {antal.Sum()}");
        Console.WriteLine($"Medelvärdet av talen är: {antal.Average()}");
        

    }
}
