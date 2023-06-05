using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaBuilder
{
    public class PizzaFluentBuilder
    {
        private readonly Pizza pizza;


        public static PizzaFluentBuilder make (){ 
            return new PizzaFluentBuilder();
        }

        private PizzaFluentBuilder()
        {
            pizza = new Pizza();

        }

        public PizzaFluentBuilder ConstruirTipoHawaina()
        {
            pizza.Tipo = "Hawaiana";
            return this;
        }

        public PizzaFluentBuilder ConstruirTipoQueso()
        {
            pizza.Tipo = "Queso";
            return this;
        }
        public PizzaFluentBuilder ConstruirMasa()
        {
            pizza.Masa = "Gruesa";
            return this;
        }
        public PizzaFluentBuilder ConstruirSalsa()
        {
            pizza.Salsa = "Tomate";
            return this;
        }
        public PizzaFluentBuilder ConstruirIngredientes()
        {
            pizza.Ingredientes = new List<string> { "Queso mozzarella", "Jamón", "Piña" };
            return this;
        }

        public Pizza Cocinar() {
            return pizza;
        }
    }
}
