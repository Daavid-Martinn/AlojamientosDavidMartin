namespace AlojamientosDavid
{
    partial class AgregarModificarReserva
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
            this.cbdUdAlojamiento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbdEstablecimiento = new System.Windows.Forms.ComboBox();
            this.cbdCategoria = new System.Windows.Forms.ComboBox();
            this.cbdCliente = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpEntradaIns = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.dtpSalidaIns = new System.Windows.Forms.DateTimePicker();
            this.txtCantIns = new System.Windows.Forms.TextBox();
            this.txtImporteIns = new System.Windows.Forms.TextBox();
            this.txtFianzaIns = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.groupBoxInsertar = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            this.lblTituloModificar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbdEstado = new System.Windows.Forms.ComboBox();
            this.txtCantMod = new System.Windows.Forms.TextBox();
            this.txtFianzaMod = new System.Windows.Forms.TextBox();
            this.txtImporteMod = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpEntradaMod = new System.Windows.Forms.DateTimePicker();
            this.dtpSalidaMod = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUd = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.Modificar = new System.Windows.Forms.Button();
            this.groupBoxModificar = new System.Windows.Forms.GroupBox();
            this.groupBoxInsertar.SuspendLayout();
            this.groupBoxModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbdUdAlojamiento
            // 
            this.cbdUdAlojamiento.FormattingEnabled = true;
            this.cbdUdAlojamiento.Location = new System.Drawing.Point(161, 143);
            this.cbdUdAlojamiento.Name = "cbdUdAlojamiento";
            this.cbdUdAlojamiento.Size = new System.Drawing.Size(121, 24);
            this.cbdUdAlojamiento.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Formulario para insertar reserva";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Unidad de alojamiento*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Establecimiento*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Categoria*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "Cliente*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 290);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(182, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "Cantidad de Personas (num)*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 324);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "Fianza (num)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 360);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 16);
            this.label17.TabIndex = 32;
            this.label17.Text = "Importe (num)*";
            // 
            // cbdEstablecimiento
            // 
            this.cbdEstablecimiento.FormattingEnabled = true;
            this.cbdEstablecimiento.Location = new System.Drawing.Point(121, 104);
            this.cbdEstablecimiento.Name = "cbdEstablecimiento";
            this.cbdEstablecimiento.Size = new System.Drawing.Size(121, 24);
            this.cbdEstablecimiento.TabIndex = 34;
            // 
            // cbdCategoria
            // 
            this.cbdCategoria.FormattingEnabled = true;
            this.cbdCategoria.Location = new System.Drawing.Point(102, 69);
            this.cbdCategoria.Name = "cbdCategoria";
            this.cbdCategoria.Size = new System.Drawing.Size(121, 24);
            this.cbdCategoria.TabIndex = 35;
            // 
            // cbdCliente
            // 
            this.cbdCliente.FormattingEnabled = true;
            this.cbdCliente.Location = new System.Drawing.Point(93, 175);
            this.cbdCliente.Name = "cbdCliente";
            this.cbdCliente.Size = new System.Drawing.Size(121, 24);
            this.cbdCliente.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 216);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 16);
            this.label19.TabIndex = 37;
            this.label19.Text = "Fecha entrada*";
            // 
            // dtpEntradaIns
            // 
            this.dtpEntradaIns.Location = new System.Drawing.Point(113, 211);
            this.dtpEntradaIns.Name = "dtpEntradaIns";
            this.dtpEntradaIns.Size = new System.Drawing.Size(200, 22);
            this.dtpEntradaIns.TabIndex = 38;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 244);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 16);
            this.label20.TabIndex = 39;
            this.label20.Text = "Fecha salida*";
            // 
            // dtpSalidaIns
            // 
            this.dtpSalidaIns.Location = new System.Drawing.Point(103, 244);
            this.dtpSalidaIns.Name = "dtpSalidaIns";
            this.dtpSalidaIns.Size = new System.Drawing.Size(200, 22);
            this.dtpSalidaIns.TabIndex = 40;
            // 
            // txtCantIns
            // 
            this.txtCantIns.Location = new System.Drawing.Point(200, 287);
            this.txtCantIns.Name = "txtCantIns";
            this.txtCantIns.Size = new System.Drawing.Size(100, 22);
            this.txtCantIns.TabIndex = 41;
            // 
            // txtImporteIns
            // 
            this.txtImporteIns.Location = new System.Drawing.Point(113, 360);
            this.txtImporteIns.Name = "txtImporteIns";
            this.txtImporteIns.Size = new System.Drawing.Size(100, 22);
            this.txtImporteIns.TabIndex = 42;
            // 
            // txtFianzaIns
            // 
            this.txtFianzaIns.Location = new System.Drawing.Point(103, 321);
            this.txtFianzaIns.Name = "txtFianzaIns";
            this.txtFianzaIns.Size = new System.Drawing.Size(100, 22);
            this.txtFianzaIns.TabIndex = 43;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(228, 331);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(85, 45);
            this.btnInsertar.TabIndex = 44;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // groupBoxInsertar
            // 
            this.groupBoxInsertar.Controls.Add(this.btnInsertar);
            this.groupBoxInsertar.Controls.Add(this.txtFianzaIns);
            this.groupBoxInsertar.Controls.Add(this.txtImporteIns);
            this.groupBoxInsertar.Controls.Add(this.txtCantIns);
            this.groupBoxInsertar.Controls.Add(this.dtpSalidaIns);
            this.groupBoxInsertar.Controls.Add(this.label20);
            this.groupBoxInsertar.Controls.Add(this.dtpEntradaIns);
            this.groupBoxInsertar.Controls.Add(this.label19);
            this.groupBoxInsertar.Controls.Add(this.cbdCliente);
            this.groupBoxInsertar.Controls.Add(this.cbdCategoria);
            this.groupBoxInsertar.Controls.Add(this.cbdEstablecimiento);
            this.groupBoxInsertar.Controls.Add(this.label17);
            this.groupBoxInsertar.Controls.Add(this.label16);
            this.groupBoxInsertar.Controls.Add(this.label15);
            this.groupBoxInsertar.Controls.Add(this.label14);
            this.groupBoxInsertar.Controls.Add(this.label13);
            this.groupBoxInsertar.Controls.Add(this.label12);
            this.groupBoxInsertar.Controls.Add(this.label9);
            this.groupBoxInsertar.Controls.Add(this.label8);
            this.groupBoxInsertar.Controls.Add(this.cbdUdAlojamiento);
            this.groupBoxInsertar.Location = new System.Drawing.Point(405, 14);
            this.groupBoxInsertar.Name = "groupBoxInsertar";
            this.groupBoxInsertar.Size = new System.Drawing.Size(323, 407);
            this.groupBoxInsertar.TabIndex = 45;
            this.groupBoxInsertar.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolver.Location = new System.Drawing.Point(734, 41);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(64, 75);
            this.btnVolver.TabIndex = 46;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.BackColor = System.Drawing.Color.Red;
            this.btnVolverInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolverInicio.Location = new System.Drawing.Point(734, 163);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(64, 75);
            this.btnVolverInicio.TabIndex = 47;
            this.btnVolverInicio.Text = "Volver inicio";
            this.btnVolverInicio.UseVisualStyleBackColor = false;
            // 
            // lblTituloModificar
            // 
            this.lblTituloModificar.AutoSize = true;
            this.lblTituloModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloModificar.Location = new System.Drawing.Point(26, 11);
            this.lblTituloModificar.Name = "lblTituloModificar";
            this.lblTituloModificar.Size = new System.Drawing.Size(301, 25);
            this.lblTituloModificar.TabIndex = 2;
            this.lblTituloModificar.Text = "Formulario para modificar reserva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "IdReserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unidad de alojamiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha salida*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha entrada*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cantidad personas (numero)*";
            // 
            // cbdEstado
            // 
            this.cbdEstado.FormattingEnabled = true;
            this.cbdEstado.Location = new System.Drawing.Point(100, 292);
            this.cbdEstado.Name = "cbdEstado";
            this.cbdEstado.Size = new System.Drawing.Size(121, 24);
            this.cbdEstado.TabIndex = 9;
            // 
            // txtCantMod
            // 
            this.txtCantMod.Location = new System.Drawing.Point(213, 255);
            this.txtCantMod.Name = "txtCantMod";
            this.txtCantMod.Size = new System.Drawing.Size(100, 22);
            this.txtCantMod.TabIndex = 11;
            // 
            // txtFianzaMod
            // 
            this.txtFianzaMod.Location = new System.Drawing.Point(134, 337);
            this.txtFianzaMod.Name = "txtFianzaMod";
            this.txtFianzaMod.Size = new System.Drawing.Size(100, 22);
            this.txtFianzaMod.TabIndex = 12;
            // 
            // txtImporteMod
            // 
            this.txtImporteMod.Location = new System.Drawing.Point(144, 379);
            this.txtImporteMod.Name = "txtImporteMod";
            this.txtImporteMod.Size = new System.Drawing.Size(100, 22);
            this.txtImporteMod.TabIndex = 13;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblId.Location = new System.Drawing.Point(101, 81);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 23);
            this.lblId.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Estado*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Fianza (numero)";
            // 
            // dtpEntradaMod
            // 
            this.dtpEntradaMod.Location = new System.Drawing.Point(137, 180);
            this.dtpEntradaMod.Name = "dtpEntradaMod";
            this.dtpEntradaMod.Size = new System.Drawing.Size(200, 22);
            this.dtpEntradaMod.TabIndex = 19;
            // 
            // dtpSalidaMod
            // 
            this.dtpSalidaMod.Location = new System.Drawing.Point(119, 218);
            this.dtpSalidaMod.Name = "dtpSalidaMod";
            this.dtpSalidaMod.Size = new System.Drawing.Size(200, 22);
            this.dtpSalidaMod.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Importe (numero)*";
            // 
            // lblUd
            // 
            this.lblUd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUd.Location = new System.Drawing.Point(177, 116);
            this.lblUd.Name = "lblUd";
            this.lblUd.Size = new System.Drawing.Size(150, 23);
            this.lblUd.TabIndex = 22;
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCliente.Location = new System.Drawing.Point(97, 146);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(163, 23);
            this.lblCliente.TabIndex = 23;
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(260, 320);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(86, 56);
            this.Modificar.TabIndex = 24;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            // 
            // groupBoxModificar
            // 
            this.groupBoxModificar.Controls.Add(this.Modificar);
            this.groupBoxModificar.Controls.Add(this.lblCliente);
            this.groupBoxModificar.Controls.Add(this.lblUd);
            this.groupBoxModificar.Controls.Add(this.label7);
            this.groupBoxModificar.Controls.Add(this.dtpSalidaMod);
            this.groupBoxModificar.Controls.Add(this.dtpEntradaMod);
            this.groupBoxModificar.Controls.Add(this.label11);
            this.groupBoxModificar.Controls.Add(this.label10);
            this.groupBoxModificar.Controls.Add(this.lblId);
            this.groupBoxModificar.Controls.Add(this.txtImporteMod);
            this.groupBoxModificar.Controls.Add(this.txtFianzaMod);
            this.groupBoxModificar.Controls.Add(this.txtCantMod);
            this.groupBoxModificar.Controls.Add(this.cbdEstado);
            this.groupBoxModificar.Controls.Add(this.label6);
            this.groupBoxModificar.Controls.Add(this.label5);
            this.groupBoxModificar.Controls.Add(this.label4);
            this.groupBoxModificar.Controls.Add(this.label3);
            this.groupBoxModificar.Controls.Add(this.label2);
            this.groupBoxModificar.Controls.Add(this.label1);
            this.groupBoxModificar.Controls.Add(this.lblTituloModificar);
            this.groupBoxModificar.Location = new System.Drawing.Point(16, 12);
            this.groupBoxModificar.Name = "groupBoxModificar";
            this.groupBoxModificar.Size = new System.Drawing.Size(364, 426);
            this.groupBoxModificar.TabIndex = 24;
            this.groupBoxModificar.TabStop = false;
            // 
            // AgregarModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBoxInsertar);
            this.Controls.Add(this.groupBoxModificar);
            this.Name = "AgregarModificarReserva";
            this.Text = "AgregarModificarReserva";
            this.groupBoxInsertar.ResumeLayout(false);
            this.groupBoxInsertar.PerformLayout();
            this.groupBoxModificar.ResumeLayout(false);
            this.groupBoxModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbdUdAlojamiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbdEstablecimiento;
        private System.Windows.Forms.ComboBox cbdCategoria;
        private System.Windows.Forms.ComboBox cbdCliente;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpEntradaIns;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpSalidaIns;
        private System.Windows.Forms.TextBox txtCantIns;
        private System.Windows.Forms.TextBox txtImporteIns;
        private System.Windows.Forms.TextBox txtFianzaIns;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.GroupBox groupBoxInsertar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnVolverInicio;
        private System.Windows.Forms.Label lblTituloModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbdEstado;
        private System.Windows.Forms.TextBox txtCantMod;
        private System.Windows.Forms.TextBox txtFianzaMod;
        private System.Windows.Forms.TextBox txtImporteMod;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpEntradaMod;
        private System.Windows.Forms.DateTimePicker dtpSalidaMod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUd;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.GroupBox groupBoxModificar;
    }
}