// See https://aka.ms/new-console-template for more information
Console.WriteLine("Control de ventas de productos");

int cant;
double precio;

Console.WriteLine("Ingrese la cantidad del producto: ");
cant = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el precio del producto: ");
precio = double.Parse(Console.ReadLine());

double impor = cant * precio;
double descuento = impor * 0.11;
double pago = impor - descuento;

Console.WriteLine("-----------------------------------");
Console.WriteLine("El pago total con descuento es : " + pago.ToString());