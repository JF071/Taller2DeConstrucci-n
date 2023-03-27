namespace Punto1;
using System;
using System.Collections.Generic;




   public class Circuito : ICircuito
    {
        public string nomCircuito { get; set; }
        public int numV { get; set; }
        public List<Monoplaza> monoplazas { get; set; }

        public Circuito(string nomCircuito, int numV)
        {
            this.nomCircuito = nomCircuito;
            this.numV = numV;
            monoplazas = new List<Monoplaza>();
        }

        public void Agregar(Monoplaza monoplaza)
        {
            monoplazas.Add(monoplaza);
        }

        public void Sacar(Monoplaza monoplaza)
        {
            monoplazas.Remove(monoplaza);
        }

        public double RealizarPrueba()
        {
            if (monoplazas == null || monoplazas.Count == 0)
            {
                Console.WriteLine("Error al iniciar la prueba");

            }

            Random rnd = new Random();
            double tiempo;
            double mejorT = double.MaxValue;

            foreach (var monoplaza in monoplazas)
            {
                monoplaza.Encender();
                monoplaza.Mov();
            }
                bool codigoMostrado = false;

            if (!codigoMostrado)
            {
                for (int i = 0; i < numV; i++)
                {
                    tiempo = rnd.Next(900, 100000);
                    Console.WriteLine($"En la vuelta {i + 1}: el tiempo es de {tiempo} segundos");

                    if(tiempo < mejorT)
                    mejorT = tiempo;  
            }

            foreach (var monoplaza in monoplazas)
            {
                monoplaza.Detener();
                monoplaza.Apagar();
        }

                Console.WriteLine($"El mejor tiempo ha sido: {mejorT} segundos");
                codigoMostrado = true;
        }

            return mejorT;
    }
}      

