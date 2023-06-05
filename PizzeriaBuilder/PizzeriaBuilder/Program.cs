using PizzeriaBuilder;
using System;
using System.Collections.Generic;


// Patrón de diseño BUILDER //
class Program
{
    static void Main(string[] args)
    {
        IPizzaBuilder builder = new PizzaPeperoniBuilder();
        Pizzero pizzero = new Pizzero(builder);
        pizzero.PrepararPizza();
        Pizza pizzaPeperoni = pizzero.ObtenerPizza();
        pizzaPeperoni.Mostrar();
        Console.WriteLine();

        
        builder = new PizzaHawaianaBuilder();
        pizzero = new Pizzero(builder);
        pizzero.PrepararPizza();
        Pizza pizzaHawaiana = pizzero.ObtenerPizza();
        pizzaHawaiana.Mostrar();

        var customPizza = PizzaFluentBuilder.make().ConstruirTipoQueso()
                                                    .ConstruirMasa()
                                                    .ConstruirSalsa()
                                                    .ConstruirIngredientes()
                                                    .Cocinar();

        customPizza.Mostrar();

        Console.ReadLine();
    }
}
