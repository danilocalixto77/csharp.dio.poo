using System;
using System.Collections.Generic;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;


namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Interfaces
            // ICalculadora calc1 = new Calculadora();
            // System.Console.WriteLine(calc1.Somar(10, 35));

            // //Classe Object
            // Computador computador1 = new Computador();
            // System.Console.WriteLine(computador1.ToString());

            // //Classe abstrata
            // Corrente conta1 = new Corrente();
            // conta1.Creditar(100);
            // conta1.ExibirSaldo();

            // //Polimorfismo em tempo de compilação exemplo 01
            // Calculadora calcdois = new Calculadora();
            // System.Console.WriteLine("Soma dois números " + calcdois.somar(1, 5));

            // Calculadora calctres = new Calculadora();
            // System.Console.WriteLine("Soma três números " + calctres.somar(1, 5, 10));


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

            ////////////////////////////////////////////////////////////////
            //Manipulação de Arquivo
            var caminho = "C:\\Projetos\\CSharp\\dio\\POO\\TrabalhandoArquivos";
            var destino = "C:\\Projetos\\CSharp\\dio\\POO\\TrabalhandoArquivos\\PastaViaCSharp";
            //var caminhoPathCombine1 = Path.Combine(caminho, "PastaViaCSharp", "SubPastaVia");
            //var caminhoPathCombine2 = Path.Combine(caminho, "Pasta1");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivobkp = Path.Combine(caminho, "arquivo-teste-backup.txt");
            var caminhoArquivoStream = Path.Combine(caminho, "arquivo-testestream.txt");
            var destinoArquivoStream = Path.Combine(destino, "SubPastaVia", "arquivo-testestream.txt");
            //var conteudoArquivo = "Olá estamos testando o conteúdo para um arquivo. Voltando ao terceiro teste";
            var listaString = new List<string> { "Teste de texto1", "Teste de texto2", "Teste de texto3", "Teste de texto4" };
            var listaStringContinuacao = new List<string> { "Teste de texto5", "Teste de texto6", "Teste de texto7", "Teste de texto8" };

            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorio(caminho);
            //helper.CriarDiretorio(caminhoPathCombine1);
            //helper.ApagarDiretorio(caminhoPathCombine2, true);
            //helper.CriarArquivoTexto(caminhoArquivo, conteudoArquivo);
            //helper.CriarArquivoTextoStream(caminhoArquivoStream, listaString);
            //helper.AdicionarTextoStream(caminhoArquivoStream, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivoStream);
            //helper.MoverArquivo(caminhoArquivoStream, destinoArquivoStream, false);
            //helper.CopiarArquivo(caminhoArquivo, caminhoArquivobkp, false);
            helper.DeletarArquivo(caminhoArquivobkp);

        }

    }
}


