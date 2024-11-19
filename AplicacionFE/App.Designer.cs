namespace AplicacionFE
{
    partial class App
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
            this.lNombre = new System.Windows.Forms.Label();
            this.lEdad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(346, 30);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre";
            // 
            // lEdad
            // 
            this.lEdad.AutoSize = true;
            this.lEdad.Location = new System.Drawing.Point(346, 128);
            this.lEdad.Name = "lEdad";
            this.lEdad.Size = new System.Drawing.Size(32, 13);
            this.lEdad.TabIndex = 1;
            this.lEdad.Text = "Edad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(234, 255);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(339, 150);
            this.dgvLista.TabIndex = 3;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(349, 65);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(349, 173);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(100, 20);
            this.tbEdad.TabIndex = 5;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lEdad);
            this.Controls.Add(this.lNombre);
            this.Name = "App";
            this.Text = "Verificador";
            this.Load += new System.EventHandler(this.App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lEdad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbEdad;
    }
}

