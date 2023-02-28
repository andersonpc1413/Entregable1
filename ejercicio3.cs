Console.WriteLine("Bienvenido a Pizzas el Fercho\n Que tipo de pizza desea, vegetariana(1)/ no vegetariana (2): ");
int tipo = Int32.Parse(Console.ReadLine());

switch(tipo){

    case 1:
        Console.WriteLine("Menú:\n\n Elige el ingrediente:\n -Pimiento\n -Champiñones\nTodas las pizzas llevan mozzarella y tomate");
        string? ingredientev = Console.ReadLine();
        Console.WriteLine($"Tipo de pizza: vegetariana");
        Console.WriteLine($"Ingredeintes: {ingredientev}, mozzarella y tomate");
        break;

    case 2:
        Console.WriteLine("Menú:\n\n Elige el ingrediente:\n -Pepperoni\n -Salami\n -Pollo\n Todas las pizzas llevan mozzarella y tomate");
        string? ingredientenv = Console.ReadLine();
        Console.WriteLine($"Tipo de pizza: no vegetariana");
        Console.WriteLine($"Ingredeintes: {ingredientenv}, mozzarella y tomate");
        break;

  default: Console.WriteLine("Ingrese una elección válida");
        break;
}

