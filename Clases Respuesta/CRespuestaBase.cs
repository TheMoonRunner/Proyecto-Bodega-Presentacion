using Gestion_Bodega.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Bodega.Clases_Respuesta
{
    public class CRespuestaBase
    {
        public CError o_error { get; set; }


        public CRespuestaBase()
        {
            o_error = new CError();
        }


    }
}
