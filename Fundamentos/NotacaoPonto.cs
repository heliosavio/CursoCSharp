using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "Hello".ToUpper().Replace("HELLO", "Olá").Insert(3, " World!")
                .Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);
            Console.WriteLine($"Hello".ToUpper().Replace("HELLO", "Olá").Insert(3, " World!")
                .Replace("World", "Mundo"));
            Console.WriteLine("Teste".Length);
            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); //O ? é a navegação segura
        }
    }
}
