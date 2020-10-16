using System;

namespace AreaTriangulo
{
    class TrianguloMain
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Console.WriteLine("Digite o valor de A, B e C:");
            try
            {
                x.A = double.Parse(Console.ReadLine());
                x.B = double.Parse(Console.ReadLine());
                x.C = double.Parse(Console.ReadLine());

                double Area = x.CalculoArea();

                if (Area == Double.NaN)
                    Console.WriteLine("Resultado do valor indefinido");
                else
                    Console.WriteLine(Area);
            }
            catch (Exception e)
            {
                Console.WriteLine("Digite valores válidos");
                Console.Clear();
            }

        }

    }
}
