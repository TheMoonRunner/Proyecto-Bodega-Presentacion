namespace Gestion_Bodega.Forms.Materiales_Bodega_CContenedor
{
    partial class wfrm_Material_Bodega
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CONTENEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_BODEGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txb_id_material = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_nombre_material = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.txb_id_contenedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CODIGO,
            this.ID_CONTENEDOR,
            this.NOMBRE,
            this.DESCRIPCION,
            this.ID_BODEGA,
            this.ESTADO,
            this.EMPRESA,
            this.UNIDADES});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(821, 295);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "codigo";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // ID_CONTENEDOR
            // 
            this.ID_CONTENEDOR.DataPropertyName = "id_contenedor";
            this.ID_CONTENEDOR.HeaderText = "ID_CONTENEDOR";
            this.ID_CONTENEDOR.Name = "ID_CONTENEDOR";
            this.ID_CONTENEDOR.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "nombre";
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "descripcion";
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // ID_BODEGA
            // 
            this.ID_BODEGA.DataPropertyName = "id_bodega";
            this.ID_BODEGA.HeaderText = "ID_BODEGA";
            this.ID_BODEGA.Name = "ID_BODEGA";
            this.ID_BODEGA.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "estado";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // EMPRESA
            // 
            this.EMPRESA.DataPropertyName = "empresa";
            this.EMPRESA.HeaderText = "EMPRESA";
            this.EMPRESA.Name = "EMPRESA";
            this.EMPRESA.ReadOnly = true;
            // 
            // UNIDADES
            // 
            this.UNIDADES.DataPropertyName = "unidades";
            this.UNIDADES.HeaderText = "UNIDADES";
            this.UNIDADES.Name = "UNIDADES";
            this.UNIDADES.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 17;
            // 
            // txb_id_material
            // 
            this.txb_id_material.Location = new System.Drawing.Point(121, 44);
            this.txb_id_material.Name = "txb_id_material";
            this.txb_id_material.Size = new System.Drawing.Size(111, 20);
            this.txb_id_material.TabIndex = 4;
            this.txb_id_material.TextChanged += new System.EventHandler(this.txb_id_material_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "nombre material";
            // 
            // txb_nombre_material
            // 
            this.txb_nombre_material.Location = new System.Drawing.Point(121, 81);
            this.txb_nombre_material.Name = "txb_nombre_material";
            this.txb_nombre_material.Size = new System.Drawing.Size(111, 20);
            this.txb_nombre_material.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Filtrar por:";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(647, 75);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(114, 23);
            this.btn_actualizar.TabIndex = 19;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // txb_id_contenedor
            // 
            this.txb_id_contenedor.Location = new System.Drawing.Point(121, 118);
            this.txb_id_contenedor.Name = "txb_id_contenedor";
            this.txb_id_contenedor.Size = new System.Drawing.Size(111, 20);
            this.txb_id_contenedor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id contenedor";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarMaterialToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(68, 26);
            // 
            // eliminarMaterialToolStripMenuItem
            // 
            this.eliminarMaterialToolStripMenuItem.Name = "eliminarMaterialToolStripMenuItem";
            this.eliminarMaterialToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // wfrm_Material_Bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 543);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_nombre_material);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_id_material);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txb_id_contenedor);
            this.Name = "wfrm_Material_Bodega";
            this.Text = "wfrm_Material_Bodega";
            this.Load += new System.EventHandler(this.wfrm_Material_Bodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txb_id_material;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_nombre_material;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.TextBox txb_id_contenedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONTENEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_BODEGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADES;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarMaterialToolStripMenuItem;
    }
}