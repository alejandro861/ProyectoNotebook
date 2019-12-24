using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoNotebook
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UsuarioLabel.BackColor = Color.Transparent;
            ContraseñaLabel.BackColor = Color.Transparent;
        }
        private bool InformacionEsValida()
        {

            bool esValida = true;
            if(UsuarioTextBox.Text.Length == 0)
            {
                esValida = false;
                errorProvider1.SetError(UsuarioTextBox, "Debe ingresar un usuario");
            }
            if (UsuarioTextBox.Text.Length == 0)
            {
                esValida = false;
                errorProvider1.SetError(UsuarioTextBox, "Debe ingresar una contaseña");
            }
            return esValida;
        }
        private void LimpiarErrorProviders()
        {
            errorProvider1.SetError(UsuarioTextBox, "");
            errorProvider1.SetError(ContraseñaTextBox, ""); 
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            if (InformacionEsValida())
            {
                //Faltaria autenticar al usuario
                Hide();
                Form2 PonerNombre = new Form2();
            }
        }
    }
}
