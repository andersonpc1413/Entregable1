string nivel = "";
double bonificacion = 50000;

Console.WriteLine("Ingrese el número de puntos obtenido (0.0, 0.4, 0.6):");
double puntos = double.Parse(Console.ReadLine());

switch (puntos) {

    case 0.0:
        nivel = "Inaceptable";
        bonificacion = bonificacion * puntos;
        Console.WriteLine($"Nivel de evaluación: {nivel}\n Bonificación Ganada: {bonificacion}");
        break;

    case 0.4:
        nivel = "Aceptable";
        bonificacion = bonificacion * puntos;
        Console.WriteLine($"Nivel de evaluación: {nivel}\n Bonificación Ganada: {bonificacion}");
        break;

    case 0.6:
        nivel = "Meritorio";
        bonificacion = bonificacion * puntos;
        Console.WriteLine($"Nivel de evaluación: {nivel}\n Bonificación Ganada: {bonificacion}");
        break;

    default:
        Console.WriteLine("Ingresar una puntuación válida");
        break;
}
