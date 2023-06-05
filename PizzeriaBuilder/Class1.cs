using System;

// Director
class Pizzero
{
    private PizzaBuilder builder;

    public Pizzero(PizzaBuilder builder)
    {
        this.builder = builder;
    }

    public void PrepararPizza()
    {
        builder.CrearPizza();
        builder.ConstruirTipo();
        builder.ConstruirMasa();
        builder.ConstruirSalsa();
        builder.ConstruirIngredientes();
    }

    public Pizza ObtenerPizza()
    {
        return builder.ObtenerPizza();
    }
}
