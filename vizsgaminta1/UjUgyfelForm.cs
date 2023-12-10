using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace vizsgaminta1
{
    public partial class UjUgyfelForm : Form
    {
        public UjUgyfelForm()
        {
            InitializeComponent();
        }

        private bool CheckNev(string név)
        {
            Regex regex = new Regex("^[A-Z]\\w+( [A-Z]\\w+)+$");
            return regex.IsMatch(név);
        }
        private bool CheckLogin(string login)
        {
            return !string.IsNullOrEmpty(login);
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckNev(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Töltse ki a név mezőt helyesen!");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckLogin(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Töltse ki a login mezőt!");
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, "");
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private bool CheckEmail(string email)
        {
            return !string.IsNullOrEmpty(email);
        }
        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmail(textBoxEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxEmail, "Töltse ki az email mezőt!");
            }
        }

        private bool CheckSzulev(string szulev)
        {
            return !string.IsNullOrEmpty(szulev);
        }

        private void textBoxSzulev_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxSzulev, "");
        }

        private void textBoxSzulev_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckSzulev(textBoxSzulev.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxSzulev, "Töltse ki az születési év mezőt!");
            }
        }

        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxEmail, "");
        }

        private bool CheckNem(string nem)
        {
            return !string.IsNullOrEmpty(nem);
        }

        private void textBoxFN_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckSzulev(textBoxFN.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxFN, "Töltse ki a nem mezőt!");
            }
        }

        private void textBoxFN_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxFN, "");
        }

        private bool CheckCim(string cim)
        {
            return !string.IsNullOrEmpty(cim);
        }

        private void textBoxLakcim_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckSzulev(textBoxLakcim.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxLakcim, "Töltse ki a lakcím mezőt!");
            }
        }

        private void textBoxLakcim_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxLakcim, "");
        }
    }
}
