using System;

namespace seglistaentrezeroedez
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            do
            {
                Console.WriteLine("Insira uma nota entre 0-10");
                nota = int.Parse(Console.ReadLine());


            } while (nota < 0 || nota > 10);

            Console.WriteLine("A nota digitada foi " + nota);

        }
    }
}



