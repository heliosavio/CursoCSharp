using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
/// <summary>
/// 
/// </summary>
class Comentarios {
        public static void Executar() {
            //Cuidado com os comentários desnecessários
            Console.WriteLine("Código claro é sempre melhor!");
            /*
             * Esse é um comentário
             * de múltiplas linhas...
             */ 
            Console.WriteLine("O C# tem o XML Comments");
            Console.WriteLine("Tenha um código limpo e claro");
            Console.WriteLine("//Comentário de uma linha");
            Console.WriteLine("/* Comentário de multiplas linhas */");

            //Para adicionar comentários usando atalhos do teclado:
            //    Ctrl KC -Comenta // Ctrl KU - Remove o comentário
        }
    }
}
