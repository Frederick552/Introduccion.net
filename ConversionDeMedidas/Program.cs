// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite la cantidad de metros");

double metro;

Console.WriteLine("Metro: ");
metro = double.Parse(Console.ReadLine());

double centimetro = metro * 100;
double pulgada = centimetro / 2.54;
double pie = pulgada / 12;
double yarda = pie / 3;

Console.WriteLine("-------------------------------------");
Console.WriteLine("Centimetros: " + centimetro.ToString("0.00"));
Console.WriteLine("Pulgadas: " + pulgada.ToString("0.00"));
Console.WriteLine("Pie: " + pie.ToString("0.00"));
Console.WriteLine("Yardas: " + yarda.ToString("0.00"));
