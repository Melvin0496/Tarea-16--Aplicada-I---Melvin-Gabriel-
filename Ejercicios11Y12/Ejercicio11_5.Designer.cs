namespace Ejercicios11Y12
{
    partial class Ejercicio11_5
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
            this.NombreArchivotextBox = new System.Windows.Forms.TextBox();
            this.NuevoNombretextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RutaArchivotextBox = new System.Windows.Forms.TextBox();
            this.Renombrarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombreArchivotextBox
            // 
            this.NombreArchivotextBox.Location = new System.Drawing.Point(104, 34);
            this.NombreArchivotextBox.Name = "NombreArchivotextBox";
            this.NombreArchivotextBox.Size = new System.Drawing.Size(155, 20);
            this.NombreArchivotextBox.TabIndex = 0;
            // 
            // NuevoNombretextBox
            // 
            this.NuevoNombretextBox.Location = new System.Drawing.Point(104, 68);
            this.NuevoNombretextBox.Name = "NuevoNombretextBox";
            this.NuevoNombretextBox.Size = new System.Drawing.Size(155, 20);
            this.NuevoNombretextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Archivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ruta Archivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nuevo nombre:";
            // 
            // RutaArchivotextBox
            // 
            this.RutaArchivotextBox.Location = new System.Drawing.Point(104, 106);
            this.RutaArchivotextBox.Name = "RutaArchivotextBox";
            this.RutaArchivotextBox.Size = new System.Drawing.Size(155, 20);
            this.RutaArchivotextBox.TabIndex = 5;
            // 
            // Renombrarbutton
            // 
            this.Renombrarbutton.Location = new System.Drawing.Point(139, 180);
            this.Renombrarbutton.Name = "Renombrarbutton";
            this.Renombrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Renombrarbutton.TabIndex = 6;
            this.Renombrarbutton.Text = "Renombrar";
            this.Renombrarbutton.UseVisualStyleBackColor = true;
            this.Renombrarbutton.Click += new System.EventHandler(this.Renombrarbutton_Click);
            // 
            // Ejercicio11_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 282);
            this.Controls.Add(this.Renombrarbutton);
            this.Controls.Add(this.RutaArchivotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NuevoNombretextBox);
            this.Controls.Add(this.NombreArchivotextBox);
            this.Name = "Ejercicio11_5";
            this.Text = "Ejercicio11_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreArchivotextBox;
        private System.Windows.Forms.TextBox NuevoNombretextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RutaArchivotextBox;
        private System.Windows.Forms.Button Renombrarbutton;
    }
}