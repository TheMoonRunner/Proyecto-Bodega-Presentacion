using Gestion_Bodega.Clases;
using Gestion_Bodega.Clases.Bodega;
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

namespace Gestion_Bodega.Bodega
{
    public partial class wfrm_ingresar_bodega : Form
    {
        public wfrm_ingresar_bodega()
        {
            InitializeComponent();
        }

        private void wfrm_ingresar_bodega_Load(object sender, EventArgs e)
        {
            CError o_error = new CError();
            cmb_estado_bodega.SelectedIndex = 0;
            actualizarGrilla();
        }

        private void btn_ingresar_bodega_Click(object sender, EventArgs e)
        {
            CError o_error = new CError();
            CInterfaz x_interfaz = new CInterfaz();
            CRespuestaInt x_material = new CRespuestaInt();
            CBodega bodega = new CBodega();
            wfrm_Listar_bodegas x_listar = new wfrm_Listar_bodegas();
            int IngresarBodega = 0;
            DialogResult resultado;
            resultado = MessageBox.Show("Los datos Ingresados son correctos?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (txt_id_bodega.Text == "")
            {
                MessageBox.Show("Debe de ingresar ID unica para esta bodgea", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                bodega.id = txt_id_bodega.Text.ToUpper();
            }

            if (txt_descripcion_bodega.Text == "")
            {
                MessageBox.Show("Debe de ingresar alguna descripcion", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                bodega.descripcion = txt_descripcion_bodega.Text.ToUpper();
            }

            if (txt_abrevitura_bodega.Text == "")
            {
                MessageBox.Show("Debe de ingresar alguna abreviatura", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;
            }
            else
            {
                bodega.abreviatura = txt_abrevitura_bodega.Text.ToUpper();
            }

            if (cmb_estado_bodega.SelectedIndex == 0)
            {
                MessageBox.Show("Debe de seleccionar una opcion para estado", "validación ",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
                return;
            }
            else
            {

                if (cmb_estado_bodega.SelectedItem.ToString() == "ACTIVO")
                {
                    bodega.estado = "S";
                }
                if (cmb_estado_bodega.SelectedItem.ToString() == "INACTIVO")
                {
                    bodega.estado = "N";
                }

            }

            IngresarBodega = x_interfaz.bodega_ingresar(bodega, ref o_error);

            if (o_error.id != 0)
            {

                MessageBox.Show("Error, no se ha logrado ingresar" + "\n" + "Error: " + o_error.mensaje.ToString());
                DialogResult = DialogResult.None;
                return;
            }
            if (o_error.id == 0)
            {
                /*resultado =*/
                MessageBox.Show("ID: " + IngresarBodega.ToString() + "\n" + "Mensaje: Se ha ingresado correctamente");
                return;

            }
        }

        public void actualizarGrilla()
        {
            CError o_error = new CError();
            wfrm_Listar_bodegas actualizar_grilla = new wfrm_Listar_bodegas();
            actualizar_grilla.cargar_grilla();
        }

        private void txt_id_bodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] Caracteres_especiales = { '.', ',', '_', '-', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }; //Permitidos

            if (char.IsLetter(e.KeyChar) || Caracteres_especiales.Contains(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y algunos caracteres especiales en ID", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
                MessageBox.Show("Solo se permiten letras y algunos caracteres especiales en DESCRIPCIÓN", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_abrevitura_bodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] Caracteres_especiales = { '.', ',', '_', '-', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }; //Permitidos

            if (char.IsLetter(e.KeyChar) || Caracteres_especiales.Contains(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y algunos caracteres especiales en ABREVIATURA", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_id_bodega_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
