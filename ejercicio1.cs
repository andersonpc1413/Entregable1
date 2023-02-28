double trimestral1 = 0, trimestral2 = 0, trimestral3 = 0, trimestral4 = 0, rentaanual = 0, totalrp =0, impuestop = 0;
double impuestoa = 0.05, impuestob = 0.1, impuestoc = 0.15, impuestod = 0.20, impuestoe = 0.30;
int impuesto = 0;

Console.WriteLine("Digite el valor del primer trimestre: ");
trimestral1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digiete el valor del segundo trimestre: ");
trimestral2 = double.Parse(Console.ReadLine());

Console.WriteLine("digite el valor del tercer trimestre: ");
trimestral3 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite el valor del cuarto trimestre: ");
trimestral4 = double.Parse(Console.ReadLine());


rentaanual = trimestral1 + trimestral2 + trimestral3 + trimestral4;
Console.WriteLine($"Renta Anual: {rentaanual}");


if (rentaanual < 10000)
    impuestop = rentaanual * impuestoa;
if (rentaanual >= 10000 && rentaanual < 20000)
    impuestop = rentaanual * impuestob;
if (rentaanual >= 20000 && rentaanual < 35000)
    impuestop = rentaanual * impuestoc;
if (rentaanual >= 35000 && rentaanual <= 45000)
    impuestop = rentaanual * impuestod;
if (rentaanual > 45000)
    impuestop = rentaanual * impuestoe;

totalrp = impuestop;
Console.WriteLine($"Total renta apagar: {totalrp}");


if (rentaanual < 10000)
    impuesto = 5;
if (rentaanual >= 10000 && rentaanual < 20000)
    impuesto = 10;
if (rentaanual >= 20000 && rentaanual < 35000)
    impuesto = 15;
if (rentaanual >= 35000 && rentaanual <= 45000)
    impuesto = 20;
if (rentaanual > 45000)
    impuesto = 30;

Console.WriteLine($"Impuesto agregado: {impuesto}%");






