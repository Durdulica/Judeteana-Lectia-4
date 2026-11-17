using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ExempluDate
{
    public partial class Planete : Form
    {
        private List<Planeta> planete = new List<Planeta>();

        public Planete()
        {
            InitializeComponent();
        }

        private void Planete_Load(object sender, EventArgs e)
        {
            string cale = Path.Combine(Application.StartupPath, "planete.txt");
            List<string> erori = new List<string>();
            planete = Date.CitestePlanete(cale, erori);
            if (erori.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, erori), "Planete",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Afiseaza(planete);
        }

        private void Afiseaza(List<Planeta> lista)
        {
            lstPlanete.DataSource = null;
            lstPlanete.DataSource = lista;
            lstPlanete.DisplayMember = "Nume";
            int cuRadiatii = lista.Count(p => p.AreRadiatii);
            lblNumar.Text = "Afisate: " + lista.Count + " | cu radiatii: " + cuRadiatii;
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Scrie un numar.", "Cautare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Planeta gasita = planete.FirstOrDefault(p => p.Id == id);
            if (gasita == null)
            {
                MessageBox.Show("Nu exista planeta cu Id-ul " + id + ".", "Cautare",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show(gasita.Descriere, gasita.Nume,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnToate_Click(object sender, EventArgs e)
        {
            Afiseaza(planete);
        }

        private void btnTraseu_Click(object sender, EventArgs e)
        {
            Afiseaza(planete.Where(p => p.Id >= 2 && p.Id <= 5).ToList());
        }

        private void btnInAfara_Click(object sender, EventArgs e)
        {
            Afiseaza(planete.Where(p => p.Id >= 6 && p.Id <= 8).ToList());
        }
    }
}
