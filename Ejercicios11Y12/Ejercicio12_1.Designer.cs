namespace Ejercicios11Y12
{
    partial class Ejercicio12_1
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
            this.NumerotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.FactorialtextBox = new System.Windows.Forms.TextBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumerotextBox
            // 
            this.NumerotextBox.Location = new System.Drawing.Point(65, 47);
            this.NumerotextBox.Name = "NumerotextBox";
            this.NumerotextBox.Size = new System.Drawing.Size(100, 20);
            this.NumerotextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 83);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Factorial:";
            // 
            // FactorialtextBox
            // 
            this.FactorialtextBox.Location = new System.Drawing.Point(65, 80);
            this.FactorialtextBox.Name = "FactorialtextBox";
            this.FactorialtextBox.Size = new System.Drawing.Size(100, 20);
            this.FactorialtextBox.TabIndex = 3;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(65, 147);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton.TabIndex = 4;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // Ejercicio12_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 211);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.FactorialtextBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumerotextBox);
            this.Name = "Ejercicio12_1";
            this.Text = "Ejercicio12_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumerotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox FactorialtextBox;
        private System.Windows.Forms.Button Calcularbutton;
    }
}