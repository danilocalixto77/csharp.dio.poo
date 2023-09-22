using System;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Documento { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, neu nome é {Nome} e tenho {Idade} anos");
        }

    }
}