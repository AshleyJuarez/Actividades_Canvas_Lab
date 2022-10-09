using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_AMJH_1220522
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tarea Laboratorio No. 6");
            Console.WriteLine("Signo zodiacal");
            Console.WriteLine("¿Cuál es el año de su nacimiento?");
            int año = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuál es el mes de su nacimiento?");
            string mes = Console.ReadLine();
            Console.WriteLine("¿Cuál es el día de su nacimiento?");
            int dia = int.Parse(Console.ReadLine());

            //mes = mes.ToUpper();

            if ((dia > 0) && (dia <= 31))
            {
                if (mes.Equals("marzo"))
                {
                    if (dia >= 21)
                        Console.WriteLine("Su signo es: Aries");
                    else
                        Console.WriteLine("Su signo es: Piscis");
                }
                else if (mes.Equals("abril"))
                {
                    if (dia >= 20)
                        Console.WriteLine("Su signo es: Tauro");
                    else
                        Console.WriteLine("Su signo es: Aries");
                }
                else if (mes.Equals("mayo"))
                {
                    if (dia >= 21)
                        Console.WriteLine("Su signo es: Géminis");
                    else
                        Console.WriteLine("Su signo es: Tauro");
                }
                else if (mes.Equals("junio"))
                {
                    if (dia >= 21)
                        Console.WriteLine("Su signo es: Cancer");
                    else
                        Console.WriteLine("Su signo es: Géminis");
                }
                else if (mes.Equals("julio"))
                {
                    if (dia >= 23)
                        Console.WriteLine("Su signo es: Leo");
                    else
                        Console.WriteLine("Su signo es: Cancer");
                }
                else if (mes.Equals("Agosto"))
                {
                    if (dia >= 23)
                        Console.WriteLine("Su signo es: Virgo");
                    else
                        Console.WriteLine("Su signo es: Leo");
                }
                else if (mes.Equals("septiembre"))
                {
                    if (dia >= 23)
                        Console.WriteLine("Su signo es: Libra");
                    else
                        Console.WriteLine("Su signo es: Virgo");
                }
                else if (mes.Equals("octubre"))
                {
                    if (dia >= 21)
                        Console.WriteLine("Su signo es: Escorpio");
                    else
                        Console.WriteLine("Su signo es: Libra");
                }
                else if (mes.Equals("Novimebre"))
                {
                    if (dia >= 22)
                        Console.WriteLine("Su signo es: Sagitario");
                    else
                        Console.WriteLine("Su signo es: Escorpio");
                }
                else if (mes.Equals("diciembre"))
                {
                    if (dia >= 22)
                        Console.WriteLine("Su signo es: Capricornio");
                    else
                        Console.WriteLine("Su signo es: Sagitario");
                }
                else if (mes.Equals("enero"))
                {
                    if (dia >= 20)
                        Console.WriteLine("Su signo es: Acuario");
                    else
                        Console.WriteLine("Su signo es: Capricornio");
                }
                else if (mes.Equals("febrero"))
                {
                    if (dia >= 21)
                        Console.WriteLine("Su signo es: Piscis");
                    else
                        Console.WriteLine("Su signo es: Acuario");
                }
            }
            else
                Console.WriteLine("El día debe ser mayor a 0 y menor a 31");
                        
            {
                Console.WriteLine("Hecho por: Ashley Juárez");
                Console.WriteLine("El programa ha terminado");
                Console.ReadKey();
            }
        }
    }
}
