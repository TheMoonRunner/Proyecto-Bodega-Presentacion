using Gestion_Bodega.Clases.Tipo_Contenedor;
using Gestion_Bodega.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Bodega.Forms.Tipo_Contenedor
{
    public partial class wfrm_CTipoContenedor_Listar : Form
    {
        public wfrm_CTipoContenedor_Listar()
        {
            InitializeComponent();
        }

        private void wfrm_CTipoContenedor_Listar_Load(object sender, EventArgs e)
        {
            cargar_grilla();
        }



        private void cargar_grilla()
        {
            CError o_error = new CError();
            CInterfaz x_interfaz = new CInterfaz();
            List<CTipoContenedor> lista_Tcontenedor = new List<CTipoContenedor>();
            CTipoContenedor x_tipo_contenedor = new CTipoContenedor();


            if (txt_id.Text.Trim() != "")
            {
                x_tipo_contenedor.id = Int32.Parse(txt_id.Text);
            }
            if (txt_nombre.Text.Trim() != "")
            {
                x_tipo_contenedor.nombre = txt_nombre.Text;
            }
            if (txt_estado.Text.Trim() != "")
            {
                x_tipo_contenedor.estado = txt_estado.Text;
            }

            //lista_Tcontenedor = x_interfaz; //complete el codigo faltante
            //this.bindingSource1.DataSource = lista_Tcontenedor;

        }


    }
}

