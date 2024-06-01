using Gestion_Bodega.Clases.Material;
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
using static Gestion_Bodega.Forms.Bodega.wfrm_modificar_bodega;

namespace Gestion_Bodega.Forms.Materiales
{
    public partial class wfrm_ModificarMaterial : Form
    {
        public class CCodigoTmpString
        {
            public string id { get; set; }
            public string descripcion { get; set; }

            public CCodigoTmpString()
            {

            }
        }


        public CMaterial g_material;//g = grilla  = g_material
        public CTipoDeMaterial c_tipo_material;


        public wfrm_ModificarMaterial()
        {
            InitializeComponent();
        }

        private void wfrm_ModificarMaterial_Load(object sender, EventArgs e)
        {
            llenar_combo_tipo_material();
            llenar_combo_estado();
            llenar_combo_seriado();
            LlenarCampos();

        }


        public void llenar_combo_estado()
        {
            List<CCodigoTmpString> x_lista = new List<CCodigoTmpString>();
            CCodigoTmpString a = new CCodigoTmpString();
            a.id = "S";
            a.descripcion = "Activo";
            x_lista.Add(a);

            a = new CCodigoTmpString();
            a.id = "N";
            a.descripcion = "Inactivo";
            x_lista.Add(a);

            cmb_estado.DataSource = x_lista;
            cmb_estado.DisplayMember = "descripcion";
            cmb_estado.ValueMember = "id";
        }

        public void llenar_combo_seriado()
        {
            List<CCodigoTmpString> x_lista = new List<CCodigoTmpString>();
            CCodigoTmpString a = new CCodigoTmpString();
            a.id = "S";
            a.descripcion = "SI";
            x_lista.Add(a);

            a = new CCodigoTmpString();
            a.id = "N";
            a.descripcion = "NO";
            x_lista.Add(a);

            cmb_seriado.DataSource = x_lista;
            cmb_seriado.DisplayMember = "descripcion";
            cmb_seriado.ValueMember = "id";

        }

        public void llenar_combo_tipo_material()
        {
            CError o_error = new CError();
            CInterfaz x = new CInterfaz();
            List<CTipoDeMaterial> x_r = new List<CTipoDeMaterial>();
            x_r = x.tipo_material_listar(ref o_error);

            cmb_tipo_de_material.DataSource = x_r;
            cmb_tipo_de_material.DisplayMember = "descripcion"; //carga la columna de descripcion
            cmb_tipo_de_material.ValueMember = "id";
        }

        private void LlenarCampos()
        {
            //TEXTBOX  // G = GRILLA 
            txb_id.Text = g_material.id.ToString();
            txb_nombre.Text = g_material.nombre;
            txb_descripcion.Text = g_material.descripcion;
            txb_ancho.Text = g_material.ancho.ToString();
            txb_alto.Text = g_material.alto.ToString();
            txb_largo.Text = g_material.largo.ToString();
            txb_codigo.Text = g_material.codigo.ToString();
            txb_empresa.Text = g_material.empresa;
            txb_unidades.Text = g_material.unidades;
            txb_peso.Text = g_material.peso.ToString();

            //COMBOBOX
            cmb_estado.SelectedValue = g_material.estado;
            cmb_seriado.SelectedValue = g_material.seriado;
            cmb_tipo_de_material.SelectedValue = g_material.tipo_material;
        }



