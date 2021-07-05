using System;

namespace nomeusuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a sua senha: ");
            string senha = Console.ReadLine();

            while (nome == senha)
            {
                Console.WriteLine("A senha não pode ser igual a seu nome, digite uma senha diferente de seu nome: ");
                senha = Console.ReadLine();

            }
        }
    }
}
