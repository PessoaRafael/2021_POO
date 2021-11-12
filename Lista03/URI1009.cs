using System;

class Program {
  public static void Main (string[] args) 
  {
    string a = (Console.ReadLine());
    double b = double.Parse (Console.ReadLine());
    double c = double.Parse (Console.ReadLine());
    double salario_bonus = b + (c*0.15);
    Console.WriteLine($"TOTAL = R$ {salario_bonus:0.00}");
  }
}