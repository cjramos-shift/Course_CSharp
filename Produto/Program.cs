using System;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.0, 10);
            Console.WriteLine(p);

            Produto p1 = new Produto("TV 2", 350.00);
            Console.WriteLine(p1);

            Produto p2 = new Produto();
            Console.WriteLine(p2);

            Produto p3 = new Produto()
            {
                Nome = "TV",
                Preco = 800.50,
                Quantidade = 5
            };
            Console.WriteLine(p3);
            /*
            string opcao;

            Console.WriteLine("Insira o nome do produto:");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Insira o preço:");
            p.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade no estoque:");
            p.Quantidade = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Escolha uma das opções a seguir:");
                Console.WriteLine("1. Valor total em estoque.");
                Console.WriteLine("2. Adicionar Estoque.");
                Console.WriteLine("3. Remover Estoque.");
                Console.WriteLine("4. Sair,");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    p.Total = p.ValorTotalEmEstoque();
                    Console.WriteLine("Dados do produto: " + p);
                    Console.WriteLine();
                }
                else if (opcao == "2")
                {
                    p.AdicionarEstoque();
                    Console.WriteLine("Dados do produto: " + p);
                }
                else if (opcao == "3")
                {
                    p.RemoverEstoque();
                    Console.WriteLine("Dados do produto: " + p);
                }
                else
                {
                    //Console.WriteLine(" ⣿⣿⡿⠋⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠈⠹⣿⣿⣿⣿⣿" +
                    //                  " ⠟⠋⠄⠄⠄⠄⠄⠄⠄⠄⠄⣀⣀⣠⣀⡀⠄⠄⠄⢀⣤⣴⣤⣄⠄⠈⢩⠟⣿⣿" +
                    //                  " ⠃⠄⠄⠄⠄⠄⠄⠄⠄⣠⡿⠉⠙⠻⣿⣿⣾⣶⣿⣿⡿⠋⠉⠙⠳⠄⠈⠄⣿⣿" +
                    //                  " ⠄⠄⠄⠄⠄⠄⠄⠄⢘⣯⠖⠙⠓⠄⠈⠙⠋⡉⠋⢉⠖⠛⠻⣦⡔⠄⠄⠄⢿⣿" +
                    //                  " ⠄⠄⠄⠄⠄⠄⠄⠄⢱⣿⣧⣒⣤⣶⣾⣱⣿⣭⣦⣿⣶⣖⣴⣿⣷⠄⠄⠄⠘⣿" +
                    //                  " ⠄⠄⠄⠄⠄⠄⠄⠄⠙⢛⣻⡿⡿⣻⣿⡿⣯⡹⢙⣿⣿⡻⣻⠛⠃⠄⠄⠄⠄⣙" +
                    //                  " ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠋⢠⣾⣿⣏⣧⣌⣛⣋⣠⣟⣿⣧⡁⠄⠄⠄⠄⠄⠈" +
                    //                  " ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠄⠄⠄⠄⠄⠄" +
                    //                  " ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠿⢛⣛⠉⣉⣉⣭⣍⣭⣉⡙⠛⢯⠄⠄⠄⠄⠄⣴" +
                    //                  " ⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣼⡿⠁⠿⠟⠿⠟⠿⠟⠟⣿⡇⠄⠄⠄⢀⣼⣿" +
                    //                  " ⣶⣆⠄⠄⠄⠄⠄⢀⠄⢰⠄⠄⢻⠃⠄⠄⠄⠄⠄⠄⠄⠄⢸⠃⠄⢠⣴⣿⣿⣿" +
                    //                  " ⣿⣿⣷⣀⠄⠄⠄⠠⠄⢸⠄⠄⠈⠄⠄⠄⠄⠄⠄⠈⠄⠄⠄⠄⣸⣿⣿⣿⣿⣿" +
                    //                  " ⣿⣿⣿⣿⣷⡀⠄⠄⠄⢸⡀⠄⠄⠄⠄⠄⠄⠄⠄⠄⣰⡜⠄⢸⣿⣿⣿⣿⣿⣿" +
                    //                  " ⣿⣿⣿⣿⣿⣿⣠⠄⠄⠈⣿⣷⣄⠄⠄⠄⠄⣠⣾⣿⡟⠄⢠⣿⣿⣿⣿⣿⣿⣿" +
                    //                  " ⣿⣿⣿⣿⣿⣿⣿⣷⡀⠄⢻⡟⣿⣦⣀⣠⣴⣿⣿⣿⡅⠄⣿⣿⣿⣿⣿⣿⣿⣿" +
                    //                  " ⣿⣿⣿⣿⣿⣿⣿⣿⣧⡄⠄⠁⠙⠼⢿⣿⣿⢿⠎⠁⢠⣾⣿⣿⣿⣿⣿⣿⣿⣿");
                    Console.WriteLine("Digite valores válidos");

                }
            } while (opcao != "4");
            */
        }
    }
}
