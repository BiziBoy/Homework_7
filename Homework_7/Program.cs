using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
  class Program
  {
    static void Main(string[] args)
    {
      //вывести массив в обратном порядке
      int[] array = Enumerable.Range(0, 5).ToArray();
      Console.WriteLine("Массив в обычном порядке: ");
      for (int i = 0; i < array.Length; i++)
      {
        Console.WriteLine((i + 1) + "-й элемент массива: " + array[i]);
      }
      Console.WriteLine("Массив в обратном порядке: ");
      for (int i = array.Length-1; i >= 0 ; i--)
      {
        Console.WriteLine((i + 1) + "-й элемент массива: " + array[i]);
      }
      Console.ReadLine();

    }
  }
}
