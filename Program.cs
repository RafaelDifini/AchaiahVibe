using static System.Console;

namespace AchaiahVibe
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto();

            produto.CalculaProduto();
            produto.AplicaPorcentagem();
            Console.Clear();
            produto.CalculaProduto();
        }
    }
}