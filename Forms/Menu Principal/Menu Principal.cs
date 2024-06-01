using Gestion_Bodega.Bodega;
using Gestion_Bodega.Clases;
using Gestion_Bodega.Forms.Materiales;
using Gestion_Bodega.Forms.Materiales_Bodega_CContenedor;
using Gestion_Bodega.Forms.Movimientos;
using Gestion_Bodega.Forms.Tipo_Contenedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Bodega
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void btn_ingresar_material_Click(object sender, EventArgs e)
        {

        }

        private void btn_listar_materiales_Click(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private wfrm_ListarMateriales listar_material;


        public void listarMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CError o_error = new CError();
            if (listar_material == null)
            {
                listar_material = new wfrm_ListarMateriales(); //instanciar el form

                listar_material.FormClosed += (o, args) => listar_material = null;
            }

            listar_material.MdiParent = this;
            listar_material.Show();

            //this.TopMost = true;

            //listar_material.BringToFront();

        }
        private void Menu_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private wfrm_Listar_bodegas listar_bodegas;

        private void listarBodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CError o_error = new CError();
            if (listar_bodegas == null)
            {
                listar_bodegas = new wfrm_Listar_bodegas(); //instanciar el form            
                listar_bodegas.FormClosed += (o, args) => listar_bodegas = null;

            }

            listar_bodegas.MdiParent = this;

            listar_bodegas.Show();

            listar_bodegas.BringToFront();
        }


        private wfrm_Material_Bodega form_grilla_material_bodega;

        private void listarMaterialesBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_grilla_material_bodega == null)
            {
                form_grilla_material_bodega = new wfrm_Material_Bodega(); //instanciar el form            

                form_grilla_material_bodega.FormClosed += (o, args) => form_grilla_material_bodega = null;
            }
            CError o_error = new CError();

            form_grilla_material_bodega.MdiParent = this;

            form_grilla_material_bodega.Show();
            form_grilla_material_bodega.BringToFront();
        }


        private wfrm_Movimientos_Listado x_listar_movimientos;

        private void listarMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CError o_error = new CError();
            if (x_listar_movimientos == null)
            {

                x_listar_movimientos = new wfrm_Movimientos_Listado(); //instanciar el form            
                x_listar_movimientos.FormClosed += (o, args) => x_listar_movimientos = null;

            }

            x_listar_movimientos.MdiParent = this;

            x_listar_movimientos.Show();

            x_listar_movimientos.BringToFront();

        }




        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private wfrm_CTipoContenedor_Listar x_listar_CTipo_contenedor;

        private void listarTipoContenedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CError o_error = new CError();

            if (x_listar_CTipo_contenedor == null)
            {
                x_listar_CTipo_contenedor = new wfrm_CTipoContenedor_Listar();
                x_listar_CTipo_contenedor.FormClosed += (o, args) => x_listar_CTipo_contenedor = null;

            }

            x_listar_CTipo_contenedor.MdiParent = this;
            x_listar_CTipo_contenedor.Show();
            x_listar_CTipo_contenedor.BringToFront();

        }


    }
}
