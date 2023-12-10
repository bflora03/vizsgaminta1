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

    public partial class UserControl3 : UserControl
    {
        Models.ReceptContext context = new Models.ReceptContext();
        public UserControl3()
        {
            InitializeComponent();
            UgyfelSzures();
            TetelSzures();


        }

        private void UgyfelSzures()
        {
            var ug = from x in context.Ugyfel
                     where x.Nev.Contains(textBoxUgyfelSzures.Text)
                     select x;
            listBoxUgyfelek.DataSource = ug.ToList();
            listBoxUgyfelek.DisplayMember = "Nev";
        }
        private void textBoxUgyfelSzures_TextChanged(object sender, EventArgs e)
        {
            UgyfelSzures();
        }

        private void RendelesListazas()
        {
            if (listBoxUgyfelek.SelectedItem == null)
            {
                return;
            }

            var selUgyfel = ((Ugyfel)listBoxUgyfelek.SelectedItem).Login;
            var rendelesek = from x in context.Rendeles
                             where x.Login == selUgyfel
                             select x;

            listBoxSorszamok.DataSource = rendelesek.ToList();
            listBoxSorszamok.DisplayMember = "Sorszam";



        }

        private void listBoxUgyfelek_SelectedIndexChanged(object sender, EventArgs e)
        {
            RendelesListazas();
        }

        //megjelennek az ügyfelek és a rendelési sorszámok


        //rendelési tételek megjelenítése datagridviewban sorszám alapján
        public void TételListázás()
        {
            if (listBoxSorszamok.SelectedItem == null)
            {
                return;
            }
            var selsorszam = ((Rendeles)listBoxSorszamok.SelectedItem).Sorszam;
            var tételek = from x in context.RendelesTetel
                          where x.Sorszam == selsorszam
                          select new Tételek
                          {
                              Termékkód = x.Termekkod,
                              Megnevezés = x.TermekkodNavigation.Megnevezes,
                              Egységár = x.Egysegar,
                              Mennyiség = x.Mennyiseg,
                              Megység = x.TermekkodNavigation.Megys
                          };
            tételekBindingSource.DataSource = tételek.ToList();
        }
        private void listBoxSorszamok_SelectedIndexChanged(object sender, EventArgs e)
        {
            TételListázás();
        }

        //!!!!!
        //rendelési tétel hozzáadása
        private void listBoxRendelesiTetelek_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selTétel = (Termek)listBoxRendelesiTetelek.SelectedItem;
            var megyseg = (from x in context.Termek where x.Termekkod == selTétel.Termekkod select x).FirstOrDefault();
            labelMegyseg.Text = megyseg.Megys.ToString();
        }

        private void TetelSzures()
        {
            var rt = from x in context.Termek
                     where x.Megnevezes.Contains(textBoxTetelSzuro.Text)
                     select x;
            listBoxRendelesiTetelek.DataSource = rt.ToList();
            listBoxRendelesiTetelek.DisplayMember = "Megnevezes";
        }

        //!!!!
        //tétel hozzáadása rendeléshez
        private void buttonPlusz_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan hozzáadod az új tételt a rendeléshez?", "Adat felvétel",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                RendelesTetel rt = new RendelesTetel();
                rt.Sorszam = ((Rendeles)listBoxSorszamok.SelectedItem).Sorszam;
                rt.Termekkod = ((Termek)listBoxRendelesiTetelek.SelectedItem).Termekkod;

                double m;
                if (double.TryParse(textBoxMennyiseg.Text, out m))
                {
                    rt.Mennyiseg = m;
                }
                double ar;
                if (double.TryParse(textBoxEgysegAr.Text, out ar))
                {
                    rt.Egysegar = ar;
                }

                context.RendelesTetel.Add(rt);


                context.SaveChanges();
                TételListázás();
            }


        }

        //!!!!
        //tétel törlése rendelésből
        private void buttonMinusz_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan tölöd a tételt a rendelésből?", "Adat törlés",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                var tetel = ((Tételek)tételekBindingSource.Current).Termékkód;
                var törölni = (from x in context.RendelesTetel where x.Termekkod == tetel select x).FirstOrDefault();
                context.RendelesTetel.Remove(törölni);
                context.SaveChanges();
                TételListázás();
            }

            
           
        }

        private void textBoxTetelSzuro_TextChanged(object sender, EventArgs e)
        {
            TetelSzures();
        }
    }
    public class Tételek
    {
        public string Termékkód { get; set; }
        public string Megnevezés { get; set; }
        public double? Egységár { get; set; }
        public double Mennyiség { get; set; }
        public string Megység { get; set; }
    }
}
