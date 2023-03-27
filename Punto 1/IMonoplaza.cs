
namespace Punto1;



public abstract class Monoplaza : IMonoplazas{

public string Escuderia { get; set; }
public bool ONOF{get; private set;}
public bool Movimiento{get; private set;}

   public Monoplaza (string escuderia)
    {
        Escuderia = escuderia;
        ONOF = false;
        Movimiento = false;
    }

   public void Encender(){
    if(ONOF == false & Movimiento == false ){
        ONOF = true;
        Console.WriteLine("El vehículo ha sido encendido");
    }else{
        Console.WriteLine("Error al encender el vehículo");
        }
    }



   public void Apagar(){
    if(this.ONOF == true & this.Movimiento == false ){
        this.ONOF = false;
        Console.WriteLine("El vehículo ha sido apagado correctamente");
    }else{
        Console.WriteLine("Error al apagar el vehículo, se encuentra en movimiento");
         }
    
     }



   public void Detener(){
    if(this.ONOF == true & this.Movimiento == true ){
        this.Movimiento = false;
        Console.WriteLine("El vehículo ha sido detenido correctamente");
    }else{
        Console.WriteLine("Error al detener el vehículo. Se encuentra apagado");
         }
    
     }



   public void Mov(){
    if(this.ONOF == true & this.Movimiento == false ){
        this.Movimiento = true;
        Console.WriteLine("El vehículo se esta movimiendo correctamente");
    }else{
        Console.WriteLine("Error al mover el vehículo");
         }
    
     }

}       

