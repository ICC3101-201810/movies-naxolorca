namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.panelBienvenida = new System.Windows.Forms.Panel();
            this.lbBienvenida = new System.Windows.Forms.Label();
            this.timerPrincipal = new System.Windows.Forms.Timer(this.components);
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.buttonEstudios = new System.Windows.Forms.Button();
            this.buttonProductores = new System.Windows.Forms.Button();
            this.buttonDirectores = new System.Windows.Forms.Button();
            this.buttonActores = new System.Windows.Forms.Button();
            this.buttonPeliculas = new System.Windows.Forms.Button();
            this.listboxBusqueda = new System.Windows.Forms.ListBox();
            this.panelBienvenida.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBienvenida
            // 
            this.panelBienvenida.Controls.Add(this.lbBienvenida);
            this.panelBienvenida.Location = new System.Drawing.Point(0, 0);
            this.panelBienvenida.Name = "panelBienvenida";
            this.panelBienvenida.Size = new System.Drawing.Size(200, 100);
            this.panelBienvenida.TabIndex = 0;
            // 
            // lbBienvenida
            // 
            this.lbBienvenida.AutoSize = true;
            this.lbBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbBienvenida.Location = new System.Drawing.Point(66, 44);
            this.lbBienvenida.Name = "lbBienvenida";
            this.lbBienvenida.Size = new System.Drawing.Size(60, 13);
            this.lbBienvenida.TabIndex = 0;
            this.lbBienvenida.Text = "Bienvenido";
            // 
            // timerPrincipal
            // 
            this.timerPrincipal.Enabled = true;
            this.timerPrincipal.Interval = 5000;
            this.timerPrincipal.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.listboxBusqueda);
            this.panelBusqueda.Controls.Add(this.tbBusqueda);
            this.panelBusqueda.Controls.Add(this.buttonEstudios);
            this.panelBusqueda.Controls.Add(this.buttonProductores);
            this.panelBusqueda.Controls.Add(this.buttonDirectores);
            this.panelBusqueda.Controls.Add(this.buttonActores);
            this.panelBusqueda.Controls.Add(this.buttonPeliculas);
            this.panelBusqueda.Location = new System.Drawing.Point(206, 0);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(572, 119);
            this.panelBusqueda.TabIndex = 1;
            this.panelBusqueda.Visible = false;
            this.panelBusqueda.Click += new System.EventHandler(this.panelBusqueda_Click);
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(16, 19);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(401, 20);
            this.tbBusqueda.TabIndex = 5;
            this.tbBusqueda.Text = "🔎Busqueda...";
            this.tbBusqueda.Click += new System.EventHandler(this.tbBusqueda_Click);
            this.tbBusqueda.TextChanged += new System.EventHandler(this.tbBusqueda_TextChanged);
            // 
            // buttonEstudios
            // 
            this.buttonEstudios.Location = new System.Drawing.Point(342, 64);
            this.buttonEstudios.Name = "buttonEstudios";
            this.buttonEstudios.Size = new System.Drawing.Size(75, 23);
            this.buttonEstudios.TabIndex = 4;
            this.buttonEstudios.Text = "Estudios";
            this.buttonEstudios.UseVisualStyleBackColor = true;
            // 
            // buttonProductores
            // 
            this.buttonProductores.Location = new System.Drawing.Point(260, 65);
            this.buttonProductores.Name = "buttonProductores";
            this.buttonProductores.Size = new System.Drawing.Size(75, 23);
            this.buttonProductores.TabIndex = 3;
            this.buttonProductores.Text = "Productores";
            this.buttonProductores.UseVisualStyleBackColor = true;
            // 
            // buttonDirectores
            // 
            this.buttonDirectores.Location = new System.Drawing.Point(178, 65);
            this.buttonDirectores.Name = "buttonDirectores";
            this.buttonDirectores.Size = new System.Drawing.Size(75, 23);
            this.buttonDirectores.TabIndex = 2;
            this.buttonDirectores.Text = "Directores";
            this.buttonDirectores.UseVisualStyleBackColor = true;
            // 
            // buttonActores
            // 
            this.buttonActores.Location = new System.Drawing.Point(97, 65);
            this.buttonActores.Name = "buttonActores";
            this.buttonActores.Size = new System.Drawing.Size(75, 23);
            this.buttonActores.TabIndex = 1;
            this.buttonActores.Text = "Actores";
            this.buttonActores.UseVisualStyleBackColor = true;
            // 
            // buttonPeliculas
            // 
            this.buttonPeliculas.Location = new System.Drawing.Point(16, 65);
            this.buttonPeliculas.Name = "buttonPeliculas";
            this.buttonPeliculas.Size = new System.Drawing.Size(75, 23);
            this.buttonPeliculas.TabIndex = 0;
            this.buttonPeliculas.Text = "Peliculas";
            this.buttonPeliculas.UseVisualStyleBackColor = true;
            this.buttonPeliculas.Click += new System.EventHandler(this.buttonPeliculas_Click);
            // 
            // listboxBusqueda
            // 
            this.listboxBusqueda.FormattingEnabled = true;
            this.listboxBusqueda.Location = new System.Drawing.Point(423, 12);
            this.listboxBusqueda.Name = "listboxBusqueda";
            this.listboxBusqueda.Size = new System.Drawing.Size(140, 95);
            this.listboxBusqueda.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(998, 446);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.panelBienvenida);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelBienvenida.ResumeLayout(false);
            this.panelBienvenida.PerformLayout();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBienvenida;
        private System.Windows.Forms.Timer timerPrincipal;
        private System.Windows.Forms.Label lbBienvenida;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Button buttonDirectores;
        private System.Windows.Forms.Button buttonActores;
        private System.Windows.Forms.Button buttonPeliculas;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Button buttonEstudios;
        private System.Windows.Forms.Button buttonProductores;
        private System.Windows.Forms.ListBox listboxBusqueda;
    }
}

