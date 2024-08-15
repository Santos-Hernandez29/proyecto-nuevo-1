using System;
public class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Bienvenidos a nuestro primer sistema creado en C#");
        Console.WriteLine("Ingrese tu nombre para continuar ");
        string Nombre = Console.ReadLine();// Par recibir valores de caracter
        Console.WriteLine("Ingrese su edad");
        int Edad = Convert.ToInt32(Console.ReadLine());//Convertir a dato tipo double
        double EdadMeses = Edad * 12;//Calculos Matematicos
        Console.WriteLine("La edad en Meses es:" + EdadMeses + "Meses");//Concarenacion
        if (Edad > 18)
        {
            Console.WriteLine("Usted es Mayor de Edad");
        }
        else
        {
            Console.WriteLine("Usted no es Mayor de Edad");
        }
    }
}