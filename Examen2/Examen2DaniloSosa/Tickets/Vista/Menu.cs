using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ticket tickform = new Ticket();
            tickform.Show();

        }
    }
}
