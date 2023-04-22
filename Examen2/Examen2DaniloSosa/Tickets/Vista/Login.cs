using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void AceptarButtom_Click(object sender, EventArgs e)
        {
            if (UsuariotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(UsuariotextBox, "Ingrese un Usuario");
                UsuariotextBox.Focus();
                return;

            }

            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ContraseñatextBox.Text))
            {
                errorProvider1.SetError(ContraseñatextBox, "Ingrese la Contraseña");
                ContraseñatextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            Menu menuformulario = new Menu();
            menuformulario.Show();
        }

        private void MostrarContraseña_Click(object sender, EventArgs e)
        {
            if (ContraseñatextBox.PasswordChar == '*')
            {
                ContraseñatextBox.PasswordChar = '\0';
            }
            else
            {
                ContraseñatextBox.PasswordChar = '*';
            }

        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
