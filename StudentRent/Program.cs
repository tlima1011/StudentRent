using System;
namespace StudentRent;

internal class Program
{
    static void Main(string[] args)
    {

        int[] rooms = new int[10];

        Console.Write("Quantos quartos serão alugados? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Aluguel #{0}\n", (i+1));
        }

        /*Aluguel #1:
        Nome: Maria Green
        Email: maria @gmail.com
        Quarto: 5*/


    }
}
