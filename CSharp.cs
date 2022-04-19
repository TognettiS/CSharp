using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  class teste
  {
    static public void Main()
    {
      double num1, num2;
      int x = 1;
      string op;

      Console.Write("Bem-vindo a calculadora!\n");

      while (x == 1) {

        Console.WriteLine("Digite o Primeiro Número:\n");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine("Digite a operação que deseja efetuar '+', '-', '*' ou '/':\n");
        op = Console.ReadLine();

        Console.WriteLine("");

        Console.WriteLine("Digite o Segundo Número:\n");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine("Seu resultado é:\n");

        switch (op) {
          case "+":
            Console.WriteLine(num1 + num2);
            break;

          case "-":
            Console.WriteLine(num1 - num2);
            break;

          case  "*":
            Console.WriteLine(num1 * num2);
            break;

          case "/":
            Console.WriteLine(num1 / num2);
            break;
        }
        Console.WriteLine("\nDigite '1' caso deseja realizar mais operações e '2' caso queira sair");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
          if (x==2) {
            Console.WriteLine("Saindo...");
          }
      }

    }
  }
