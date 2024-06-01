using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Bodega.Clases.Contenedor
{
    public class CContenedor
    {
        public string id_bodega { get; set; }
        public Nullable<int> id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public string empresa { get; set; }
        public string unidades { get; set; }

        public Nullable<int> id_contenedor { get; set; }


    }
}
