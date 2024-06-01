namespace Gestion_Bodega.Forms.Materiales
{
    partial class wfrm_ListarMateriales
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ancho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.largo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_volver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_material = new System.Windows.Forms.TextBox();
            this.txt_nombre_material = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo_material = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_empresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(214, 12);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(148, 39);
            this.btn_actualizar.TabIndex = 0;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.codigo,
            this.nombre,
            this.descripcion,
            this.estado,
            this.empresa,
            this.unidades,
            this.peso,
            this.ancho,
            this.alto,
            this.largo,
            this.seriado,
            this.tipo_material});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(849, 325);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // empresa
            // 
            this.empresa.DataPropertyName = "empresa";
            this.empresa.HeaderText = "EMPRESA";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            // 
            // unidades
            // 
            this.unidades.DataPropertyName = "unidades";
            this.unidades.HeaderText = "UNIDADES";
            this.unidades.Name = "unidades";
            this.unidades.ReadOnly = true;
            // 
            // peso
            // 
            this.peso.DataPropertyName = "peso";
            this.peso.HeaderText = "PESO";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            // 
            // ancho
            // 
            this.ancho.DataPropertyName = "ancho";
            this.ancho.HeaderText = "ANCHO";
            this.ancho.Name = "ancho";
            this.ancho.ReadOnly = true;
            // 
            // alto
            // 
            this.alto.DataPropertyName = "alto";
            this.alto.HeaderText = "ALTO";
            this.alto.Name = "alto";
            this.alto.ReadOnly = true;
            // 
            // largo
            // 
            this.largo.DataPropertyName = "largo";
            this.largo.HeaderText = "LARGO";
            this.largo.Name = "largo";
            this.largo.ReadOnly = true;
            // 
            // seriado
            // 
            this.seriado.DataPropertyName = "seriado";
            this.seriado.HeaderText = "SERIADO";
            this.seriado.Name = "seriado";
            this.seriado.ReadOnly = true;
            // 
            // tipo_material
            // 
            this.tipo_material.DataPropertyName = "descripcion_tm";
            this.tipo_material.HeaderText = "TIPO_MATERIAL";
            this.tipo_material.Name = "tipo_material";
            this.tipo_material.ReadOnly = true;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(556, 12);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(148, 39);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarMaterialToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 26);
            // 
            // eliminarMaterialToolStripMenuItem
            // 
            this.eliminarMaterialToolStripMenuItem.Name = "eliminarMaterialToolStripMenuItem";
            this.eliminarMaterialToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.eliminarMaterialToolStripMenuItem.Text = "Eliminar material";
            this.eliminarMaterialToolStripMenuItem.Click += new System.EventHandler(this.eliminarMaterialToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // txt_id_material
            // 
            this.txt_id_material.Location = new System.Drawing.Point(12, 87);
            this.txt_id_material.Name = "txt_id_material";
            this.txt_id_material.Size = new System.Drawing.Size(100, 20);
            this.txt_id_material.TabIndex = 5;
            this.txt_id_material.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_material_KeyPress);
            // 
            // txt_nombre_material
            // 
            this.txt_nombre_material.Location = new System.Drawing.Point(127, 87);
            this.txt_nombre_material.Name = "txt_nombre_material";
            this.txt_nombre_material.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_material.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOMBRE:";
            // 
            // txt_codigo_material
            // 
            this.txt_codigo_material.Location = new System.Drawing.Point(252, 87);
            this.txt_codigo_material.Name = "txt_codigo_material";
            this.txt_codigo_material.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo_material.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CODIGO:";
            // 
            // txt_empresa
            // 
            this.txt_empresa.Location = new System.Drawing.Point(397, 87);
            this.txt_empresa.Name = "txt_empresa";
            this.txt_empresa.Size = new System.Drawing.Size(100, 20);
            this.txt_empresa.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "EMPRESA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "FILTROS:";
            // 
            // ListarMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_empresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_codigo_material);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre_material);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id_material);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_actualizar);
            this.Name = "ListarMateriales";
            this.Text = "Listar Materiales";
            this.Load += new System.EventHandler(this.wfrm_ListarMateriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarMaterialToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ancho;
        private System.Windows.Forms.DataGridViewTextBoxColumn alto;
        private System.Windows.Forms.DataGridViewTextBoxColumn largo;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_material;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_material;
        private System.Windows.Forms.TextBox txt_nombre_material;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo_material;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_empresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

