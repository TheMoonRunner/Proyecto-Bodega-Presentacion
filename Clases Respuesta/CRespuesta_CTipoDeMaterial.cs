using Gestion_Bodega.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Bodega.Clases_Respuesta
{
    class CRespuesta_CTipoDeMaterial : CRespuestaBase
    {
        public List<CTipoDeMaterial> datos { get; set; }


        public CRespuesta_CTipoDeMaterial()
        {
            datos = new List<CTipoDeMaterial>();

        }
    }
}
