namespace Ejercicios11Y12
{
    partial class Ejercicio11_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreArchtextBox = new System.Windows.Forms.TextBox();
            this.RutaArchtextBox = new System.Windows.Forms.TextBox();
            this.DatosArchlistBox = new System.Windows.Forms.ListBox();
            this.Informacionbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Archivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ruta Archivo:";
            // 
            // NombreArchtextBox
            // 
            this.NombreArchtextBox.Location = new System.Drawing.Point(123, 30);
            this.NombreArchtextBox.Name = "NombreArchtextBox";
            this.NombreArchtextBox.Size = new System.Drawing.Size(195, 20);
            this.NombreArchtextBox.TabIndex = 2;
            // 
            // RutaArchtextBox
            // 
            this.RutaArchtextBox.Location = new System.Drawing.Point(123, 66);
            this.RutaArchtextBox.Name = "RutaArchtextBox";
            this.RutaArchtextBox.Size = new System.Drawing.Size(195, 20);
            this.RutaArchtextBox.TabIndex = 3;
            // 
            // DatosArchlistBox
            // 
            this.DatosArchlistBox.FormattingEnabled = true;
            this.DatosArchlistBox.Items.AddRange(new object[] {
            "Contenido Archivo:"});
            this.DatosArchlistBox.Location = new System.Drawing.Point(12, 101);
            this.DatosArchlistBox.Name = "DatosArchlistBox";
            this.DatosArchlistBox.Size = new System.Drawing.Size(413, 394);
            this.DatosArchlistBox.TabIndex = 4;
            // 
            // Informacionbutton
            // 
            this.Informacionbutton.Location = new System.Drawing.Point(77, 509);
            this.Informacionbutton.Name = "Informacionbutton";
            this.Informacionbutton.Size = new System.Drawing.Size(75, 23);
            this.Informacionbutton.TabIndex = 5;
            this.Informacionbutton.Text = "Informacion";
            this.Informacionbutton.UseVisualStyleBackColor = true;
            this.Informacionbutton.Click += new System.EventHandler(this.Informacionbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(266, 509);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 6;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Ejercicio11_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 544);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Informacionbutton);
            this.Controls.Add(this.DatosArchlistBox);
            this.Controls.Add(this.RutaArchtextBox);
            this.Controls.Add(this.NombreArchtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio11_2";
            this.Text = "Ejercicio11.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreArchtextBox;
        private System.Windows.Forms.TextBox RutaArchtextBox;
        private System.Windows.Forms.ListBox DatosArchlistBox;
        private System.Windows.Forms.Button Informacionbutton;
        private System.Windows.Forms.Button Nuevobutton;
    }
}