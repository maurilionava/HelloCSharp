// See https://aka.ms/new-console-template for more information
using HelloCSharp.CSharpBank;

Console.WriteLine("Hello CSharp");

Titular titular = new Titular("John Doe", "1233211233219");
Titular titularDestino = new Titular("Mary Doe", "9876789843334");
ContaCorrente contaCorrente = new ContaCorrente(titular, "1234", "123456");
ContaCorrente contaDestino= new ContaCorrente(titularDestino, "4321", "654321");

contaCorrente.Depositar(1000);
contaCorrente.Sacar(500);
contaCorrente.Transferir(250, contaDestino);