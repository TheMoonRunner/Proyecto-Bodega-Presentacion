using Gestion_Bodega.Clases.Movimientos;
using Gestion_Bodega.Clases;
using Gestion_Bodega.Clases_Respuesta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Bodega.Forms.Materiales;

namespace Gestion_Bodega.Forms.Movimientos
{
    public partial class wfrm_Movimientos_Listado : Form
    {
        public wfrm_Movimientos_Listado()
        {
            InitializeComponent();
        }

        private void wfrm_Movimientos_Listado_Load(object sender, EventArgs e)
        {
            cargar_grilla();
        }
        private void cargar_grilla()
        {
            CError o_error = new CError();
            CInterfaz x_interfaz = new CInterfaz();
            List<CMovimientos> lista_cmovimientos = new List<CMovimientos>();
            CMovimientos movimiento = new CMovimientos();

            if (txt_id.Text.Trim() != "")
            {
                movimiento.id = Int32.Parse(txt_id.Text);
            }

            if (txt_id_material.Text.Trim() != "")
            {
                movimiento.id_material = Int32.Parse(txt_id_material.Text);
            }

            if (txt_tipo_operacion.Text.Trim() != "")
            {
                movimiento.tipo_operacion = txt_tipo_operacion.Text.ToUpper();
            }

            if (txt_usuario.Text.Trim() != "")
            {
                movimiento.usuario = txt_usuario.Text.ToUpper();
            }

            lista_cmovimientos = x_interfaz.listar_movimientos(movimiento, ref o_error);
            this.bindingSource1.DataSource = lista_cmovimientos;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            cargar_grilla();
        }

        public wfrm_ListarMateriales g_movimiento;

        public wfrm_movimientos_modificar frm_movimientos_modificar;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //Utilizar en modificar
        {

            CError o_error = new CError();

            CMovimientos x_m;
            x_m = (CMovimientos)dataGridView1.CurrentRow.DataBoundItem;

            CInterfaz x_interfaz = new CInterfaz();
            CMovimientos x_movimiento = new CMovimientos();
            CRespuestaInt x_respuesta = new CRespuestaInt();



            x_movimiento = (CMovimientos)dataGridView1.CurrentRow.DataBoundItem;

            wfrm_movimientos_modificar x_modificar_movimiento = new wfrm_movimientos_modificar();

            x_modificar_movimiento.g_movimientos = x_movimiento;


            if (x_modificar_movimiento.ShowDialog() == DialogResult.OK)
            {
                cargar_grilla();
            }


            //if (frm_movimientos_modificar == null)
            //{
            //    frm_movimientos_modificar = new wfrm_movimientos_modificar();
            //    frm_movimientos_modificar.FormClosed += (o, args) => frm_movimientos_modificar = null;
            //}

            // frm_movimientos_modificar.g_movimientos = x_movimiento;

            // //frm_movimientos_modificar.MdiParent = this.MdiParent;  //Esta linea tiene conflicto con la siguiente



            //// frm_movimientos_modificar.ShowDialog(); //SOLO DEBE DE SER SHOW PARA NO GENERAR CONFLICTO CON LA LINEA DE ARRIBA



            //cargar_grilla();

        }

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Eliminar").Name = "Eliminar Bodega";
            CError o_error = new CError();
            CInterfaz x_interfaz = new CInterfaz();
            CMovimientos x_movimiento = new CMovimientos();
            x_movimiento = (CMovimientos)dataGridView1.CurrentRow.DataBoundItem;
            int x_filas_afectadas = 0;

            DialogResult resultado;

            resultado = MessageBox.Show("Seguro que desea eliminar?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes) //x_material.valor == 1) quitado para la modificación
            {
                x_filas_afectadas = x_interfaz.Movimiento_Eliminar(x_movimiento, ref o_error);
                if (o_error.id == 0)
                {
                    resultado = MessageBox.Show("La bodega de la ID: " + x_movimiento.id.ToString() + "\n" + "Se ha eliminado correctamente.");
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
    }
}
