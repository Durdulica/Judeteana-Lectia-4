using System;
using System.Windows.Forms;

namespace Descoperiri
{
    public partial class Expeditie : Form
    {
        private int hrana;
        private int bogatii = 0;
        private int incarcatura = 0;

        public Expeditie(int nrExploratori)
        {
            InitializeComponent();

            CancelButton = btnIesire;

            lblExploratori.Text = nrExploratori.ToString();
            hrana = 2 * nrExploratori * 100;
            incarcatura = nrExploratori * 90 + hrana;

            lblHrana.Text = hrana.ToString();
            lblBogatii.Text = bogatii.ToString();
            lblIncarcatura.Text = incarcatura.ToString();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Expeditie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
                return;
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                Salvare salvare = new Salvare();
                salvare.ShowDialog();
            }
        }

        private void Expeditie_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
