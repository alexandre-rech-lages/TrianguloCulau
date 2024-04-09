using System.Reflection;

namespace TrianguloOrientado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            while (op == 1)
            {
                Funcoes.Cabecalho();
                decimal ld1 = Funcoes.LerDecimal("Para informar o tipo de triangulo é necessário informar o tamanho dos 3 lados.\n\nDigite o valor do primeiro lado: ");
                decimal ld2 = Funcoes.LerDecimal("\nDigite o valor do segundo lado: ");
                decimal ld3 = Funcoes.LerDecimal("\nDigite o valor do terceiro lado:  ");
                op = Funcoes.Verificacao(ld1, ld2, ld3);
                if (op == 1)
                {
                    continue;
                }
                string resultado = Funcoes.Equacao(ld1, ld2, ld3);
                op = Funcoes.Resaida(resultado);
            }
        }
    }

    public class Funcoes
    {
        public static void Cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.WriteLine("######################################################################################");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                          Academia do programador 2024                          ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("###                                   TRIÂNGULOS                                   ###");
            Console.WriteLine("###                                                                                ###");
            Console.WriteLine("######################################################################################\n\n");
        }
        public static int LerInt(string texto)
        {
            while (true)
            {
                Console.Write(texto);
                var digitouNumero = int.TryParse(Console.ReadLine(), out var numero);

                if (digitouNumero)
                {
                    return numero;
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine("\n\n######################################################################################");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                                     ATENÇÃO                                    ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###              Comando inválido. Por favor digite um numero válido.              ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                     Precione qualquer tecla para continuar.                    ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("######################################################################################");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.ReadKey();
                Cabecalho();
            }
        }
        public static decimal LerDecimal(string texto)
        {
            while (true)
            {
                Console.Write(texto);
                var digitouNumero = decimal.TryParse(Console.ReadLine(), out var numero);

                if (digitouNumero)
                {
                    return numero;
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine("\n\n######################################################################################");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                                     ATENÇÃO                                    ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###              Comando inválido. Por favor digite um numero válido.              ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                     Precione qualquer tecla para continuar.                    ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("######################################################################################");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.ReadKey();
                Cabecalho();
            }
        }
        public static int Verificacao(decimal ld1, decimal ld2, decimal ld3)
        {
            decimal aux1 = (ld1 + ld2) - ld3;
            decimal aux2 = (ld1 + ld3) - ld2;
            decimal aux3 = (ld2 + ld3) - ld1;
            int op = 0;
            if (aux1 < 0 || aux2 < 0 || aux3 < 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine("\n\n######################################################################################");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                                     ATENÇÃO                                    ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###       Para um triangulo ser válido é necessário que a soma de dois lados       ###");
                Console.WriteLine("###       seja maior que um dos lados. Verifique os dados e tente novamente.       ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("###                     Precione qualquer tecla para continuar.                    ###");
                Console.WriteLine("###                                                                                ###");
                Console.WriteLine("######################################################################################");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.ReadKey();
                op = 1;
            }
            return op;
        }
        public static string Equacao(decimal ld1, decimal ld2, decimal ld3)
        {
            string resultado = "Se você está lendo isso, lamento, mas o programa bugou :(\n\nReinicie-me por favor.";
            if (ld1 == ld2 && ld2 == ld3)
            {
                resultado = "Equilátero";
            }
            else if ((ld1 == ld2 && ld2 != ld3) || (ld2 == ld3 && ld2 != ld1))
            {
                resultado = "Isósceles";
            }
            else if ((ld1 != ld2 && ld2 != ld3 && ld3 != ld1))
            {
                resultado = "Escaleno";
            }
            return resultado;
        }        
        public static int Resaida(string resultado)
        {
            int op = 1;
            while (true)
            {
                Cabecalho();
                op = LerInt($"O triangulo é {resultado}.\n\n\nEscolha uma opção\n\n1. Reconhecer outro triangulo\n2. Sair\nSua opção: ");
                if (op != 1 && op != 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.WriteLine("\n\n######################################################################################");
                    Console.WriteLine("###                                                                                ###");
                    Console.WriteLine("###                                     ATENÇÃO                                    ###");
                    Console.WriteLine("###                                                                                ###");
                    Console.WriteLine("###      Comando inválido. Por favor digite um numero correspondente ao menu.      ###");
                    Console.WriteLine("###                                                                                ###");
                    Console.WriteLine("###                     Precione qualquer tecla para continuar.                    ###");
                    Console.WriteLine("###                                                                                ###");
                    Console.WriteLine("######################################################################################");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.ReadKey();
                    continue;
                }
                return op;
            }
        }
    }
}