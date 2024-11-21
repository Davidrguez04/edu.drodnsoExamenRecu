using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.drodnsoExamenRecu.dtos
{
    internal class UsuarioDto
    {
        //-----------------------------------------Atributos--------------------------------------
        string dni = "aaaaaa";
        string nombre = "aaaaaaa";
        string apellidos = "aaaaaa aaaaaa";



        //----------------------------------------Getters y setters------------------------------
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }



        //--------------------------------------Controladores-------------------------------------
        public UsuarioDto(string dni, string nombre, string apellidos)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
        }

        public UsuarioDto()
        {
        }

        //-------------------------------------Método ToString-----------------------------------
    }
}
