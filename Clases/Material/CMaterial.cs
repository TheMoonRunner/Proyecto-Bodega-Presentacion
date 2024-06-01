using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Bodega.Clases.Material
{
    public class CMaterial
    {
        public Nullable<int> id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int ancho { get; set; }
        public int alto { get; set; }
        public int largo { get; set; }
        public string codigo { get; set; }
        public string estado { get; set; }
        public string empresa { get; set; }
        public string unidades { get; set; }
        public int peso { get; set; }
        public string seriado { get; set; }

        public int tipo_material { get; set; } //insert
        public string descripcion_tm { get; set; } // GRILLA - y se ocupa en el leer 
    }
}
