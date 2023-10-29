partial class Program
{
    static void Main(string[] args)
    {
        double x, y;  

        double resultado = 0;

        int operacaoEscolhida = 0;

        try
        {
            
            while (operacaoEscolhida != 5)
            {
                FormatarTitulo("***   Calculadora console   ***");
                Console.WriteLine("Digite [1] para somar, [2] para subtrair, [3] para multiplicar e [4] para dividir e [5] para encerrar a aplicação");

                try
                {
                    operacaoEscolhida = int.Parse(Console.ReadLine()!);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                if (operacaoEscolhida == 1)
                {
                    Console.Clear();
                    Console.Write("1º valor: ");
                    x = double.Parse(Console.ReadLine()!);
                    Console.Write("2º valor: ");
                    y = double.Parse(Console.ReadLine()!);
                    resultado = soma(x, y);
                    ExibirResultado(resultado);
                }

                if (operacaoEscolhida == 2)
                {
                    Console.Write("1º valor: ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("2º valor: ");
                    y = double.Parse(Console.ReadLine());
                    resultado = subtracao(x, y);
                    ExibirResultado(resultado);
                }

                if (operacaoEscolhida == 3)
                {
                    Console.Write("1º valor: ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("2º valor: ");
                    y = double.Parse(Console.ReadLine());
                    resultado = multiplicacao(x, y);
                    ExibirResultado(resultado);
                }

                if (operacaoEscolhida == 4)
                {
                    Console.Write("1º valor: ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("2º valor: ");
                    y = double.Parse(Console.ReadLine());
                    resultado = multiplicacao(x, y);
                    ExibirResultado(resultado);
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static void ExibirResultado(double resultado)
    {
        Console.Clear();
        Console.WriteLine($"Resultado: [{resultado}]");
        return;
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
