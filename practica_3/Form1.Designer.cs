namespace practica_3
{
    partial class Form1
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
            label2 = new Label();
            txtNumero = new TextBox();
            txtLetra = new TextBox();
            bValidar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(35, 38);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 0;
            label1.Text = "Escriba un numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(214, 38);
            label2.Name = "label2";
            label2.Size = new Size(215, 21);
            label2.TabIndex = 1;
            label2.Text = "Escribe una letra o caracter";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(58, 81);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(90, 23);
            txtNumero.TabIndex = 2;
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(271, 81);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(89, 23);
            txtLetra.TabIndex = 3;
            // 
            // bValidar
            // 
            bValidar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            bValidar.Location = new Point(169, 157);
            bValidar.Name = "bValidar";
            bValidar.Size = new Size(82, 31);
            bValidar.TabIndex = 4;
            bValidar.Text = "Determinar";
            bValidar.UseVisualStyleBackColor = true;
            bValidar.Click += bValidar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 251);
            Controls.Add(bValidar);
            Controls.Add(txtLetra);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumero;
        private TextBox txtLetra;
        private Button bValidar;
    }
}