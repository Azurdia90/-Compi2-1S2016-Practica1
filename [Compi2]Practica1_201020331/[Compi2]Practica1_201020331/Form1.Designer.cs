namespace _Compi2_Practica1_201020331
{
    partial class Form1
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
            this.mS_Aplication = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.analizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMICargar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Analizar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Debugger = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaDeTokensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erroresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tC_Aplication = new System.Windows.Forms.TabControl();
            this.tP_Analizar = new System.Windows.Forms.TabPage();
            this.tP_Cargar = new System.Windows.Forms.TabPage();
            this.tP_Debugger = new System.Windows.Forms.TabPage();
            this.tC_Analizar = new System.Windows.Forms.TabControl();
            this.b_Analizar = new System.Windows.Forms.Button();
            this.tC_Cargar = new System.Windows.Forms.TabControl();
            this.tPCargar_0 = new System.Windows.Forms.TabPage();
            this.b_Cargar = new System.Windows.Forms.Button();
            this.tPAnalizar_0 = new System.Windows.Forms.TabPage();
            this.rTB_Cargar = new System.Windows.Forms.RichTextBox();
            this.rTB_Analizar = new System.Windows.Forms.RichTextBox();
            this.mS_Aplication.SuspendLayout();
            this.tC_Aplication.SuspendLayout();
            this.tP_Analizar.SuspendLayout();
            this.tP_Cargar.SuspendLayout();
            this.tC_Analizar.SuspendLayout();
            this.tC_Cargar.SuspendLayout();
            this.tPCargar_0.SuspendLayout();
            this.tPAnalizar_0.SuspendLayout();
            this.SuspendLayout();
            // 
            // mS_Aplication
            // 
            this.mS_Aplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.analizadorToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.mS_Aplication.Location = new System.Drawing.Point(0, 0);
            this.mS_Aplication.Name = "mS_Aplication";
            this.mS_Aplication.Size = new System.Drawing.Size(704, 24);
            this.mS_Aplication.TabIndex = 0;
            this.mS_Aplication.Text = "mS_Aplication";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.TSMI_Exit});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // TSMI_Exit
            // 
            this.TSMI_Exit.Name = "TSMI_Exit";
            this.TSMI_Exit.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Exit.Text = "Salir";
            this.TSMI_Exit.Click += new System.EventHandler(this.TSMI_Exit_Click);
            // 
            // analizadorToolStripMenuItem
            // 
            this.analizadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMICargar,
            this.TSMI_Analizar,
            this.TSMI_Debugger});
            this.analizadorToolStripMenuItem.Name = "analizadorToolStripMenuItem";
            this.analizadorToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.analizadorToolStripMenuItem.Text = "Analizador";
            // 
            // TSMICargar
            // 
            this.TSMICargar.Name = "TSMICargar";
            this.TSMICargar.Size = new System.Drawing.Size(152, 22);
            this.TSMICargar.Text = "Cargar";
            this.TSMICargar.Click += new System.EventHandler(this.TSMICargar_Click);
            // 
            // TSMI_Analizar
            // 
            this.TSMI_Analizar.Name = "TSMI_Analizar";
            this.TSMI_Analizar.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Analizar.Text = "Analizar";
            this.TSMI_Analizar.Click += new System.EventHandler(this.TSMI_Analizar_Click);
            // 
            // TSMI_Debugger
            // 
            this.TSMI_Debugger.Name = "TSMI_Debugger";
            this.TSMI_Debugger.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Debugger.Text = "Debugger";
            this.TSMI_Debugger.Click += new System.EventHandler(this.TSMI_Debugger_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaDeTokensToolStripMenuItem,
            this.erroresToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // tablaDeTokensToolStripMenuItem
            // 
            this.tablaDeTokensToolStripMenuItem.Name = "tablaDeTokensToolStripMenuItem";
            this.tablaDeTokensToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tablaDeTokensToolStripMenuItem.Text = "Tabla de Tokens";
            // 
            // erroresToolStripMenuItem
            // 
            this.erroresToolStripMenuItem.Name = "erroresToolStripMenuItem";
            this.erroresToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.erroresToolStripMenuItem.Text = "Errores";
            // 
            // tC_Aplication
            // 
            this.tC_Aplication.Controls.Add(this.tP_Cargar);
            this.tC_Aplication.Controls.Add(this.tP_Analizar);
            this.tC_Aplication.Controls.Add(this.tP_Debugger);
            this.tC_Aplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tC_Aplication.Location = new System.Drawing.Point(0, 24);
            this.tC_Aplication.Name = "tC_Aplication";
            this.tC_Aplication.SelectedIndex = 0;
            this.tC_Aplication.Size = new System.Drawing.Size(704, 417);
            this.tC_Aplication.TabIndex = 1;
            // 
            // tP_Analizar
            // 
            this.tP_Analizar.Controls.Add(this.b_Analizar);
            this.tP_Analizar.Controls.Add(this.tC_Analizar);
            this.tP_Analizar.Location = new System.Drawing.Point(4, 22);
            this.tP_Analizar.Name = "tP_Analizar";
            this.tP_Analizar.Padding = new System.Windows.Forms.Padding(3);
            this.tP_Analizar.Size = new System.Drawing.Size(696, 391);
            this.tP_Analizar.TabIndex = 0;
            this.tP_Analizar.Text = "Analizar";
            this.tP_Analizar.UseVisualStyleBackColor = true;
            // 
            // tP_Cargar
            // 
            this.tP_Cargar.Controls.Add(this.b_Cargar);
            this.tP_Cargar.Controls.Add(this.tC_Cargar);
            this.tP_Cargar.Location = new System.Drawing.Point(4, 22);
            this.tP_Cargar.Name = "tP_Cargar";
            this.tP_Cargar.Padding = new System.Windows.Forms.Padding(3);
            this.tP_Cargar.Size = new System.Drawing.Size(696, 391);
            this.tP_Cargar.TabIndex = 1;
            this.tP_Cargar.Text = "Cargar";
            this.tP_Cargar.UseVisualStyleBackColor = true;
            // 
            // tP_Debugger
            // 
            this.tP_Debugger.Location = new System.Drawing.Point(4, 22);
            this.tP_Debugger.Name = "tP_Debugger";
            this.tP_Debugger.Padding = new System.Windows.Forms.Padding(3);
            this.tP_Debugger.Size = new System.Drawing.Size(696, 391);
            this.tP_Debugger.TabIndex = 2;
            this.tP_Debugger.Text = "Debugger";
            this.tP_Debugger.UseVisualStyleBackColor = true;
            // 
            // tC_Analizar
            // 
            this.tC_Analizar.Controls.Add(this.tPAnalizar_0);
            this.tC_Analizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tC_Analizar.Location = new System.Drawing.Point(3, 3);
            this.tC_Analizar.Name = "tC_Analizar";
            this.tC_Analizar.SelectedIndex = 0;
            this.tC_Analizar.Size = new System.Drawing.Size(690, 340);
            this.tC_Analizar.TabIndex = 0;
            // 
            // b_Analizar
            // 
            this.b_Analizar.Location = new System.Drawing.Point(311, 360);
            this.b_Analizar.Name = "b_Analizar";
            this.b_Analizar.Size = new System.Drawing.Size(75, 23);
            this.b_Analizar.TabIndex = 1;
            this.b_Analizar.Text = "Analizar";
            this.b_Analizar.UseVisualStyleBackColor = true;
            // 
            // tC_Cargar
            // 
            this.tC_Cargar.Controls.Add(this.tPCargar_0);
            this.tC_Cargar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tC_Cargar.Location = new System.Drawing.Point(3, 3);
            this.tC_Cargar.Name = "tC_Cargar";
            this.tC_Cargar.SelectedIndex = 0;
            this.tC_Cargar.Size = new System.Drawing.Size(690, 339);
            this.tC_Cargar.TabIndex = 0;
            // 
            // tPCargar_0
            // 
            this.tPCargar_0.Controls.Add(this.rTB_Cargar);
            this.tPCargar_0.Location = new System.Drawing.Point(4, 22);
            this.tPCargar_0.Name = "tPCargar_0";
            this.tPCargar_0.Padding = new System.Windows.Forms.Padding(3);
            this.tPCargar_0.Size = new System.Drawing.Size(682, 313);
            this.tPCargar_0.TabIndex = 1;
            this.tPCargar_0.Text = "Analizar.txt";
            this.tPCargar_0.UseVisualStyleBackColor = true;
            // 
            // b_Cargar
            // 
            this.b_Cargar.Location = new System.Drawing.Point(315, 360);
            this.b_Cargar.Name = "b_Cargar";
            this.b_Cargar.Size = new System.Drawing.Size(75, 23);
            this.b_Cargar.TabIndex = 1;
            this.b_Cargar.Text = "Cargar";
            this.b_Cargar.UseVisualStyleBackColor = true;
            this.b_Cargar.Click += new System.EventHandler(this.b_Cargar_Click);
            // 
            // tPAnalizar_0
            // 
            this.tPAnalizar_0.Controls.Add(this.rTB_Analizar);
            this.tPAnalizar_0.Location = new System.Drawing.Point(4, 22);
            this.tPAnalizar_0.Name = "tPAnalizar_0";
            this.tPAnalizar_0.Padding = new System.Windows.Forms.Padding(3);
            this.tPAnalizar_0.Size = new System.Drawing.Size(682, 314);
            this.tPAnalizar_0.TabIndex = 1;
            this.tPAnalizar_0.Text = "Analizar.dx";
            this.tPAnalizar_0.UseVisualStyleBackColor = true;
            // 
            // rTB_Cargar
            // 
            this.rTB_Cargar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTB_Cargar.Location = new System.Drawing.Point(3, 3);
            this.rTB_Cargar.Name = "rTB_Cargar";
            this.rTB_Cargar.Size = new System.Drawing.Size(676, 307);
            this.rTB_Cargar.TabIndex = 0;
            this.rTB_Cargar.Text = "";
            // 
            // rTB_Analizar
            // 
            this.rTB_Analizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTB_Analizar.Location = new System.Drawing.Point(3, 3);
            this.rTB_Analizar.Name = "rTB_Analizar";
            this.rTB_Analizar.Size = new System.Drawing.Size(676, 308);
            this.rTB_Analizar.TabIndex = 0;
            this.rTB_Analizar.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.tC_Aplication);
            this.Controls.Add(this.mS_Aplication);
            this.MainMenuStrip = this.mS_Aplication;
            this.Name = "Form1";
            this.Text = "DLex Editor";
            this.mS_Aplication.ResumeLayout(false);
            this.mS_Aplication.PerformLayout();
            this.tC_Aplication.ResumeLayout(false);
            this.tP_Analizar.ResumeLayout(false);
            this.tP_Cargar.ResumeLayout(false);
            this.tC_Analizar.ResumeLayout(false);
            this.tC_Cargar.ResumeLayout(false);
            this.tPCargar_0.ResumeLayout(false);
            this.tPAnalizar_0.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mS_Aplication;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
        private System.Windows.Forms.ToolStripMenuItem analizadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMICargar;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Analizar;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Debugger;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaDeTokensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erroresToolStripMenuItem;
        private System.Windows.Forms.TabControl tC_Aplication;
        private System.Windows.Forms.TabPage tP_Analizar;
        private System.Windows.Forms.TabPage tP_Cargar;
        private System.Windows.Forms.TabPage tP_Debugger;
        private System.Windows.Forms.Button b_Analizar;
        private System.Windows.Forms.TabControl tC_Analizar;
        private System.Windows.Forms.Button b_Cargar;
        private System.Windows.Forms.TabControl tC_Cargar;
        private System.Windows.Forms.TabPage tPCargar_0;
        private System.Windows.Forms.RichTextBox rTB_Cargar;
        private System.Windows.Forms.TabPage tPAnalizar_0;
        private System.Windows.Forms.RichTextBox rTB_Analizar;
    }
}

