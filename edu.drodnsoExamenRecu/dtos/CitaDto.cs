using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.drodnsoExamenRecu.dtos
{
    internal class CitaDto
    {
        //-----------------------------------------Atributos--------------------------------------
        string dni = "aaaaaa";
        string especialidad = "aaaaaa";
        DateTime fechaCita=DateTime.Now;
        string asistencia = "aaaa";
        string nombre = "aaaaa";
        string apellidos = "aaaaaa";





        //----------------------------------------Getters y setters------------------------------
        public string Dni { get => dni; set => dni = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime FechaCita { get => fechaCita; set => fechaCita = value; }
        public string Asistencia { get => asistencia; set => asistencia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }




        //--------------------------------------Controladores-------------------------------------
        public CitaDto(string dni, string especialidad, DateTime fechaCita, string asistencia, string nombre, string apellidos)
        {
            this.dni = dni;
            this.especialidad = especialidad;
            this.fechaCita = fechaCita;
            this.asistencia = asistencia;
            this.nombre = nombre;
            this.apellidos = apellidos;
            
        }

        public CitaDto()
        {
        }

        //-------------------------------------Método ToString-----------------------------------
        
    }
}
