namespace Gestion_Bodega.Bodega
{
    partial class wfrm_Listar_bodegas
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abreviatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ingresar_bodega = new System.Windows.Forms.Button();
            this.txt_id_filtro = new System.Windows.Forms.TextBox();
            this.txt_abreviaura_filtro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_estado_filtro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.id,
            this.descripcion,
            this.abreviatura,
            this.estado});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(435, 223);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // abreviatura
            // 
            this.abreviatura.DataPropertyName = "abreviatura";
            this.abreviatura.HeaderText = "ABREVIATURA";
            this.abreviatura.Name = "abreviatura";
            this.abreviatura.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarBodegaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 26);
            // 
            // eliminarBodegaToolStripMenuItem
            // 
            this.eliminarBodegaToolStripMenuItem.Name = "eliminarBodegaToolStripMenuItem";
            this.eliminarBodegaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.eliminarBodegaToolStripMenuItem.Text = "Eliminar Bodega";
            this.eliminarBodegaToolStripMenuItem.Click += new System.EventHandler(this.eliminarBodegaToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ingresar_bodega
            // 
            this.btn_ingresar_bodega.Location = new System.Drawing.Point(429, 42);
            this.btn_ingresar_bodega.Name = "btn_ingresar_bodega";
            this.btn_ingresar_bodega.Size = new System.Drawing.Size(75, 23);
            this.btn_ingresar_bodega.TabIndex = 1;
            this.btn_ingresar_bodega.Text = "Ingresar";
            this.btn_ingresar_bodega.Click += new System.EventHandler(this.btn_ingresar_bodega_Click);
            // 
            // txt_id_filtro
            // 
            this.txt_id_filtro.Location = new System.Drawing.Point(80, 35);
            this.txt_id_filtro.Name = "txt_id_filtro";
            this.txt_id_filtro.Size = new System.Drawing.Size(100, 20);
            this.txt_id_filtro.TabIndex = 2;
            // 
            // txt_abreviaura_filtro
            // 
            this.txt_abreviaura_filtro.Location = new System.Drawing.Point(80, 65);
            this.txt_abreviaura_filtro.Name = "txt_abreviaura_filtro";
            this.txt_abreviaura_filtro.Size = new System.Drawing.Size(100, 20);
            this.txt_abreviaura_filtro.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Abreviatura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estado:";
            // 
            // cmb_estado_filtro
            // 
            this.cmb_estado_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado_filtro.FormattingEnabled = true;
            this.cmb_estado_filtro.Items.AddRange(new object[] {
            "SELECCIONE",
            "S",
            "N"});
            this.cmb_estado_filtro.Location = new System.Drawing.Point(80, 96);
            this.cmb_estado_filtro.Name = "cmb_estado_filtro";
            this.cmb_estado_filtro.Size = new System.Drawing.Size(100, 21);
            this.cmb_estado_filtro.TabIndex = 9;
            // 
            // wfrm_Listar_bodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 384);
            this.Controls.Add(this.cmb_estado_filtro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_abreviaura_filtro);
            this.Controls.Add(this.txt_id_filtro);
            this.Controls.Add(this.btn_ingresar_bodega);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "wfrm_Listar_bodegas";
            this.Text = "wfrm_Listar_bodegas";
            this.Load += new System.EventHandler(this.wfrm_Listar_bodegas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn abreviatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ingresar_bodega;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarBodegaToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_id_filtro;
        private System.Windows.Forms.TextBox txt_abreviaura_filtro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_estado_filtro;
    }
}