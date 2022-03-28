using DIO.Bank.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Bank
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }

        public Conta(TipoConta tipoConta, string nome, double saldo, double credito)
        {
            TipoConta = tipoConta;
            Nome = nome;
            Saldo = saldo;
            Credito = credito;
        }

        public void Sacar(double valor)
        {

            if (valor < Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente !");
            }
        }

        public void Transferir(double valor, Conta contaDestino)
        {

            if (valor < Saldo)
            {
                Saldo -= valor;
                contaDestino.Depositar(valor);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente !");
            }
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return "Dados " +
                "\nNome: " + Nome +
                "\nSaldo: " + Saldo +
                "\nCredito: " + Credito;

        }

    }


}