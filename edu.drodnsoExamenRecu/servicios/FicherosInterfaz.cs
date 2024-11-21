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
    /// Interfaz que contiene los métodos de los ficheros de la app
    /// </summary>
    internal interface FicherosInterfaz
    {
        public void ficheroLog(string mensaje, string ruta);


        public void cargaInicialFicheroUsuario(List<UsuarioDto> listaUsuarios, string ruta);


        public void cargaInicialFicheroCita(List<CitaDto> listaCitas, string ruta);
        
        }
}
