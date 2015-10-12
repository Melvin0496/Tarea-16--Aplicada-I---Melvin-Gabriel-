using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios11Y12
{
    public partial class Ejercicios11Y12 : Form
    {
        public Ejercicios11Y12()
        {
            InitializeComponent();
        }

        private void ejercicio112ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ejercicio111ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio11 e11 = new Ejercicio11();
            e11.Show();
        }

        private void ejercicio112ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio11_2 e11_2 = new Ejercicio11_2();
            e11_2.Show();
        }

        private void ejercicio113ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio11_3 e11_3 = new Ejercicio11_3();
            e11_3.Show();
        }

        private void ejercicio114ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio11_4 e11_4 = new Ejercicio11_4();
            e11_4.Show();
        }

        private void ejercicio115ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio11_5 e11_5 = new Ejercicio11_5();
            e11_5.Show();
        }
    }
}
