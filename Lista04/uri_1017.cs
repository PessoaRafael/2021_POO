using System;

class Program {
  public static void Main (string[] args) 
  {
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double calc = (b/12) *a;
    Console.WriteLine($"{calc:0.000}");
  }
}