using System;
using POO_Dio.Models;

namespace POO_Dio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Herança

            Aluno a1 = new Aluno();
            a1.nome = "LOL";
            a1.idade = 98;
            a1.nota = 35;
            a1.Apresentar();

            Professor pr1 = new Professor();
            pr1.nome = "Kleber";
            pr1.idade = 57;
            pr1.salario = 2500;
            pr1.Apresentar();
           
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

            Pessoa p1 = new Pessoa();
            p1.nome = "Matheus";
            p1.idade = 55;
            p1.Apresentar();
        }

    }

}