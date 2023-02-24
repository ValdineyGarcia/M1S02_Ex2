using System;
namespace M1S02_Ex2
{
    public class FichaInscricao
    {
        public int Id { get; set;}
        public string Nome { get; set;}
        public DateTime DataNascimento { get; set;}
        public bool MenorIdade { get; set;}

        public FichaInscricao(int id, string nome, DateTime dataNascimento, bool menorIdade ) 
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            MenorIdade = menorIdade;              
        }


public void RetornaTexto() 
        {
    Console.WriteLine($" Nome {Nome}, Data Nascimento {DataNascimento}");
        }
}
}
