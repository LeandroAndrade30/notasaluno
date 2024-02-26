using System;

namespace LerTresNotasAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno Aluno = new Aluno();

            Console.WriteLine("Informe o Nome do Aluno");
             Aluno.Nome = Console.ReadLine();
            Console.WriteLine("Informe a Nota do  Aluno no Primeiro Trimestre");
            Aluno.Nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Nota do  Aluno no Primeiro Segundo");
            Aluno.Nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Nota do  Aluno no Primeiro Terceiro");
            Aluno.Nota3= float.Parse(Console.ReadLine());
            float MediaPonderada = Aluno.CalcularMediaPonderada();
            float mediaAluno = Aluno.MediaAluno(Aluno);
            
            

        }
    }
}


