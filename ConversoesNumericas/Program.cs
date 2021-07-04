using System;

namespace ConversoesNumericas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando ConversoesNumericas..");
            Console.WriteLine("Execução finalizada. Tecle enter para continuar.");

            double salario;
            salario = 1200.50;

            int salarioInteiro;
            salarioInteiro = (int)salario;

            Console.WriteLine(salario);

            Console.ReadLine();
        }
    }
}
