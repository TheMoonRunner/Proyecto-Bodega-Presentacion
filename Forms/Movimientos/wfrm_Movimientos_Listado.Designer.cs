namespace Gestion_Bodega.Forms.Movimientos
{
    partial class wfrm_Movimientos_Listado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.txt_id_material = new System.Windows.Forms.TextBox();
            this.txt_tipo_operacion = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CONTENEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_MATERIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_OPERACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DOCUMENTO_ORIGEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPO_DOCUMENTO_ORIGEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_CONTENEDOR,
            this.ID_MATERIAL,
            this.TIPO_OPERACION,
            this.CANTIDAD,
            this.FECHA,
            this.USUARIO,
            this.ID_DOCUMENTO_ORIGEN,
            this.ID_TIPO_DOCUMENTO_ORIGEN});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 289);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarRegistroToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 26);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(678, 32);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar.TabIndex = 12;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // txt_id_material
            // 
            this.txt_id_material.Location = new System.Drawing.Point(99, 55);
            this.txt_id_material.Name = "txt_id_material";
            this.txt_id_material.Size = new System.Drawing.Size(100, 20);
            this.txt_id_material.TabIndex = 4;
            // 
            // txt_tipo_operacion
            // 
            this.txt_tipo_operacion.Location = new System.Drawing.Point(99, 81);
            this.txt_tipo_operacion.Name = "txt_tipo_operacion";
            this.txt_tipo_operacion.Size = new System.Drawing.Size(100, 20);
            this.txt_tipo_operacion.TabIndex = 5;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(99, 29);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 6;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(99, 108);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID Material:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo Operacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Usuario:";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // ID_CONTENEDOR
            // 
            this.ID_CONTENEDOR.DataPropertyName = "id_contenedor";
            this.ID_CONTENEDOR.HeaderText = "ID_CONTENEDOR";
            this.ID_CONTENEDOR.Name = "ID_CONTENEDOR";
            // 
            // ID_MATERIAL
            // 
            this.ID_MATERIAL.DataPropertyName = "id_material";
            this.ID_MATERIAL.HeaderText = "ID_MATERIAL";
            this.ID_MATERIAL.Name = "ID_MATERIAL";
            // 
            // TIPO_OPERACION
            // 
            this.TIPO_OPERACION.DataPropertyName = "tipo_operacion";
            this.TIPO_OPERACION.HeaderText = "TIPO_OPERACION";
            this.TIPO_OPERACION.Name = "TIPO_OPERACION";
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DataPropertyName = "cantidad";
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "fecha";
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            // 
            // USUARIO
            // 
            this.USUARIO.DataPropertyName = "usuario";
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            // 
            // ID_DOCUMENTO_ORIGEN
            // 
            this.ID_DOCUMENTO_ORIGEN.DataPropertyName = "ID_DOCUMENTO_ORIGEN";
            this.ID_DOCUMENTO_ORIGEN.HeaderText = "ID_DOCUMENTO_ORIGEN";
            this.ID_DOCUMENTO_ORIGEN.Name = "ID_DOCUMENTO_ORIGEN";
            // 
            // ID_TIPO_DOCUMENTO_ORIGEN
            // 
            this.ID_TIPO_DOCUMENTO_ORIGEN.DataPropertyName = "ID_TIPO_DOCUMENTO_ORIGEN";
            this.ID_TIPO_DOCUMENTO_ORIGEN.HeaderText = "ID_TIPO_DOCUMENTO_ORIGEN";
            this.ID_TIPO_DOCUMENTO_ORIGEN.Name = "ID_TIPO_DOCUMENTO_ORIGEN";
            // 
            // eliminarRegistroToolStripMenuItem
            // 
            this.eliminarRegistroToolStripMenuItem.Name = "eliminarRegistroToolStripMenuItem";
            this.eliminarRegistroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarRegistroToolStripMenuItem.Text = "Eliminar registro";
            this.eliminarRegistroToolStripMenuItem.Click += new System.EventHandler(this.eliminarRegistroToolStripMenuItem_Click);
            // 
            // wfrm_Movimientos_Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_tipo_operacion);
            this.Controls.Add(this.txt_id_material);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "wfrm_Movimientos_Listado";
            this.Text = "Movimientos Listado";
            this.Load += new System.EventHandler(this.wfrm_Movimientos_Listado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.TextBox txt_id_material;
        private System.Windows.Forms.TextBox txt_tipo_operacion;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONTENEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MATERIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_OPERACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DOCUMENTO_ORIGEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPO_DOCUMENTO_ORIGEN;
        private System.Windows.Forms.ToolStripMenuItem eliminarRegistroToolStripMenuItem;
    }
}