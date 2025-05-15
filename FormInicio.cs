using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño_arboles_binarios
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "UNAD")
            {
                Fase_4_árbol_binario principal = new Fase_4_árbol_binario();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
