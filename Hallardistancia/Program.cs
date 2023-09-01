//Enunciado: 1.Lea las coordenadas de dos puntos y que muestre la distancia entre los dos puntos.//


public class HallarDistanci
{
    static void Main(string[] args)
    {
        double x1, y1, x2, y2, distancia;

        Console.Write("Ingrese x1: ");
        x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        distancia = Math.Sqrt(Math.Pow(x2-x1, 2) +  Math.Pow(y2-y1, 2));

        Console.Write("La distancia es: " + distancia);
        Console.Write("\n");
    
    
    }





}
    