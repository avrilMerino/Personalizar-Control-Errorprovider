using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq; //por si contiene un número

namespace Personalizar_Control_Errorprovider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNombre_Validating(object sender, CancelEventArgs e)
        {
            //Si el textbox está vacío, mostramos el error de vacío
            if (string.IsNullOrEmpty(tbNombre.Text))
            {
                errorProvider1.SetError(this.tbNombre, "El nombre no puede estar vacío");

            }else if (tbNombre.Text.Any(char.IsDigit)) //Si en el texto hay números el textbox se pondrá rojo el tb
            {
                tbNombre.BackColor = Color.Red;
            }
            else
            {
                tbNombre.BackColor = SystemColors.Window;
                errorProvider1.SetError(tbNombre, "");
            }
        }
    }
}
