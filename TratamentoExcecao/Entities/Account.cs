using System;
using System.Collections.Generic;
using TratamentoExcecao.Entities.Exceptions;

namespace TratamentoExcecao.Entities
{
    class Account
    {
        public int NumeroConta { get; set; }
        public string NomeProprietario { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Account(int numeroConta, string nomeProprietario, double saldo, double limiteSaque)
        {
            NumeroConta = numeroConta;
            NomeProprietario = nomeProprietario;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            if (valor > Saldo)
            {
                throw new DomainException("Você não possui saldo.");
            }
            if (valor > LimiteSaque)
            {
                throw new DomainException("Este valor excede o limite de saque.");
            }

            Saldo -= valor;
        }



    }
}
