namespace Presentacion
{
    partial class PagoPlin
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
            button1 = new Button();
            txtTotalPagar = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(7, 225, 206);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(123, 86);
            button1.Name = "button1";
            button1.Size = new Size(97, 27);
            button1.TabIndex = 6;
            button1.Text = "Plin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Location = new Point(37, 50);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.PlaceholderText = "Monto a pagar 0.0S/";
            txtTotalPagar.Size = new Size(159, 23);
            txtTotalPagar.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(37, 21);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Numero Telefonico";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 93);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 8;
            label1.Text = "Monto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 93);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 9;
            label2.Text = "0.0";
            // 
            // PagoPlin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(232, 118);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(txtTotalPagar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PagoPlin";
            Text = "FormPagoYape";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtTotalPagar;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}