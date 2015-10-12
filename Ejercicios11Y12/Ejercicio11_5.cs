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
    public partial class Ejercicio11_5 : Form
    {
        public Ejercicio11_5()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            NombreArchivotextBox.Clear();
            RutaArchivotextBox.Clear();
            NuevoNombretextBox.Clear();
        }
        private void Renombrarbutton_Click(object sender, EventArgs e)
        {
           
            string combinacion = Path.Combine(@""+RutaArchivotextBox.Text+"/"+NombreArchivotextBox.Text+".txt");
            string combinacion2 = Path.Combine(@""+RutaArchivotextBox.Text+"/"+NuevoNombretextBox.Text+".txt");
            if (!File.Exists(combinacion))
            {
                MessageBox.Show("No se pudo encontrar el archivo","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                File.Copy(combinacion, combinacion2);
                File.Delete(combinacion);
                MessageBox.Show("Nombre cambiado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            Limpiar();
           
        }
    }
}
