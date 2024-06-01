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
    public partial class wfrm_IngresarMateriales : Form
    {
        public wfrm_IngresarMateriales()
        {
            InitializeComponent();
        }

        private void wfrm_IngresarMateriales_Load(object sender, EventArgs e)
        {

        }

        public void actualizarGrilla()
        {
            CError o_error = new CError();
            wfrm_ListarMateriales actualiar_grilla = new wfrm_ListarMateriales();
            actualiar_grilla.cargar_grilla();

        }
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            actualizarGrilla();
        }
        private void IngresarMaterial_Load_1(object sender, EventArgs e)
        {
            CError o_error = new CError();

            cmb_seriado.SelectedIndex = 0;
            cmb_estado.SelectedIndex = 0;
            cargar_cmb_tipo_material();
            actualizarGrilla();

        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
        public void descripcion_cmb_tipo_material()
        {

        }
        public void cargar_cmb_tipo_material()
        {

            CError o_error = new CError();
            CInterfaz x = new CInterfaz();
            List<CTipoDeMaterial> x_r = new List<CTipoDeMaterial>();
            x_r = x.tipo_material_listar(ref o_error);
            cmb_tipo_material.DataSource = x_r;
            cmb_tipo_material.DisplayMember = "descripcion"; //carga la columna de descripcion
            cmb_tipo_material.SelectedValue = "id";
        }

        private void btn_ingresar_Click_1(object sender, EventArgs e)
        {
            CError o_error = new CError();
            CInterfaz x_interfaz = new CInterfaz();
            CRespuestaInt x_material = new CRespuestaInt();
            CMaterial material = new CMaterial();
            wfrm_ListarMateriales x_listar = new wfrm_ListarMateriales();
            int ingresar_material = 0;
            CTipoDeMaterial tipo_material = new CTipoDeMaterial();

            DialogResult resultado;
            resultado = MessageBox.Show("Los datos Ingresados son correctos?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (txb_nombre.Text == "") //Como son materiales se pueden ingresar numeros y letras
            {
                MessageBox.Show("Debe de ingresar algun nombre", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;
            }
            else
            {

                material.nombre = txb_nombre.Text.ToUpper();
            }

            material.descripcion = txb_descripcion.Text.ToUpper(); //DESCRIPCION PUEDE SER NULL

            if (txb_ancho.Text == "")
            {
                MessageBox.Show("Debe de ingresar algun valor de ancho", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                try
                {
                    material.ancho = Int32.Parse(txb_ancho.Text);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Por favor, verifique el dato ingresado en la casilla (ANCHO)", "Validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DialogResult = DialogResult.None;
                    return;
                }

            }

            if (txb_alto.Text == "")
            {

                MessageBox.Show("Debe de ingresar algun valor de alto", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;
            }
            else
            {

                try
                {
                    material.alto = Int32.Parse(txb_alto.Text);
                }

                catch (Exception error)
                {
                    MessageBox.Show("Por favor, verifique el dato ingresado en la casilla (ALTO) ", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    DialogResult = DialogResult.None;
                    txb_alto.Text = "";


                    return;
                }

            }

            if (txb_largo.Text == "")
            {
                MessageBox.Show("Debe de ingresar algun valor largo", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;
            }
            else
            {



                try
                {
                    material.largo = Int32.Parse(txb_largo.Text);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Por favor, verifique el dato ingresado en la casilla (LARGO)", "Validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DialogResult = DialogResult.None;
                    return;
                }
            }

            if (txb_codigo.Text == "")
            {
                MessageBox.Show("Debe de ingresar algun valor de codigo", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;

            }
            else
            {
                material.codigo = txb_codigo.Text.ToUpper();
            }

            if (cmb_estado.SelectedIndex == 0)
            {
                MessageBox.Show("Debe de seleccionar una opcion para estado", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;

            }
            else
            {
                if (cmb_estado.SelectedItem.ToString() == "ACTIVO")
                {
                    material.estado = "S";
                }
                if (cmb_estado.SelectedItem.ToString() == "INACTIVO")
                {
                    material.estado = "N";
                }
            }



            if (txb_empresa.Text == "")
            {
                MessageBox.Show("Debe de ingresar algun nombre de empresa", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;

            }
            else
            {
                material.empresa = txb_empresa.Text.ToUpper();
            }

            if (txb_unidades.Text == "")
            {
                MessageBox.Show("Debe de ingresar algun valor de unidades", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;

            }
            else
            {
                material.unidades = txb_unidades.Text.ToUpper();
            }

            if (txb_peso.Text == "")
            {
                MessageBox.Show("Debe de ingresar algun valor de peso", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;

            }
            else
            {



                try
                {
                    material.peso = Int32.Parse(txb_peso.Text);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Por favor, verifique el dato ingresado en la casilla (PESO)", "Validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DialogResult = DialogResult.None;
                    return;
                }
            }

            if (cmb_seriado.SelectedIndex == 0)
            {
                MessageBox.Show("Debe de seleccionar una opcion para seriado", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;

            }
            else
            {
                if (cmb_seriado.SelectedItem.ToString() == "SI")
                {
                    material.seriado = "S";
                }
                if (cmb_seriado.SelectedItem.ToString() == "NO")
                {
                    material.seriado = "N";
                }
            }



            if (cmb_tipo_material.SelectedIndex == 0)
            {
                MessageBox.Show("Debe de seleccionar una opcion para (TIPO MATERIAL)", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;

            }
            else
            {
                if (cmb_seriado.SelectedItem.ToString() == "(SELECCIONE)")
                {
                    MessageBox.Show("Debe de seleccionar una opcion para (TIPO MATERIAL)", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DialogResult = DialogResult.None;
                    return;
                }

            }


            tipo_material.id = cmb_tipo_material.SelectedIndex;   //select ID del CMB segun la desc escogida                        

            //}
            //else
            //{
            //    MessageBox.Show("Error, no se han encontrado valores a ingresar. Accion Cancelada");

            //}



            ingresar_material = x_interfaz.IngresarMateriales(material, tipo_material, ref o_error);

            if (o_error.id != 0)
            {

                MessageBox.Show("Error, no se ha logrado ingresar" + "\n" + "Error: " + o_error.mensaje.ToString());
                DialogResult = DialogResult.None;
                return;
            }
            if (o_error.id == 0)
            {
                /*resultado =*/
                MessageBox.Show("ID: " + ingresar_material.ToString() + "\n" + "Mensaje: Se ha ingresado correctamente");
                return;

            }

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close(); //CERRAMOS el FORM actual
        }

        private void lbl_id_ingresado_respuesta_Click(object sender, EventArgs e)
        {
        }
        //
        // LO SIGUIENTE ES VALIDACION DE TIPO DE DATO EN CIERTOS TEXTBOX
        //
        private void txb_ancho_KeyPress(object sender, KeyPressEventArgs e) //vALIDACION DE ENTRADA PARA TEXTBOX "ANCHO"
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
            else if ((e.KeyChar == '.') && (!txb_ancho.Text.Contains(".")))
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

        private void txb_alto_KeyPress(object sender, KeyPressEventArgs e)
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
            else if ((e.KeyChar == '.') && (!txb_alto.Text.Contains(".")))
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

        private void txb_largo_KeyPress(object sender, KeyPressEventArgs e)
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
            else if ((e.KeyChar == '.') && (!txb_largo.Text.Contains(".")))
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

        private void txb_peso_KeyPress(object sender, KeyPressEventArgs e)
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
            else if ((e.KeyChar == '.') && (!txb_peso.Text.Contains(".")))
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

        public void IngresarMaterial_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }

}


