namespace Gestion_Bodega.Forms.Materiales
{
    partial class wfrm_ModificarMaterial
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
            this.txb_codigo = new System.Windows.Forms.TextBox();
            this.txb_largo = new System.Windows.Forms.TextBox();
            this.txb_alto = new System.Windows.Forms.TextBox();
            this.txb_ancho = new System.Windows.Forms.TextBox();
            this.txb_descripcion = new System.Windows.Forms.TextBox();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ancho = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txb_peso = new System.Windows.Forms.TextBox();
            this.txb_unidades = new System.Windows.Forms.TextBox();
            this.txb_empresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txb_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.cmb_tipo_de_material = new System.Windows.Forms.ComboBox();
            this.cmb_seriado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txb_codigo
            // 
            this.txb_codigo.Location = new System.Drawing.Point(155, 207);
            this.txb_codigo.Name = "txb_codigo";
            this.txb_codigo.ShortcutsEnabled = false;
            this.txb_codigo.Size = new System.Drawing.Size(148, 20);
            this.txb_codigo.TabIndex = 6;
            // 
            // txb_largo
            // 
            this.txb_largo.Location = new System.Drawing.Point(155, 181);
            this.txb_largo.Name = "txb_largo";
            this.txb_largo.ShortcutsEnabled = false;
            this.txb_largo.Size = new System.Drawing.Size(148, 20);
            this.txb_largo.TabIndex = 5;
            this.txb_largo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_largo_KeyPress);
            // 
            // txb_alto
            // 
            this.txb_alto.Location = new System.Drawing.Point(155, 155);
            this.txb_alto.Name = "txb_alto";
            this.txb_alto.ShortcutsEnabled = false;
            this.txb_alto.Size = new System.Drawing.Size(148, 20);
            this.txb_alto.TabIndex = 4;
            this.txb_alto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_alto_KeyPress);
            // 
            // txb_ancho
            // 
            this.txb_ancho.Location = new System.Drawing.Point(155, 129);
            this.txb_ancho.Name = "txb_ancho";
            this.txb_ancho.ShortcutsEnabled = false;
            this.txb_ancho.Size = new System.Drawing.Size(148, 20);
            this.txb_ancho.TabIndex = 3;
            this.txb_ancho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_ancho_KeyPress_1);
            // 
            // txb_descripcion
            // 
            this.txb_descripcion.Location = new System.Drawing.Point(155, 103);
            this.txb_descripcion.Name = "txb_descripcion";
            this.txb_descripcion.ShortcutsEnabled = false;
            this.txb_descripcion.Size = new System.Drawing.Size(148, 20);
            this.txb_descripcion.TabIndex = 2;
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(155, 77);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.ShortcutsEnabled = false;
            this.txb_nombre.Size = new System.Drawing.Size(148, 20);
            this.txb_nombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Largo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Alto:";
            // 
            // lbl_ancho
            // 
            this.lbl_ancho.AutoSize = true;
            this.lbl_ancho.Location = new System.Drawing.Point(37, 133);
            this.lbl_ancho.Name = "lbl_ancho";
            this.lbl_ancho.Size = new System.Drawing.Size(41, 13);
            this.lbl_ancho.TabIndex = 23;
            this.lbl_ancho.Text = "Ancho:";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(37, 107);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(66, 13);
            this.lbl_descripcion.TabIndex = 22;
            this.lbl_descripcion.Text = "Descripcion:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(37, 81);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 21;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(435, 17);
            this.lbl_titulo.TabIndex = 19;
            this.lbl_titulo.Text = "Complete los siguientes campos para modificar un material";
            // 
            // txb_peso
            // 
            this.txb_peso.Location = new System.Drawing.Point(155, 311);
            this.txb_peso.Name = "txb_peso";
            this.txb_peso.ShortcutsEnabled = false;
            this.txb_peso.Size = new System.Drawing.Size(148, 20);
            this.txb_peso.TabIndex = 10;
            this.txb_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_peso_KeyPress);
            // 
            // txb_unidades
            // 
            this.txb_unidades.Location = new System.Drawing.Point(155, 285);
            this.txb_unidades.Name = "txb_unidades";
            this.txb_unidades.ShortcutsEnabled = false;
            this.txb_unidades.Size = new System.Drawing.Size(148, 20);
            this.txb_unidades.TabIndex = 9;
            // 
            // txb_empresa
            // 
            this.txb_empresa.Location = new System.Drawing.Point(155, 259);
            this.txb_empresa.Name = "txb_empresa";
            this.txb_empresa.ShortcutsEnabled = false;
            this.txb_empresa.Size = new System.Drawing.Size(148, 20);
            this.txb_empresa.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Unidades:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Peso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Empresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Estado:";
            // 
            // btn_volver
            // 
            this.btn_volver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_volver.Location = new System.Drawing.Point(372, 120);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 14;
            this.btn_volver.Text = "volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_modificar.Location = new System.Drawing.Point(372, 72);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 13;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // txb_id
            // 
            this.txb_id.Location = new System.Drawing.Point(155, 51);
            this.txb_id.Name = "txb_id";
            this.txb_id.ReadOnly = true;
            this.txb_id.Size = new System.Drawing.Size(148, 20);
            this.txb_id.TabIndex = 0;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(37, 55);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 45;
            this.lbl_id.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Tipo de Material:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Seriado:";
            // 
            // cmb_estado
            // 
            this.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "(SELECCIONE)",
            "ACTIVO",
            "INACTIVO"});
            this.cmb_estado.Location = new System.Drawing.Point(155, 233);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(148, 21);
            this.cmb_estado.TabIndex = 7;
            // 
            // cmb_tipo_de_material
            // 
            this.cmb_tipo_de_material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_de_material.FormattingEnabled = true;
            this.cmb_tipo_de_material.Items.AddRange(new object[] {
            "(SELECCIONE)"});
            this.cmb_tipo_de_material.Location = new System.Drawing.Point(155, 365);
            this.cmb_tipo_de_material.Name = "cmb_tipo_de_material";
            this.cmb_tipo_de_material.Size = new System.Drawing.Size(148, 21);
            this.cmb_tipo_de_material.TabIndex = 12;
            // 
            // cmb_seriado
            // 
            this.cmb_seriado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_seriado.FormattingEnabled = true;
            this.cmb_seriado.Location = new System.Drawing.Point(155, 339);
            this.cmb_seriado.Name = "cmb_seriado";
            this.cmb_seriado.Size = new System.Drawing.Size(148, 21);
            this.cmb_seriado.TabIndex = 11;
            // 
            // ModificarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 410);
            this.Controls.Add(this.cmb_seriado);
            this.Controls.Add(this.cmb_tipo_de_material);
            this.Controls.Add(this.cmb_estado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txb_id);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.txb_peso);
            this.Controls.Add(this.txb_unidades);
            this.Controls.Add(this.txb_empresa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_codigo);
            this.Controls.Add(this.txb_largo);
            this.Controls.Add(this.txb_alto);
            this.Controls.Add(this.txb_ancho);
            this.Controls.Add(this.txb_descripcion);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ancho);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "ModificarMaterial";
            this.Text = "Modificar Material";
            this.Load += new System.EventHandler(this.wfrm_ModificarMaterial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_codigo;
        private System.Windows.Forms.TextBox txb_largo;
        private System.Windows.Forms.TextBox txb_alto;
        private System.Windows.Forms.TextBox txb_ancho;
        private System.Windows.Forms.TextBox txb_descripcion;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ancho;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txb_peso;
        private System.Windows.Forms.TextBox txb_unidades;
        private System.Windows.Forms.TextBox txb_empresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.TextBox txb_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.ComboBox cmb_tipo_de_material;
        private System.Windows.Forms.ComboBox cmb_seriado;
    }
}