using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto11
{
    internal class ingrediente : Iingredientes
    {
        
        public int Cantidad { get;set; }
        public string NombreI { get;set;}
        public double Precio { get;set;}

        public ingrediente(int cantidad, string nombreI, double precio)
        {
            Cantidad = cantidad;
            NombreI = nombreI;
            Precio = precio;
        }
    }
}
