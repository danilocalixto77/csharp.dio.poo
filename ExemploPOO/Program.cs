using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polimorfismo em tempo de compilação exemplo 01
            Calculadora calcdois = new Calculadora();
            System.Console.WriteLine("Soma dois números " + calcdois.somar(1, 5));

            Calculadora calctres = new Calculadora();
            System.Console.WriteLine("Soma três números " + calctres.somar(1, 5, 10));


            // //Polimorfismo em tempo de execução exemplo 01
            // Aluno pessoa4 = new Aluno();
            // pessoa4.Nome = "Eliel";
            // pessoa4.Idade = 65;
            // pessoa4.Documento = "123456";
            // pessoa4.Nota = 10;
            // pessoa4.Apresentar();
            // //Polimorfismo em tempo de execução exemplo 02
            // Professor pessoa5 = new Professor();
            // pessoa5.Nome = "Eliel";
            // pessoa5.Idade = 65;
            // pessoa5.Documento = "123456";
            // pessoa5.Salario = 1250;
            // pessoa5.Apresentar();

            // //Herança Exemplo1
            // Aluno pessoa2 = new Aluno();
            // pessoa2.Nome = "Lucas";
            // pessoa2.Idade = 7;
            // pessoa2.Nota = 10;
            // pessoa2.Documento = "123";
            // pessoa2.Apresentar();
            // //Herança Exemplo1
            // Professor pessoa3 = new Professor();
            // pessoa3.Nome = "Luciana";
            // pessoa3.Idade = 41;
            // pessoa3.Salario = 1500;
            // pessoa3.Documento = "456";
            // pessoa3.Apresentar();

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


