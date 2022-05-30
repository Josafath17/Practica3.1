using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2 ,area;
            double pi =3.14;
            //int num3 = 2;
        
            bool salir = false;

            while (!salir)
            {
                try
                {
                    Console.WriteLine("Bienvenido Calculador de Areas");
                    Console.WriteLine("1. Area Rectangulo");
                    Console.WriteLine("2. Area Cuadrado");
                    Console.WriteLine("3. Area Circulo");
                    Console.WriteLine("4. Area Triangulo");
                    Console.WriteLine("5. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1: 
                            Console.WriteLine("Buscar Area del Rectangulo");
                            Console.WriteLine("Ingrese Largo: ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese ancho: ");
                            num2 = int.Parse(Console.ReadLine());
                            area =num1 * num2;
                            Console.WriteLine("El resultados del Area del Rectangulo es: " + area);

                            break;


                        case 2:
                            Console.WriteLine("Buscar Area del Cuadrado");
                            Console.WriteLine("Ingrese Lado: ");
                            num1 = int.Parse(Console.ReadLine());
                            area = num1 * num1;
                            Console.WriteLine("El resultados del Area del Cuadrado es: " + area);
                            break;

                        case 3:
                            Console.WriteLine("Buscar Area del Circulo");
                            Console.WriteLine("Ingrese Radio: ");
                            num1 = int.Parse(Console.ReadLine());
                           
                            area = (int)(pi * num1*num1);
                            Console.WriteLine("El resultados del Area del Circulo es: " + area);

                            break;

                        case 4:
                            Console.WriteLine("Buscar Area del Triangulo");
                            Console.WriteLine("Ingrese Base: ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese La altura: ");
                            num2 = int.Parse(Console.ReadLine());
                            area = num1 * num2 / 2;
                            Console.WriteLine("El resultados del Area del Triangulo es: " + area);
                            break;

                        case 5:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 5");
                            break;
                    }

                
}
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadLine();
                Console.Clear();
            }
    }
}
}