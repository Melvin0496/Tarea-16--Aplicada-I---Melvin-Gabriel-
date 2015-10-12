namespace Ejercicios11Y12
{
    partial class Ejercicio11
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
            this.CadenatextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Presionabutton = new System.Windows.Forms.Button();
            this.MostrarlistBox = new System.Windows.Forms.ListBox();
            this.Mostrarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CadenatextBox
            // 
            this.CadenatextBox.Location = new System.Drawing.Point(120, 43);
            this.CadenatextBox.Name = "CadenatextBox";
            this.CadenatextBox.Size = new System.Drawing.Size(195, 20);
            this.CadenatextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escriba una cadena:";
            // 
            // Presionabutton
            // 
            this.Presionabutton.Location = new System.Drawing.Point(190, 226);
            this.Presionabutton.Name = "Presionabutton";
            this.Presionabutton.Size = new System.Drawing.Size(75, 23);
            this.Presionabutton.TabIndex = 2;
            this.Presionabutton.Text = "Presiona";
            this.Presionabutton.UseVisualStyleBackColor = true;
            this.Presionabutton.Click += new System.EventHandler(this.Presionabutton_Click);
            // 
            // MostrarlistBox
            // 
            this.MostrarlistBox.FormattingEnabled = true;
            this.MostrarlistBox.Items.AddRange(new object[] {
            "Datos:"});
            this.MostrarlistBox.Location = new System.Drawing.Point(12, 97);
            this.MostrarlistBox.Name = "MostrarlistBox";
            this.MostrarlistBox.Size = new System.Drawing.Size(303, 95);
            this.MostrarlistBox.TabIndex = 3;
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.Location = new System.Drawing.Point(61, 226);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Mostrarbutton.TabIndex = 4;
            this.Mostrarbutton.Text = "Mostrar";
            this.Mostrarbutton.UseVisualStyleBackColor = true;
            this.Mostrarbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejercicio11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 261);
            this.Controls.Add(this.Mostrarbutton);
            this.Controls.Add(this.MostrarlistBox);
            this.Controls.Add(this.Presionabutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CadenatextBox);
            this.Name = "Ejercicio11";
            this.Text = "Ejercicio11";
            this.Load += new System.EventHandler(this.Ejercicio11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CadenatextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Presionabutton;
        private System.Windows.Forms.ListBox MostrarlistBox;
        private System.Windows.Forms.Button Mostrarbutton;
    }
}