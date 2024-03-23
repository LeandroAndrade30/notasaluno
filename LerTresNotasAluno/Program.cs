using System;

namespace LerTresNotasAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Informe o Nome do Aluno");
              string nome = Console.ReadLine();
            Console.WriteLine("Informe a Nota do  Aluno no Primeiro Trimestre");
              float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Nota do  Aluno no Primeiro Segundo");
            float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Nota do  Aluno no Primeiro Terceiro");
            float nota3= float.Parse(Console.ReadLine());
            Aluno Aluno = new Aluno(nome,nota1,nota2,nota3);
            Console.WriteLine(Aluno);




        }
    }
}


