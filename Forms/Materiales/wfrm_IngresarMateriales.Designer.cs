namespace Gestion_Bodega.Forms.Materiales
{
    partial class wfrm_IngresarMateriales
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_ancho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_descripcion = new System.Windows.Forms.TextBox();
            this.txb_ancho = new System.Windows.Forms.TextBox();
            this.txb_alto = new System.Windows.Forms.TextBox();
            this.txb_largo = new System.Windows.Forms.TextBox();
            this.txb_codigo = new System.Windows.Forms.TextBox();
            this.txb_empresa = new System.Windows.Forms.TextBox();
            this.txb_unidades = new System.Windows.Forms.TextBox();
            this.txb_peso = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.cmb_seriado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_tipo_material = new System.Windows.Forms.ComboBox();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(478, 17);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Complete los siguientes campos para ingresar un nuevo material";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(36, 73);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(36, 99);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(66, 13);
            this.lbl_descripcion.TabIndex = 3;
            this.lbl_descripcion.Text = "Descripcion:";
            // 
            // lbl_ancho
            // 
            this.lbl_ancho.AutoSize = true;
            this.lbl_ancho.Location = new System.Drawing.Point(36, 125);
            this.lbl_ancho.Name = "lbl_ancho";
            this.lbl_ancho.Size = new System.Drawing.Size(41, 13);
            this.lbl_ancho.TabIndex = 4;
            this.lbl_ancho.Text = "Ancho:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Largo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Empresa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Peso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Unidades:";
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(126, 69);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.ShortcutsEnabled = false;
            this.txb_nombre.Size = new System.Drawing.Size(160, 20);
            this.txb_nombre.TabIndex = 0;
            // 
            // txb_descripcion
            // 
            this.txb_descripcion.Location = new System.Drawing.Point(126, 95);
            this.txb_descripcion.Name = "txb_descripcion";
            this.txb_descripcion.ShortcutsEnabled = false;
            this.txb_descripcion.Size = new System.Drawing.Size(160, 20);
            this.txb_descripcion.TabIndex = 1;
            // 
            // txb_ancho
            // 
            this.txb_ancho.Location = new System.Drawing.Point(126, 121);
            this.txb_ancho.Name = "txb_ancho";
            this.txb_ancho.ShortcutsEnabled = false;
            this.txb_ancho.Size = new System.Drawing.Size(160, 20);
            this.txb_ancho.TabIndex = 2;
            this.txb_ancho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_ancho_KeyPress);
            // 
            // txb_alto
            // 
            this.txb_alto.Location = new System.Drawing.Point(126, 147);
            this.txb_alto.Name = "txb_alto";
            this.txb_alto.ShortcutsEnabled = false;
            this.txb_alto.Size = new System.Drawing.Size(160, 20);
            this.txb_alto.TabIndex = 3;
            this.txb_alto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_alto_KeyPress);
            // 
            // txb_largo
            // 
            this.txb_largo.Location = new System.Drawing.Point(126, 173);
            this.txb_largo.Name = "txb_largo";
            this.txb_largo.ShortcutsEnabled = false;
            this.txb_largo.Size = new System.Drawing.Size(160, 20);
            this.txb_largo.TabIndex = 4;
            this.txb_largo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_largo_KeyPress);
            // 
            // txb_codigo
            // 
            this.txb_codigo.Location = new System.Drawing.Point(126, 199);
            this.txb_codigo.Name = "txb_codigo";
            this.txb_codigo.ShortcutsEnabled = false;
            this.txb_codigo.Size = new System.Drawing.Size(160, 20);
            this.txb_codigo.TabIndex = 5;
            // 
            // txb_empresa
            // 
            this.txb_empresa.Location = new System.Drawing.Point(126, 251);
            this.txb_empresa.Name = "txb_empresa";
            this.txb_empresa.ShortcutsEnabled = false;
            this.txb_empresa.Size = new System.Drawing.Size(160, 20);
            this.txb_empresa.TabIndex = 7;
            // 
            // txb_unidades
            // 
            this.txb_unidades.Location = new System.Drawing.Point(126, 277);
            this.txb_unidades.Name = "txb_unidades";
            this.txb_unidades.ShortcutsEnabled = false;
            this.txb_unidades.Size = new System.Drawing.Size(160, 20);
            this.txb_unidades.TabIndex = 8;
            // 
            // txb_peso
            // 
            this.txb_peso.Location = new System.Drawing.Point(126, 303);
            this.txb_peso.Name = "txb_peso";
            this.txb_peso.ShortcutsEnabled = false;
            this.txb_peso.Size = new System.Drawing.Size(160, 20);
            this.txb_peso.TabIndex = 9;
            this.txb_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_peso_KeyPress);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ingresar.Location = new System.Drawing.Point(415, 71);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_ingresar.TabIndex = 12;
            this.btn_ingresar.Text = "INGRESAR";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click_1);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(415, 119);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 13;
            this.btn_volver.Text = "VOLVER";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // cmb_seriado
            // 
            this.cmb_seriado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_seriado.FormattingEnabled = true;
            this.cmb_seriado.Items.AddRange(new object[] {
            "(SELECCIONE)",
            "SI",
            "NO"});
            this.cmb_seriado.Location = new System.Drawing.Point(126, 330);
            this.cmb_seriado.Name = "cmb_seriado";
            this.cmb_seriado.Size = new System.Drawing.Size(160, 21);
            this.cmb_seriado.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Seriado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Tipo de Material:";
            // 
            // cmb_tipo_material
            // 
            this.cmb_tipo_material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_material.FormattingEnabled = true;
            this.cmb_tipo_material.Items.AddRange(new object[] {
            "(SELECCIONE)"});
            this.cmb_tipo_material.Location = new System.Drawing.Point(126, 358);
            this.cmb_tipo_material.Name = "cmb_tipo_material";
            this.cmb_tipo_material.Size = new System.Drawing.Size(160, 21);
            this.cmb_tipo_material.TabIndex = 11;
            // 
            // cmb_estado
            // 
            this.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "(SELECCIONE)",
            "ACTIVO",
            "INACTIVO"});
            this.cmb_estado.Location = new System.Drawing.Point(126, 224);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(160, 21);
            this.cmb_estado.TabIndex = 6;
            // 
            // IngresarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 406);
            this.Controls.Add(this.cmb_estado);
            this.Controls.Add(this.cmb_tipo_material);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_seriado);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txb_peso);
            this.Controls.Add(this.txb_unidades);
            this.Controls.Add(this.txb_empresa);
            this.Controls.Add(this.txb_codigo);
            this.Controls.Add(this.txb_largo);
            this.Controls.Add(this.txb_alto);
            this.Controls.Add(this.txb_ancho);
            this.Controls.Add(this.txb_descripcion);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ancho);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "IngresarMaterial";
            this.Text = "Ingresar Material";
            this.Load += new System.EventHandler(this.IngresarMaterial_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_ancho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.TextBox txb_descripcion;
        private System.Windows.Forms.TextBox txb_ancho;
        private System.Windows.Forms.TextBox txb_alto;
        private System.Windows.Forms.TextBox txb_largo;
        private System.Windows.Forms.TextBox txb_codigo;
        private System.Windows.Forms.TextBox txb_empresa;
        private System.Windows.Forms.TextBox txb_unidades;
        private System.Windows.Forms.TextBox txb_peso;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.ComboBox cmb_seriado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_tipo_material;
        private System.Windows.Forms.ComboBox cmb_estado;
    }
}