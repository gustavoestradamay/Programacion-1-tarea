namespace CapitalDeEmpresa
{
    partial class CapitalTotal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Mostrar = new Label();
            calcular = new Button();
            txtMonto3 = new TextBox();
            txtMonto2 = new TextBox();
            txtMonto1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Aplicar1 = new Button();
            label5 = new Label();
            limpiar = new Button();
            SuspendLayout();
            // 
            // Mostrar
            // 
            Mostrar.BackColor = SystemColors.Info;
            Mostrar.ForeColor = SystemColors.AppWorkspace;
            Mostrar.Location = new Point(12, 273);
            Mostrar.Name = "Mostrar";
            Mostrar.Size = new Size(497, 168);
            Mostrar.TabIndex = 0;
            // 
            // calcular
            // 
            calcular.Location = new Point(515, 273);
            calcular.Name = "calcular";
            calcular.Size = new Size(75, 37);
            calcular.TabIndex = 1;
            calcular.Text = "calcular";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // txtMonto3
            // 
            txtMonto3.Location = new Point(12, 191);
            txtMonto3.Name = "txtMonto3";
            txtMonto3.Size = new Size(100, 23);
            txtMonto3.TabIndex = 2;
            // 
            // txtMonto2
            // 
            txtMonto2.Location = new Point(12, 147);
            txtMonto2.Name = "txtMonto2";
            txtMonto2.Size = new Size(100, 23);
            txtMonto2.TabIndex = 3;
            // 
            // txtMonto1
            // 
            txtMonto1.Location = new Point(12, 108);
            txtMonto1.Name = "txtMonto1";
            txtMonto1.Size = new Size(100, 23);
            txtMonto1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 116);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 5;
            label2.Text = "Primer Monto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 199);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 6;
            label3.Text = "Tercer Monto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 155);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 7;
            label4.Text = "Segundo Monto";
            // 
            // Aplicar1
            // 
            Aplicar1.Location = new Point(226, 108);
            Aplicar1.Name = "Aplicar1";
            Aplicar1.Size = new Size(75, 23);
            Aplicar1.TabIndex = 8;
            Aplicar1.Text = "Aplicar";
            Aplicar1.UseVisualStyleBackColor = true;
            Aplicar1.Click += Aplicar1_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(171, 9);
            label5.Name = "label5";
            label5.Size = new Size(327, 61);
            label5.TabIndex = 11;
            label5.Text = "Capital de una Empresa ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // limpiar
            // 
            limpiar.Location = new Point(307, 107);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(75, 23);
            limpiar.TabIndex = 12;
            limpiar.Text = "Limpiar";
            limpiar.UseVisualStyleBackColor = true;
            limpiar.Click += limpiar_Click;
            // 
            // CapitalTotal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(676, 450);
            Controls.Add(limpiar);
            Controls.Add(label5);
            Controls.Add(Aplicar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMonto1);
            Controls.Add(txtMonto2);
            Controls.Add(txtMonto3);
            Controls.Add(calcular);
            Controls.Add(Mostrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CapitalTotal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CapitalDeUnaEmpresaDe3Hermanos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Mostrar;
        private Button calcular;
        private TextBox txtMonto3;
        private TextBox txtMonto2;
        private TextBox txtMonto1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Aplicar1;
        private Label label5;
        private Button limpiar;
    }
}