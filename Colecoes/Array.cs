using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
       public static void Executar() {
            string[] alunos = new string[5]; //[]alunos
            alunos[0] = "Mateus";
            alunos[1] = "Mateus";
            alunos[2] = "Mateus";
            alunos[3] = "Mateus";
            alunos[4] = "Mateus";

            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);   
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach(var nota in notas) {
                somatorio += nota;
            }

            //for(int i = 0; i < notas.Length; i++) {
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra); 
        }
    }
}
