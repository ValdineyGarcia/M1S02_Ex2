using System;
using System.Collections.Generic;
using System.Linq;

namespace M1S02_Ex2
{
    public class FichaInscricao
    {
        public int Id { get; set;}
        public string Nome { get; set;}
        public DateTime DataNascimento { get; set;}
        public bool MenorIdade { get; set;}

        public FichaInscricao(int id, string nome, dataNascimento datetime dataNascimento, bool menorIdade ) 
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            MenorIdade = menorIdade;              
        }


public void RetornaTexto() 
        {
    Console.WriteLine($" Nome {nome}, Data Nascimento {dataNascimento}");
        }
}
}
