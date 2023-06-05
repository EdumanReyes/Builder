using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaBuilder
{
    // Builder concreto
    class PizzaPeperoniBuilder : IPizzaBuilder
    {
        private Pizza pizza;
        public PizzaPeperoniBuilder()
        {
            pizza = new Pizza();
        }
        public void ConstruirTipo()
        {
            pizza.Tipo = "Peperoni";
        }
        public void ConstruirMasa()
        {
            pizza.Masa = "Delgada";
        }
        public void ConstruirSalsa()
        {
            pizza.Salsa = "Tomate";
        }
        public void ConstruirIngredientes()
        {
            pizza.Ingredientes = new List<string> { "Queso mozzarella", "Albahaca", "Tomates frescos" };
        }
        public Pizza ObtenerPizza()
        {
            return pizza;
        }
    }

    
}
