using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_3_RyanMontgomery
{
    public partial class ViewAllQuotes : Form
    {
        private List<DeskQuote> quotes = new List<DeskQuote>();

        public ViewAllQuotes()
        {
            InitializeComponent();
            DeserializeJson();
            PopulateQuotesTable();
        }

        private void DeserializeJson() {
            using (StreamReader file = new StreamReader(path: @"C:\MegaDesk\quotes.json")) {
                string line;
                while ((line = file.ReadLine()) != null) {
                    quotes.Add(Newtonsoft.Json.JsonConvert.DeserializeObject<DeskQuote>(line));
                }
            }
        }

        private void PopulateQuotesTable() {
            foreach (DeskQuote quote in quotes) {
                QuotesTable.RowCount += 1;
                QuotesTable.Controls.Add(new Label() { Text = quote.CustomerName }, 0, QuotesTable.RowCount - 1);
                QuotesTable.Controls.Add(new Label() { Text = quote.SurfaceArea().ToString() }, 1, QuotesTable.RowCount - 1);
                QuotesTable.Controls.Add(new Label() { Text = quote.MyDesk.Material.ToString() }, 2, QuotesTable.RowCount - 1);
                QuotesTable.Controls.Add(new Label() { Text = quote.MyDesk.Drawers.ToString() }, 3, QuotesTable.RowCount - 1);
                QuotesTable.Controls.Add(new Label() { Text = "$" + quote.DeskPrice().ToString() }, 4, QuotesTable.RowCount - 1);
                QuotesTable.Controls.Add(new Label() { Text = quote.RushDays.ToString() + " Days" }, 5, QuotesTable.RowCount - 1);
                QuotesTable.Controls.Add(new Label() { Text = "$" + quote.ShippingPrice().ToString() }, 6, QuotesTable.RowCount - 1);
                QuotesTable.Controls.Add(new Label() { Text = "$" + quote.TotalPrice().ToString() }, 7, QuotesTable.RowCount - 1);

            }
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
