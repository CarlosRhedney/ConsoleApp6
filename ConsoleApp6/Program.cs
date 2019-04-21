using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string operacao;
            double num1, num2, result;
            Console.Write("Digite o 1° valor: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a operação matemática: ");
            operacao = Console.ReadLine();
            Console.Write("Digite o 2° valor: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            result = 0;
            if (operacao == "+")
            {
                result = num1 + num2;
            }else if (operacao == "-")
            {
                result = num1 - num2;
            }else if(operacao == "*")
            {
                result = num1 * num2;
            }else if (operacao == "/")
            {
                result = num1 / num2;
            }else
            {
                Console.Write("\nOperação Inválida!");
            }
            Console.Write("\n*******************************************************************************");
            Console.Write("\nA operação entre os valores é: " + result);
            Console.Write("\nPressione qualquer tecla para sair....");
            Console.ReadKey();
        }
    }
}
