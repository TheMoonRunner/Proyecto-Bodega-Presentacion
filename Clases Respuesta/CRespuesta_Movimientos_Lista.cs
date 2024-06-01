using Gestion_Bodega.Clases.Movimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Bodega.Clases_Respuesta
{
    public class CRespuesta_Movimientos_Lista : CRespuestaBase
    {

        public List<CMovimientos> datos { get; set; }

        public List<Int32> datos_num { get; set; }

        public CRespuesta_Movimientos_Lista()
        {

        }

    }
}
