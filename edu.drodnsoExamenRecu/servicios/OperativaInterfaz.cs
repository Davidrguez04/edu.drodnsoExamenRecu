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
    /// Interfaz que contiene los métodos de la operativa de la app
    /// </summary>
    internal interface OperativaInterfaz
    {
        public void registroLlegada(List<CitaDto> listaCitas);
        

        public void mostrarConsultas(List<CitaDto> listaCitas);
        

        }
    }
