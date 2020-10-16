using System;

namespace ExPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção abaixo:");
            Console.WriteLine("(1) Inserir Alunos");
            Console.WriteLine("(2) Inserir Funcionário");
            try
            {
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Aluno();
                }
                else if (op == 2)
                {
                    Empregado();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Insira apenas números");
            }
        }

        static void Empregado()
        {
            Funcionario func = new Funcionario();
            Console.WriteLine("Digite o nome do primeiro funcionario:");
            func.NomeFuncionario1 = Console.ReadLine();
            Console.WriteLine("Digite o salário:");
            func.Salario1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do segundo funcionario:");
            func.NomeFuncionario2 = Console.ReadLine();
            Console.WriteLine("Digite o salário:");
            func.Salario2 = double.Parse(Console.ReadLine());

            MediaSalario(func);
        }


        static void Aluno()
        {
            Pessoa p = new Pessoa();

            Console.WriteLine("Digite o nome do primeiro aluno:");
            p.Nome1 = Console.ReadLine();
            Console.WriteLine("Digite a idade do primeiro aluno:");
            p.Idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do segundo aluno:");
            p.Nome2 = Console.ReadLine();
            Console.WriteLine("Digite a idade do segundo aluno:");
            p.Idade2 = int.Parse(Console.ReadLine());

            MediaIdade(p);
        }

        static void MediaIdade(Pessoa p)
        {
            int media = (p.Idade1 + p.Idade2) / 2;
            Console.WriteLine($"A media das idades é: {media}");
        }

        static void MediaSalario(Funcionario func)
        {
            double media = (func.Salario1 + func.Salario2) / 2;
            Console.WriteLine($"A media do salário é: {media}");
        }

    }
}
