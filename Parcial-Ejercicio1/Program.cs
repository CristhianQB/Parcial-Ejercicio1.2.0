using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el año: ");
            int año = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el peso: ");
            int peso = int.Parse(Console.ReadLine());

            Console.ReadKey();
            Console.Clear();

            int clase = 0;
            float tarifa = 0f;
            if (año <= 1970)
            {
                for (int i = 0; peso < 2700 && i == 0; i++)
                {
                    clase = 1;
                    tarifa = 16.50f;
                    i++;
                }
                for (int i = 0; peso >= 2700 && peso <= 3800 && i == 0; i++)
                {
                    clase = 2;
                    tarifa = 25.50f;
                    i++;
                }
                for (int i = 0; peso > 3800 && i == 0; i++)
                {
                    clase = 3;
                    tarifa = 46.50f;
                    i++;
                }
            }
            else if (año >= 1971 && año <= 1979)
            {
                for (int i = 0; peso < 2700 && i == 0; i++)
                {
                    clase = 4;
                    tarifa = 27.00f;
                    i++;
                }
                for (int i = 0; peso >= 2700 && peso <= 3800 && i == 0; i++)
                {
                    clase = 5;
                    tarifa = 30.50f;
                    i++;
                }
                for (int i = 0; peso > 3800 && i == 0; i++)
                {
                    clase = 6;
                    tarifa = 52.50f;
                    i++;
                }
            }
            else if (año >= 1980)
            {
                for (int i = 0; peso < 3500 && i == 0; i++)
                {
                    clase = 7;
                    tarifa = 19.50f;
                    i++;
                }
                for (int i = 0; peso >= 3500 && i == 0; i++)
                {
                    clase = 8;
                    tarifa = 52.50f;
                    i++;
                }

            }
            Console.Write("Año del modelo");
            Console.Write("{0,10}", "Peso");
            Console.Write("{0,24}", "Clase de peso");
            Console.Write("{0,30}", "Tarifa de registro");
            Console.WriteLine();

            Console.Write(año);
            Console.Write("{0,24}", peso + " lbs");
            Console.Write("{0,8}", clase);
            Console.Write("{0,28}", tarifa);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
