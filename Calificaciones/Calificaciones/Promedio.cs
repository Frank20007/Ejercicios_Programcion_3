using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    class Promedio
    {
        public string Nombre { get; set; }
        public int Cuenta { get; set; }
        public int Nota_1 { get; set; }
        public int Nota_2 { get; set; }
        public int Nota_3 { get; set; }
        public int Nota_4 { get; set; }

        public Promedio (string nombre, int cuenta)
        {
            Nombre = nombre;
            Cuenta  = cuenta;
        }
 public Promedio(string nombre, int cuenta, int nota_1 , int nota_2, int nota_3, int nota_4)
        {
            Nombre = nombre;
            Cuenta = cuenta;
            Nota_1 = nota_1;
            Nota_2 = nota_2;
            Nota_3 = nota_3;
            Nota_4 = nota_4;

        }

        public string DevolverPromnedio()
        {
            return Convert.ToString  ( (Nota_1+Nota_2 +Nota_3 +Nota_4)/4);
        }

        public string AprobadoReprobado()
        {
             
            var resultado = (Nota_1 + Nota_2 + Nota_3 + Nota_4)/4;
            string  a;
            
            if  (resultado   <= 69)
                {
                a = ("REPROBADO");

            }
            else
                {
                a = ("APROBADO");
            }

            

                return a ;
              
        }


    }
}
