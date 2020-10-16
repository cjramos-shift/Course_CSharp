using System;
using System.Globalization;

namespace Course_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Bruh";
            double preco1 = 100.27556059029092090;
            double potencia = 10;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"O {produto1} custa {preco1:F5} e é um lixo de caro;");
            Console.WriteLine(Math.Pow(potencia, 2)); /*Variável potencia elevado a dois*/
            Console.WriteLine(Math.Sqrt(potencia)); /*Raiz quadrada*/

            Console.WriteLine("Digite 3 palavras ou mais");
            string s = Console.ReadLine();
            string[] vet = s.Split(' '); /*Criando vetor + usando a classe Split, que separa as palavras dentro
                                           da string, e coloca em ordem dentro dos espaços do vetor.*/

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write($"{i}º Valor: ");
                Console.WriteLine(vet[i]);
            }

            Console.Write("Digite um número: ");
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture /*Classe pra ler o ponto como vírgula*/);
            /* ReadLine() somente recebe string, portanto
             * para receber tipos numéricos, como double,
             * ou int, é necessário a conversão dele
             */
            Console.WriteLine(d);


        }
    }
}
