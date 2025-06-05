using System;
// la clase de mounstrous 
public class Mounstrou
{
    public string nombre;
    public string tipo;
    public int vida;
    public int fuerza;


    // el constructor creo
    public Mounstrou()
    {
        this.nombre = PedirNombre();
        this.tipo = PedirTipo();
        this.vida = PedirVida();
        this.fuerza = PedirFuerza();

    }
    public string PedirNombre()
    {
        Console.Write("Ingrese el nombre de su mounstruo:");
        string nombre = "" + Console.ReadLine();
        return nombre;
    }
    public string PedirTipo()
    {
        Console.Write($"Ingrese si {this.nombre} es de tipo Fuego, Agua, Aire o Tierra:");
        string tipo = "" + Console.ReadLine();
        return tipo;
    }
    public int PedirVida()
    {
        Console.Write($"ingrese la vida de {this.nombre} del tipo {this.tipo}:");
        int vida = int.Parse(Console.ReadLine());
        return vida;
    }
    public int PedirFuerza()
    {
        Console.Write($"ingrese la fuerza de {this.nombre} del tipo {this.tipo}:");
        int fuerza = int.Parse(Console.ReadLine());
        return fuerza;
    }
    public void ImprimirInformacion()
    { 
        Console.WriteLine($"{this.nombre} es del tipo {this.tipo} con vida {this.vida} y fuerza {this.fuerza}");
    }
}




//public string nombreq;
//public string tipoq;
//public int vidaq;
//public int fuerzaq;




// this.nombreq = nombreq;
//this.tipoq = tipoq;
//this.vidaq = vidaq;
//this.fuerzaq = fuerzaq;

