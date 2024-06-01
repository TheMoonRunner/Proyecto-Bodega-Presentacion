using Gestion_Bodega.Clases.Bodega;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Bodega.Clases_Respuesta
{
    public class CRespuestaBodegaLista : CRespuestaBase
    {
        public List<CBodega> datos { get; set; }

        public CRespuestaBodegaLista()
        {

        }

    }
}
