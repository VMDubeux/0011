using System;
namespace Exercicio
{
    class ProjetoOnze
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua senha:");
            int senha = int.Parse(Console.ReadLine());
            while (senha != 2002)
            {
                Console.WriteLine("Senha Inválida. Tente novamente.");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido.");
        }
    }
}