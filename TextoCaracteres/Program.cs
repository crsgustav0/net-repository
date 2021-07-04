using System;

namespace TextoCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando TextoCaracteres...");

            char primeiraLetra = 'a';
            finalizarExecucao(primeiraLetra);
        }

        private static void finalizarExecucao(char conteudo)
        {
            Console.WriteLine(conteudo);
            Console.WriteLine("A execução acabou. Tecle Enter para finalizar... ");
            Console.ReadLine();
        }
    }
}
