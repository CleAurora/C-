using System;

namespace ex32OOex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa para gerenciar conta corrente.
            System.Console.WriteLine("Bem vindo - Sportore Bank");

            new ContaCorrente(); //através do new, eu instanciei, eu criei minha CC.

            ContaCorrente conta1 = new ContaCorrente();

            // se eu digito conta1. - meus atributos, que foram definidos como público no conta 1 aparecem aqui.

            conta1.titular = "Cesar";
            conta1.agencia = 132;
            conta1.numeroConta = 999;
            conta1.Depositar(10000);

            ContaCorrente conta2 = new ContaCorrente();

            conta2.titular = "Tsukamoto";
            conta2.agencia = 132;
            conta2.numeroConta = 01;
            conta2.Depositar(5000);

            System.Console.WriteLine($"----- Primeira Conta ------");
            System.Console.WriteLine($"Titular: {conta1.titular}");
            System.Console.WriteLine($"Agência: {conta1.agencia}");
            System.Console.WriteLine($"Número da Conta: {conta1.numeroConta}");
            System.Console.WriteLine($"Saldo: {conta1.ExibirSaldo()}");
            System.Console.WriteLine("---------------------------");


            System.Console.WriteLine($"----- Segunda Conta ------");
            System.Console.WriteLine($"Titular: {conta2.titular}");
            System.Console.WriteLine($"Agência: {conta2.agencia}");
            System.Console.WriteLine($"Número da Conta: {conta2.numeroConta}");
            System.Console.WriteLine($"Saldo: {conta2.ExibirSaldo()}");
            System.Console.WriteLine("---------------------------");

            // bool valorRetornado = conta1.Sacar(3500);
            // if (valorRetornado){
            //     System.Console.WriteLine("Parabéns, você conseguiu!");
            // }else{
            //     System.Console.WriteLine("Você não tem dinheiro na conta");
            // }

            // //System.Console.WriteLine($"{valorRetornado}");
            // System.Console.WriteLine($"Saldo depois do saque: {conta1.ExibirSaldo()}");
            

            conta2.Transferir(1000, conta1);

            System.Console.WriteLine($"Saldo conta 1: {conta1.ExibirSaldo()}");

            System.Console.WriteLine($"Saldo conta 2: {conta2.ExibirSaldo()}");
        }
    }
}
