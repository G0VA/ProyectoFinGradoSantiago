namespace Bienvenida.Presentacion.Principal
{
    partial class Principal
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnNewPedido = new System.Windows.Forms.Button();
            this.btnModPedido = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(937, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(207, 33);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "DD/MM/AAAA";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAceptar.Location = new System.Drawing.Point(12, 12);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(131, 64);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Volver";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnNewPedido
            // 
            this.btnNewPedido.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNewPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPedido.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnNewPedido.Location = new System.Drawing.Point(943, 57);
            this.btnNewPedido.Name = "btnNewPedido";
            this.btnNewPedido.Size = new System.Drawing.Size(201, 64);
            this.btnNewPedido.TabIndex = 11;
            this.btnNewPedido.Text = "Nuevo Pedido";
            this.btnNewPedido.UseVisualStyleBackColor = false;
            // 
            // btnModPedido
            // 
            this.btnModPedido.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModPedido.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnModPedido.Location = new System.Drawing.Point(943, 145);
            this.btnModPedido.Name = "btnModPedido";
            this.btnModPedido.Size = new System.Drawing.Size(201, 64);
            this.btnModPedido.TabIndex = 12;
            this.btnModPedido.Text = "Modificar Pedido";
            this.btnModPedido.UseVisualStyleBackColor = false;
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTicket.Location = new System.Drawing.Point(943, 370);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(201, 64);
            this.btnTicket.TabIndex = 13;
            this.btnTicket.Text = "Imprimir Ticket";
            this.btnTicket.UseVisualStyleBackColor = false;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPagar.Location = new System.Drawing.Point(943, 457);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(201, 64);
            this.btnPagar.TabIndex = 14;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnProductos.Location = new System.Drawing.Point(12, 93);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(131, 64);
            this.btnProductos.TabIndex = 15;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1206, 623);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnModPedido);
            this.Controls.Add(this.btnNewPedido);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnNewPedido;
        private System.Windows.Forms.Button btnModPedido;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnProductos;
    }
}