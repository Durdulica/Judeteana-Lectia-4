using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Descoperiri
{
    public partial class Salvare : Form
    {
        private List<Insula> insule;
        readonly string cale = Path.Combine(Application.StartupPath, "insule.txt");

        public Salvare()
        {
            InitializeComponent();
        }

        private void Salvare_Load(object sender, EventArgs e)
        {
            List<string> erori = new List<string>();
            insule = Date.CitesteInsule(cale, erori);
            if(erori.Count > 0) MessageBox.Show(string.Join(Environment.NewLine, erori));
            Afiseaza(insule);
        }

        private void Afiseaza(List<Insula> lista)
        {
            lstInsule.DataSource = lista;
            
            lblNumar.Text = "Afisate: " + lista.Count + " | cu virusi: " + lista.Where(x => x.AreVirusi == true).Count();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Scrie un numar", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Insula ins = insule.FirstOrDefault(x => x.Id == id);
            if (ins == null) 
            {
                MessageBox.Show("Nu exista insula cu Id-ul " + id, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return;
            }
            MessageBox.Show(ins.Descriere, ins.Nume);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnToate_Click(object sender, EventArgs e)
        {
            Afiseaza(insule);
        }

        private void btnTraseu_Click(object sender, EventArgs e)
        {
            Afiseaza(insule.Where(i => i.Id >= 2  && i.Id <= 7).ToList());
        }

        private void btnInAfara_Click(object sender, EventArgs e)
        {
            Afiseaza(insule.Where(i => i.Id >= 8 && i.Id <= 11).ToList());
        }
    }
}
