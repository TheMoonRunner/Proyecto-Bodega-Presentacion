using Gestion_Bodega.Clases;
using Gestion_Bodega.Clases.Bodega;
using Gestion_Bodega.Clases_Respuesta;
using Gestion_Bodega.Forms.Bodega;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_Bodega.Bodega
{
    public partial class wfrm_Listar_bodegas : Form
    {
        public wfrm_Listar_bodegas()
        {
            InitializeComponent();
        }

        private void wfrm_Listar_bodegas_Load(object sender, EventArgs e)
        {
            cargar_grilla();
        }

        public void cargar_grilla()
        {
            CError o_error = new CError();
            CInterfaz x_interfaz = new CInterfaz();
            List<CBodega> x_lista_de_bodega = new List<CBodega>();
            CBodega bodega = new CBodega();

            if (txt_id_filtro.Text.Trim() != "")
            {
                bodega.id = txt_id_filtro.Text.ToUpper();
            }
            if (txt_abreviaura_filtro.Text.Trim() != "")
            {
                bodega.abreviatura = txt_abreviaura_filtro.Text.ToUpper();
            }
            //if (txt_estado_filtro.Text.Trim() != "")
            //{
            //    bodega.estado = txt_estado_filtro.Text.ToUpper();
            //}

            if (cmb_estado_filtro.SelectedIndex < 1)
            {

            }
            else
            {
                if (cmb_estado_filtro.SelectedItem.ToString() == "S")
                {
                    bodega.estado = "S";
                }
                if (cmb_estado_filtro.SelectedItem.ToString() == "N")
                {
                    bodega.estado = "N";
                }

            }



            x_lista_de_bodega = x_interfaz.listar_bodegas(bodega, ref o_error);
            this.bindingSource1.DataSource = x_lista_de_bodega;
        }

        private void btn_ingresar_bodega_Click(object sender, EventArgs e)
        {
            CError o_error = new CError();
            wfrm_ingresar_bodega ingresar_bodega = new wfrm_ingresar_bodega();

            if (ingresar_bodega.ShowDialog() == DialogResult.OK) //ir al otro form
            {
                cargar_grilla();
            }
        }


        //private wfrm_modificar_bodega frm_modificar_bodega;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //CError o_error = new CError();

            CBodega x_m;
            x_m = (CBodega)dataGridView1.CurrentRow.DataBoundItem;

            CInterfaz x_interfaz = new CInterfaz();
            CBodega x_bodega = new CBodega();
            CRespuestaInt x_respuesta = new CRespuestaInt();

            x_bodega = (CBodega)dataGridView1.CurrentRow.DataBoundItem;

            wfrm_modificar_bodega frm_modificar_bodega = new wfrm_modificar_bodega();
            frm_modificar_bodega.g_bodega = x_bodega;

            if (frm_modificar_bodega.ShowDialog() == DialogResult.OK)
            {
                cargar_grilla();
            }



            // if (frm_modificar_bodega == null)
            // {
            //     frm_modificar_bodega = new wfrm_modificar_bodega();
            //     frm_modificar_bodega.FormClosed += (o, args) => frm_modificar_bodega = null;

            // }

            // frm_modificar_bodega.g_bodega = x_bodega;

            //// frm_modificar_bodega.MdiParent = this.MdiParent;  //Esta linea tiene conflicto con la siguiente



            // frm_modificar_bodega.ShowDialog(); //SOLO DEBE DE SER SHOW PARA NO GENERAR CONFLICTO CON LA LINEA DE ARRIBA



            // cargar_grilla();


            //
        }

        private void eliminarBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Eliminar").Name = "Eliminar Bodega";
            CError o_error = new CError();
            CInterfaz x_interfaz = new CInterfaz();
            CBodega x_bodega = new CBodega();
            x_bodega = (CBodega)dataGridView1.CurrentRow.DataBoundItem;
            int x_filas_afectadas = 0;

            DialogResult resultado;

            resultado = MessageBox.Show("Seguro que desea eliminar?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes) //x_material.valor == 1) quitado para la modificación
            {

                x_filas_afectadas = x_interfaz.EliminarBodega(x_bodega, ref o_error);
                if (o_error.id == 0)
                {
                    resultado = MessageBox.Show("La bodega de la ID: " + x_bodega.id.ToString() + "\n" + "Se ha eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al eliminar," + "\n" + "error debido a:" + o_error.mensaje);
                }

                cargar_grilla();
            }
            else
            {
                MessageBox.Show("Operacion cancelada");
            }
            cargar_grilla();
        }

        private void button1_Click(object sender, EventArgs e) //actualizar btn
        {
            cargar_grilla();
        }
    }

}
