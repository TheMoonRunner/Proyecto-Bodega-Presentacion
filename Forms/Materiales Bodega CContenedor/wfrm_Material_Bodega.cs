using Gestion_Bodega.Clases.Contenedor;
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

namespace Gestion_Bodega.Forms.Materiales_Bodega_CContenedor
{
    public partial class wfrm_Material_Bodega : Form
    {
        public wfrm_Material_Bodega()
        {
            InitializeComponent();
        }

        private void wfrm_Material_Bodega_Load(object sender, EventArgs e)
        {
            cargar_grilla();
        }

        public void cargar_grilla()
        {

            CError o_error = new CError();
            CInterfaz x_interfaz = new CInterfaz();
            List<CContenedor> x_r = new List<CContenedor>();
            CContenedor material = new CContenedor();


            if (txb_id_material.Text.Trim() != "")
            {
                material.id = Int32.Parse(txb_id_material.Text);
            }
            else
            {

            }

            if (txb_nombre_material.Text.Trim() != "")
            {
                material.nombre = txb_nombre_material.Text.ToUpper();
            }
            else
            {

            }
            if (txb_id_contenedor.Text.Trim() != "")
            {
                material.id_contenedor = Int32.Parse(txb_id_contenedor.Text);
            }
            else
            {

            }

            x_r = x_interfaz.listar_Materiales_bodegas(material, ref o_error);
            bindingSource1.DataSource = x_r;

        }



        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            cargar_grilla();
        }

        private void txb_id_material_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cargar_grilla();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            MessageBox.Show("Esto es solamente un reporte, no se pueden modificar los registros de la grilla");

        }

    }
}


