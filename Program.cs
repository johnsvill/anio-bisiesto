using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int anio;
                do
                {
                    Console.Write("Ingrese el año: ");
                    anio = PidaEntero();
                    if(anio <= 0)
                    {
                        Console.WriteLine("\nDebe ingresar solo números positivos. \nInténtelo de nuevo o presione CTRL + C para cancelar...\n");
                    }
                } while(anio <= 0);
                
                DateTime fecha = DateTime.Now;
                string aux;

                if (fecha.Year == anio) aux = "es";
                else if (fecha.Year < anio) aux = "será";
                else aux = "fue";

                if (EsBisiesto(anio))
                {
                    Console.WriteLine("El año {0} SI {1} bisiesto", anio, aux);
                }
                else
                {
                    Console.WriteLine("El año {0} NO {1} bisiesto", anio, aux);
                }
                Console.WriteLine("\nPresione ENTER para continuar validando otro año o CTRL + C para terminar\n");
                Console.ReadKey();
            } while (true);
        }
        //Método para capturar string en la consola y convertir a entero
        static int PidaEntero()
        {
            int numero;
            string cadena;
            cadena = Console.ReadLine();
            try
            {
                numero = Convert.ToInt16(cadena);
            }
            catch(Exception)
            {
                numero = -1;
            }
            return numero;
        }
        static bool EsBisiesto(int anio)
        {
            if(anio % 4 == 0)
            {
                if(anio % 100 == 0)
                {
                    if(anio % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
