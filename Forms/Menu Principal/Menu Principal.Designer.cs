namespace Gestion_Bodega
{
    partial class Menu_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listarMaterialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarBodegasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMaterialesBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarMovimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTipoContenedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarMaterialesToolStripMenuItem,
            this.listarBodegasToolStripMenuItem,
            this.listarMaterialesBodegaToolStripMenuItem,
            this.listarMovimientosToolStripMenuItem,
            this.listarTipoContenedorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // listarMaterialesToolStripMenuItem
            // 
            this.listarMaterialesToolStripMenuItem.Name = "listarMaterialesToolStripMenuItem";
            this.listarMaterialesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.listarMaterialesToolStripMenuItem.Text = "Listar Materiales";
            this.listarMaterialesToolStripMenuItem.Click += new System.EventHandler(this.listarMaterialesToolStripMenuItem_Click);
            // 
            // listarBodegasToolStripMenuItem
            // 
            this.listarBodegasToolStripMenuItem.Name = "listarBodegasToolStripMenuItem";
            this.listarBodegasToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.listarBodegasToolStripMenuItem.Text = "Listar Bodegas";
            this.listarBodegasToolStripMenuItem.Click += new System.EventHandler(this.listarBodegasToolStripMenuItem_Click);
            // 
            // listarMaterialesBodegaToolStripMenuItem
            // 
            this.listarMaterialesBodegaToolStripMenuItem.Name = "listarMaterialesBodegaToolStripMenuItem";
            this.listarMaterialesBodegaToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.listarMaterialesBodegaToolStripMenuItem.Text = "Listar Materiales Bodega";
            this.listarMaterialesBodegaToolStripMenuItem.Click += new System.EventHandler(this.listarMaterialesBodegaToolStripMenuItem_Click);
            // 
            // listarMovimientosToolStripMenuItem
            // 
            this.listarMovimientosToolStripMenuItem.Name = "listarMovimientosToolStripMenuItem";
            this.listarMovimientosToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.listarMovimientosToolStripMenuItem.Text = "Listar Movimientos";
            this.listarMovimientosToolStripMenuItem.Click += new System.EventHandler(this.listarMovimientosToolStripMenuItem_Click);
            // 
            // listarTipoContenedorToolStripMenuItem
            // 
            this.listarTipoContenedorToolStripMenuItem.Name = "listarTipoContenedorToolStripMenuItem";
            this.listarTipoContenedorToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.listarTipoContenedorToolStripMenuItem.Text = "Listar Tipo Contenedor";
            this.listarTipoContenedorToolStripMenuItem.Click += new System.EventHandler(this.listarTipoContenedorToolStripMenuItem_Click);
            // 
            // menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 500);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu_principal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listarMaterialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarBodegasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarMaterialesBodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarMovimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTipoContenedorToolStripMenuItem;
    }
}