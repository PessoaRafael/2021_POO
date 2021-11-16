using System;

class Program {
  public static void Main (string[] args) 
  {
    string[] x = Console.ReadLine().Split(' ');
    double a = double.Parse (x[0]);
    double b = double.Parse (x[1]);
    double c = double.Parse (x[2]);
    double area_t = a*c/2;
    double circ = c*c * 3.14159;
    double trap = (a+b)*c/2;
    double quad = b*b;
    double retang = a*b;
    Console.WriteLine($"TRIANGULO: {area_t:0.000}\nCIRCULO: {circ:0.000}\nTRAPEZIO: {trap:0.000}\nQUADRADO: {quad:0.000}\nRETANGULO: {retang:0.000}");
  }
}