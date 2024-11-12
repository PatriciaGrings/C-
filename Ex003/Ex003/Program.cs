using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection.Metadata;

namespace Ex003 {
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Digite o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());
            double calculo = (raio) * 5;
            Console.WriteLine(calculo);

        }
    }
}
