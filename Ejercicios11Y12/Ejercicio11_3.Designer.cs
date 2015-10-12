namespace Ejercicios11Y12
{
    partial class Ejercicio11_3
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
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RutatextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewRutatextBox = new System.Windows.Forms.TextBox();
            this.Presionabutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(104, 33);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(212, 20);
            this.NombretextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Archivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ruta Archivo:";
            // 
            // RutatextBox
            // 
            this.RutatextBox.Location = new System.Drawing.Point(104, 72);
            this.RutatextBox.Name = "RutatextBox";
            this.RutatextBox.Size = new System.Drawing.Size(212, 20);
            this.RutatextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nueva Ruta:";
            // 
            // NewRutatextBox
            // 
            this.NewRutatextBox.Location = new System.Drawing.Point(104, 111);
            this.NewRutatextBox.Name = "NewRutatextBox";
            this.NewRutatextBox.Size = new System.Drawing.Size(212, 20);
            this.NewRutatextBox.TabIndex = 5;
            // 
            // Presionabutton
            // 
            this.Presionabutton.Location = new System.Drawing.Point(137, 194);
            this.Presionabutton.Name = "Presionabutton";
            this.Presionabutton.Size = new System.Drawing.Size(75, 23);
            this.Presionabutton.TabIndex = 6;
            this.Presionabutton.Text = "Presiona";
            this.Presionabutton.UseVisualStyleBackColor = true;
            this.Presionabutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejercicio11_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 261);
            this.Controls.Add(this.Presionabutton);
            this.Controls.Add(this.NewRutatextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RutatextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombretextBox);
            this.Name = "Ejercicio11_3";
            this.Text = "Ejercicio11_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RutatextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewRutatextBox;
        private System.Windows.Forms.Button Presionabutton;
    }
}