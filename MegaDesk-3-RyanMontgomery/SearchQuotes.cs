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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();

            ComboBoxMaterials.DataSource = ((Desk.Materials[])Enum.GetValues(typeof(Desk.Materials))).ToList();
        }

        private void AddQuoteCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitQuoteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
