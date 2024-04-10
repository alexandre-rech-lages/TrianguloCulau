namespace TrianguloOrientado;

internal class Program
{
    static void Main(string[] args)
    {
        Triangulo t1 = new Triangulo();
        t1.ladoX = 1;
        t1.ladoY = 2;
        t1.ladoZ = 3;

        Console.WriteLine( "O tipo do primeiro trinagulo é " + t1.ObterTipo() );

        Triangulo t2 = new Triangulo();
        t2.ladoX = 1;
        t2.ladoY = 2;
        t2.ladoZ = 3;

        Console.WriteLine("O tipo do segundo trinagulo é " + t2.ObterTipo());

        Triangulo t3 = new Triangulo();
        t3.ladoX = 1;
        t3.ladoY = 2;
        t3.ladoZ = 3;

        Console.WriteLine("O tipo do terceiro trinagulo é " + t3.ObterTipo());

    }

    static void Main2(string[] args)
    {       
        while (true)
        {
            ApresentarCabecalho();

            Triangulo novoTriangulo = new Triangulo();

            Console.WriteLine("Para informar o tipo de triangulo é necessário informar o tamanho dos 3 lados\n");

            novoTriangulo.ladoX = LerDecimal("\nDigite o valor do primeiro lado: ");
            novoTriangulo.ladoY = LerDecimal("\nDigite o valor do segundo lado: ");
            novoTriangulo.ladoZ = LerDecimal("\nDigite o valor do terceiro lado:  ");

            string tipo = novoTriangulo.ObterTipo();

            if (tipo == "Triângulo Inválido")            
                ApresentarMensagemErro();
            else
                ApresentarMensagemSucesso(tipo);            
        }
    }

    private static void ApresentarMensagemSucesso(string tipo)
    {
        Console.WriteLine("O tipo do Triângulo é: " + tipo);
        Console.ReadKey();
    }

    private static void ApresentarMensagemErro()
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
    }

    static void ApresentarCabecalho()
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
    
    static decimal LerDecimal(string texto)
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
            ApresentarCabecalho();
        }
    }
}