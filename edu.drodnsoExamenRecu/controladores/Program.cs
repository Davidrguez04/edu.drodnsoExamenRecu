/**/
using edu.drodnsoExamenRecu.dtos;
using edu.drodnsoExamenRecu.servicios;

namespace edu.drodnsoExamenRecu.controladores
{
    /// <summary>
    /// David Rodriguez Alonso - 21/11/2024
    /// Clase que controla el flujo inicial de la app
    /// </summary>
    class Program
    {
        public static DateTime fechaHoy=DateTime.Now;
        public static string rutaFicheroLog = "C:\\Users\\csi22\\OneDrive\\Escritorio\\desarrollo web servidor\\edu.drodnsoExamenRecu\\edu.drodnsoExamenRecu\\Ficheros\\log- "+ fechaHoy.ToString("ddMMyyyy") + ".txt";
        public static string rutaFichero = "C:\\Users\\csi22\\OneDrive\\Escritorio\\desarrollo web servidor\\edu.drodnsoExamenRecu\\edu.drodnsoExamenRecu\\Ficheros\\citas.txt";
        /// <summary>
        /// David Rodriguez Alonso - 21/11/2024
        /// Método inicial que controla el orden de ejecucíon de la apps y como se ejecuta
        /// </summary>
        static void Main(string[] args)
        {
            FicherosInterfaz fi=new FicherosImplementacion();
            MenuInterfaz mn = new MenuImplementacion();
            OperativaInterfaz op=new OperativaImplementacion();

            List<UsuarioDto> listaUsuarios = new List<UsuarioDto>();
            List<CitaDto>listaCitas = new List<CitaDto>();

            int opcionMenu = 0;
            bool salirMenu = false;

            fi.cargaInicialFicheroUsuario(listaUsuarios, rutaFichero);
            fi.cargaInicialFicheroCita(listaCitas, rutaFichero);

            while(!salirMenu)
            {
                opcionMenu = mn.mostrarMenu();

                switch( opcionMenu )
                {
                    case 0:
                        fi.ficheroLog("Opción salir", rutaFicheroLog);
                        salirMenu = true;
                        break;

                    case 1:
                        fi.ficheroLog("Registro de llegada opción", rutaFicheroLog);
                        op.registroLlegada(listaCitas);
                        break;

                    case 2:
                        fi.ficheroLog("Listado de consultas opción", rutaFicheroLog);
                        opcionMenu =mn.mostrarMenu2();

                        switch (opcionMenu)
                        {
                            case 0:
                                fi.ficheroLog("Opción salir ", rutaFicheroLog);
                                break;

                            case 1:
                                fi.ficheroLog("\n\tMostrar consultas", rutaFicheroLog);
                                op.mostrarConsultas(listaCitas);
                                break;

                            case 2:
                                fi.ficheroLog("\n\tImprimir consultas", rutaFicheroLog);
                                break;

                            default:
                                fi.ficheroLog("\n\tERROR OPCION ELEGIDA!!", rutaFicheroLog);
                                Console.WriteLine("\n\tOpción introducida incorrecta!!!");
                                break;

                        }

                        break;

                    default:
                        fi.ficheroLog("\n\tERROR OPCION!!", rutaFicheroLog);
                        Console.WriteLine("\n\tOpción introducida incorrecta!!!");
                        break;

                }

            }



        }


    }
}
