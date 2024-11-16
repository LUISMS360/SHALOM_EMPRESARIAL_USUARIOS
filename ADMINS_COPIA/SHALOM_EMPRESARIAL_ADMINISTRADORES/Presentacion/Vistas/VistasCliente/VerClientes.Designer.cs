namespace Presentacion.Vistas.VistasCliente
{
    partial class VerClientes
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
            label1 = new Label();
            cmbFiltroBusquedaClientes = new ComboBox();
            resultadoBusqueda = new DataGridView();
            btnBuscar = new Button();
            lblDni = new Label();
            txtDni = new TextBox();
            lblErrorDni = new Label();
            ((System.ComponentModel.ISupportInitialize)resultadoBusqueda).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 3;
            label1.Text = "VER  CLIENTES";
            // 
            // cmbFiltroBusquedaClientes
            // 
            cmbFiltroBusquedaClientes.Font = new Font("Sitka Display", 11.249999F);
            cmbFiltroBusquedaClientes.FormattingEnabled = true;
            cmbFiltroBusquedaClientes.Items.AddRange(new object[] { "Todos", "Especifico" });
            cmbFiltroBusquedaClientes.Location = new Point(12, 48);
            cmbFiltroBusquedaClientes.Name = "cmbFiltroBusquedaClientes";
            cmbFiltroBusquedaClientes.Size = new Size(126, 29);
            cmbFiltroBusquedaClientes.TabIndex = 4;
            cmbFiltroBusquedaClientes.SelectedIndexChanged += cmbFiltroBusquedaClientes_SelectedIndexChanged;
            // 
            // resultadoBusqueda
            // 
            resultadoBusqueda.BackgroundColor = SystemColors.ButtonHighlight;
            resultadoBusqueda.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Sitka Display", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            resultadoBusqueda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            resultadoBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Sitka Display", 11.249999F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            resultadoBusqueda.DefaultCellStyle = dataGridViewCellStyle2;
            resultadoBusqueda.EnableHeadersVisualStyles = false;
            resultadoBusqueda.Location = new Point(18, 181);
            resultadoBusqueda.Name = "resultadoBusqueda";
            resultadoBusqueda.Size = new Size(800, 457);
            resultadoBusqueda.TabIndex = 36;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LimeGreen;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(156, 113);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(134, 33);
            btnBuscar.TabIndex = 48;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            lblDni.Location = new Point(18, 93);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(81, 17);
            lblDni.TabIndex = 50;
            lblDni.Text = "DNI Cliente";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Sitka Display", 11.249999F);
            txtDni.Location = new Point(12, 113);
            txtDni.Multiline = true;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(117, 33);
            txtDni.TabIndex = 49;
            // 
            // lblErrorDni
            // 
            lblErrorDni.AutoSize = true;
            lblErrorDni.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorDni.ForeColor = Color.Red;
            lblErrorDni.Location = new Point(16, 149);
            lblErrorDni.Name = "lblErrorDni";
            lblErrorDni.Size = new Size(83, 19);
            lblErrorDni.TabIndex = 51;
            lblErrorDni.Text = "Valor Invalido!";
            lblErrorDni.Visible = false;
            // 
            // VerClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 227, 232);
            ClientSize = new Size(830, 641);
            Controls.Add(lblErrorDni);
            Controls.Add(lblDni);
            Controls.Add(txtDni);
            Controls.Add(btnBuscar);
            Controls.Add(resultadoBusqueda);
            Controls.Add(cmbFiltroBusquedaClientes);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerClientes";
            Text = "VerClientes";
            ((System.ComponentModel.ISupportInitialize)resultadoBusqueda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbFiltroBusquedaClientes;
        private DataGridView resultadoBusqueda;
        private Button btnBuscar;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblErrorDni;
    }
}