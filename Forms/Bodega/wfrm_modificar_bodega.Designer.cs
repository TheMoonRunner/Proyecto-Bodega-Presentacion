namespace Gestion_Bodega.Forms.Bodega
{
    partial class wfrm_modificar_bodega
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
            this.btn_modificar_bodega = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_bodega = new System.Windows.Forms.TextBox();
            this.cmb_estado_bodega = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_abrevitura_bodega = new System.Windows.Forms.TextBox();
            this.txt_descripcion_bodega = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_modificar_bodega
            // 
            this.btn_modificar_bodega.Location = new System.Drawing.Point(290, 23);
            this.btn_modificar_bodega.Name = "btn_modificar_bodega";
            this.btn_modificar_bodega.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar_bodega.TabIndex = 16;
            this.btn_modificar_bodega.Text = "Modificar";
            this.btn_modificar_bodega.UseVisualStyleBackColor = true;
            this.btn_modificar_bodega.Click += new System.EventHandler(this.btn_modificar_bodega_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID:";
            // 
            // txt_id_bodega
            // 
            this.txt_id_bodega.Location = new System.Drawing.Point(131, 24);
            this.txt_id_bodega.Name = "txt_id_bodega";
            this.txt_id_bodega.ReadOnly = true;
            this.txt_id_bodega.Size = new System.Drawing.Size(100, 20);
            this.txt_id_bodega.TabIndex = 23;
            // 
            // cmb_estado_bodega
            // 
            this.cmb_estado_bodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado_bodega.FormattingEnabled = true;
            this.cmb_estado_bodega.Items.AddRange(new object[] {
            "(SELECCIONE)",
            "ACTIVO",
            "INACTIVO"});
            this.cmb_estado_bodega.Location = new System.Drawing.Point(131, 103);
            this.cmb_estado_bodega.Name = "cmb_estado_bodega";
            this.cmb_estado_bodega.Size = new System.Drawing.Size(100, 21);
            this.cmb_estado_bodega.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "ESTADO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ABREVIATURA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "DESCRIPCIÓN:";
            // 
            // txt_abrevitura_bodega
            // 
            this.txt_abrevitura_bodega.Location = new System.Drawing.Point(131, 76);
            this.txt_abrevitura_bodega.Name = "txt_abrevitura_bodega";
            this.txt_abrevitura_bodega.ShortcutsEnabled = false;
            this.txt_abrevitura_bodega.Size = new System.Drawing.Size(100, 20);
            this.txt_abrevitura_bodega.TabIndex = 18;
            this.txt_abrevitura_bodega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_abrevitura_bodega_KeyPress);
            // 
            // txt_descripcion_bodega
            // 
            this.txt_descripcion_bodega.Location = new System.Drawing.Point(131, 50);
            this.txt_descripcion_bodega.Name = "txt_descripcion_bodega";
            this.txt_descripcion_bodega.ShortcutsEnabled = false;
            this.txt_descripcion_bodega.Size = new System.Drawing.Size(100, 20);
            this.txt_descripcion_bodega.TabIndex = 17;
            this.txt_descripcion_bodega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descripcion_bodega_KeyPress);
            // 
            // wfrm_modificar_bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id_bodega);
            this.Controls.Add(this.cmb_estado_bodega);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_abrevitura_bodega);
            this.Controls.Add(this.txt_descripcion_bodega);
            this.Controls.Add(this.btn_modificar_bodega);
            this.Name = "wfrm_modificar_bodega";
            this.ShowInTaskbar = false;
            this.Text = "Modificar Bodega";
            this.Load += new System.EventHandler(this.wfrm_modificar_bodega_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modificar_bodega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_bodega;
        private System.Windows.Forms.ComboBox cmb_estado_bodega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_abrevitura_bodega;
        private System.Windows.Forms.TextBox txt_descripcion_bodega;
    }
}