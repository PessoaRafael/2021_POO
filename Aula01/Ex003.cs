using System;

class Program {
  public static void Main (string[] args) 
  {
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    int a = int.Parse (Console.ReadLine());
    Console.WriteLine ("Digite a nota do segundo bimestre da disciplina:");
    int b = int.Parse (Console.ReadLine());
    int x = (a + b) / 2;
    Console.WriteLine($"Media parcial: {x}");
  }
}