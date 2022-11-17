using System;
using POO_Dio.Models;

namespace POO_Dio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulamento
            // Valores Validos
            Retangulo r1 = new Retangulo();
            r1.DefinirMedidas(25, 73);

            Console.WriteLine($"Area: {r1.ObterArea()}");

            // Valores Invalidos
            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(0, -73);

            Console.WriteLine($"Area: {r2.ObterArea()}");



            // Abstração
            // Pessoa p1 = new Pessoa();
            // p1.nome = "Matheus";
            // p1.idade = 55;
            // p1.Apresentar();
        }

    }

}