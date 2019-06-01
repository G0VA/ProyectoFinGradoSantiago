namespace Bienvenida.Presentacion.Pedidos
{
    partial class ModificaPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificaPedido));
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnModificaPedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFPago = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvModPedido = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnVolver.Location = new System.Drawing.Point(17, 483);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 64);
            this.btnVolver.TabIndex = 28;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(709, 302);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(142, 136);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadir.Image")));
            this.btnAñadir.Location = new System.Drawing.Point(709, 117);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(134, 136);
            this.btnAñadir.TabIndex = 31;
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnModificaPedido
            // 
            this.btnModificaPedido.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificaPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaPedido.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnModificaPedido.Location = new System.Drawing.Point(714, 469);
            this.btnModificaPedido.Name = "btnModificaPedido";
            this.btnModificaPedido.Size = new System.Drawing.Size(129, 78);
            this.btnModificaPedido.TabIndex = 30;
            this.btnModificaPedido.Text = "Modifica Pedido";
            this.btnModificaPedido.UseVisualStyleBackColor = false;
            this.btnModificaPedido.Click += new System.EventHandler(this.btnModificaPedido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 26);
            this.label2.TabIndex = 38;
            this.label2.Text = "Forma Pago";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(302, 73);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(186, 20);
            this.txtCliente.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "DESC. CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "DNI EMPLEADO";
            // 
            // cbFPago
            // 
            this.cbFPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFPago.FormattingEnabled = true;
            this.cbFPago.Location = new System.Drawing.Point(553, 72);
            this.cbFPago.Name = "cbFPago";
            this.cbFPago.Size = new System.Drawing.Size(137, 21);
            this.cbFPago.TabIndex = 34;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(30, 409);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(102, 20);
            this.txtTotal.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 26);
            this.label6.TabIndex = 44;
            this.label6.Text = "Total";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(30, 160);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 83);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 26);
            this.label5.TabIndex = 42;
            this.label5.Text = "Producto";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(30, 266);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(156, 20);
            this.txtProduct.TabIndex = 41;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(30, 340);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(102, 20);
            this.nudAmount.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "Cantidad";
            // 
            // dgvModPedido
            // 
            this.dgvModPedido.AllowUserToAddRows = false;
            this.dgvModPedido.AllowUserToDeleteRows = false;
            this.dgvModPedido.AllowUserToResizeColumns = false;
            this.dgvModPedido.AllowUserToResizeRows = false;
            this.dgvModPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModPedido.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvModPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModPedido.Location = new System.Drawing.Point(212, 117);
            this.dgvModPedido.Name = "dgvModPedido";
            this.dgvModPedido.ReadOnly = true;
            this.dgvModPedido.RowHeadersVisible = false;
            this.dgvModPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModPedido.Size = new System.Drawing.Size(478, 325);
            this.dgvModPedido.TabIndex = 46;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(745, 72);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(106, 20);
            this.txtId.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(732, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 26);
            this.label7.TabIndex = 47;
            this.label7.Text = "ID PEDIDO";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(30, 73);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(186, 20);
            this.txtDni.TabIndex = 49;
            // 
            // ModificaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(878, 575);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvModPedido);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFPago);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnModificaPedido);
            this.Controls.Add(this.btnVolver);
            this.Name = "ModificaPedido";
            this.Text = "ModificaPedido";
            this.Shown += new System.EventHandler(this.ModificaPedido_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnModificaPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFPago;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvModPedido;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDni;
    }
}