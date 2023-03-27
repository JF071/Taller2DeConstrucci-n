using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Punto1;


// See https://aka.ms/new-console-template for more information



    List<Monoplaza> monoplazas = new List<Monoplaza>{new McLaren(), new Ferrari(), new RedBull()};
    Circuito circuito= new Circuito("Monaco", 3);
    Dictionary<string, double> resultado = new Dictionary<string, double>();

int opcion; 
        do
        {
            Console.WriteLine("=== Menú ===");
            Console.WriteLine("1. Iniciar carrera");
            Console.WriteLine("2. Salir");
            Console.Write("Ingrese una opción: ");
            opcion = int.Parse(s: Console.ReadLine());
            
            switch (opcion)
            {
                case 1:
                   foreach(Monoplaza monoplaza in monoplazas){
                    circuito.Agregar(monoplaza);
                    double mejorT = circuito.RealizarPrueba();
                    resultado.Add(monoplaza.Escuderia, mejorT);
                    circuito.Sacar(monoplaza);
                   }
                    break;
                case 2:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                case 3:
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
            
            Console.WriteLine();
            Console.Write("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            
        } while (opcion != 2);
    