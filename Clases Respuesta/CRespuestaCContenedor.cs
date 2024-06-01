using Gestion_Bodega.Clases.Contenedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Bodega.Clases_Respuesta
{
    public class CRespuestaCContenedor : CRespuestaBase
    {
        public List<CContenedor> datos { get; set; }

        public CRespuestaCContenedor()
        {
            datos = new List<CContenedor>();
        }

    }
}
