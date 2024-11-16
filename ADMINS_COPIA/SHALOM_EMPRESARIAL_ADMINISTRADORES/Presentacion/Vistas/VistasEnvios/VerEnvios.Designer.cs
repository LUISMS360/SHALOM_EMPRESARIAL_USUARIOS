namespace Presentacion.Vistas.VistasEnvios
{
    partial class VerEnvios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            cmbSeleccion = new ComboBox();
            resultadoBusqueda = new DataGridView();
            txtCliente = new TextBox();
            lblCliente = new Label();
            label4 = new Label();
            label5 = new Label();
            lblDestino = new Label();
            lblOrigen = new Label();
            panelFecha = new Panel();
            cmbAnioFin = new ComboBox();
            cmbMesFin = new ComboBox();
            cmbDiaFin = new ComboBox();
            cmbAnioIncio = new ComboBox();
            cmbMesIncio = new ComboBox();
            cmbDiaIncio = new ComboBox();
            btnBuscar = new Button();
            hScrollBar1 = new HScrollBar();
            vScrollBar1 = new VScrollBar();
            cmbOrigen = new ComboBox();
            cmbDestino = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)resultadoBusqueda).BeginInit();
            panelFecha.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 2;
            label1.Text = "VER  ENVIOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 33;
            label2.Text = "FILTRO DE VISUALIZACION";
            // 
            // cmbSeleccion
            // 
            cmbSeleccion.Font = new Font("Sitka Display", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSeleccion.FormattingEnabled = true;
            cmbSeleccion.Items.AddRange(new object[] { "Todos", "Por Cliente", "Por Fecha", "Por Origen", "Por Destino", "Pagados Recaudado", "No Pagados Recaudado", "Entregados", "Registrados", "En camino", "Aereo", "Terrestre" });
            cmbSeleccion.Location = new Point(12, 63);
            cmbSeleccion.Name = "cmbSeleccion";
            cmbSeleccion.Size = new Size(160, 29);
            cmbSeleccion.TabIndex = 34;
            cmbSeleccion.SelectedIndexChanged += cmbSeleccion_SelectedIndexChanged;
            // 
            // resultadoBusqueda
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            resultadoBusqueda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resultadoBusqueda.BackgroundColor = SystemColors.ButtonHighlight;
            resultadoBusqueda.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.Font = new Font("Sitka Display", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            resultadoBusqueda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resultadoBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Sitka Display", 11.249999F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            resultadoBusqueda.DefaultCellStyle = dataGridViewCellStyle3;
            resultadoBusqueda.EnableHeadersVisualStyles = false;
            resultadoBusqueda.Location = new Point(8, 198);
            resultadoBusqueda.Name = "resultadoBusqueda";
            resultadoBusqueda.Size = new Size(800, 423);
            resultadoBusqueda.TabIndex = 35;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(383, 42);
            txtCliente.Multiline = true;
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(117, 33);
            txtCliente.TabIndex = 36;
            txtCliente.Visible = false;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            lblCliente.Location = new Point(383, 12);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(81, 17);
            lblCliente.TabIndex = 38;
            lblCliente.Text = "DNI Cliente";
            lblCliente.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            label4.Location = new Point(3, 4);
            label4.Name = "label4";
            label4.Size = new Size(68, 13);
            label4.TabIndex = 39;
            label4.Text = "Fecha Inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            label5.Location = new Point(3, 46);
            label5.Name = "label5";
            label5.Size = new Size(72, 13);
            label5.TabIndex = 40;
            label5.Text = "Fecha Limite";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            lblDestino.Location = new Point(532, 12);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(56, 17);
            lblDestino.TabIndex = 42;
            lblDestino.Text = "Destino";
            lblDestino.Visible = false;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            lblOrigen.Location = new Point(735, 12);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(51, 17);
            lblOrigen.TabIndex = 44;
            lblOrigen.Text = "Origen";
            lblOrigen.Visible = false;
            // 
            // panelFecha
            // 
            panelFecha.BackColor = Color.White;
            panelFecha.Controls.Add(cmbAnioFin);
            panelFecha.Controls.Add(cmbMesFin);
            panelFecha.Controls.Add(cmbDiaFin);
            panelFecha.Controls.Add(cmbAnioIncio);
            panelFecha.Controls.Add(cmbMesIncio);
            panelFecha.Controls.Add(cmbDiaIncio);
            panelFecha.Controls.Add(label4);
            panelFecha.Controls.Add(label5);
            panelFecha.Location = new Point(514, 81);
            panelFecha.Name = "panelFecha";
            panelFecha.Size = new Size(231, 89);
            panelFecha.TabIndex = 46;
            panelFecha.Visible = false;
            // 
            // cmbAnioFin
            // 
            cmbAnioFin.FormattingEnabled = true;
            cmbAnioFin.Items.AddRange(new object[] { "2024" });
            cmbAnioFin.Location = new Point(3, 62);
            cmbAnioFin.Name = "cmbAnioFin";
            cmbAnioFin.Size = new Size(72, 23);
            cmbAnioFin.TabIndex = 46;
            cmbAnioFin.Text = "Año";
            // 
            // cmbMesFin
            // 
            cmbMesFin.FormattingEnabled = true;
            cmbMesFin.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            cmbMesFin.Location = new Point(95, 62);
            cmbMesFin.Name = "cmbMesFin";
            cmbMesFin.Size = new Size(50, 23);
            cmbMesFin.TabIndex = 45;
            cmbMesFin.Text = "Mes";
            // 
            // cmbDiaFin
            // 
            cmbDiaFin.FormattingEnabled = true;
            cmbDiaFin.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            cmbDiaFin.Location = new Point(167, 62);
            cmbDiaFin.Name = "cmbDiaFin";
            cmbDiaFin.Size = new Size(52, 23);
            cmbDiaFin.TabIndex = 44;
            cmbDiaFin.Text = "Dia";
            // 
            // cmbAnioIncio
            // 
            cmbAnioIncio.FormattingEnabled = true;
            cmbAnioIncio.Items.AddRange(new object[] { "2024" });
            cmbAnioIncio.Location = new Point(3, 20);
            cmbAnioIncio.Name = "cmbAnioIncio";
            cmbAnioIncio.Size = new Size(68, 23);
            cmbAnioIncio.TabIndex = 43;
            cmbAnioIncio.Text = "Año";
            // 
            // cmbMesIncio
            // 
            cmbMesIncio.FormattingEnabled = true;
            cmbMesIncio.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            cmbMesIncio.Location = new Point(95, 20);
            cmbMesIncio.Name = "cmbMesIncio";
            cmbMesIncio.Size = new Size(50, 23);
            cmbMesIncio.TabIndex = 42;
            cmbMesIncio.Text = "Mes";
            // 
            // cmbDiaIncio
            // 
            cmbDiaIncio.FormattingEnabled = true;
            cmbDiaIncio.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            cmbDiaIncio.Location = new Point(167, 20);
            cmbDiaIncio.Name = "cmbDiaIncio";
            cmbDiaIncio.Size = new Size(52, 23);
            cmbDiaIncio.TabIndex = 41;
            cmbDiaIncio.Text = "Dia";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LimeGreen;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(257, 104);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(134, 36);
            btnBuscar.TabIndex = 47;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Visible = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(12, 621);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(800, 15);
            hScrollBar1.TabIndex = 48;
            hScrollBar1.Visible = false;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(811, 195);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 441);
            vScrollBar1.TabIndex = 49;
            vScrollBar1.Visible = false;
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "Shalom_001", "Shalom_002", "Shalom_003", "Shalom_004", "Shalom_005", "Shalom_006", "Shalom_007", "Shalom_008", "Shalom_009", "Shalom_010", "Shalom_011", "Shalom_012", "Shalom_013", "Shalom_014", "Shalom_015", "Shalom_016", "Shalom_017", "Shalom_018", "Shalom_019", "Shalom_020", "Shalom_021" });
            cmbOrigen.Location = new Point(526, 43);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(121, 23);
            cmbOrigen.TabIndex = 50;
            cmbOrigen.Visible = false;
            // 
            // cmbDestino
            // 
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Items.AddRange(new object[] { "Shalom_001", "Shalom_002", "Shalom_003", "Shalom_004", "Shalom_005", "Shalom_006", "Shalom_007", "Shalom_008", "Shalom_009", "Shalom_010", "Shalom_011", "Shalom_012", "Shalom_013", "Shalom_014", "Shalom_015", "Shalom_016", "Shalom_017", "Shalom_018", "Shalom_019", "Shalom_020", "Shalom_021" });
            cmbDestino.Location = new Point(697, 42);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(121, 23);
            cmbDestino.TabIndex = 51;
            cmbDestino.Visible = false;
            // 
            // VerEnvios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 243, 250);
            ClientSize = new Size(830, 641);
            Controls.Add(cmbDestino);
            Controls.Add(cmbOrigen);
            Controls.Add(vScrollBar1);
            Controls.Add(hScrollBar1);
            Controls.Add(btnBuscar);
            Controls.Add(panelFecha);
            Controls.Add(lblOrigen);
            Controls.Add(lblDestino);
            Controls.Add(lblCliente);
            Controls.Add(txtCliente);
            Controls.Add(resultadoBusqueda);
            Controls.Add(cmbSeleccion);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerEnvios";
            Text = "VerEnvios";
            ((System.ComponentModel.ISupportInitialize)resultadoBusqueda).EndInit();
            panelFecha.ResumeLayout(false);
            panelFecha.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbSeleccion;
        private DataGridView resultadoBusqueda;
        private TextBox txtCliente;
        private Label lblCliente;
        private Label label4;
        private Label label5;
        private Label lblDestino;
        private Label lblOrigen;
        private Panel panelFecha;
        private ComboBox cmbAnioIncio;
        private ComboBox cmbMesIncio;
        private ComboBox cmbDiaIncio;
        private ComboBox cmbAnioFin;
        private ComboBox cmbMesFin;
        private ComboBox cmbDiaFin;
        private Button btnBuscar;
        private HScrollBar hScrollBar1;
        private VScrollBar vScrollBar1;
        private ComboBox cmbOrigen;
        private ComboBox cmbDestino;
    }
}