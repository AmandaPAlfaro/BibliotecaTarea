using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class BibliotecarioVista
    {
        public void bibliotecarioVista() 
        {
            do
            {
                int opcion = 0;
                Console.WriteLine("Buscar Libros");
                Console.WriteLine();
                Console.WriteLine("Verificar stock"); 
                Console.WriteLine();
                Console.WriteLine("Registrar Libros");
                Console.WriteLine();
                Console.WriteLine("Eliminar Libro");
                Console.WriteLine();
                Console.WriteLine("Registrar Prestamo");
                Console.WriteLine();

                switch (opcion)
                {

                    case 1:
                        Console.WriteLine("Ingrece el libro que desea buascar");

                        break;

                    case 2:
                        Console.WriteLine("Verifique stock - ingrese el nombre del libro");
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el libro que desea registrar");
                        break;

                    case 4:
                        Console.WriteLine("Ingrese el libro que quiera eliminar");
                        break;

                    case 5:
                        Console.WriteLine("Registre el prestamo");
                        break;                        

                    default:
                        break;
                }

            } while (true);
        }
    }
}
