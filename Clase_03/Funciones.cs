    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public static class Funciones
    {
      /// <summary>
      /// Descripcion del metodo
      /// /// </summary>
      /// <returns> Descripcion del return</returns>
        public static string  NombreApp()
        {
            return "Universidad Tecnologica Nacional";
        }

        /// <summary>
        /// aaaaaaaaaaaaaaaa
        /// </summary>
        /// <param name="division"></param>
        /// <returns>bbbbbbbbbbbbbbb</returns>
        public static int CantidadAlumnos(string division)
        {
            if (division=="A")
            {
                return 10;
            }
            else if (division == "B")
            {
                return 20;
            }
            else
            {
                return 500;
            }
        }
    }
}
