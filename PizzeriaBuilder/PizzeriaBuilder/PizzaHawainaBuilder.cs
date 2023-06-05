using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaBuilder
{   
    //Builder Concreto
    class PizzaHawaianaBuilder : IPizzaBuilder
    {
        private Pizza pizza;

        public PizzaHawaianaBuilder()
        {
            pizza = new Pizza();
        }
        public void ConstruirTipo()
        {
            pizza.Tipo = "Hawaiana";
        }
        public void ConstruirMasa()
        {
            pizza.Masa = "Gruesa";
        }
        public void ConstruirSalsa()
        {
            pizza.Salsa = "Tomate";
        }
        public void ConstruirIngredientes()
        {
            pizza.Ingredientes = new List<string> { "Queso mozzarella", "Jamón", "Piña" };
        }
        public Pizza ObtenerPizza()
        {
            return pizza;
        }
    }
}
