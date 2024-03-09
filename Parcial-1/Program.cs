using System.Timers;

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


        double sueldo = 1000000;
        double comision = 0.10;
        double ventasMes;
        double porcentajeValor1;
        double porcentajeValor2;
        double porcentajeValor3;



        Console.WriteLine("Ingrese el valor de la primera venta");
        double venta1 = double.Parse(Console.ReadLine());

        porcentajeValor1 = venta1 * comision;

        Console.WriteLine("Ingrese el valor de la segunda venta");
        double venta2 = double.Parse(Console.ReadLine());

        porcentajeValor2 = venta2 * comision;

        Console.WriteLine("Ingrese el valor de la tercera venta");
        double venta3 = double.Parse(Console.ReadLine());

        porcentajeValor3 = venta3 * comision;

        if (porcentajeValor1 > porcentajeValor2)
        {
            Console.WriteLine("$esta fue la venta de mator comision" + porcentajeValor1);
        }
        if (porcentajeValor2 > porcentajeValor3)
        {
            Console.WriteLine("$esta fue la venta de mator comision" + porcentajeValor2);
        }
        if (porcentajeValor3 > porcentajeValor1)
        {
            Console.WriteLine("$esta fue la venta de mator comision" + porcentajeValor3);
        }

        ventasMes = porcentajeValor1 + porcentajeValor2 + porcentajeValor2;

        Console.WriteLine("$Total Ventas mes =" + ventasMes);

        double totalSueldo = ventasMes + sueldo;

        Console.WriteLine("$Tu sueldo en el mes es de = " + totalSueldo);

        double promedioVenta = (porcentajeValor1 + porcentajeValor2 + porcentajeValor3) / 3;

        Console.WriteLine("$El promedio de las ventas realizadas fue = " + promedioVenta);



        if (ventasMes >= 1000000)
        {
            Console.WriteLine("Buena esa te ganaste el bono de 1000000");
        }
        else
        {
            Console.WriteLine("Hey esfuerzate mas para la proxima");
        }
    }
}