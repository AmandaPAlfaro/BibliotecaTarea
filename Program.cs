using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   ***Menu Sistema***  ");
            MenuSistema menuSistema = new MenuSistema();
            menuSistema.menuPrincipal();

            //Console.WriteLine("Buscar Libro");
            //Console.WriteLine();
            //Console.WriteLine("Verificar stock"); 
            //Console.WriteLine();
            //Console.WriteLine("Registre el libro");
            //Console.WriteLine();
            //Console.WriteLine("Elimine el Libro");
            //Console.WriteLine();
            //Console.WriteLine("Registrar el prestamo");
            //Console.WriteLine();

            //Console.WriteLine("Hacer reserva //tiempo ");
            //Console.WriteLine();
            //Console.WriteLine("Realizar devolucion");
            Console.ReadLine();
        }
    }
}
