using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
       public static void Recepicionar(params string[] pessoas) {
            foreach(var pessoa in pessoas) {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }

        public static void Executar() {
            Recepicionar("Mateus", "Mateus", "50 de braço", "Deus grego");
        }
    }
}
