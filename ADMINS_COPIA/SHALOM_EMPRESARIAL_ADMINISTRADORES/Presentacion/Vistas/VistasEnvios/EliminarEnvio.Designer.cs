namespace Presentacion.Vistas.VistasEnvios
{
    partial class EliminarEnvio
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
            label1 = new Label();
            label17 = new Label();
            txtDniEmisor = new TextBox();
            label2 = new Label();
            btnBuscar = new Button();
            btnEliminar = new Button();
            panel3 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            label5 = new Label();
            label15 = new Label();
            label6 = new Label();
            label14 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel5 = new Panel();
            label29 = new Label();
            label9 = new Label();
            label18 = new Label();
            label13 = new Label();
            label11 = new Label();
            label12 = new Label();
            label16 = new Label();
            label10 = new Label();
            lblNroEnvio = new Label();
            lblCliente = new Label();
            lblServicio = new Label();
            lblTipoPaquete = new Label();
            lblPeso = new Label();
            lblContenido = new Label();
            lblDestinatario = new Label();
            lblOrigen = new Label();
            lblDestino = new Label();
            lblCamion = new Label();
            lblTotal = new Label();
            lblEstadoEnvio = new Label();
            lblAdministrador = new Label();
            lblEstadoPago = new Label();
            panel1 = new Panel();
            lblFecha = new Label();
            labelErrorEmisor = new Label();
            label19 = new Label();
            txtNroEnvio = new TextBox();
            lblErrorNroEnvio = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 1;
            label1.Text = "ELIMINACION DE ENVIO";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.HotTrack;
            label17.Location = new Point(12, 146);
            label17.Name = "label17";
            label17.Size = new Size(125, 17);
            label17.TabIndex = 22;
            label17.Text = "Informacion Envio";
            // 
            // txtDniEmisor
            // 
            txtDniEmisor.Font = new Font("Sitka Display", 11.249999F);
            txtDniEmisor.Location = new Point(12, 66);
            txtDniEmisor.Multiline = true;
            txtDniEmisor.Name = "txtDniEmisor";
            txtDniEmisor.Size = new Size(138, 36);
            txtDniEmisor.TabIndex = 23;
            txtDniEmisor.TextChanged += txtDniEmisor_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 41);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 24;
            label2.Text = "DNI DEL CLIENTE";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DodgerBlue;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(392, 66);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(144, 36);
            btnBuscar.TabIndex = 25;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(7, 425);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 41);
            btnEliminar.TabIndex = 26;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(818, 52);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(13, 9);
            label4.Name = "label4";
            label4.Size = new Size(236, 30);
            label4.TabIndex = 0;
            label4.Text = "ENVIO ENCONTRADO";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(3, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(818, 37);
            panel4.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 12);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 0;
            label3.Text = "Nro Envio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(118, 12);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 2;
            label5.Text = "Cliente";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(544, 12);
            label15.Name = "label15";
            label15.Size = new Size(71, 15);
            label15.TabIndex = 12;
            label15.Text = "Contenido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(207, 12);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 3;
            label6.Text = "Servicio";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(438, 12);
            label14.Name = "label14";
            label14.Size = new Size(36, 15);
            label14.TabIndex = 11;
            label14.Text = "Peso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(312, 12);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 4;
            label7.Text = "Tipo Paquete";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(665, 12);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 5;
            label8.Text = "Destinatario";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label29);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(3, 131);
            panel5.Name = "panel5";
            panel5.Size = new Size(818, 37);
            panel5.TabIndex = 24;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.Location = new Point(690, 11);
            label29.Name = "label29";
            label29.Size = new Size(77, 15);
            label29.TabIndex = 40;
            label29.Text = "Fecha Envio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(7, 11);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 6;
            label9.Text = "Origen";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(588, 11);
            label18.Name = "label18";
            label18.Size = new Size(82, 15);
            label18.TabIndex = 14;
            label18.Text = "Estado Pago";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(114, 11);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 10;
            label13.Text = "Destino";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(464, 11);
            label11.Name = "label11";
            label11.Size = new Size(95, 15);
            label11.TabIndex = 8;
            label11.Text = "Administrador";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(361, 11);
            label12.Name = "label12";
            label12.Size = new Size(85, 15);
            label12.TabIndex = 9;
            label12.Text = "Estado Envio";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(207, 11);
            label16.Name = "label16";
            label16.Size = new Size(53, 15);
            label16.TabIndex = 13;
            label16.Text = "Camion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(283, 11);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 7;
            label10.Text = "Total";
            // 
            // lblNroEnvio
            // 
            lblNroEnvio.AutoSize = true;
            lblNroEnvio.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNroEnvio.Location = new Point(13, 96);
            lblNroEnvio.Name = "lblNroEnvio";
            lblNroEnvio.Size = new Size(56, 21);
            lblNroEnvio.TabIndex = 25;
            lblNroEnvio.Text = "label26";
            lblNroEnvio.Visible = false;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(116, 96);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 21);
            lblCliente.TabIndex = 26;
            lblCliente.Text = "label27";
            lblCliente.Visible = false;
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblServicio.Location = new Point(210, 96);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(56, 21);
            lblServicio.TabIndex = 27;
            lblServicio.Text = "label28";
            lblServicio.Visible = false;
            // 
            // lblTipoPaquete
            // 
            lblTipoPaquete.AutoSize = true;
            lblTipoPaquete.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoPaquete.Location = new Point(315, 96);
            lblTipoPaquete.Name = "lblTipoPaquete";
            lblTipoPaquete.Size = new Size(56, 21);
            lblTipoPaquete.TabIndex = 28;
            lblTipoPaquete.Text = "label29";
            lblTipoPaquete.Visible = false;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPeso.Location = new Point(441, 96);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(56, 21);
            lblPeso.TabIndex = 29;
            lblPeso.Text = "label30";
            lblPeso.Visible = false;
            // 
            // lblContenido
            // 
            lblContenido.AutoSize = true;
            lblContenido.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContenido.Location = new Point(547, 96);
            lblContenido.Name = "lblContenido";
            lblContenido.Size = new Size(54, 21);
            lblContenido.TabIndex = 30;
            lblContenido.Text = "label31";
            lblContenido.Visible = false;
            // 
            // lblDestinatario
            // 
            lblDestinatario.AutoSize = true;
            lblDestinatario.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDestinatario.Location = new Point(668, 96);
            lblDestinatario.Name = "lblDestinatario";
            lblDestinatario.Size = new Size(56, 21);
            lblDestinatario.TabIndex = 31;
            lblDestinatario.Text = "label32";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrigen.Location = new Point(10, 181);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(56, 21);
            lblOrigen.TabIndex = 32;
            lblOrigen.Text = "label33";
            lblOrigen.Visible = false;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDestino.Location = new Point(115, 181);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(56, 21);
            lblDestino.TabIndex = 33;
            lblDestino.Text = "label34";
            lblDestino.Visible = false;
            // 
            // lblCamion
            // 
            lblCamion.AutoSize = true;
            lblCamion.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCamion.Location = new Point(211, 181);
            lblCamion.Name = "lblCamion";
            lblCamion.Size = new Size(55, 21);
            lblCamion.TabIndex = 34;
            lblCamion.Text = "label35";
            lblCamion.Visible = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(286, 181);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 21);
            lblTotal.TabIndex = 35;
            lblTotal.Text = "label36";
            lblTotal.Visible = false;
            // 
            // lblEstadoEnvio
            // 
            lblEstadoEnvio.AutoSize = true;
            lblEstadoEnvio.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstadoEnvio.Location = new Point(364, 181);
            lblEstadoEnvio.Name = "lblEstadoEnvio";
            lblEstadoEnvio.Size = new Size(55, 21);
            lblEstadoEnvio.TabIndex = 36;
            lblEstadoEnvio.Text = "label37";
            lblEstadoEnvio.Visible = false;
            // 
            // lblAdministrador
            // 
            lblAdministrador.AutoSize = true;
            lblAdministrador.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdministrador.Location = new Point(467, 181);
            lblAdministrador.Name = "lblAdministrador";
            lblAdministrador.Size = new Size(56, 21);
            lblAdministrador.TabIndex = 37;
            lblAdministrador.Text = "label38";
            lblAdministrador.Visible = false;
            // 
            // lblEstadoPago
            // 
            lblEstadoPago.AutoSize = true;
            lblEstadoPago.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstadoPago.Location = new Point(591, 181);
            lblEstadoPago.Name = "lblEstadoPago";
            lblEstadoPago.Size = new Size(56, 21);
            lblEstadoPago.TabIndex = 38;
            lblEstadoPago.Text = "label39";
            lblEstadoPago.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblEstadoPago);
            panel1.Controls.Add(lblAdministrador);
            panel1.Controls.Add(lblEstadoEnvio);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblCamion);
            panel1.Controls.Add(lblDestino);
            panel1.Controls.Add(lblOrigen);
            panel1.Controls.Add(lblDestinatario);
            panel1.Controls.Add(lblContenido);
            panel1.Controls.Add(lblPeso);
            panel1.Controls.Add(lblTipoPaquete);
            panel1.Controls.Add(lblServicio);
            panel1.Controls.Add(lblCliente);
            panel1.Controls.Add(lblNroEnvio);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(4, 179);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 222);
            panel1.TabIndex = 3;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(714, 181);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(56, 21);
            lblFecha.TabIndex = 41;
            lblFecha.Text = "label39";
            lblFecha.Visible = false;
            // 
            // labelErrorEmisor
            // 
            labelErrorEmisor.AutoSize = true;
            labelErrorEmisor.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorEmisor.ForeColor = Color.Red;
            labelErrorEmisor.Location = new Point(17, 110);
            labelErrorEmisor.Name = "labelErrorEmisor";
            labelErrorEmisor.Size = new Size(81, 19);
            labelErrorEmisor.TabIndex = 27;
            labelErrorEmisor.Text = "Dato Invalido!";
            labelErrorEmisor.Visible = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(215, 41);
            label19.Name = "label19";
            label19.Size = new Size(84, 17);
            label19.TabIndex = 30;
            label19.Text = "NRO ENVIO";
            // 
            // txtNroEnvio
            // 
            txtNroEnvio.Font = new Font("Sitka Display", 11.249999F);
            txtNroEnvio.Location = new Point(215, 66);
            txtNroEnvio.Multiline = true;
            txtNroEnvio.Name = "txtNroEnvio";
            txtNroEnvio.Size = new Size(138, 36);
            txtNroEnvio.TabIndex = 29;
            txtNroEnvio.TextChanged += txtNroEnvio_TextChanged;
            // 
            // lblErrorNroEnvio
            // 
            lblErrorNroEnvio.AutoSize = true;
            lblErrorNroEnvio.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorNroEnvio.ForeColor = Color.Red;
            lblErrorNroEnvio.Location = new Point(218, 110);
            lblErrorNroEnvio.Name = "lblErrorNroEnvio";
            lblErrorNroEnvio.Size = new Size(81, 19);
            lblErrorNroEnvio.TabIndex = 31;
            lblErrorNroEnvio.Text = "Dato Invalido!";
            lblErrorNroEnvio.Visible = false;
            // 
            // EliminarEnvio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 243, 250);
            ClientSize = new Size(830, 641);
            Controls.Add(lblErrorNroEnvio);
            Controls.Add(label19);
            Controls.Add(txtNroEnvio);
            Controls.Add(labelErrorEmisor);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(label2);
            Controls.Add(txtDniEmisor);
            Controls.Add(label17);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EliminarEnvio";
            Text = "EliminarEnvio";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label17;
        private TextBox txtDniEmisor;
        private Label label2;
        private Button btnBuscar;
        private Button btnEliminar;
        private Panel panel3;
        private Label label4;
        private Panel panel4;
        private Label label3;
        private Label label5;
        private Label label15;
        private Label label6;
        private Label label14;
        private Label label7;
        private Label label8;
        private Panel panel5;
        private Label label9;
        private Label label18;
        private Label label13;
        private Label label11;
        private Label label12;
        private Label label16;
        private Label label10;
        private Label lblNroEnvio;
        private Label lblCliente;
        private Label lblServicio;
        private Label lblTipoPaquete;
        private Label lblPeso;
        private Label lblContenido;
        private Label lblDestinatario;
        private Label lblOrigen;
        private Label lblDestino;
        private Label lblCamion;
        private Label lblTotal;
        private Label lblEstadoEnvio;
        private Label lblAdministrador;
        private Label lblEstadoPago;
        private Panel panel1;
        private Label label29;
        private Label lblFecha;
        private Label labelErrorEmisor;
        private Label label19;
        private TextBox txtNroEnvio;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblErrorNroEnvio;
    }
}