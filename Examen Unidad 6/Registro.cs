using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen_Unidad_6
{
    //Clase
    class Registro
    {
        //atributos
        string nombre;
        string descripcion;
        float precio;
        int cant;
        
        

        //Metodos
        public void Registrar()
        {
            StreamWriter sw = new StreamWriter("Productos.txt",true);
            
            char resp;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("- Bienvendio al registro de productos");

                    Console.WriteLine("- Ahora ingresarás todos los datos necesarios para registrar el nuevo producto.");

                    Console.Write("* Indica el nombre del nuevo producto: ");
                    nombre = Console.ReadLine();

                    Console.Write("\n* Indica la descripción del nuevo producto: ");
                    descripcion = Console.ReadLine();

                    Console.Write("\n* Indica el precio del nuevo producto: ");
                    precio = int.Parse(Console.ReadLine());

                    Console.Write("\n* Indica la cantidad que habrá de deste producto en stock: ");
                    cant = int.Parse(Console.ReadLine());
                   
                    sw.WriteLine("\n*Nombre: " + nombre);
                    sw.WriteLine("*Descripción: " + descripcion);
                    sw.WriteLine("*Precio: {0:C}", precio);
                    sw.WriteLine("*Cantidad en stock: " + cant);

                    Console.WriteLine("Se registró tu producto en el archivo.");





                    Console.WriteLine("¿Deseas seguir capturando productos? (s/n)");
                    resp = Console.ReadKey().KeyChar;
                } while ((resp == 's') || (resp == 'S'));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

                if (sw != null)
                    sw.Close();
            }

            Console.WriteLine("\n\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }


        public void Consultar()
        {
            StreamReader sr = new StreamReader("Productos.txt");
            string registro;
            try
            {
                
                

                registro = sr.ReadLine();

                Console.WriteLine("Bienvenido al registro de todos los productos almacenados.");

                while (registro != null)
                {
                    Console.WriteLine(registro);
                    registro = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

                if (sr != null)
                    sr.Close();
            }

            Console.WriteLine("\n\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }


        ~Registro()
        {
            Console.WriteLine("MEMORIA LIBERADA CLASE REGISTRO.");
        }
    }
}
