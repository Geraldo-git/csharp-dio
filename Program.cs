using DIO.Bank.Enum;
using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta cp1 = new Conta(TipoConta.PessoaFisica, "Maria", 0, 0);


            Console.WriteLine(cp1.ToString());
        }
    }
}
