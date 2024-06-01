using Gestion_Bodega.Clases;
using Gestion_Bodega.Clases.Bodega;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Bodega.Forms.Bodega
{
    public partial class wfrm_modificar_bodega : Form
    {

        public CBodega g_bodega;


        public class CCodigoTmpString
        {
            public string id { get; set; }
            public string descripcion { get; set; }

            public CCodigoTmpString()
            {

            }
        }
        public wfrm_modificar_bodega()
        {
            InitializeComponent();
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

            cmb_estado_bodega.DataSource = x_lista;
            cmb_estado_bodega.DisplayMember = "descripcion";
            cmb_estado_bodega.ValueMember = "id";
        }


        private void LlenarCampos()
        {
            //TEXTBOX  // G = GRILLA 
            txt_id_bodega.Text = g_bodega.id.ToString();

            txt_descripcion_bodega.Text = g_bodega.descripcion;
            txt_abrevitura_bodega.Text = g_bodega.abreviatura;

            //COMBOBOX
            cmb_estado_bodega.SelectedValue = g_bodega.estado;

        }

        private void wfrm_modificar_bodega_Load(object sender, EventArgs e)
        {
            llenar_combo_estado();
            LlenarCampos();

        }
        private void btn_modificar_bodega_Click(object sender, EventArgs e)
        {

            CError o_error = new CError();
            CBodega bodega_a_modificar = new CBodega();
            CBodega x_bodega = new CBodega();
            CInterfaz interfaz = new CInterfaz();

            if (txt_descripcion_bodega.Text.Trim() == "")
            {
                MessageBox.Show("El nombre no puede estar vacio,  ¡ERROR!");
                DialogResult = DialogResult.None;
                txt_descripcion_bodega.Focus();
                return;
            }

            if (txt_abrevitura_bodega.Text.Trim() == "")
            {
                MessageBox.Show("El valor de Ancho no puede estar vacio,  ¡ERROR!");
                DialogResult = DialogResult.None;
                txt_abrevitura_bodega.Focus();
                return;
            }

            x_bodega.id = txt_id_bodega.Text;
            x_bodega.descripcion = txt_descripcion_bodega.Text.ToUpper();
            x_bodega.abreviatura = txt_abrevitura_bodega.Text.ToUpper();
            x_bodega.estado = cmb_estado_bodega.SelectedValue.ToString();

            DialogResult resultado;

            resultado = MessageBox.Show("Los datos Ingresados a modificar son correctos?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {

                if (o_error.id == 0)
                {
                    interfaz.ModificarBodegas(x_bodega, ref o_error);
                    MessageBox.Show("El ID: " + x_bodega.id.ToString() + " se ha modificado correctamente " + "\n"
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

        private void txt_descripcion_bodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] Caracteres_especiales = { '.', ',', '_', '-', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }; //Permitidos

            if (char.IsLetter(e.KeyChar) || Caracteres_especiales.Contains(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y algunos caracteres especiales en DESCRIPCIÖN", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txt_abrevitura_bodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] Caracteres_especiales = { '.', ',', '_', '-', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }; //PERMITIDOS

            if (char.IsLetter(e.KeyChar) || Caracteres_especiales.Contains(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y algunos caracteres especiales en ABREVIATURA", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}
