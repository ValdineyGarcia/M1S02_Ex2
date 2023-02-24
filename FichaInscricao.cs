using System;
namespace M1S02_Ex2
{
    public class FichaInscricao
    {
        public int Id { get; set;}
        public string Nome { get; set;}
        public string DataNascimento { get; set;}
        public bool MenorIdade { get; set;}

        public FichaInscricao(int id, string nome, string dataNascimento, bool menorIdade ) 
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            MenorIdade = menorIdade;              
        }

        public string ValidaIdade()
        {

if (MenorIdade == true)
            {
                return "Sim";
            }
else
            {
                return "Não";
            }
        }

public void RetornaTexto() 
        {
    Console.WriteLine($"Código: {Id}, Nome: {Nome}, Data Nascimento: {DataNascimento}. Menor de idade? {ValidaIdade()}");
        }
}
}
