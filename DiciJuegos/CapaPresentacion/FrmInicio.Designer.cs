﻿namespace CapaPresentacion
{
    partial class FrmInicio
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
            this.TLPFondoInicio = new System.Windows.Forms.TableLayoutPanel();
            this.MSInicio = new System.Windows.Forms.MenuStrip();
            this.aBMsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palabrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PBUtnFooter = new System.Windows.Forms.PictureBox();
            this.PContenedor = new System.Windows.Forms.Panel();
            this.TLPFondoInicio.SuspendLayout();
            this.MSInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBUtnFooter)).BeginInit();
            this.SuspendLayout();
            // 
            // TLPFondoInicio
            // 
            this.TLPFondoInicio.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TLPFondoInicio.BackgroundImage = global::CapaPresentacion.Properties.Resources.textura_1_celeste;
            this.TLPFondoInicio.ColumnCount = 1;
            this.TLPFondoInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPFondoInicio.Controls.Add(this.MSInicio, 0, 0);
            this.TLPFondoInicio.Controls.Add(this.PBUtnFooter, 0, 2);
            this.TLPFondoInicio.Controls.Add(this.PContenedor, 0, 1);
            this.TLPFondoInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPFondoInicio.Location = new System.Drawing.Point(0, 0);
            this.TLPFondoInicio.Name = "TLPFondoInicio";
            this.TLPFondoInicio.RowCount = 3;
            this.TLPFondoInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TLPFondoInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPFondoInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TLPFondoInicio.Size = new System.Drawing.Size(905, 643);
            this.TLPFondoInicio.TabIndex = 0;
            // 
            // MSInicio
            // 
            this.MSInicio.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MSInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMsToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.configuracToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.MSInicio.Location = new System.Drawing.Point(0, 0);
            this.MSInicio.Name = "MSInicio";
            this.MSInicio.Size = new System.Drawing.Size(905, 25);
            this.MSInicio.TabIndex = 0;
            this.MSInicio.Text = "menuStrip1";
            // 
            // aBMsToolStripMenuItem
            // 
            this.aBMsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.palabrasToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.regionesToolStripMenuItem});
            this.aBMsToolStripMenuItem.Name = "aBMsToolStripMenuItem";
            this.aBMsToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aBMsToolStripMenuItem.Text = "ABMs";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // palabrasToolStripMenuItem
            // 
            this.palabrasToolStripMenuItem.Name = "palabrasToolStripMenuItem";
            this.palabrasToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.palabrasToolStripMenuItem.Text = "Palabras";
            this.palabrasToolStripMenuItem.Click += new System.EventHandler(this.palabrasToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.categoriaToolStripMenuItem.Text = "Categorias";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // regionesToolStripMenuItem
            // 
            this.regionesToolStripMenuItem.Name = "regionesToolStripMenuItem";
            this.regionesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.regionesToolStripMenuItem.Text = "Regiones";
            this.regionesToolStripMenuItem.Click += new System.EventHandler(this.regionesToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // configuracToolStripMenuItem
            // 
            this.configuracToolStripMenuItem.Name = "configuracToolStripMenuItem";
            this.configuracToolStripMenuItem.Size = new System.Drawing.Size(107, 21);
            this.configuracToolStripMenuItem.Text = "Configuración";
            this.configuracToolStripMenuItem.Click += new System.EventHandler(this.configuracToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.ayudaToolStripMenuItem.Text = "Creditos";
            // 
            // PBUtnFooter
            // 
            this.PBUtnFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PBUtnFooter.BackColor = System.Drawing.Color.Transparent;
            this.PBUtnFooter.Image = global::CapaPresentacion.Properties.Resources.Logo_UTN;
            this.PBUtnFooter.Location = new System.Drawing.Point(751, 618);
            this.PBUtnFooter.Name = "PBUtnFooter";
            this.PBUtnFooter.Size = new System.Drawing.Size(151, 22);
            this.PBUtnFooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBUtnFooter.TabIndex = 1;
            this.PBUtnFooter.TabStop = false;
            // 
            // PContenedor
            // 
            this.PContenedor.BackColor = System.Drawing.Color.Transparent;
            this.PContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PContenedor.Location = new System.Drawing.Point(3, 32);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(899, 580);
            this.PContenedor.TabIndex = 2;
            this.PContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PContenedor_Paint);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 643);
            this.Controls.Add(this.TLPFondoInicio);
            this.MainMenuStrip = this.MSInicio;
            this.MinimumSize = new System.Drawing.Size(921, 682);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dici Juegos";
            this.TLPFondoInicio.ResumeLayout(false);
            this.TLPFondoInicio.PerformLayout();
            this.MSInicio.ResumeLayout(false);
            this.MSInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBUtnFooter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPFondoInicio;
        private System.Windows.Forms.MenuStrip MSInicio;
        private System.Windows.Forms.ToolStripMenuItem aBMsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palabrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.PictureBox PBUtnFooter;
        private System.Windows.Forms.Panel PContenedor;
    }
}