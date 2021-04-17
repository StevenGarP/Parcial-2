
namespace tarea_7
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
            this.buttonCargar = new System.Windows.Forms.Button();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.labelpromedio1 = new System.Windows.Forms.Label();
            this.labelpromedio2 = new System.Windows.Forms.Label();
            this.labelpromedio3 = new System.Windows.Forms.Label();
            this.buttonSecciones = new System.Windows.Forms.Button();
            this.promedio = new System.Windows.Forms.Button();
            this.textBoxParcial = new System.Windows.Forms.TextBox();
            this.textBoxSeccion = new System.Windows.Forms.TextBox();
            this.buttonSumatoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(53, 32);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(115, 23);
            this.buttonCargar.TabIndex = 4;
            this.buttonCargar.Text = "Cargar Archivo";
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(199, 12);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContenido.Size = new System.Drawing.Size(298, 238);
            this.textBoxContenido.TabIndex = 3;
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(521, 12);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(196, 238);
            this.listBoxResultado.TabIndex = 6;
            // 
            // labelpromedio1
            // 
            this.labelpromedio1.AutoSize = true;
            this.labelpromedio1.Location = new System.Drawing.Point(216, 324);
            this.labelpromedio1.Name = "labelpromedio1";
            this.labelpromedio1.Size = new System.Drawing.Size(0, 13);
            this.labelpromedio1.TabIndex = 9;
            // 
            // labelpromedio2
            // 
            this.labelpromedio2.AutoSize = true;
            this.labelpromedio2.Location = new System.Drawing.Point(216, 347);
            this.labelpromedio2.Name = "labelpromedio2";
            this.labelpromedio2.Size = new System.Drawing.Size(0, 13);
            this.labelpromedio2.TabIndex = 9;
            // 
            // labelpromedio3
            // 
            this.labelpromedio3.AutoSize = true;
            this.labelpromedio3.Location = new System.Drawing.Point(216, 371);
            this.labelpromedio3.Name = "labelpromedio3";
            this.labelpromedio3.Size = new System.Drawing.Size(0, 13);
            this.labelpromedio3.TabIndex = 9;
            // 
            // buttonSecciones
            // 
            this.buttonSecciones.Location = new System.Drawing.Point(58, 84);
            this.buttonSecciones.Name = "buttonSecciones";
            this.buttonSecciones.Size = new System.Drawing.Size(110, 20);
            this.buttonSecciones.TabIndex = 10;
            this.buttonSecciones.Text = "Clasificar";
            this.buttonSecciones.UseVisualStyleBackColor = true;
            this.buttonSecciones.Click += new System.EventHandler(this.buttonSecciones_Click);
            // 
            // promedio
            // 
            this.promedio.Location = new System.Drawing.Point(58, 130);
            this.promedio.Name = "promedio";
            this.promedio.Size = new System.Drawing.Size(109, 23);
            this.promedio.TabIndex = 11;
            this.promedio.Text = "promedios";
            this.promedio.UseVisualStyleBackColor = true;
            this.promedio.Click += new System.EventHandler(this.promedio_Click);
            // 
            // textBoxParcial
            // 
            this.textBoxParcial.Location = new System.Drawing.Point(199, 285);
            this.textBoxParcial.Name = "textBoxParcial";
            this.textBoxParcial.Size = new System.Drawing.Size(91, 20);
            this.textBoxParcial.TabIndex = 12;
            // 
            // textBoxSeccion
            // 
            this.textBoxSeccion.Location = new System.Drawing.Point(313, 285);
            this.textBoxSeccion.Name = "textBoxSeccion";
            this.textBoxSeccion.Size = new System.Drawing.Size(91, 20);
            this.textBoxSeccion.TabIndex = 12;
            // 
            // buttonSumatoria
            // 
            this.buttonSumatoria.Location = new System.Drawing.Point(61, 177);
            this.buttonSumatoria.Name = "buttonSumatoria";
            this.buttonSumatoria.Size = new System.Drawing.Size(105, 30);
            this.buttonSumatoria.TabIndex = 13;
            this.buttonSumatoria.Text = "sumatoria ";
            this.buttonSumatoria.UseVisualStyleBackColor = true;
            this.buttonSumatoria.Click += new System.EventHandler(this.buttonSumatoria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 501);
            this.Controls.Add(this.buttonSumatoria);
            this.Controls.Add(this.textBoxSeccion);
            this.Controls.Add(this.textBoxParcial);
            this.Controls.Add(this.promedio);
            this.Controls.Add(this.buttonSecciones);
            this.Controls.Add(this.labelpromedio3);
            this.Controls.Add(this.labelpromedio2);
            this.Controls.Add(this.labelpromedio1);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.buttonCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Label labelpromedio1;
        private System.Windows.Forms.Label labelpromedio2;
        private System.Windows.Forms.Label labelpromedio3;
        private System.Windows.Forms.Button buttonSecciones;
        private System.Windows.Forms.Button promedio;
        private System.Windows.Forms.TextBox textBoxParcial;
        private System.Windows.Forms.TextBox textBoxSeccion;
        private System.Windows.Forms.Button buttonSumatoria;
    }
}

