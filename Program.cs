/*************************
* Автор: Базанов В.В.    *
* Название: Вариант №1   *
*************************/

using System;

namespace csharpProject
{
  class Program
  {
    static void Main()
    {
      int variableA, variableN, answer;
      string variableX, variableY;
      char numberX;
      answer = 1;

      Console.Write("Enter variable a: ");
      variableA = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter variable n: ");
      variableN = Convert.ToInt32(Console.ReadLine());
      for (int index = 0; index < variableN; ++index)
      {
        answer *= variableA;
      }

      Console.Write("a^n= " + answer);

      Console.Write("\nEnter seed number x, x>= 100: ");
      variableX = (Console.ReadLine());
      numberX = variableX[1];
      variableX = variableX.Remove(1,1);
      variableY = variableX + numberX;

      Console.Write("final number: " + variableY);
    }
  }
}