namespace FormularioBienvenida
{
    partial class Form1
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
            lblNombre = new Label();
            lblEdad = new Label();
            lblResultado = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            btnAceptar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(67, 87);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(67, 130);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(67, 223);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(150, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Aquí aparecerá el resultado";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(127, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "(vacío)";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(127, 127);
            txtEdad.Name = "txtEdad";
            txtEdad.PlaceholderText = "(vacío)";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 4;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(67, 176);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 39);
            label4.Name = "label4";
            label4.Size = new Size(142, 15);
            label4.TabIndex = 6;
            label4.Text = "Formulario de bienvenida";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnAceptar);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblResultado);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblEdad;
        private Label lblResultado;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Button btnAceptar;
        private Label label4;
    }
}
