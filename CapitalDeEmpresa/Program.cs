// See https://aka.ms/new-console-template for more information
Console.WriteLine("Montos del capital");

double monto1,monto2,monto3;

Console.WriteLine("Ingrese el capital del monto 1: ");
monto1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el capital del monto 2: ");
monto2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el capital del monto 3: ");
monto3 = double.Parse(Console.ReadLine());

double capital = monto1 + monto2 + monto3;
double psocio1 = (monto1 * 100) / capital;
double psocio2 = (monto2 * 100) / capital;
double psocio3 = (monto3 * 100) / capital;

Console.WriteLine("-----------------------------------");
Console.WriteLine("El total del capital es: " + capital.ToString());
Console.WriteLine("El Capital del socio 1 es " + psocio1.ToString());
Console.WriteLine("El Capital del socio 2 es " + psocio2.ToString());
Console.WriteLine("El Capital del socio 3 es " + psocio3.ToString());