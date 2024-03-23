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


        public Aluno(string nome, float nota1,float nota2, float nota3)
        {

            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;


        }




        public  float CalcularMediaPonderada()
        {
            MediaPonderada = (Nota1 * 0.3f + Nota2 * 0.35f + Nota3 * 0.35f ) /1;
            return MediaPonderada;

        }

        public static  string MediaAluno(Aluno Aluno)

        {
            

            

            if (Aluno.MediaPonderada >= 60)
            {
                return "\nAluno Aprovado";
            }
            else
            {
                float NotaFaltando = 60 - Aluno.MediaPonderada;
                return $"\n Aluno Reprovado Faltando {NotaFaltando} para o Aluno {Aluno.Nome} ser Aprovado";




            }
            
            
        }

        public override string ToString()
        {
            return $"Nome :{Nome} Media: {CalcularMediaPonderada()}, Situação: {MediaAluno(this)}";
        }




    }
}

