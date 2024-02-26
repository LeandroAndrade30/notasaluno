using System;
using System.Collections.Generic;
using System.Text;

namespace LerTresNotasAluno
{
    class Aluno
    {
        public string Nome;
        public float Nota1;
        public float Nota2;
        public float Nota3;
        public float MediaPonderada;




        public  float CalcularMediaPonderada()
        {
            MediaPonderada = (Nota1 * 0.3f + Nota2 * 0.35f + Nota3 * 0.35f ) /1;
            return MediaPonderada;

        }

        public static  float MediaAluno(Aluno Aluno)

        {
            

            Console.WriteLine($"A Média do Aluno {Aluno.Nome} é: {Aluno.MediaPonderada}");

            if (Aluno.MediaPonderada >= 60)
            {
                Console.WriteLine("\n Aluno Aprovado\n");
            }
            else
            {
                Console.WriteLine("\n Aluno Reprovado\n");

                float NotaFaltando = (60 - Aluno.MediaPonderada);

                Console.WriteLine($"Faltando {NotaFaltando } para o aluno {Aluno.Nome} ser aprovado");
                
            }
            return Aluno.MediaPonderada;
            
        }
    }
}

