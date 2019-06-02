namespace Bienvenida.Presentacion.Principal1
{
    partial class Contabilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contabilidad));
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmple = new System.Windows.Forms.ComboBox();
            this.ckDate = new System.Windows.Forms.CheckBox();
            this.datesss = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.ckDate2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtVentaHoy = new System.Windows.Forms.TextBox();
            this.txtVentaMes = new System.Windows.Forms.TextBox();
            this.txtVentaAno = new System.Windows.Forms.TextBox();
            this.txtVentaElegido = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnVolver.Location = new System.Drawing.Point(385, 438);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 56);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Empleado";
            // 
            // cbEmple
            // 
            this.cbEmple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEmple.FormattingEnabled = true;
            this.cbEmple.Location = new System.Drawing.Point(52, 68);
            this.cbEmple.Name = "cbEmple";
            this.cbEmple.Size = new System.Drawing.Size(121, 21);
            this.cbEmple.TabIndex = 22;
            // 
            // ckDate
            // 
            this.ckDate.AutoSize = true;
            this.ckDate.Location = new System.Drawing.Point(317, 39);
            this.ckDate.Name = "ckDate";
            this.ckDate.Size = new System.Drawing.Size(15, 14);
            this.ckDate.TabIndex = 33;
            this.ckDate.UseVisualStyleBackColor = true;
            this.ckDate.CheckedChanged += new System.EventHandler(this.cambioCk1);
            // 
            // datesss
            // 
            this.datesss.AutoSize = true;
            this.datesss.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datesss.Location = new System.Drawing.Point(216, 29);
            this.datesss.Name = "datesss";
            this.datesss.Size = new System.Drawing.Size(77, 26);
            this.datesss.TabIndex = 32;
            this.datesss.Text = "Fecha";
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(221, 68);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(111, 20);
            this.date.TabIndex = 31;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(739, 39);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 51);
            this.btnLimpiar.TabIndex = 35;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(603, 29);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(102, 83);
            this.btnFiltrar.TabIndex = 34;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // ckDate2
            // 
            this.ckDate2.AutoSize = true;
            this.ckDate2.Enabled = false;
            this.ckDate2.Location = new System.Drawing.Point(471, 39);
            this.ckDate2.Name = "ckDate2";
            this.ckDate2.Size = new System.Drawing.Size(15, 14);
            this.ckDate2.TabIndex = 38;
            this.ckDate2.UseVisualStyleBackColor = true;
            this.ckDate2.CheckedChanged += new System.EventHandler(this.cambioCk2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fecha";
            // 
            // date2
            // 
            this.date2.Enabled = false;
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date2.Location = new System.Drawing.Point(375, 68);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(111, 20);
            this.date2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtVentaElegido);
            this.panel1.Controls.Add(this.txtVentaAno);
            this.panel1.Controls.Add(this.txtVentaMes);
            this.panel1.Controls.Add(this.txtVentaHoy);
            this.panel1.Controls.Add(this.lblDias);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(65, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 193);
            this.panel1.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total vendido hoy_____________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total vendido mes____________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total vendido año_____________________";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(19, 141);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(0, 24);
            this.lblDias.TabIndex = 3;
            // 
            // txtVentaHoy
            // 
            this.txtVentaHoy.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtVentaHoy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVentaHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentaHoy.Location = new System.Drawing.Point(395, 13);
            this.txtVentaHoy.Name = "txtVentaHoy";
            this.txtVentaHoy.Size = new System.Drawing.Size(100, 22);
            this.txtVentaHoy.TabIndex = 5;
            this.txtVentaHoy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVentaMes
            // 
            this.txtVentaMes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtVentaMes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVentaMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentaMes.Location = new System.Drawing.Point(395, 58);
            this.txtVentaMes.Name = "txtVentaMes";
            this.txtVentaMes.Size = new System.Drawing.Size(100, 22);
            this.txtVentaMes.TabIndex = 6;
            this.txtVentaMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVentaAno
            // 
            this.txtVentaAno.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtVentaAno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVentaAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentaAno.Location = new System.Drawing.Point(395, 98);
            this.txtVentaAno.Name = "txtVentaAno";
            this.txtVentaAno.Size = new System.Drawing.Size(100, 22);
            this.txtVentaAno.TabIndex = 7;
            this.txtVentaAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVentaElegido
            // 
            this.txtVentaElegido.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtVentaElegido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVentaElegido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentaElegido.Location = new System.Drawing.Point(395, 141);
            this.txtVentaElegido.Name = "txtVentaElegido";
            this.txtVentaElegido.Size = new System.Drawing.Size(100, 22);
            this.txtVentaElegido.TabIndex = 8;
            this.txtVentaElegido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(77, 128);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(0, 24);
            this.lblCambio.TabIndex = 10;
            // 
            // btnGrafico
            // 
            this.btnGrafico.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafico.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGrafico.Location = new System.Drawing.Point(679, 168);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(131, 56);
            this.btnGrafico.TabIndex = 40;
            this.btnGrafico.Text = "Ver grafico dia";
            this.btnGrafico.UseVisualStyleBackColor = false;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(679, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 56);
            this.button1.TabIndex = 41;
            this.button1.Text = "Ver grafico mes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(679, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 56);
            this.button2.TabIndex = 42;
            this.button2.Text = "Ver grafico año";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Contabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(909, 542);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ckDate2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.ckDate);
            this.Controls.Add(this.datesss);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEmple);
            this.Controls.Add(this.btnVolver);
            this.Name = "Contabilidad";
            this.Text = "Contabilidad";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmple;
        private System.Windows.Forms.CheckBox ckDate;
        private System.Windows.Forms.Label datesss;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckBox ckDate2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtVentaElegido;
        private System.Windows.Forms.TextBox txtVentaAno;
        private System.Windows.Forms.TextBox txtVentaMes;
        private System.Windows.Forms.TextBox txtVentaHoy;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}