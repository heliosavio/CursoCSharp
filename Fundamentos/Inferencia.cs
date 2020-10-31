using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            var nome = "Hélio";
            //não é possível atribuir outro tipo de dados a essa variável (var)
            Console.WriteLine(nome);

            var idade = 49; // variaveis inferidas precisam ser inicializadas
            Console.WriteLine("Idade: " + idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);

        }
    }
}
