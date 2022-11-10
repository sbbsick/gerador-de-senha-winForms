using GeradorDeSenhas.Content;
using Microsoft.VisualBasic.Devices;
using System.Diagnostics;


namespace GeradorDeSenhas
{
    public partial class FormMain : Form
    {
        private readonly PasswordGenerator randomPassword = new();
        private Services? services;

        public FormMain()
        {
            InitializeComponent();
        }

        private void InsertStandardPassword()
        {
            services = new(randomPassword.GetPassword, nudDaysToExpire.Value, nudViewsToExpire.Value, nudCharactersQuantity.Value, nudPasswordQuantity.Value, textBoxValues);

            if (checkBoxSpecial.Checked == true)
                services.NewNumberAndSpecialPassword();
            else
                services.NewNumberPassword();

        }

        private void InsertTicketPassword()
        {
            services = new(randomPassword.GetPassword, nudDaysToExpire.Value, nudViewsToExpire.Value, nudCharactersQuantity.Value, nudPasswordQuantity.Value, textBoxValues);

            if (checkBoxResetPortuguese.Checked == true)
                services.PasswordTicketResetPortuguese(checkBoxSpecial);
            else if (checkBoxCreatePortuguese.Checked == true)
                services.PasswordTicketCreatePortuguese(checkBoxSpecial);
            else if (checkBoxResetSpanish.Checked == true)
                services.PasswordTicketResetSpanish(checkBoxSpecial);
            else if (checkBoxCreateSpanish.Checked == true)
                services.PasswordTicketCreateSpanish(checkBoxSpecial);
        }

        private void DesactiveTicketButtons()
        {
            if (checkBoxResetSpanish.Checked == false || checkBoxResetPortuguese.Checked == false || checkBoxCreateSpanish.Checked == false || checkBoxCreatePortuguese.Checked == false)
            {
                checkBoxResetSpanish.Enabled = true;
                checkBoxCreateSpanish.Enabled = true;
                checkBoxResetPortuguese.Enabled = true;
                checkBoxCreatePortuguese.Enabled = true;
            }

            if (checkBoxCreatePortuguese.Checked)
            {
                checkBoxResetPortuguese.Enabled = false;
                checkBoxCreateSpanish.Enabled = false;
                checkBoxResetSpanish.Enabled = false;
            }
            else if (checkBoxCreateSpanish.Checked)
            {
                checkBoxResetPortuguese.Enabled = false;
                checkBoxCreatePortuguese.Enabled = false;
                checkBoxResetSpanish.Enabled = false;
            }
            else if (checkBoxResetPortuguese.Checked)
            {
                checkBoxCreatePortuguese.Enabled = false;
                checkBoxCreateSpanish.Enabled = false;
                checkBoxResetSpanish.Enabled = false;
            }
            else if (checkBoxResetSpanish.Checked)
            {
                checkBoxCreatePortuguese.Enabled = false;
                checkBoxCreateSpanish.Enabled = false;
                checkBoxResetPortuguese.Enabled = false;
            }
        }

        private void ActiveAndDesactiveButtonCopyAndClear()
        {
            if (textBoxValues.Text.Length > 0)
            {
                btnClearForm.Enabled = true;
                btnCopy.Enabled = true;
            }
            else
            {
                btnClearForm.Enabled = false;
                btnCopy.Enabled = false;
            }
        }

        private void ClearForm()
        {
            var dialogResult = MessageBox.Show("LIMPAR TUDO?", "LIMPAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                textBoxValues.Clear();

                checkBoxSpecial.Checked = false;
                checkBoxCreatePortuguese.Checked = false;
                checkBoxCreateSpanish.Checked = false;
                checkBoxResetPortuguese.Checked = false;
                checkBoxResetSpanish.Checked = false;
                checkBoxCreatePortuguese.Enabled = true;
                checkBoxCreateSpanish.Enabled = true;
                checkBoxResetPortuguese.Enabled = true;
                checkBoxResetSpanish.Enabled = true;
                nudPasswordQuantity.Value = 1;
                nudCharactersQuantity.Value = 12;
                nudDaysToExpire.Value = 30;
                nudViewsToExpire.Value = 30;
            }
        }

        private void btnCreatePassword_Click(object sender, EventArgs e)
        {
            ActiveAndDesactiveButtonCopyAndClear();

            if (checkBoxCreatePortuguese.Checked || checkBoxCreateSpanish.Checked ||
                checkBoxResetPortuguese.Checked || checkBoxResetSpanish.Checked)
                InsertTicketPassword();
            else
                InsertStandardPassword();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxValues.Text);
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void checkBoxCreateSpanish_CheckedChanged(object sender, EventArgs e)
        {
            DesactiveTicketButtons();
        }

        private void checkBoxCreatePortuguese_CheckedChanged(object sender, EventArgs e)
        {
            DesactiveTicketButtons();
        }

        private void checkBoxResetPortuguese_CheckedChanged(object sender, EventArgs e)
        {
            DesactiveTicketButtons();
        }

        private void checkBoxResetSpanish_CheckedChanged(object sender, EventArgs e)
        {
            DesactiveTicketButtons();
        }

        private void textBoxValues_TextChanged(object sender, EventArgs e)
        {
            ActiveAndDesactiveButtonCopyAndClear();
        }

        private void textBoxValues_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (textBoxValues.ReadOnly == true)
            {
                textBoxValues.ReadOnly = false;
                textBoxValues.Cursor = Cursor.Current = Cursors.IBeam;
            }         
            else
            {
                textBoxValues.ReadOnly = true;
                textBoxValues.Cursor = Cursor.Current = Cursors.No;
            }           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = "https://www.linkedin.com/in/silas-batista/"
                }).Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Tente novamente mais tarde.");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = "https://github.com/sbbsick"
                }).Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Tente novamente mais tarde.");
            }
        }
    }
}