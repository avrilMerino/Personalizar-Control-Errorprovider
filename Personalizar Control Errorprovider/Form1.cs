using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personalizar_Control_Errorprovider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // ErrorProvider en nombre
        private void tbNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                errorProvider1.Icon = Properties.Resources.cerrar;
                errorProvider1.SetError(tbNombre, "El nombre no puede estar vacío");
            }
            else
            {
                errorProvider1.Icon = Properties.Resources.abrir;
                errorProvider1.SetError(tbNombre, "Correcto");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

    }
}
