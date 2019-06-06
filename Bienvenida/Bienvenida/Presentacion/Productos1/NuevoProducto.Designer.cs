namespace Bienvenida.Presentacion.Productos
{
    partial class NuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoProducto));
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbTipo1 = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipo2 = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnCreaTipo1 = new System.Windows.Forms.Button();
            this.btnCreaTipo2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(195, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // cbTipo1
            // 
            this.cbTipo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipo1.FormattingEnabled = true;
            this.cbTipo1.Location = new System.Drawing.Point(195, 175);
            this.cbTipo1.Name = "cbTipo1";
            this.cbTipo1.Size = new System.Drawing.Size(158, 21);
            this.cbTipo1.TabIndex = 8;
            this.cbTipo1.SelectedIndexChanged += new System.EventHandler(this.cambioValor);
            this.cbTipo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTipo1_KeyPress);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCerrar.Location = new System.Drawing.Point(626, 379);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(131, 64);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tipo 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Precio-€";
            // 
            // cbTipo2
            // 
            this.cbTipo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipo2.FormattingEnabled = true;
            this.cbTipo2.Location = new System.Drawing.Point(195, 259);
            this.cbTipo2.Name = "cbTipo2";
            this.cbTipo2.Size = new System.Drawing.Size(158, 21);
            this.cbTipo2.TabIndex = 18;
            this.cbTipo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTipo2_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(195, 354);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(158, 20);
            this.txtStock.TabIndex = 19;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(195, 432);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(158, 20);
            this.txtPrecio.TabIndex = 20;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // btnAñadir
            // 
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadir.Image")));
            this.btnAñadir.Location = new System.Drawing.Point(611, 144);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(134, 136);
            this.btnAñadir.TabIndex = 13;
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnCreaTipo1
            // 
            this.btnCreaTipo1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreaTipo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreaTipo1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCreaTipo1.Location = new System.Drawing.Point(389, 172);
            this.btnCreaTipo1.Name = "btnCreaTipo1";
            this.btnCreaTipo1.Size = new System.Drawing.Size(131, 29);
            this.btnCreaTipo1.TabIndex = 21;
            this.btnCreaTipo1.Text = "Crear tipo 1";
            this.btnCreaTipo1.UseVisualStyleBackColor = false;
            this.btnCreaTipo1.Click += new System.EventHandler(this.btnCreaTipo1_Click);
            // 
            // btnCreaTipo2
            // 
            this.btnCreaTipo2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreaTipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreaTipo2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCreaTipo2.Location = new System.Drawing.Point(389, 256);
            this.btnCreaTipo2.Name = "btnCreaTipo2";
            this.btnCreaTipo2.Size = new System.Drawing.Size(131, 29);
            this.btnCreaTipo2.TabIndex = 22;
            this.btnCreaTipo2.Text = "Crear tipo 2";
            this.btnCreaTipo2.UseVisualStyleBackColor = false;
            this.btnCreaTipo2.Click += new System.EventHandler(this.btnCreaTipo2_Click);
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(901, 603);
            this.Controls.Add(this.btnCreaTipo2);
            this.Controls.Add(this.btnCreaTipo1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.cbTipo2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cbTipo1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NuevoProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbTipo1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipo2;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnCreaTipo1;
        private System.Windows.Forms.Button btnCreaTipo2;
    }
}