using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_6
{
    //Reynoso Rosales Eduardo Guadalupe
    class Program
    {


        static void Main(string[] args)
        {
            //variable auxiliar y instancia de la clase Registro
            char opc;
            Registro producto = new Registro();

            do
            {
                //Menu
                Console.Clear();
                Console.WriteLine("-Sistema de inventarios Amazon-");
                Console.WriteLine("Bienvenido, ¿qué es lo que deseas hacer?");
                Console.WriteLine("1) Registrar productos. \n2) Consultar productos registrados. \n3) Salir del programa.");
                opc = Console.ReadKey().KeyChar;

                switch (opc)
                {
                    case '1':
                        Console.Clear();
                        producto.Registrar();
                        break;

                    case '2':
                        Console.Clear();
                        producto.Consultar();
                        break;

                    case '3':
                        Console.Clear();
                        Console.WriteLine("No vemos, GRACIAS por usar nuestra aplicación.");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Esa opción no es valida...");
                        Console.WriteLine("Presiona cualquier tecla para continuar...");
                        Console.ReadKey();

                        break;
                
                }

            } while (opc != '3');

            
        }
    }
}
