using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace proyecto11
{
    internal class Pastel
    {
        
       public Pastel(String Nombre, string Tamaño) 
        {
        this.Nombre=Nombre;
        this.Tamaño = Tamaño;
        this.ListaIngredientes=new List<ingrediente>();
        }  
        public List<ingrediente>ListaIngredientes= new List<ingrediente>();
        public String Nombre { get; set; }
        public String Tamaño { get; set; }


        public void agregarIngredientes(ingrediente ingrediente)
        {
            this.ListaIngredientes.Add(ingrediente);
        }
        public int cantidadingre()
        {
           int count=ListaIngredientes.Count();
            //Retorno
           return count;
        }
        public string listaringredientes()
        {
            string concatenar = null;
            foreach (ingrediente ingrediente in ListaIngredientes)
            {
                concatenar += ingrediente.Cantidad + " " + ingrediente.NombreI + "\n";
            }
            return concatenar;
        }

        public double Costodelpastel()
        {
            double precio = 0;
            foreach (ingrediente ingrediente in ListaIngredientes)
            {
                precio += ingrediente.Cantidad * ingrediente.Precio;
                
            }
            return precio;
        }
    }

   
    
}
