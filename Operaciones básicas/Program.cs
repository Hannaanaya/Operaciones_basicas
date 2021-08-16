using System;

namespace operaciones_básicas
{
    class operaciones
    {
        //variables
        double n1 = 0;
        double n2 = 0;

        //cargar datos
        public void inicializar()
        {
            Console.Write("Introduce el primer número: ");
            n1 = Double.Parse(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            n2 = Double.Parse(Console.ReadLine());
        }


        public void imprimirResultado()
        {
            double sum = n1 + n2;
            Console.WriteLine("\nSuma: " + sum);

            double rest = n1 - n2;
            Console.WriteLine("Resta: " + rest);

            double mult = n1 * n2;
            Console.WriteLine("Multiplicación: " + mult);

            double div = n1 / n2;
            Console.WriteLine("División: " + div);

            double resi = n1 % n2;
            Console.WriteLine("Residuo: " + resi);
        }
        static void Main(string[] args)
        {
            operaciones op = new operaciones();
            op.inicializar();
            op.imprimirResultado();
            Console.ReadKey();
        }
    }
}
