using System;
using System.Globalization;

namespace Produto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public double Total;
        public int Quantidade;

        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
            Total = Quantidade * Preco;
        }

        public Produto(string nome,double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Total = Quantidade * Preco;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarEstoque()
        {
            Console.WriteLine("Digite a quantidade que vai ser inserida:");
            Quantidade = Quantidade + int.Parse(Console.ReadLine());
            Total = ValorTotalEmEstoque();
        }

        public void RemoverEstoque()
        {
            Console.WriteLine("Digite a quantidade que vai ser removida:");
            Quantidade = Quantidade - int.Parse(Console.ReadLine());
            Total = ValorTotalEmEstoque();
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString(CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: " + Total.ToString(CultureInfo.InvariantCulture);
        }
    }
}
