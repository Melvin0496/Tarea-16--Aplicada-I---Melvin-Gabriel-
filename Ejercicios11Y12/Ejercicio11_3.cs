using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicios11Y12
{
    public partial class Ejercicio11_3 : Form
    {
        
        public Ejercicio11_3()
        {
            InitializeComponent();
        }
        public void Archivo()
        {
            string nombre = NombretextBox.Text;
            string ruta = RutatextBox.Text;
            string nuevaRuta = NewRutatextBox.Text;

            string filaActual = Path.Combine(@"" + ruta + "/" + nombre + ".txt");
            string nuevaFila = Path.Combine(@"" + nuevaRuta + "/" + nombre + ".txt");

            if (!Directory.Exists(nuevaRuta))
            {
                MessageBox.Show("Esa ruta no existe","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (!File.Exists(nuevaFila))
                {
                    File.Copy(filaActual, nuevaFila);
                    MessageBox.Show("Archivo copiado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede copiar porque ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          
            
        }
        public void Limpiar()
        {
            NombretextBox.Clear();
            RutatextBox.Clear();
            NewRutatextBox.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Archivo();
            Limpiar();

        }
    }
}
