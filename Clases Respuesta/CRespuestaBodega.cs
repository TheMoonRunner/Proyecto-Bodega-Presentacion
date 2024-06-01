using Gestion_Bodega.Clases.Bodega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Bodega.Clases_Respuesta
{
    public class CRespuestaBodega : CRespuestaBase
    {

        public CBodega datos { get; set; }

        public CRespuestaBodega()
        {

        }
    }
}
