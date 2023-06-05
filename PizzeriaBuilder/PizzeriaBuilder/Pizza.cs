using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaBuilder
{
    // Producto
    public class Pizza
    {
        public string Tipo { get; set; }
        public string Masa { get; set; }
        public string Salsa { get; set; }
        public List<string> Ingredientes { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("Detalles de la pizza:");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Masa: {Masa}");
            Console.WriteLine($"Salsa: {Salsa}");
            Console.WriteLine("Ingredientes:");

            foreach (var ingrediente in Ingredientes)
            {
                Console.WriteLine($"- {ingrediente}");
            }
        }
    }

}
