using static System.Console;

namespace AchaiahVibe
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaProduto();
        }

        static void CalculaProduto()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do produto a ser calculado: ");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine($"Qual valor de produçao de {nomeProduto}: ");
            double valorProducao = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora trabalhada: ");
            double horaTrabalho = double.Parse(Console.ReadLine());

            double valorProduto = valorProducao + horaTrabalho;

            Console.WriteLine($"O valor do produto é {valorProduto}");

            Console.WriteLine("Digite a porcentagem de lucro desejada: ");

            double percentualLucro = double.Parse(Console.ReadLine());

            double lucro = valorProduto * percentualLucro / 100;

            Console.WriteLine($"valor do lucro é de {lucro.ToString("C")}");

            double valorFinalProduto = valorProduto + lucro;

            Console.WriteLine($"O valor final do produto {nomeProduto} é de: {valorFinalProduto.ToString("C")}");
            Console.WriteLine("Aperte [ENTER] para calcular outro produto...");
            Console.ReadLine();

            CalculaProduto();
        }

    }
}