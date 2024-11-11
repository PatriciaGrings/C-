using System;
using System.Globalization;

namespace Ex002 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine("A soma dos dois números é: " + soma);

        }
    }
}