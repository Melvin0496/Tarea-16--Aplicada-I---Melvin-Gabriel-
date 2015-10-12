namespace Ejercicios11Y12
{
    partial class Ejercicio11_4
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
            this.NombreArchivotextBox = new System.Windows.Forms.TextBox();
            this.DireccionArchivotextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del archivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion del archivo:";
            // 
            // NombreArchivotextBox
            // 
            this.NombreArchivotextBox.Location = new System.Drawing.Point(128, 40);
            this.NombreArchivotextBox.Name = "NombreArchivotextBox";
            this.NombreArchivotextBox.Size = new System.Drawing.Size(150, 20);
            this.NombreArchivotextBox.TabIndex = 2;
            // 
            // DireccionArchivotextBox
            // 
            this.DireccionArchivotextBox.Location = new System.Drawing.Point(128, 75);
            this.DireccionArchivotextBox.Name = "DireccionArchivotextBox";
            this.DireccionArchivotextBox.Size = new System.Drawing.Size(150, 20);
            this.DireccionArchivotextBox.TabIndex = 3;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(107, 152);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 4;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Ejercicio11_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 197);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.DireccionArchivotextBox);
            this.Controls.Add(this.NombreArchivotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio11_4";
            this.Text = "Ejercicio11_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreArchivotextBox;
        private System.Windows.Forms.TextBox DireccionArchivotextBox;
        private System.Windows.Forms.Button Eliminarbutton;
    }
}