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
    public partial class Ejercicio11 : Form
    {
        MemoryStream ms;
        byte[] buffer;
        public Ejercicio11()
        {
            InitializeComponent();
            ms = new MemoryStream(50);
            buffer = new byte[50];
        }
  
        private void Ejercicio11_Load(object sender, EventArgs e)
        {

        }

        private void Presionabutton_Click(object sender, EventArgs e)
        {

            ms.Write(ASCIIEncoding.ASCII.GetBytes(CadenatextBox.Text),0,CadenatextBox.TextLength);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ms.Seek(-10, SeekOrigin.End);
            ms.Read(buffer, 0, CadenatextBox.TextLength);

            MostrarlistBox.Items.Add(ASCIIEncoding.ASCII.GetString(buffer));
            ms.Close();
        }
    }
}
