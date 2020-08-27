using ContaBancaria.Entidades;
using ContaBancaria.Entidades.Exceptions;
using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados da conta.");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine());
            Console.Write("limite de saque: ");
            double limiteSaque = double.Parse(Console.ReadLine());
            Conta conta = new Conta(numero, nome, saldo, limiteSaque);
            Console.WriteLine();

            try
            {
                Console.Write("Entre com o valor do saque: ");
                double valor = double.Parse(Console.ReadLine());
                conta.Saque(valor);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro ao executar a acao: " + e.Message);
            }

        }
    }
}
