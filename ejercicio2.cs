double descuentoa = 0.05, descuentob = 0.03, entrada = 0;
double precioentrada = 15000;
int descuento = 0;

Console.WriteLine("Ingrese el nombre completo: ");
string? nombre = Console.ReadLine();

Console.WriteLine("Ingrese la edad: ");
int edad = Int32.Parse(Console.ReadLine());


if (edad < 4)
    entrada = precioentrada - precioentrada;
if (edad >= 4 && edad < 18)
    entrada = precioentrada - (precioentrada * descuentoa) ;
if (edad > 18)
    entrada = precioentrada - (precioentrada * descuentob) ;


if (edad < 4)
    descuento = 100;
if (edad >= 4 && edad <= 18)
    descuento = 5;
if (edad > 18)
    descuento = 3;

Console.WriteLine($"Nombre: {nombre}");
Console.WriteLine($"Precio entrada: {entrada}");
Console.WriteLine($"Descuento: {descuento}%");