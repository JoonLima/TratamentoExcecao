using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TratamentoExcecao.Entities;
using TratamentoExcecao.Entities.Exceptions;

namespace TratamentoExcecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Entre com os dados da conta:");
                Console.Write("Número: ");
                int numeroConta = int.Parse(Console.ReadLine());
                Console.Write("Proprietário: ");
                string nomeProprietario = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite de saque: ");
                double limiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(numeroConta, nomeProprietario, saldo, limiteSaque);

                Console.WriteLine();
                Console.Write("Entre com o valor para saque: ");
                account.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.WriteLine();
                Console.WriteLine($"Novo saldo: {account.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Erro no saque: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro no saque: {e.Message}");
            }
        }
    }
}
