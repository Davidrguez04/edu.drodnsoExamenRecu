using edu.drodnsoExamenRecu.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.drodnsoExamenRecu.servicios
{
    /// <summary>
    /// David Rodriguez Alonso - 21/11/2024
    /// Clase que contiene los métodos de la operativa de la app
    /// </summary>
    internal class OperativaImplementacion:OperativaInterfaz
    {
        //Método que controla el registro de las personas que van llegando a la consulta y comrueba si esta todo correcto y tiene cita ese mismo día
        public void registroLlegada(List<CitaDto>listaCitas)
        {
           
            
                Console.WriteLine("\n\tPor favor introduzca su dni: ");
                string dni = Console.ReadLine();

                bool validado = validarDni(dni);

            

            DateTime fechaDia= DateTime.Now;

            foreach(CitaDto cita in listaCitas)
            {
                if (cita.Dni.Equals(dni)&& fechaDia.Date.Equals(cita.FechaCita.Date))
                {
                    cita.Asistencia = "true";
                    Console.WriteLine("\n\tEspere su turno para la consulta de " + cita.Especialidad + " en la sala de espera. Su especialista le avisará."); 
                }
                else if(cita.Dni.Equals(dni) && fechaDia!=(cita.FechaCita))
                {
                    Console.WriteLine("\n\tNo dispone de cita para el día de hoy losiento! ");
                }
            }


        }

        //Método que muestra las consultas del dia dicho por consola
        public void mostrarConsultas(List<CitaDto> listaCitas)
        {
            Console.WriteLine("\n\tElija una fecha (dd-MM-yyyy):");
            DateTime fechaDia=Convert.ToDateTime(Console.ReadLine());

            MenuInterfaz mn = new MenuImplementacion();
            int opcion=mn.mostrarMenu3();

            string especialidad="aaaa";

            if (opcion == 1)
            {
                especialidad = "Psicología";
            }
            else if (opcion == 2)
            {
                especialidad = "Traumatología";
            }
            else if (opcion == 3)
            {
                especialidad = "Fisioterapia";
            }
            

            

            foreach (CitaDto cita in listaCitas)
            {
                if (cita.FechaCita.Date.Equals(fechaDia.Date)&&cita.Especialidad.Equals(especialidad))
                {
                    Console.WriteLine("\n\tNombre completo: " + cita.Nombre + " " + cita.Apellidos + ", Hora: " + cita.FechaCita.Hour);
                }
            }

        }

        //Método qeu valida la letra del dni si es correcta o no
        public bool validarDni(string dni)
        {
            Console.WriteLine("\n\tPor favor introduzca su dni sin letra");
            int numeroDni = Convert.ToInt32(Console.ReadLine());

            bool validado=false;

            string[] letras = { "T","R","W","A","G","M","Y","F","P","D","X","B","N","J","Z","S","Q","V","H","L","C","K","E"};
            int letra = numeroDni % 23;
            Console.WriteLine(letra);
            string dniComprobado = numeroDni + letras[letra];

            if (dniComprobado == dni)
            {
                 validado = true;
                Console.WriteLine("\n\tDni correcto");
            }
            else
            {
                validado = false;
                Console.WriteLine("\n\tLetra del dni incorrecta!!!");
            }

            return validado;

        }



    }
}
