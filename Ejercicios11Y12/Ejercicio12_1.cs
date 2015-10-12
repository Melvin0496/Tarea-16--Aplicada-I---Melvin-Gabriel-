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
    public partial class Ejercicio12_1 : Form
    {
        public Ejercicio12_1()
        {
            InitializeComponent();
        }

        public int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(NumerotextBox.Text);
            FactorialtextBox.Text = Factorial(numero).ToString();
        }
    }
}
