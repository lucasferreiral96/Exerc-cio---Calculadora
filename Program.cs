using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoIniciante
{
    class Program
    {
        static void Main(string[] args)
        {

          do{

          double num1 = 0;
          double num2 = 0;
          double  result = 0;

          Console.WriteLine("---------------------------------------------------");
          Console.WriteLine("Calculadora em C#");
          Console.WriteLine("---------------------------------------------------");

          Console.WriteLine("Digite o primeiro numero: ");
          num1 = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Digite o segundo numero: ");
          num2 = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Digite uma opção ");
           Console.WriteLine("\t+: Somar ");
           Console.WriteLine("\t-: Subtrair ");
           Console.WriteLine("\t*: Multiplicar ");
           Console.WriteLine("\t/: Dividir");
           Console.Write("Insira uma opção: ");

           switch(Console.ReadLine()){
              case "+":
                result = num1 + num2;
                Console.WriteLine("Resultado: " + result);
              break;

              case "-":
                result = num1 - num2;
                Console.WriteLine("Resultado: " + result);
              break;

              case "*":
                result = num1 * num2;
                Console.WriteLine("Resultado: " + result);
              break;

              case "/":
                result = num1 / num2;
                Console.WriteLine("Resultado: " + result);
              break;

              default:
              Console.WriteLine("Opção inválida.");
              break;
           
         
          }
          Console.WriteLine("Fazer novo calculo?      Sim = Y / Não = N ");

          }while(Console.ReadLine().ToUpper() == "Y");

          Console.WriteLine("Até logo!");
          Console.ReadKey();

          }



        }
         


    }

