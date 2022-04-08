using static System.Console;

namespace AchaiahVibe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Produto produto = new Produto();

            produto.CalculaProduto();
            produto.AplicaPorcentagem();
            produto.CalculaProduto();
        }
    }
}