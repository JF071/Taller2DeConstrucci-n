using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto11
{
    internal interface Iingredientes
    {
        public int Cantidad { set; get; }
        public string NombreI { get; set; }
        public double Precio { get; set; }

        
    }
}
