using Gestion_Bodega.Clases.Material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Bodega.Clases_Respuesta
{
    public class CRespuestaListaMaterial : CRespuestaBase
    {

        public List<CMaterial> datos { get; set; }

        public CRespuestaListaMaterial()
        {
            datos = new List<CMaterial>();

        }

    }
}
