using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
           string result;
            double respostadaop;
            Console.WriteLine("Digite qual Operação deseja fazer: soma,subtracao,multiplicacao ou divisao ?");
            result = Console.ReadLine();

            soma s = new soma();
            subtracao sub = new subtracao();
            multiplicacao mult = new multiplicacao();
            div dis = new div();

            if (result == "soma") 
            {
                Console.WriteLine("Digite o primeiro numero da soma:");
                s.conta1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero da soma:");
               s.conta2 = Convert.ToDouble(Console.ReadLine());

                respostadaop = (s.conta1 + s.conta2);
               Console.WriteLine("O resultado é:", respostadaop);

            }

            if (result == "subtracao")
            {

                Console.WriteLine("Digite o primeiro numero da subtracao:");
                sub.num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero da subtracao:");
                sub.num2 = Convert.ToDouble(Console.ReadLine());

                respostadaop = (sub.num1 - sub.num2);
                Console.WriteLine("O resultado é:", respostadaop);
            }
            if (result == "multiplicacao") 
            {

                Console.WriteLine("Digite o primeiro numero da multiplicacao:");
                mult.mult1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero da multiplicacao:");
                mult.mult2 = Convert.ToDouble(Console.ReadLine());

                respostadaop = (mult.mult1 * mult.mult2);
                Console.WriteLine("O resultado é:", respostadaop);
            }
            if (result == "divisao")
            {

                Console.WriteLine("Digite o primeiro numero da divisao:");
                dis.div1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero da divisao:");
                dis.div2 = Convert.ToDouble(Console.ReadLine());

                respostadaop = (dis.div1/dis.div2);
                Console.WriteLine("O resultado é:", respostadaop);
            }
        }
    }
}
