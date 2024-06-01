namespace Gestion_Bodega.Bodega
{
   
    partial class wfrm_ingresar_bodega
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
            this.txt_descripcion_bodega = new System.Windows.Forms.TextBox();
            this.txt_abrevitura_bodega = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ingresar_bodega = new System.Windows.Forms.Button();
            this.cmb_estado_bodega = new System.Windows.Forms.ComboBox();
            this.txt_id_bodega = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_descripcion_bodega
            // 
            this.txt_descripcion_bodega.Location = new System.Drawing.Point(144, 59);
            this.txt_descripcion_bodega.Name = "txt_descripcion_bodega";
            this.txt_descripcion_bodega.ShortcutsEnabled = false;
            this.txt_descripcion_bodega.Size = new System.Drawing.Size(100, 20);
            this.txt_descripcion_bodega.TabIndex = 1;
            this.txt_descripcion_bodega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descripcion_bodega_KeyPress);
            // 
            // txt_abrevitura_bodega
            // 
            this.txt_abrevitura_bodega.Location = new System.Drawing.Point(144, 85);
            this.txt_abrevitura_bodega.Name = "txt_abrevitura_bodega";
            this.txt_abrevitura_bodega.ShortcutsEnabled = false;
            this.txt_abrevitura_bodega.Size = new System.Drawing.Size(100, 20);
            this.txt_abrevitura_bodega.TabIndex = 2;
            this.txt_abrevitura_bodega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_abrevitura_bodega_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DESCRIPCIÓN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ABREVIATURA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ESTADO:";
            // 
            // btn_ingresar_bodega
            // 
            this.btn_ingresar_bodega.Location = new System.Drawing.Point(311, 36);
            this.btn_ingresar_bodega.Name = "btn_ingresar_bodega";
            this.btn_ingresar_bodega.Size = new System.Drawing.Size(75, 23);
            this.btn_ingresar_bodega.TabIndex = 8;
            this.btn_ingresar_bodega.Text = "Ingresar";
            this.btn_ingresar_bodega.UseVisualStyleBackColor = true;
            this.btn_ingresar_bodega.Click += new System.EventHandler(this.btn_ingresar_bodega_Click);
            // 
            // cmb_estado_bodega
            // 
            this.cmb_estado_bodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado_bodega.FormattingEnabled = true;
            this.cmb_estado_bodega.Items.AddRange(new object[] {
        "(SELECCIONE)",
        "ACTIVO",
        "INACTIVO"});
            this.cmb_estado_bodega.Location = new System.Drawing.Point(144, 112);
            this.cmb_estado_bodega.Name = "cmb_estado_bodega";
            this.cmb_estado_bodega.Size = new System.Drawing.Size(100, 21);
            this.cmb_estado_bodega.TabIndex = 9;
            // 
            // txt_id_bodega
            // 
            this.txt_id_bodega.Location = new System.Drawing.Point(144, 33);
            this.txt_id_bodega.Name = "txt_id_bodega";
            this.txt_id_bodega.ShortcutsEnabled = false;
            this.txt_id_bodega.Size = new System.Drawing.Size(100, 20);
            this.txt_id_bodega.TabIndex = 10;
            this.txt_id_bodega.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_id_bodega_KeyDown);
            this.txt_id_bodega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_bodega_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID:";
            // 
            // wfrm_ingresar_bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 234);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id_bodega);
            this.Controls.Add(this.cmb_estado_bodega);
            this.Controls.Add(this.btn_ingresar_bodega);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_abrevitura_bodega);
            this.Controls.Add(this.txt_descripcion_bodega);
            this.Name = "wfrm_ingresar_bodega";
            this.Text = "Ingresar Bodega";
            this.Load += new System.EventHandler(this.wfrm_ingresar_bodega_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_descripcion_bodega;
        private System.Windows.Forms.TextBox txt_abrevitura_bodega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ingresar_bodega;
        private System.Windows.Forms.ComboBox cmb_estado_bodega;
        private System.Windows.Forms.TextBox txt_id_bodega;
        private System.Windows.Forms.Label label1;
    }

}