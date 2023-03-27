// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
namespace proyecto11{
    public class program {
    static void Main(string[] args){
        
            Console.WriteLine("Ingrese el Nombre del pastel : ");
            string nombre= Console.ReadLine();
            Console.WriteLine("Ingrese el tamaño del pastel : /Grande /Mediano /Pequeño ");
            string tamaño= Console.ReadLine();
            Pastel pastel01 = new Pastel(nombre, tamaño);
            
            ingrediente ingrediente01=new ingrediente(3,"Huevos",3000);
            ingrediente ingrediente02 = new ingrediente(2, "Mantequillas", 5000);
            ingrediente ingrediente03 = new ingrediente(1, "Leche", 4000);

            pastel01.agregarIngredientes(ingrediente01);
            pastel01.agregarIngredientes(ingrediente02);
            pastel01.agregarIngredientes(ingrediente03);

            Console.WriteLine("Nombre del pastel : " + pastel01.Nombre);
            Console.WriteLine("La cantidad de ingredientes son : => " + pastel01.cantidadingre());
            Console.WriteLine("Los ingredientes son : " + pastel01.listaringredientes());
            Console.WriteLine("El costo total es : " + pastel01.Costodelpastel());
    }
}


}
