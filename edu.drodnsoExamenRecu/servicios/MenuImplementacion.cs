using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.drodnsoExamenRecu.servicios
{
    /// <summary>
    /// David Rodriguez Alonso - 21/11/2024
    /// Clase que contiene los métodos de los menús de la app
    /// </summary>
    internal class MenuImplementacion:MenuInterfaz
    {
        //Método que muestra el menú principal y recopge la opción elegida
        public int mostrarMenu()
        {
            int opcion = 0;

            Console.WriteLine("\n\tMenú principal:");
            Console.WriteLine("\n\t1.-Registro de llegada.");
            Console.WriteLine("\n\t2.-Listado de consultas");
            Console.WriteLine("\n\tSeleccione una opción: ");

            opcion = Console.ReadKey().KeyChar - ('0');

            return opcion;
        }

        //Método que contiene el segfundo menú y recoge la opción
        public int mostrarMenu2()
        {
            int opcion = 0;

            Console.WriteLine("\n\tMenú:");
            Console.WriteLine("\n\t1.-Mostrar consultas.");
            Console.WriteLine("\n\t2.-Imprimir consultas");
            Console.WriteLine("\n\tSeleccione una opción: ");

            opcion = Console.ReadKey().KeyChar - ('0');

            return opcion;
        }

        //Ultimo método de menú de la app
        public int mostrarMenu3()
        {
            int opcion = 0;

            Console.WriteLine("\n\tMenú:");
            Console.WriteLine("\n\t1.- Psicología.");
            Console.WriteLine("\n\t2.-Traumatología.");
            Console.WriteLine("\n\t3.-Fisioterapia.");
            Console.WriteLine("\n\tSeleccione una opción: ");

            opcion = Console.ReadKey().KeyChar - ('0');

            return opcion;
        }


    }
}
