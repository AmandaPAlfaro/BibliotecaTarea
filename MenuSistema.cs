using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class MenuSistema
    {
        public void menuPrincipal() 
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("Opciones M.S.");
                Console.WriteLine();
                Console.WriteLine("1. BIBLIOTECARIO ");
                Console.WriteLine();
                Console.WriteLine("2. USUARIO ");
                Console.WriteLine();
                Console.WriteLine("Elija su opcion");
                Console.WriteLine();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(" Estamos en Menu BIBLIOTECARIO ");
                        BibliotecarioVista bibliotecarioVista = new BibliotecarioVista();
                        bibliotecarioVista.bibliotecarioVista();
                        break;

                    case 2:
                        Console.WriteLine(" Estamos en Menu USUARIO ");
                        UsuarioVista usuarioVista = new UsuarioVista();
                        
                        break;

                    default:
                        break;
                }

            } while (opcion >= 2);
        }
  
    }
    
}
