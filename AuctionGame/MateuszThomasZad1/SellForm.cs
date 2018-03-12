using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuctionGame
{
    public partial class SellForm : Form
    {
        /// <summary>
        /// Pole okna głównego. Wykorzystywane do odwołań do podstawowego okna aplikacji.
        /// </summary>
        MainForm mainForm;
        /// <summary>
        /// Licznik timera odmierzajacego pięciokrotną zmianę kwoty sprzedaży przedmiotu.
        /// </summary>
        int timerCounter;
        /// <summary>
        /// Losowa cena przedmiotu.
        /// </summary>
        Random randomPrice;
        /// <summary>
        /// aktualna wylosowana cena przedmiotu.
        /// </summary>
        int actualPrice;
        /// <summary>
        /// Cena zakupu przedmiotu.
        /// </summary>
        int purchasePrice;
        public SellForm(Thing thing, int purchasePrice, MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.purchasePrice = purchasePrice;
            mainForm.block();
            InitializeComponent();
            labelItemName.Text = thing.getName();
            labelPurchasePrice.Text = "Cena zakupu: " + purchasePrice;
            labelValueSellItem.Text = "Wartość: " + thing.value;
            pictureBoxItem.Image = thing.image;
            pictureBoxItem.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonBackToMainForm.Visible = false;
            timerCounter = 0;
            actualPrice = (thing.value * 38)/100;
            randomPrice = new Random();
            timerTimeAuction.Start();
        }
        /// <summary>
        /// Reakcja na wciśniecie klawisza powrotnego do okna głównego. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBackToMainForm_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = true;
            mainForm.resume();
            mainForm.dataAfterSoldItem(labelItemName.Text, purchasePrice , actualPrice);
            Close();
        }
        /// <summary>
        /// Funkcja reakcji na odmierzanei czasu. Losuje nową kwotę towaru.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTimeAuction_Tick(object sender, EventArgs e)
        {
            
            if(timerCounter < 5)
            {
                actualPrice = randomPrice.Next(100*actualPrice, 167* actualPrice) /100;
                labelActualPrice.Text = actualPrice.ToString();
                if (timerCounter == 4)
                {
                    timerTimeAuction.Stop();
                    MessageBox.Show("Przedmiot został sprzedany za: " + actualPrice);
                    buttonBackToMainForm.Visible = true;
                }
            }
            timerCounter++;
        }
    }
}
