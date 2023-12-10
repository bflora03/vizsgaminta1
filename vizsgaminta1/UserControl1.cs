using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vizsgaminta1.Models;

namespace vizsgaminta1
{
    public partial class UserControl1 : UserControl
    {
        Models.ReceptContext context = new Models.ReceptContext();
        public UserControl1()
        {
            InitializeComponent();
            ÜgyfélSzűrés();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void ÜgyfélSzűrés()
        {
            var ug = from x in context.Ugyfel
                     where x.Nev.Contains(textBoxÜgyfélSzűrés.Text)
                     select x;
            listBoxÜgyfél.DataSource = ug.ToList();
            listBoxÜgyfél.DisplayMember = "Nev";
        }
        private void textBoxÜgyfélSzűrés_TextChanged(object sender, EventArgs e)
        {
            ÜgyfélSzűrés();
        }
        private void listBoxÜgyfél_SelectedIndexChanged(object sender, EventArgs e)
        {
            RendelesListazas();
        }
        private void RendelesListazas()
        {
            var selUgyfel = ((Ugyfel)listBoxÜgyfél.SelectedItem).Login;
            var rendelesek = from x in context.Rendeles
                             where x.Login == selUgyfel
                             select new RendelesDetail
                             {
                                 Sorszam = x.Sorszam,
                                 RendDatum = x.RendDatum,
                                 SzallCim = x.SzallCim,
                                 SzallDatum = x.SzallDatum

                             };
            listBoxRendelések.DataSource = rendelesek.ToList();
            listBoxRendelések.DisplayMember = "RendDatum"; //ezt akarom én?

        }

     

        private void listBoxRendelések_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sorszam = ((RendelesDetail)listBoxRendelések.SelectedItem).Sorszam;
            var rendtetel = from x in context.RendelesTetel
                            where x.Sorszam == sorszam
                            select new
                            {
                                Ár = x.Egysegar * x.Mennyiseg
                            };

            var összesen = (from x in rendtetel select x.Ár).Sum();
            textBoxÖssz.Text = $"{összesen}";

            textBoxDarab.Text = listBoxRendelések.Items.Count.ToString();

        }
    }
    public class RendelesDetail
    {
        public int Sorszam { get; set; }
        public DateTime? RendDatum { get; set; }
        public string SzallCim { get; set; }
        public DateTime? SzallDatum { get; set; }

    }
}
