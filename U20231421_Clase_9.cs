using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
		//PROGRAMA PARA EVALUAR LA CALAFIFICACIÓN INGRESADA
            Console.WriteLine("\n------PROGRAMA PARA EVALUAR CALIFICACIÓN------\n");
            Console.WriteLine("Ingresa la calificación: ");
            double calificación = Convert.ToDouble(Console.ReadLine());

            //Si la nota es mayor o igual que 9.5
            if (calificación >= 9.5) 
            { 
                Console.WriteLine("\nLa nota " + calificación + " ingresada es excelente \n");
                Console.WriteLine("\n------FIN DEL PROGRAMA------\n");
            }
            //Si la nota es mayor o igual que 8.5
            else if (calificación >= 8.5)
             {
                Console.WriteLine("\nLa nota " + calificación + " ingresada es muy buena\n");
                Console.WriteLine("\n------FIN DEL PROGRAMA------\n");
            }
            //Si la nota es mayor o igual que 7.0
             else if (calificación >= 7)
             {
                Console.WriteLine("\nLa nota " + calificación + " ingresada es buena\n");
                Console.WriteLine("\n------FIN DEL PROGRAMA------\n");
            }

            //Si no se cumplen ninguna condición
            else
            {
                Console.WriteLine("\nLa calificación " + calificación + " es deficiente\n");
                Console.WriteLine("\n------FIN DEL PROGRAMA------\n");
            }
        }
    }
}

