using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace MegaDesk_3_RyanMontgomery
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            ComboBoxMaterials.DataSource = Enum.GetNames(typeof(Desk.Materials));
        }

        private void ComboBoxMaterials_SelectedValueChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Desk.Materials>(ComboBoxMaterials.SelectedValue.ToString(), out Desk.Materials materials);
        }

        private void AddQuoteCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitQuoteButton_Click(object sender, EventArgs e)
        {
            WidthTextBox.BackColor = Color.White;
            DepthTextBox.BackColor = Color.White;
            DrawersTextBox.BackColor = Color.White;

            
            int width;
            int depth;
            int drawers;
            string customerName = (string)CustomerNameTextBox.Text;

            customerName.Replace(',', ' ');
            customerName.Replace('"', ' ');

            try
            {
                width = int.Parse(WidthTextBox.Text);
            }
            catch (FormatException ex)
            {
                WidthTextBox.BackColor = Color.Red;
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                depth = int.Parse(DepthTextBox.Text);
            }
            catch (FormatException ex)
            {
                DepthTextBox.BackColor = Color.Red;
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                drawers = int.Parse(DrawersTextBox.Text);
            }
            catch (FormatException ex)
            {
                DrawersTextBox.BackColor = Color.Red;
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                Desk.Materials materials;
                Enum.TryParse<Desk.Materials>(ComboBoxMaterials.SelectedValue.ToString(), out materials);

                int daysRushed;
                if (ThreeShippingRadio.Checked)
                    daysRushed = 3;
                else if (FiveShippingRadio.Checked)
                    daysRushed = 5;
                else if (SevenShippingRadio.Checked)
                    daysRushed = 7;
                else
                    daysRushed = 14;
                
                DateTime dt = DateTime.Now;

                DeskQuote deskQuote = new DeskQuote(customerName, new Desk(width, depth, drawers, materials), daysRushed, dt.ToString("g"));
                
                string json = JsonConvert.SerializeObject(deskQuote);
                File.AppendAllText(@"C:\Users\montg\documents\quotes.json", json);
            }

            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidWidthException ex)
            {
                WidthTextBox.BackColor = Color.Red;
                MessageBox.Show(ex.Message);
            }
            catch (InvalidDepthException ex)
            {
                DepthTextBox.BackColor = Color.Red;
                MessageBox.Show(ex.Message);
            }
            catch (InvalidDrawersException ex)
            {
                DrawersTextBox.BackColor = Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        private void WidthTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(WidthTextBox.Text, out int userInput))
            {
                if(userInput > Desk.MAX_WIDTH || userInput < Desk.MIN_WIDTH)
                {
                    WidthTextBox.BackColor = Color.Red;
                }
                else
                {
                    WidthTextBox.BackColor = Color.White;
                }
            }
            else
            {
                WidthTextBox.BackColor = Color.Red;
            }
        }

        private void DepthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && int.TryParse(DepthTextBox.Text + e.KeyChar, out int userInput))
            {
                if (userInput > Desk.MAX_DEPTH || userInput < Desk.MIN_DEPTH)
                {
                    DepthTextBox.BackColor = Color.Red;
                }
                else
                {
                    DepthTextBox.BackColor = Color.White;
                }
            }
            else
            {
                DepthTextBox.BackColor = Color.Red;
            }
        }
    }
}
