using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_RyanMontgomery
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode.ToString() == "A")
                AddQuoteButton.Focus();
            if (e.Alt && e.KeyCode.ToString() == "V")
                ViewQuotesButton.Focus();
            if (e.Alt && e.KeyCode.ToString() == "S")
                SearchQuotesButton.Focus();
            if (e.Alt && e.KeyCode.ToString() == "X")
                ExitButton.Focus();
        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Show();
            this.Hide();
            addNewQuoteForm.FormClosing += ShowForm;
        }

        private void ShowForm(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
