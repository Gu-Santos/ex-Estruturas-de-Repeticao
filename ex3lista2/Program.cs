using System;

namespace ex3lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int salario;
            string nome;
            string estado_civil;

            do
            {
                Console.WriteLine("Digite seu nome");
                nome = Console.ReadLine();

            } while (nome == "");


            do
            {
                Console.WriteLine("Insira a sua idade");
                idade = int.Parse(Console.ReadLine());

            } while (idade <= 0 || idade > 150);

            do
            {
                Console.WriteLine("Insira o seu salário");
                salario = int.Parse(Console.ReadLine());
            } while (salario == 0);

            bool validacao = false;
            do
            {
                Console.WriteLine(@"Qual o seu estado civil? s (solteiro(a)) c (casado(a)) v (viuvo(a)) d (divorciado(a))");
                estado_civil = Console.ReadLine().ToLower();


                switch (estado_civil)
                {
                    case "s":
                    case "c":
                    case "v":
                    case "d":
                    validacao = true;

                        break;
                    default: Console.WriteLine("Resposta incorreta");
                        break;
                }

            } while (validacao == false);

            Console.WriteLine("Seu nome é " + nome + " você tem " + idade + " anos, você ganha R$" + salario + " e você é " + estado_civil);





        }
    }
}
