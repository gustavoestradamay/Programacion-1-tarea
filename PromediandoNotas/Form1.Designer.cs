namespace PromediandoNotas
{
    partial class PormedioNotas
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtNota1 = new TextBox();
            label2 = new Label();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Aplicar = new Button();
            Calcular = new Button();
            Limpieza = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.LightBlue;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 130);
            label1.Name = "label1";
            label1.Size = new Size(364, 243);
            label1.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(448, 131);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(448, 181);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(569, 139);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre Del Estudiante";
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(448, 230);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 4;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(448, 277);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(100, 23);
            txtNota3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(569, 189);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 6;
            label3.Text = "Nota #1 Del Estudiante";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(569, 238);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 7;
            label4.Text = "Nota #2 Del Estudiante";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(569, 285);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 8;
            label5.Text = "Nota #3 Del Estudiante";
            // 
            // Aplicar
            // 
            Aplicar.ForeColor = Color.Black;
            Aplicar.Location = new Point(448, 351);
            Aplicar.Name = "Aplicar";
            Aplicar.Size = new Size(75, 35);
            Aplicar.TabIndex = 9;
            Aplicar.Text = "Aplicar";
            Aplicar.UseVisualStyleBackColor = true;
            Aplicar.Click += Aplicar_Click;
            // 
            // Calcular
            // 
            Calcular.ForeColor = Color.Black;
            Calcular.Location = new Point(554, 351);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 35);
            Calcular.TabIndex = 10;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Limpieza
            // 
            Limpieza.ForeColor = Color.Black;
            Limpieza.Location = new Point(663, 351);
            Limpieza.Name = "Limpieza";
            Limpieza.Size = new Size(75, 35);
            Limpieza.TabIndex = 11;
            Limpieza.Text = "Limpiar";
            Limpieza.UseVisualStyleBackColor = true;
            Limpieza.Click += Limpieza_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(193, 26);
            label6.TabIndex = 12;
            label6.Text = "Promedio de notas";
            // 
            // PormedioNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(Limpieza);
            Controls.Add(Calcular);
            Controls.Add(Aplicar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(label2);
            Controls.Add(txtNota1);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PormedioNotas";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Promedio de Notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtNota1;
        private Label label2;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Aplicar;
        private Button Calcular;
        private Button Limpieza;
        private Label label6;
    }
}