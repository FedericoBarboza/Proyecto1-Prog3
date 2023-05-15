using Prueba_Estados;
using Bibilioteca;

/*class Program
{
    static void Main(string[] args)
    {
        Tramite t = new Tramite();
        t.numero = 2001;

        t.operacion3();

        t.estado = new EstadoTramiteB();
        t.operacion3();

        Console.ReadKey();

    }
}*/

public class Program
{


    static void Main(string[] args)
    {
        Ejemplo e1 = new Ejemplo();
        Ejemplo2 e2 = new Ejemplo2();
        e1.procesar();
        e2.procesar();
        e1.operacion2();
        e2.operacion2();

        Console.ReadKey();
    }



}