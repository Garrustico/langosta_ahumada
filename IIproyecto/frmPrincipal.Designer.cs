namespace IIproyecto
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.txtPersonas = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gpbCalcular = new System.Windows.Forms.GroupBox();
            this.txtNumCotizacion = new System.Windows.Forms.TextBox();
            this.lblNumCotizacion = new System.Windows.Forms.Label();
            this.gpbBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.gpbResultados = new System.Windows.Forms.GroupBox();
            this.lsvResultados = new System.Windows.Forms.ListView();
            this.picSebastian = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.gpbCalcular.SuspendLayout();
            this.gpbBuscar.SuspendLayout();
            this.gpbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSebastian)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.limpiarToolStripMenuItem.Text = "Limpiar";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonas.Location = new System.Drawing.Point(6, 57);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(181, 15);
            this.lblPersonas.TabIndex = 1;
            this.lblPersonas.Text = "Ingrese el número de personas:";
            // 
            // txtPersonas
            // 
            this.txtPersonas.Location = new System.Drawing.Point(193, 56);
            this.txtPersonas.Name = "txtPersonas";
            this.txtPersonas.Size = new System.Drawing.Size(100, 20);
            this.txtPersonas.TabIndex = 2;
            this.txtPersonas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonas_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(9, 82);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 26);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gpbCalcular
            // 
            this.gpbCalcular.Controls.Add(this.txtNumCotizacion);
            this.gpbCalcular.Controls.Add(this.lblNumCotizacion);
            this.gpbCalcular.Controls.Add(this.lblPersonas);
            this.gpbCalcular.Controls.Add(this.txtPersonas);
            this.gpbCalcular.Controls.Add(this.btnCalcular);
            this.gpbCalcular.Location = new System.Drawing.Point(12, 41);
            this.gpbCalcular.Name = "gpbCalcular";
            this.gpbCalcular.Size = new System.Drawing.Size(309, 116);
            this.gpbCalcular.TabIndex = 5;
            this.gpbCalcular.TabStop = false;
            this.gpbCalcular.Text = "Calcular";
            // 
            // txtNumCotizacion
            // 
            this.txtNumCotizacion.Location = new System.Drawing.Point(125, 24);
            this.txtNumCotizacion.Name = "txtNumCotizacion";
            this.txtNumCotizacion.Size = new System.Drawing.Size(100, 20);
            this.txtNumCotizacion.TabIndex = 5;
            // 
            // lblNumCotizacion
            // 
            this.lblNumCotizacion.AutoSize = true;
            this.lblNumCotizacion.Location = new System.Drawing.Point(6, 27);
            this.lblNumCotizacion.Name = "lblNumCotizacion";
            this.lblNumCotizacion.Size = new System.Drawing.Size(113, 13);
            this.lblNumCotizacion.TabIndex = 4;
            this.lblNumCotizacion.Text = "Número de cotización:";
            // 
            // gpbBuscar
            // 
            this.gpbBuscar.Controls.Add(this.btnBuscar);
            this.gpbBuscar.Controls.Add(this.txtConsulta);
            this.gpbBuscar.Controls.Add(this.lblConsulta);
            this.gpbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBuscar.Location = new System.Drawing.Point(334, 41);
            this.gpbBuscar.Name = "gpbBuscar";
            this.gpbBuscar.Size = new System.Drawing.Size(312, 97);
            this.gpbBuscar.TabIndex = 6;
            this.gpbBuscar.TabStop = false;
            this.gpbBuscar.Text = "Buscar presupuesto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(9, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 27);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(184, 27);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(100, 21);
            this.txtConsulta.TabIndex = 1;
            this.txtConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsulta_KeyPress);
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(6, 27);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(172, 15);
            this.lblConsulta.TabIndex = 0;
            this.lblConsulta.Text = "Ingrese número de cotización:";
            // 
            // gpbResultados
            // 
            this.gpbResultados.Controls.Add(this.lsvResultados);
            this.gpbResultados.Location = new System.Drawing.Point(12, 163);
            this.gpbResultados.Name = "gpbResultados";
            this.gpbResultados.Size = new System.Drawing.Size(413, 148);
            this.gpbResultados.TabIndex = 7;
            this.gpbResultados.TabStop = false;
            this.gpbResultados.Text = "Resultados";
            // 
            // lsvResultados
            // 
            this.lsvResultados.HideSelection = false;
            this.lsvResultados.Location = new System.Drawing.Point(9, 19);
            this.lsvResultados.Name = "lsvResultados";
            this.lsvResultados.Size = new System.Drawing.Size(397, 121);
            this.lsvResultados.TabIndex = 0;
            this.lsvResultados.UseCompatibleStateImageBehavior = false;
            this.lsvResultados.View = System.Windows.Forms.View.Details;
            // 
            // picSebastian
            // 
            this.picSebastian.Image = ((System.Drawing.Image)(resources.GetObject("picSebastian.Image")));
            this.picSebastian.Location = new System.Drawing.Point(478, 163);
            this.picSebastian.Name = "picSebastian";
            this.picSebastian.Size = new System.Drawing.Size(140, 160);
            this.picSebastian.TabIndex = 8;
            this.picSebastian.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(668, 335);
            this.ControlBox = false;
            this.Controls.Add(this.picSebastian);
            this.Controls.Add(this.gpbResultados);
            this.Controls.Add(this.gpbBuscar);
            this.Controls.Add(this.gpbCalcular);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La Langosta Ahumada";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbCalcular.ResumeLayout(false);
            this.gpbCalcular.PerformLayout();
            this.gpbBuscar.ResumeLayout(false);
            this.gpbBuscar.PerformLayout();
            this.gpbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSebastian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.TextBox txtPersonas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gpbCalcular;
        private System.Windows.Forms.GroupBox gpbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.GroupBox gpbResultados;
        private System.Windows.Forms.ListView lsvResultados;
        private System.Windows.Forms.TextBox txtNumCotizacion;
        private System.Windows.Forms.Label lblNumCotizacion;
        private System.Windows.Forms.PictureBox picSebastian;
    }
}

