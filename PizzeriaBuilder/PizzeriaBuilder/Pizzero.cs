using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaBuilder
{
    // Director
    class Pizzero
    {
        private IPizzaBuilder builder;
        public Pizzero(IPizzaBuilder builder)
        {
            this.builder = builder;
        }
        public void PrepararPizza()
        {
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

}
