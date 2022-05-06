namespace AchaiahVibe
{
    public class Produto
    {
        public string nomeProduto;
        public double valorProduto;
        public double valorProducao;
        public double horaTrabalho;
        public double percentualLucro;
        public double lucro;
        public double valorFinalProduto;

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
        public void CriarDiretorioProdutos()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "CalculoProdutos");
            if (!Directory.Exists(path))
            {
                var pastaArquivos = Directory.CreateDirectory(path);
            }

        }
        public void CriarArquivo()
        {
            var nomeArquivo = this.nomeProduto + ".txt";
            var path = Path.Combine(@"C:\\workspace\AchaiahVibe\CalculoProdutos", nomeArquivo);
            if (!File.Exists(path))
            {
                using var sw = File.CreateText(path);
                sw.WriteLine($"Valor da produção de {this.nomeProduto}: {this.valorProducao.ToString("C")}");
                sw.WriteLine($"Valor hora trabalho: {this.horaTrabalho.ToString("C")}");
                sw.WriteLine($"Percentual de lucro: {this.percentualLucro.ToString("P01")}");
                sw.WriteLine($"Valor do produto: {this.valorProduto.ToString("C")}");
                sw.WriteLine(this.lucro.ToString("C"));
                sw.WriteLine(this.valorFinalProduto.ToString("C"));
            }
        }



    }

}