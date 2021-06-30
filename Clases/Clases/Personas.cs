using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
  public class Personas
    {
        //Atributos
        private string _nombre;
        private string _apellido;
        private int _edad;
        private string _direccion;

        //Propiedades
        //public string Nombre
        //{
        //    get { return _nombre; }
        //    set { _nombre = value; }
        //}
        //public string Apellido
        //{
        //    get { return _apellido; }
        //    set { _apellido = value; }
        //}
        //public int Edad
        //{
        //    get { return _edad; }
        //    set { _edad = value; }
        //}
        //public string Direccion
        //{
        //    get { return _direccion; }
        //    set { _direccion = value; }
        //}

        //Otro tipo de propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        //Constructores
        public Personas()
        {
        }
        public Personas(string nombre, string apellido, int edad, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Direccion = direccion;
        }

        public Personas(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        //Métodos o Funciones (Acciones)
        public string DevolverNombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

    }
}
