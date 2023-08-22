namespace practica_3
{
    partial class Form2
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
            btnLanzar = new Button();
            SuspendLayout();
            // 
            // btnLanzar
            // 
            btnLanzar.BackColor = SystemColors.ActiveCaption;
            btnLanzar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLanzar.Location = new Point(93, 70);
            btnLanzar.Name = "btnLanzar";
            btnLanzar.Size = new Size(219, 129);
            btnLanzar.TabIndex = 0;
            btnLanzar.Text = "Lanzar";
            btnLanzar.UseVisualStyleBackColor = false;
            btnLanzar.Click += btnLanzar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 294);
            Controls.Add(btnLanzar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLanzar;
    }
}