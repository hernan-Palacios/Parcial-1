internal class Program
{
    private static void Main(string[] args)
    {

        /*Realizar un algoritmo con C# donde se solucione el siguiente problema: Un vendedor recibe un 
        sueldo base de $XXXX. Además, recibe una comisión del 10% sobre el valor total de cada venta que 
        realiza. El vendedor desea saber: 
         ¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el 
        mes? 
         ¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones? 
         ¿Cuál fue la venta que le generó la mayor comisión? 
         ¿Cuál fue el promedio de las comisiones que recibió por cada venta? 
        Además, la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes. El 
        objetivo es sumar en las 3 ventas como mínimo $1.000.000 en ventas. Mostrar un mensaje donde 
        indique si ganó o no el beneficio.*/


        float sueldo = 20000;
        float comision = 0.10;

        float ventasMes;
        float porcentajeValor1;
        float porcentajeValor2;
        float porcentajeValor3;


        Console.WriteLine("Ingrese el valor de la primera venta");
        float venta1 = float.Parse(Console.ReadLine());

        porcentajeValor1 = venta1 * comision;

        Console.WriteLine("Ingrese el valor de la segunda venta");
        float venta2 = float.Parse(Console.ReadLine());
        
        porcentajeValor2 = venta2 * comision;

        Console.WriteLine("Ingrese el valor de la tercera venta");
        float venta3 = float.Parse(Console.ReadLine());

        porcentajeValor2 = venta3 * comision;
    
        ventasMes = porcentajeValor1+porcentajeValor2+porcentajeValor2;

        Console.WriteLine("$Total Ventas mes =" + ventasMes);





    }
}