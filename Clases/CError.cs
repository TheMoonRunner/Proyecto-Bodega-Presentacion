using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Bodega.Clases
{
    public class CError
    {
        public int id { get; set; }
        public string mensaje { get; set; }

        public CError()
        {
            id = 0;
            mensaje = "";
        }

    }
}
