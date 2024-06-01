using Gestion_Bodega.Clases.Material;
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

namespace Gestion_Bodega.Forms.Materiales
{
    public partial class wfrm_ListarMateriales : Form
    {
        public wfrm_ListarMateriales()
        {
            InitializeComponent();
        }

        private void wfrm_ListarMateriales_Load(object sender, EventArgs e)
        {
            cargar_grilla();
        }



        public void btn_test_Click(object sender, EventArgs e)
        {
            cargar_grilla();
        }

        public void cargar_grilla()  //INCLUYE FILTROS
        {
            CError o_error = new CError();
            CInterfaz x_interfaz = new CInterfaz();
            List<CMaterial> x_r = new List<CMaterial>();
            CMaterial material = new CMaterial();

            if (txt_id_material.Text.Trim() == "")
            {
                //MessageBox.Show("Debe de ingresar solamente valores numericos", "validación ",
                //MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //DialogResult = DialogResult.None;
                //return;
            }
            else
            {
                try
                {
                    material.id = Int32.Parse(txt_id_material.Text);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Por favor, ingrese solo valores numericos en la casilla (ID)", "Validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DialogResult = DialogResult.None;
                    return;
                }

            }

            if (txt_nombre_material.Text.Trim() != "")
            {
                material.nombre = txt_nombre_material.Text.ToUpper();
            }
            else
            {

            }
            if (txt_codigo_material.Text.Trim() != "")
            {
                material.codigo = txt_codigo_material.Text;
            }
            else
            {

            }
            if (txt_empresa.Text.Trim() != "")
            {
                material.empresa = txt_empresa.Text;
            }
            else
            {

            }

            x_r = x_interfaz.listarMateriales(material, ref o_error);
            this.bindingSource1.DataSource = x_r;

        }
        private void btn_volver_Click(object sender, EventArgs e)
        {
            Menu_Principal x_menu_principal = new Menu_Principal();
            this.Hide(); //ocultamos el actual
        }


        // aqui declaramos un metodo y le pasamos 2 parametros , el segundo ingresar material con llamado al metodo de actualizar evento para la grilla



        private void button1_Click(object sender, EventArgs e) //Boton Ingresar
        {
            CError o_error = new CError();
            wfrm_IngresarMateriales ingresar_material = new wfrm_IngresarMateriales();

            if (ingresar_material.ShowDialog() == DialogResult.OK) //ir al otro form
            {
                cargar_grilla();
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        public void eliminarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //de implementarse, la pantalla ELIMINAR se suprimira junto con su codigo ya que se implementara aca.

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Eliminar").Name = "Eliminar Material";
            CError o_error = new CError();
            CInterfaz x_interfaz = new CInterfaz();
            CMaterial x_material = new CMaterial();
            x_material = (CMaterial)dataGridView1.CurrentRow.DataBoundItem;
            int x_filas_afectadas = 0;

            DialogResult resultado;

            resultado = MessageBox.Show("Seguro que desea eliminar?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes) //x_material.valor == 1) quitado para la modificación
            {

                x_filas_afectadas = x_interfaz.EliminarMaterial(x_material, ref o_error);
                if (o_error.id == 0)
                {
                    resultado = MessageBox.Show("ID: " + x_material.id.ToString() + "\n" + "Se ha eliminado correctamente.");
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


        private wfrm_ModificarMaterial wfrm_modificar_material;

        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CError o_error = new CError();

            CMaterial x_m;
            x_m = (CMaterial)dataGridView1.CurrentRow.DataBoundItem;

            CInterfaz x_interfaz = new CInterfaz();
            CMaterial x_material = new CMaterial();
            CRespuestaInt x_respuesta = new CRespuestaInt();
            wfrm_ListarMateriales x_materiales_grilla = new wfrm_ListarMateriales();
            x_material = (CMaterial)dataGridView1.CurrentRow.DataBoundItem;

            wfrm_ModificarMaterial frm_modificar_material = new wfrm_ModificarMaterial();


            if (wfrm_modificar_material == null)
            {
                wfrm_modificar_material = new wfrm_ModificarMaterial();
                wfrm_modificar_material.FormClosed += (o, args) => wfrm_modificar_material = null;

            }

            wfrm_modificar_material.g_material = x_material;

            //     wfrm_modificar_material.MdiParent = this.MdiParent;  //Esta linea tiene conflicto con la siguiente



            wfrm_modificar_material.ShowDialog(); //SOLO DEBE DE SER SHOW PARA NO GENERAR CONFLICTO CON LA LINEA DE ARRIBA



            cargar_grilla();

            //this.TopMost = true;

            //frm_modificar_material.BringToFront();


            //frm_modificar_material.g_material = x_material;

            //frm_modificar_material.MdiParent = this.MdiParent;  //Esta linea tiene conflicto con la siguiente

            //frm_modificar_material.ShowDialog(); //esta linea tiene conflicto con la anterior

            //frm_modificar_material.BringToFront();




            //if (frm_modificar_material.ShowDialog() == DialogResult.OK)
            //{

            //    cargar_grilla();

            //}


        }

        private void txt_id_material_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (char.IsDigit(e.KeyChar)) //condicion para que solo sean numeros
            {
                e.Handled = false;
            }
            //Para la tecla de borrar (backspace)
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //verifica que pueda ingresar punto y también que solo pueda ingresar un punto
            else if ((e.KeyChar == '.') && (!txt_id_material.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }




    }
}

