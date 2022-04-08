namespace AchaiahVibe
{
    public class Produto
    {
        public Produto(string nomeProduto,
        double valorProducao,
        double horaTrabalho,
        double valorProduto,
        double percentualLucro,
        double lucro,
        double valorFinalProduto)
        {
            this.nomeProduto = nomeProduto;
            this.valorProduto = valorProduto;
            this.valorProducao = valorProducao;
            this.horaTrabalho = horaTrabalho;
            this.percentualLucro = percentualLucro;
            this.lucro = lucro;
            this.valorFinalProduto = valorFinalProduto;

        }
        public Produto()
        { }

        public string nomeProduto;
        public double valorProduto;
        public double valorProducao;
        public double horaTrabalho;
        public double percentualLucro;
        public double lucro;
        public double valorFinalProduto;



        public void AplicaPorcentagem()
        {
            Console.WriteLine("Digite a porcentagem de lucro desejada: ");
            this.percentualLucro = double.Parse(Console.ReadLine());
            this.lucro = valorProduto * percentualLucro / 100;
            Console.WriteLine($"valor do lucro é de {lucro.ToString("C")}");
            this.valorFinalProduto = valorProduto + lucro;
            Console.WriteLine($"O valor final do produto {nomeProduto} é de: {valorFinalProduto.ToString("C")}");
            Console.WriteLine(@"Deseja aplicar outra porcentagem? Digite 'S' ou 'N'");
            string resposta = Console.ReadLine();
            if (resposta.ToUpper().Contains("S")) AplicaPorcentagem();
            Console.WriteLine("Aperte [ENTER] para calcular outro produto...");
            Console.ReadLine();

        }

        public void CalculaProduto()
        {
            Console.WriteLine("Digite o nome do produto a ser calculado: ");
            this.nomeProduto = Console.ReadLine();
            Console.WriteLine($"Qual valor de produçao de {nomeProduto}: ");
            this.valorProducao = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora trabalhada: ");
            this.horaTrabalho = double.Parse(Console.ReadLine());

            this.valorProduto = valorProducao + horaTrabalho;
            Console.WriteLine($"O valor do produto é {valorProduto}");


        }

    }

}