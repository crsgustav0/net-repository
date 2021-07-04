using System;

namespace TextoCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando TextoCaracteres...");

            string primeiraLetra = @"a" +
                "Conteudo:" +
                "Concatenado";
            finalizarExecucao(primeiraLetra);
        }

        private static void finalizarExecucao(string conteudo)
        {
            Console.WriteLine(conteudo);
            Console.WriteLine("A execução acabou. Tecle Enter para finalizar... ");
            Console.ReadLine();
        }
    }
}
