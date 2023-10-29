
using System.Runtime.Serialization;
using System.Threading.Channels;

partial class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        int y = 0;

        double resultado = 0;

        FormatarTitulo("***   Calculadora console   ***");
        Console.WriteLine("Digite [1] para somar, [2] para subtrair, [3] para multiplicar e [4] para dividir e [5] para encerrar a aplicação");

        int opcaoEscolhida = 0;
        try
        {
            while (opcaoEscolhida != 5)
            {
                try
                {
                    opcaoEscolhida = int.Parse(Console.ReadLine()!);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                if (opcaoEscolhida == 1)
                {
                    Console.Clear();
                    Console.Write("1º valor: ");
                    x = int.Parse(Console.ReadLine()!);
                    Console.Write("2º valor: ");
                    y = int.Parse(Console.ReadLine()!);
                    resultado = soma(x, y);
                    ExibirResultado(resultado);
                    return;
                }

                if (opcaoEscolhida == 2)
                {
                    Console.Write("1º valor: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("2º valor: ");
                    y = int.Parse(Console.ReadLine());
                    resultado = subtracao(x, y);
                    ExibirResultado(resultado);
                    return;
                }

                if (opcaoEscolhida == 3)
                {
                    Console.Write("1º valor: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("2º valor: ");
                    y = int.Parse(Console.ReadLine());
                    resultado = multiplicacao(x, y);
                    ExibirResultado(resultado);
                    return;
                }

                if (opcaoEscolhida == 4)
                {
                    Console.Write("1º valor: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("2º valor: ");
                    y = int.Parse(Console.ReadLine());
                    resultado = multiplicacao(x, y);
                    ExibirResultado(resultado);
                    return;
                }
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
    static void ExibirResultado(double resultado)
    {
        Console.Clear();
        Console.WriteLine($"Resultado: [{resultado}]");
        Console.ReadKey();
    }

   static void FormatarTitulo(string titulo)
    {
        int tamanhoDoTitulo = titulo.Length;
        string escrever = string.Empty.PadLeft(tamanhoDoTitulo, '*');

        Console.WriteLine(escrever);
        Console.WriteLine(titulo);
        Console.WriteLine(escrever + "\n\n");

    }
}
