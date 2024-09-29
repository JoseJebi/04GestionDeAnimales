using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GestionDeAnimales
{
    public class Program
    {
        public static void Main()
        {
            ArrayList animales= new ArrayList();
            int opcMenu;

            do
            {
                Console.WriteLine("Selecciona una opción:" +
                    "\n1. Añadir nuevo animal" +
                    "\n2. Mostrar información de todos los animales" +
                    "\n3. Buscar animal por nombre" +
                    "\n4. Eliminar animal");

                opcMenu = int.Parse(Console.ReadLine());
            } while (opcMenu > 0 && opcMenu < 5);
        }
    }
}
