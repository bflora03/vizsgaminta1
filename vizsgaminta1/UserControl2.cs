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
    public partial class UserControl2 : UserControl
    {
        Models.ReceptContext context = new Models.ReceptContext();
        public UserControl2()
        {
            InitializeComponent();
            dataGridView1.DataSource = context.Ugyfel.ToList();
        }

        private void ugyfelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonÚjÜgyfél_Click(object sender, EventArgs e)
        {
            UjUgyfelForm uu = new UjUgyfelForm();
            if (uu.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Ugyfel ugyfel = new Ugyfel();
            {
                ugyfel.Nev = uu.textBox1.Text;
                ugyfel.Login = uu.textBox2.Text;
                ugyfel.Email = uu.textBoxEmail.Text;
                ugyfel.Szulev = Convert.ToInt32(uu.textBoxSzulev.Text);
                ugyfel.Nem = uu.textBoxFN.Text;
                ugyfel.Cim = uu.textBoxLakcim.Text;

            }
            context.Ugyfel.Add(ugyfel);

            try
            {
                context.SaveChanges();
            }
            catch (Exception err)
            {

                MessageBox.Show($"Nem sikerült az adatbázist elmenteni a következő hiba miatt: {err.InnerException.Message}");
            }
        }
    }
}
