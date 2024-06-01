using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Bodega.Clases.Movimientos
{
    public class CMovimientos
    {

        //Propiedades de la clase

        //AQUI VAN LOS ATRIBUTOS DE LA CLASE

        public Nullable<int> id { get; set; }
        public Nullable<int> id_material { get; set; }
        public int id_contenedor { get; set; }
        public string tipo_operacion { get; set; }
        public int cantidad { get; set; }
        public Nullable<DateTime> fecha { get; set; }
        public string usuario { get; set; }

        public int ID_DOCUMENTO_ORIGEN { get; set; }
        public int ID_TIPO_DOCUMENTO_ORIGEN { get; set; }
        public string serie { get; set; }


    }
}
