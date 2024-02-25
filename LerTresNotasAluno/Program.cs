using System;

namespace LerTresNotasAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o Nome do Aluno");
            string Nome = Console.ReadLine();
            Console.WriteLine("Informe a Nota do  Aluno no Primeiro Trimestre");
            float Nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Nota do  Aluno no Primeiro Segundo");
            float Nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Nota do  Aluno no Primeiro Terceiro");
            float Nota3 = float.Parse(Console.ReadLine());
            float MediaPonderada = (Nota1 * 30  + Nota2 * 35  + Nota3 * 35) / 100;
            Console.WriteLine($"A Média do Aluno {Nome} é: {MediaPonderada}");

             if(MediaPonderada>=60)
            {
                Console.WriteLine("\nAluno Aprovado");
            }
             else
            {
                Console.WriteLine("\nAluno Reprovado");

                float NotaFaltando = (60 - MediaPonderada);

                Console.WriteLine($"\nFaltando {NotaFaltando} para o aluno ser aprovado");

            }


        }
    }
}
