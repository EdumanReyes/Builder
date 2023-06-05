using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaBuilder
{
    // Interfaz del Builder
    interface IPizzaBuilder
    {
        void ConstruirTipo();
        void ConstruirMasa();
        void ConstruirSalsa();
        void ConstruirIngredientes();
        Pizza ObtenerPizza();
    }
}
