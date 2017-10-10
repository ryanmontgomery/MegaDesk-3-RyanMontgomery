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
    public partial class DisplayQuote : Form
    {
        private DeskQuote deskQuote;

        public DisplayQuote(DeskQuote dq)
        {
            deskQuote = dq;
            InitializeComponent();
            FormOutputQuote();
        }

        private void FormOutputQuote() {
            this.OutCustomerName.Text = deskQuote.CustomerName;
            this.OutDeskSize.Text = deskQuote.SurfaceArea().ToString();
            this.OutMaterial.Text = deskQuote.MyDesk.Material.ToString();
            this.OutDrawers.Text = deskQuote.MyDesk.Drawers.ToString();
            this.OutShippingSpeed.Text = deskQuote.RushDays.ToString() + " Days";
            this.OutDeskPrice.Text = deskQuote.DeskPrice().ToString();
            this.OutShippingPrice.Text = "+ " + deskQuote.ShippingPrice().ToString();
            this.OutTotalPrice.Text = deskQuote.TotalPrice().ToString();
        }
    }
}
