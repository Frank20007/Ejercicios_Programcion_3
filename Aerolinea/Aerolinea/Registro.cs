using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea
{
    public class Registro
    {
        public int Factura { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Fecha { get; set; }
        public int Hora { get; set; }
        public int Fecha_Salida { get; set; }
        public int Fecha_Regreso { get; set; }
        public string Abordaje { get; set; }
        public string Escala { get; set; }
        public string Destino { get; set; }
        public string Asiento { get; set; }
        public string Maleta { get; set; }
        public int Peso { get; set; }
        public int Forma_Pago { get; set; }
        public int Total { get; set; }

        public Registro()
        {
        }

        public Registro(int factura, string nombre, int edad, int fecha, int hora, int fechasalida, int fecharegreso, string abordaje, string escala, string destino, string asiento, string maleta, int peso, int formapago, int total)
        {
            Factura = factura;
            Nombre = nombre;
            Edad = edad;
            Fecha = fecha;

        }

    }
}
