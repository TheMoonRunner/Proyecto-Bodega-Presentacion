using Gestion_Bodega.Clases.Tipo_Contenedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Bodega.Clases_Respuesta
{
    public class CTipoContenedor_respuesta : CRespuestaBase
    {
        public List<CTipoContenedor> datos { get; set; }


        public CTipoContenedor_respuesta()
        {
            datos = new List<CTipoContenedor>();

        }

    }
}
