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
    public partial class Ejercicio11_4 : Form
    {
        public Ejercicio11_4()
        {
            InitializeComponent();
        }
        public void BorrarArchivo()
        {
            string nombreArchivo = NombreArchivotextBox.Text;
            string direccionarchivo = DireccionArchivotextBox.Text;

            string Archivo = Path.Combine(@""+direccionarchivo+"/"+nombreArchivo+".txt");

            if (!File.Exists(Archivo))
            {
                MessageBox.Show("El archivo o la direccion no existe","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                File.Delete(Archivo);
                MessageBox.Show("Borrado exitoso...","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        public void Limpiar()
        {
            NombreArchivotextBox.Clear();
            DireccionArchivotextBox.Clear();
        }
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            BorrarArchivo();
            Limpiar();
        }
    }
}
