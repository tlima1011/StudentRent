using System;
namespace StudentRent;

internal class Program
{
    static void Main(string[] args)
    {

        Student [] rooms = new Student[10];

        Console.Write("Quantos quartos serão alugados? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Aluguel #{0}\n", (i+1));
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Quarto: ");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (rooms[i] == null)
            {
                rooms[quarto] = new Student {Name = name, Email = email};
            }
        }

        Console.WriteLine("Quartos Ocupados");
        for(int i = 0; i < 10; i++)
        {
            if (rooms[i] != null)
            {
                Console.WriteLine("{0}: {1}", i, rooms[i]);
            }
        }

        /*Aluguel #1:
        Nome: Maria Green
        Email: maria @gmail.com
        Quarto: 5*/


    }
}
