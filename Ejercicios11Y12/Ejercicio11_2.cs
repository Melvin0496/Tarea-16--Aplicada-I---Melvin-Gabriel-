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
    public partial class Ejercicio11_2 : Form
    {
        FileStream fs;
        byte[] ArchInfo;
        string Nombre;
        string ruta;
        public Ejercicio11_2()
        {
            InitializeComponent();
            
            ArchInfo = new byte[100];
        }
        public void InformacionArchivo()
        {
            Nombre = NombreArchtextBox.Text;
            ruta = RutaArchtextBox.Text;

            string Combinacion = Path.Combine(@""+ruta+"/"+Nombre+".txt");

            
            if (!File.Exists(Combinacion))
            {
                MessageBox.Show("No se pudo abrir el archivo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fs = new FileStream(Combinacion, FileMode.Open);
                fs.Read(ArchInfo, 0, (int)fs.Length);
                DatosArchlistBox.Items.Add(ASCIIEncoding.ASCII.GetString(ArchInfo));
                fs.Close();
            }
            
        }
        public void Limpiar()
        {
            NombreArchtextBox.Clear();
            RutaArchtextBox.Clear();
            DatosArchlistBox.Items.Add(""+"\n\n");
        }
        private void Informacionbutton_Click(object sender, EventArgs e)
        {
            InformacionArchivo();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
