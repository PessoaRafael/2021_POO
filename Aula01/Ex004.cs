using System;

class Program {
  public static void Main (string[] args) 
  {
    Console.WriteLine("Digite a base e altura do retangulo");
    int a = int.Parse (Console.ReadLine());
    int b = int.Parse (Console.ReadLine());
    int area = a*b;
    int perimetro = a*2 + b*2;
    double diagonal = Math.Sqrt(a*a + b*b);
    Console.WriteLine($"Area = {area} perimetro = {perimetro} diagonal = {diagonal}");
  }
}