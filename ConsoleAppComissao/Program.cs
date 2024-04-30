using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppComissao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nome = new String[5];
            double[] venda = new double[5];
            double[] comi = new double[5];

           for (int i = 0; i <=4; i++)
            {
                Console.WriteLine("Informe o nome do vendedor: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Informe o valor da venda: ");
                venda[i] = double.Parse(Console.ReadLine());

                if (venda[i] <= 20.000)
                {
                    comi[i] = venda[i] * 0.05;
                } else if (venda[i] <= 40.000)
                {
                    comi[i] = venda[i] * 0.06;
                } else
                {
                    comi[i] = venda[i] * 0.07;
                }
            }

           for (int j = 0; j <=4; j++)
            {
                Console.WriteLine("VENDEDOR: " + nome[j] + "  VENDA: " + venda[j] + "  COMISSÃO: " + comi[j]);
            }

           Console.ReadKey();

            
        }
    }
}
