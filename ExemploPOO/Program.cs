using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno pessoa2 = new Aluno();
            pessoa2.Nome = "Lucas";
            pessoa2.Idade = 7;
            pessoa2.Nota = 10;
            pessoa2.Documento = "123";
            pessoa2.Apresentar();

            Professor pessoa3 = new Professor();
            pessoa3.Nome = "Luciana";
            pessoa3.Idade = 41;
            pessoa3.Salario = 1500;
            pessoa3.Documento = "456";
            pessoa3.Apresentar();


            // //Encapsulamento
            // //Valores válidos
            // Retangulo reta1 = new Retangulo();
            // reta1.DefinirMedidas(10, 5.5);
            // System.Console.WriteLine($"Área: {reta1.ObterArea()}");
            // //Valores inválidos
            // Retangulo reta2 = new Retangulo();
            // reta2.DefinirMedidas(0, -5.5);
            // System.Console.WriteLine($"Área: {reta2.ObterArea()}");

            // Abstração
            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Danilo";
            // p1.Idade = 46;
            // p1.Apresentar();

        }

    }
}


