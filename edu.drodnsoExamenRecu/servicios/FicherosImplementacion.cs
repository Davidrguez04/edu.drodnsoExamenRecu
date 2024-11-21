using edu.drodnsoExamenRecu.dtos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.drodnsoExamenRecu.servicios
{
    /// <summary>
    /// David Rodriguez Alonso - 21/11/2024
    /// Clase que contiene los métodos de los ficheros
    /// </summary>
    internal class FicherosImplementacion:FicherosInterfaz
    {
        //Método que crea y escribe el fichero log de las opciones elegidas por consola
        public void ficheroLog(string mensaje, string ruta)
        {
            StreamWriter sw = null;

            try
            {
                sw= new StreamWriter(ruta);
                sw.WriteLine(mensaje);

            }catch (Exception ex)
            {
                Console.WriteLine("\n\tERROR"+ex);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }


        }

        //Método que hace una carga inicial del fichero
        public void cargaInicialFicheroUsuario(List<UsuarioDto> listaUsuarios, string ruta)
        {
            try
            {
                string[] lineas = File.ReadAllLines(ruta);

                foreach(string line in lineas)
                {
                    string[] paciente = line.Split(';');

                    UsuarioDto usuario = new UsuarioDto();
                    usuario.Dni = paciente[0];
                    usuario.Nombre = paciente[1];
                    usuario.Apellidos = paciente[2];

                    listaUsuarios.Add(usuario);


                }


            }catch (Exception ex)
            {
                Console.WriteLine("\n\tNo se ha podido abrir el fichero!!"+ex);
            }


        }

        //Métodoque hace una carga inicial al fichero cita
        public void cargaInicialFicheroCita(List<CitaDto> listaCitas, string ruta)
        {
            try
            {
                string[] lineas = File.ReadAllLines(ruta);

                foreach (string line in lineas)
                {
                    string[] paciente = line.Split(';');

                    CitaDto citas = new CitaDto();
                    citas.Dni = paciente[0];
                    citas.Asistencia = paciente[5];
                    citas.FechaCita=Convert.ToDateTime(paciente[4]);
                    citas.Especialidad = paciente[3];
                    citas.Nombre = paciente[1]; 
                    citas.Apellidos= paciente[2];

                    listaCitas.Add(citas);


                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\tNo se ha podido abrir el fichero!!" + ex);
            }


        }

       


    }
}
