using Gestion_Bodega.Clases.Movimientos;
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

namespace Gestion_Bodega.Forms.Movimientos
{
    public partial class wfrm_movimientos_modificar : Form
    {
        public wfrm_movimientos_modificar()
        {
            InitializeComponent();
        }
        public CMovimientos g_movimientos; //grilla movimientos
        private void wfrm_movimientos_modificar_Load(object sender, EventArgs e)
        {
            LlenarCampos();
        }
        private void LlenarCampos()
        {
            //TextBox  //G = grilla

            txt_id.Text = g_movimientos.id.ToString();
            txt_id_contenedor.Text = g_movimientos.id_contenedor.ToString();
            txt_id_material.Text = g_movimientos.id_material.ToString();
            txt_tipo_operacion.Text = g_movimientos.tipo_operacion;
            txt_cantidad.Text = g_movimientos.cantidad.ToString();
            txt_fecha.Text = g_movimientos.fecha.ToString();
            txt_usuario.Text = g_movimientos.usuario;
            txt_id_doc_origen.Text = g_movimientos.ID_DOCUMENTO_ORIGEN.ToString();
            txt_doc_tipo_origen.Text = g_movimientos.ID_TIPO_DOCUMENTO_ORIGEN.ToString();

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            CError o_error = new CError();
            CMovimientos movimiento_modificar = new CMovimientos();
            CMovimientos movimientos = new CMovimientos();
            CInterfaz x_interfaz = new CInterfaz();

            if (txt_id_contenedor.Text.Trim() == "")
            {
                MessageBox.Show("El ID del Contenedor no debe de estar vacio, ¡ERROR!");
                DialogResult = DialogResult.None;
                txt_id_contenedor.Focus();
                return;
            }
            if (txt_id_material.Text.Trim() == "")
            {
                MessageBox.Show("El ID contenedor no debe de estar vacio, ¡ERROR!");
                DialogResult = DialogResult.None;
                txt_id_material.Focus();
                return;

            }
            if (txt_tipo_operacion.Text.Trim() == "")
            {
                MessageBox.Show("El Tipo de operación no debe de estar vacio, ¡ERROR!");
                DialogResult = DialogResult.None;
                txt_tipo_operacion.Focus();
                return;

            }
            if (txt_cantidad.Text.Trim() == "")
            {
                MessageBox.Show("La cantidad no puede estar vacia, ¡ERROR!");
                DialogResult = DialogResult.None;
                txt_cantidad.Focus();
                return;
            }

            if (txt_usuario.Text.Trim() == "")
            {
                MessageBox.Show("El usuario no puede estar vacio, ¡ERROR!");
                DialogResult = DialogResult.None;
                txt_usuario.Focus();
                return;
            }
            if (txt_id_doc_origen.Text.Trim() == "")
            {
                MessageBox.Show("El ID documento origen no puede estar vacio, ¡ERROR!");
                DialogResult = DialogResult.None;
                txt_id_doc_origen.Focus();
                return;
            }
            if (txt_doc_tipo_origen.Text.Trim() == "")
            {
                MessageBox.Show("El Documento tipo Origen no puede estar vacio, ¡ERROR!");
                DialogResult = DialogResult.None;
                txt_doc_tipo_origen.Focus();
                return;
            }

            movimientos.id = Int32.Parse(txt_id.Text);
            movimientos.id_contenedor = Int32.Parse(txt_id_contenedor.Text);
            movimientos.id_material = Int32.Parse(txt_id_material.Text);
            movimientos.tipo_operacion = txt_tipo_operacion.Text;
            movimientos.cantidad = Int32.Parse(txt_cantidad.Text);
            //Aqui debe de ir la fecha, pero no se modifica, es fija
            movimientos.usuario = txt_usuario.Text;
            movimientos.ID_DOCUMENTO_ORIGEN = Int32.Parse(txt_id_doc_origen.Text);
            movimientos.ID_TIPO_DOCUMENTO_ORIGEN = Int32.Parse(txt_doc_tipo_origen.Text);

            DialogResult resultado;

            resultado = MessageBox.Show("Los datos Ingresados a modificar son correctos?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {

                if (o_error.id == 0)
                {

                    x_interfaz.Movimientos_modificar(movimientos, ref o_error);
                    MessageBox.Show("El ID: " + movimientos.id.ToString() + " se ha modificado correctamente " + "\n"
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
    }
}