        private void btn_modificar_Click(object sender, EventArgs e)
        {
            CError o_error = new CError();
            CMaterial material_a_modificar = new CMaterial();
            CMaterial x_material = new CMaterial();
            CInterfaz interfaz = new CInterfaz();

            if (txb_nombre.Text.Trim() == "")
            {
                MessageBox.Show("El nombre no puede estar vacio,  ¡ERROR!");
                DialogResult = DialogResult.None;
                txb_nombre.Focus();
                return;
            }

            if (txb_ancho.Text.Trim() == "")
            {
                MessageBox.Show("El valor de Ancho no puede estar vacio,  ¡ERROR!");
                DialogResult = DialogResult.None;
                txb_ancho.Focus();
                return;
            }

            x_material.descripcion = txb_descripcion.Text;

            if (txb_alto.Text.Trim() == "")
            {
                MessageBox.Show("El valor de Alto no puede estar vacio,  ¡ERROR!");
                DialogResult = DialogResult.None;
                txb_alto.Focus();
                return;
            }

            if (txb_largo.Text.Trim() == "")
            {
                MessageBox.Show("El valor de Largo no puede estar vacio,  ¡ERROR!");
                DialogResult = DialogResult.None;
                txb_largo.Focus();
                return;
            }

            if (txb_codigo.Text.Trim() == "")
            {
                MessageBox.Show("El valor de codigo no puede estar vacio,  ¡ERROR!");
                DialogResult = DialogResult.None;
                txb_codigo.Focus();
                return;
            }

            if (txb_empresa.Text.Trim() == "")
            {
                MessageBox.Show("Empresa no puede estar vacio,  ¡ERROR!");
                DialogResult = DialogResult.None;
                txb_empresa.Focus();
                return;
            }

            if (txb_unidades.Text.Trim() == "")
            {
                MessageBox.Show("Empresa no puede estar vacio,  ¡ERROR!");
                DialogResult = DialogResult.None;
                txb_unidades.Focus();
                return;
            }

            if (txb_peso.Text.Trim() == "")
            {
                MessageBox.Show("Empresa no puede estar vacio,  ¡ERROR!");
                DialogResult = DialogResult.None;
                txb_peso.Focus();
                return;
            }


            if (cmb_tipo_de_material.SelectedIndex == 0)
            {
                MessageBox.Show("Debe de seleccionar una opcion para (TIPO MATERIAL)", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;

            }
            else
            {
                if (cmb_tipo_de_material.SelectedItem.ToString() == "(SELECCIONE)")
                {
                    MessageBox.Show("Debe de seleccionar una opcion para (TIPO MATERIAL)", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DialogResult = DialogResult.None;
                    return;
                }

            }


            x_material.id = Int32.Parse(txb_id.Text);
            x_material.nombre = txb_nombre.Text;
            x_material.descripcion = txb_descripcion.Text;
            x_material.codigo = txb_codigo.Text;
            x_material.empresa = txb_empresa.Text;
            x_material.largo = Int32.Parse(txb_largo.Text);
            x_material.ancho = Int32.Parse(txb_ancho.Text);
            x_material.unidades = txb_unidades.Text;
            x_material.alto = Int32.Parse(txb_alto.Text);
            x_material.estado = cmb_estado.SelectedValue.ToString();
            x_material.seriado = cmb_seriado.SelectedValue.ToString();
            x_material.tipo_material = Int32.Parse(cmb_tipo_de_material.SelectedValue.ToString());
            x_material.peso = Int32.Parse(txb_peso.Text);



            DialogResult resultado;


            resultado = MessageBox.Show("Los datos Ingresados a modificar son correctos?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);



            if (resultado == DialogResult.OK)
            {

                if (o_error.id == 0)
                {
                    interfaz.ModificarMateriales(x_material, ref o_error);
                    MessageBox.Show("El ID: " + x_material.id.ToString() + " se ha modificado correctamente " + "\n"
                          + "Error: " + o_error.mensaje + "Ninguno");
                    DialogResult = DialogResult.OK;
                    this.Close();
                    return;

                }
                else
                {
                    MessageBox.Show("¡Error inesperado!, No se pudo realizar la operacion." + "\n" +
                 "Error:" + o_error.mensaje);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Accion cancelada");
                this.Close();
                return;
            }
        }



        //
        //
        //validaciones de tipo de datos a ingresar en textbox
        private void txb_ancho_KeyPress(object sender, KeyPressEventArgs e) //vALIDACION DE ENTRADA PARA TEXTBOX "ANCHO"
        {
            if (char.IsDigit(e.KeyChar)) //condicion para que solo sean numeros
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar)) //Para la tecla de borrar (backspace)
            {
                e.Handled = false;
            }

            else if ((e.KeyChar == '.') && (!txb_ancho.Text.Contains(".")))//verifica que pueda ingresar punto y también que solo pueda ingresar un punto
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true; //si no se cumple nada de lo anterior entonces que no lo deje pasar
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txb_alto_KeyPress(object sender, KeyPressEventArgs e)
        {


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

        private void txb_ancho_KeyPress_1(object sender, KeyPressEventArgs e)
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
    }
}


