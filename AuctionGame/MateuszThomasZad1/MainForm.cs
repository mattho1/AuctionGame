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

namespace AuctionGame
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Gracz człowiek.
        /// </summary>
        Human playerHuman;
        /// <summary>
        /// Gracz jako komputer.
        /// </summary>
        Computer playerComputer;
        /// <summary>
        /// Okno ustawiania ustawień gry.
        /// </summary>
        StartForm startForm;
        /// <summary>
        /// Okno sprzedaży przedmiotów gracza.
        /// </summary>
        SellForm sellForm;
        /// <summary>
        /// Lista przedmiotów które mogą być wystawione na aukcji.
        /// </summary>
        List<AuctionItem> auctionList;
        /// <summary>
        /// Przedmiot wystawiany na pierwszej aukcji.
        /// </summary>
        AuctionItem firstAuctionItem;
        /// <summary>
        /// Przedmiot wystawiany na drugiej aukcji.
        /// </summary>
        AuctionItem secondAuctionItem;
        /// <summary>
        /// Przedmiot wystawiany na trzeciej aukcji.
        /// </summary>
        AuctionItem thirdAuctionItem;
        int numberAuction;
        /// <summary>
        /// Licznik timera odliczającego reakcje komputera.
        /// </summary>
        int counterTimerBiddingComputer = 0;
        /// <summary>
        /// Czas trwania aukcji w pierwszym oknie.
        /// </summary>
        int timeFirstAuction;
        /// <summary>
        /// Czas trwania aukcji w drugim oknie.
        /// </summary>
        int timeSecondAuction;
        /// <summary>
        /// Czas trwania aukcji w trzecim oknie.
        /// </summary>
        int timeThirdAuction;
        /// <summary>
        /// Licznik timera odliczającego czas pierwszej aukcji.
        /// </summary>
        int counterTimerFirstAuction = 0;
        /// <summary>
        /// Licznik timera odliczającego czas drugiej aukcji.
        /// </summary>
        int counterTimerSecondAuction = 0;
        /// <summary>
        /// Licznik timera odliczającego czas trzeciej aukcji.
        /// </summary>
        int counterTimerThirdAuction = 0;
        /// <summary>
        /// Licznik odliczający numery zdjęć wyświetlane w pierwszej aukcji.
        /// </summary>
        int counterPictureFirstAuction = 1;
        /// <summary>
        /// Licznik odliczający numery zdjęć wyświetlane w drugiej aukcji.
        /// </summary>
        int counterPictureSecondAuction = 10;
        /// <summary>
        /// Licznik odliczający numery zdjęć wyświetlane w trzeciej aukcji.
        /// </summary>
        int counterPictureThirdAuction = 18;

        int difficultyLevel;

        public MainForm()
        {
            InitializeComponent();
            auctionList = new List<AuctionItem>();
            groupBoxAllFunction.Enabled = false;
            buttonStart.Enabled = true;
            numberAuction = 0;
            loadDate();
            timeFirstAuction = 20;
            timeSecondAuction = 30;
            timeThirdAuction = 40;
        }
        /// <summary>
        /// Obsługa timera odpowiedzialnego za odmieżanie czasu pierwszej aukcji.
        /// /// Co określony w zmiennej timeFirstAuction w sekundach czas kończy aukcje i tworzy nową.
        /// Czas jest odmierzany co 1 sekunde.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFirstAuction_Tick(object sender, EventArgs e)
        {
            if (counterTimerFirstAuction == 0)
            {
                if (!labelHighestOfferFirstAuction.Text.Equals("0"))
                {
                    dataGridViewDataComplitedAuction.Rows.Add(firstAuctionItem.getName(), labelCurrentWinnerFirstAuction.Text, labelHighestOfferFirstAuction.Text, firstAuctionItem.getValue(), firstAuctionItem.getSpecialFeaturesItems());
                    if (labelCurrentWinnerFirstAuction.Text.Equals(playerHuman.name))
                    {
                        dataGridViewThingsPlayer1.Rows.Add(firstAuctionItem.getName(), labelHighestOfferFirstAuction.Text, firstAuctionItem.getValue(), firstAuctionItem.getSpecialFeaturesItems());
                        comboBoxItemsPlayer1.Items.Add(firstAuctionItem.getName());
                        playerHuman.addThing(firstAuctionItem.getThing());
                    }
                }
                if (counterPictureFirstAuction == numberAuction )
                {
                    counterPictureFirstAuction = 0;
                }
                firstAuctionItem = auctionList[counterPictureFirstAuction];
                labelHighestOfferFirstAuction.Text = firstAuctionItem.initialPriceAuction().ToString();
                labelCurrentWinnerFirstAuction.Text = "brak";
                textBoxDescriptionFirstAuction.Text = firstAuctionItem.getDescriptionThingAuction();
                labelValueFirstAuction.Text = firstAuctionItem.getValue().ToString();
                pictureBoxFirstAuction.Image = firstAuctionItem.getPicture();
                pictureBoxFirstAuction.SizeMode = PictureBoxSizeMode.StretchImage;
                counterPictureFirstAuction++;

                progressBarFirstAuction.Value = timeFirstAuction;
                counterTimerFirstAuction = timeFirstAuction;
            }

            labelTimeToTheEndFirstAuction.Text = counterTimerFirstAuction.ToString();

            if (counterTimerFirstAuction != timeFirstAuction)
            {
                progressBarFirstAuction.Increment(-1);
            }

            counterTimerFirstAuction--;
        }

        /// <summary>
        /// Obsługa timera odpowiedzialnego za odmieżanie czasu drugiej aukcji.
        /// /// Co określony w zmiennej timeSecondAuction w sekundach czas kończy aukcje i tworzy nową.
        /// Czas jest odmierzany co 1 sekunde.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerSecondAuction_Tick(object sender, EventArgs e)
        {
            if (counterTimerSecondAuction == 0)
            {
                if (!labelHighestOfferSecondAuction.Text.Equals("0"))
                {
                    dataGridViewDataComplitedAuction.Rows.Add(secondAuctionItem.getName(), labelCurrentWinnerSecondAuction.Text, labelHighestOfferSecondAuction.Text, secondAuctionItem.getValue(), secondAuctionItem.getSpecialFeaturesItems());
                    if (labelCurrentWinnerSecondAuction.Text.Equals(playerHuman.name))
                    {
                        dataGridViewThingsPlayer1.Rows.Add(secondAuctionItem.getName(), labelHighestOfferSecondAuction.Text, secondAuctionItem.getValue(), secondAuctionItem.getSpecialFeaturesItems());
                        comboBoxItemsPlayer1.Items.Add(secondAuctionItem.getName());
                        playerHuman.addThing(secondAuctionItem.getThing());
                    }
                }
                if (counterPictureSecondAuction == numberAuction )
                {
                    counterPictureSecondAuction = 0;
                }
                secondAuctionItem = auctionList[counterPictureSecondAuction];
                labelHighestOfferSecondAuction.Text = secondAuctionItem.initialPriceAuction().ToString();
                labelCurrentWinnerSecondAuction.Text = "brak";
                textBoxDescriptionSecondAuction.Text = secondAuctionItem.getDescriptionThingAuction();
                labelValueSecondAuction.Text = secondAuctionItem.getValue().ToString();
                pictureBoxSecondAuction.Image = secondAuctionItem.getPicture();
                pictureBoxSecondAuction.SizeMode = PictureBoxSizeMode.StretchImage;
                counterPictureSecondAuction++;

                progressBarSecondAuction.Value = timeSecondAuction;
                counterTimerSecondAuction = timeSecondAuction;
            }
            labelTimeToTheEndSecondAuction.Text = counterTimerSecondAuction.ToString();
            if (counterTimerSecondAuction != timeSecondAuction)
            {
                progressBarSecondAuction.Increment(-1);
            }
            counterTimerSecondAuction--;
        }

        /// <summary>
        /// Obsługa timera odpowiedzialnego za odmieżanie czasu trzeciej aukcji.
        /// Co określony w zmiennej timeThirdAuction w sekundach czas kończy aukcje i tworzy nową.
        /// Czas jest odmierzany co 1 sekunde.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerThirdAuction_Tick(object sender, EventArgs e)
        {
            if (counterTimerThirdAuction == 0)
            {
                if (!labelHighestOfferThirdAuction.Text.Equals("0"))
                {
                    dataGridViewDataComplitedAuction.Rows.Add(thirdAuctionItem.getName(), labelCurrentWinnerThirdAuction.Text, labelHighestOfferThirdAuction.Text, thirdAuctionItem.getValue(), thirdAuctionItem.getSpecialFeaturesItems());
                    if (labelCurrentWinnerThirdAuction.Text.Equals(playerHuman.name))
                    {
                        dataGridViewThingsPlayer1.Rows.Add(thirdAuctionItem.getName(), labelHighestOfferThirdAuction.Text, thirdAuctionItem.getValue(), thirdAuctionItem.getSpecialFeaturesItems());
                        comboBoxItemsPlayer1.Items.Add(thirdAuctionItem.getName());
                        playerHuman.addThing(thirdAuctionItem.getThing());
                    }
                }
                if (counterPictureThirdAuction == numberAuction)
                {
                    counterPictureThirdAuction = 0;
                }
                thirdAuctionItem = auctionList[counterPictureThirdAuction];
                labelHighestOfferThirdAuction.Text = thirdAuctionItem.initialPriceAuction().ToString();
                labelCurrentWinnerThirdAuction.Text = "brak";
                textBoxDescriptionThirdAuction.Text = thirdAuctionItem.getDescriptionThingAuction();
                labelValueThirdAuction.Text = thirdAuctionItem.getValue().ToString();
                pictureBoxThirdAuction.Image = thirdAuctionItem.getPicture();
                pictureBoxThirdAuction.SizeMode = PictureBoxSizeMode.StretchImage;
                counterPictureThirdAuction++;

                progressBarThirdAuction.Value = timeThirdAuction;
                counterTimerThirdAuction = timeThirdAuction;
            }
            labelTimeToTheEndThirdAuction.Text = counterTimerThirdAuction.ToString();
            if (counterTimerThirdAuction != timeThirdAuction)
            {
                progressBarThirdAuction.Increment(-1);
            }
            counterTimerThirdAuction--;

        }

        /// <summary>
        /// Funkcja odpowiada za obsługę kliknięcia przycisku składania oferty przez pierwszego klienta.
        /// Sprawdza który z radioButton-ów został wybrany i odpowiednio dobiera dalsza akcję.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBidFirstClient_Click(object sender, EventArgs e)
        {
            if (!textBoxFirstClientOffer.Text.Equals("0"))
            {
                if (radioButtonChoiceFirstAuctionFirstClient.Checked)
                {
                    if ((Int32.Parse(textBoxFirstClientOffer.Text) > Int32.Parse(labelHighestOfferFirstAuction.Text)))
                    {
                        if (labelCurrentWinnerFirstAuction.Text.Equals(playerHuman.name))
                        {
                            playerHuman.increaseWealth(Int32.Parse(labelHighestOfferFirstAuction.Text));
                            updateAccount();
                        }
                        labelHighestOfferFirstAuction.Text = textBoxFirstClientOffer.Text;
                        labelCurrentWinnerFirstAuction.Text = playerHuman.name;
                        playerHuman.decreaseWealth(Int32.Parse(textBoxFirstClientOffer.Text));
                        updateAccount();
                    }
                }
                if (radioButtonChoiceSecondAuctionFirstClient.Checked)
                {
                    if ((Int32.Parse(textBoxFirstClientOffer.Text) > Int32.Parse(labelHighestOfferSecondAuction.Text)))
                    {
                        if (labelCurrentWinnerSecondAuction.Text.Equals(playerHuman.name))
                        {
                            playerHuman.increaseWealth(Int32.Parse(labelHighestOfferSecondAuction.Text));
                            updateAccount();
                        }
                        labelHighestOfferSecondAuction.Text = textBoxFirstClientOffer.Text;
                        labelCurrentWinnerSecondAuction.Text = playerHuman.name;
                        playerHuman.decreaseWealth(Int32.Parse(textBoxFirstClientOffer.Text));
                        updateAccount();
                    }
                }
                if (radioButtonChoiceThirdAuctionFirstClient.Checked)
                {
                    if ((Int32.Parse(textBoxFirstClientOffer.Text) > Int32.Parse(labelHighestOfferThirdAuction.Text)))
                    {
                        if (labelCurrentWinnerThirdAuction.Text.Equals(playerHuman.name))
                        {
                            playerHuman.increaseWealth(Int32.Parse(labelHighestOfferThirdAuction.Text));
                            updateAccount();
                        }
                        labelHighestOfferThirdAuction.Text = textBoxFirstClientOffer.Text;
                        labelCurrentWinnerThirdAuction.Text = playerHuman.name;
                        playerHuman.decreaseWealth(Int32.Parse(textBoxFirstClientOffer.Text));
                        updateAccount();
                    }
                }

            }
        }
        /// <summary>
        /// Pobranie i przetworzenie danych z okna SellForm. Dane po sprzedaży przedmiotu generują króżne działania.
        /// </summary>
        /// <param name="thingName"></param>
        /// <param name="purchePrice"></param>
        /// <param name="actualPrice"></param>
        public void dataAfterSoldItem(string thingName, int purchePrice, int actualPrice)
        {
            int findItemNumber = 0;
            playerHuman.changeLevel(actualPrice, purchePrice);
            playerHuman.removeThing(thingName);
            playerHuman.increaseWealth(actualPrice);
            updateAccount();
            for (int i = 0; i < comboBoxItemsPlayer1.Items.Count; i++)
            {
                if (comboBoxItemsPlayer1.Items[i].Equals(thingName))
                {
                    findItemNumber = i;
                    break;
                }
            }
            dataGridViewThingsPlayer1.Rows.RemoveAt(findIndexRowAuctionIndataGridViewThingsPlayer1(thingName));
            comboBoxItemsPlayer1.Items.RemoveAt(findItemNumber);
            comboBoxItemsPlayer1.Text = "";
            changeLabelLevelPlayer(playerHuman.getLevel());
        }
        /// <summary>
        /// Ustawienie ustawień wybranych poprzez okno StartForm. Inicjuje działanie aplikacji.
        /// </summary>
        /// <param name="namePlayer"></param>
        /// <param name="difficultLevel"></param>
        public void setSettings(string namePlayer, int difficultLevel)
        {
            groupBoxAllFunction.Enabled = true;
            this.difficultyLevel = difficultLevel;
            labelFirstClientName.Text = namePlayer;
            playerHuman = new Human(namePlayer);
            playerComputer = new Computer(difficultLevel, "Komputer");
            timerFirstAuction.Start();
            timerSecondAuction.Start();
            timerThirdAuction.Start();
            timerBiddingComputer.Start();
            updateAccount();
            buttonStart.Enabled = false;
        }
        /// <summary>
        /// Pobranie danych z pliku tekstowego. Utworzenei odpowiednich list aukcji i przedmiotów.
        /// Wprowadzenei danych do aplikacji.
        /// </summary>
        private void loadDate()
        {
            using (StreamReader streamReader = new StreamReader("Date.txt"))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Char delimiter = ' ';
                    String[] substrings = line.Split(delimiter);
                    String substringName = substrings[0];
                    if (substringName.Remove(4).Equals("waza"))
                    {
                        auctionList.Add(new AuctionItem(new Vase(substrings[0], Int32.Parse(substrings[1]), substrings[2], substrings[3])));
                    }
                    substringName = substrings[0];
                    if (substringName.Remove(5).Equals("obraz"))
                    {
                        auctionList.Add(new AuctionItem(new Picture(substrings[0], Int32.Parse(substrings[1]), substrings[2], substrings[3])));
                    }
                    substringName = substrings[0];
                    if (substringName.Remove(6).Equals("rzezba"))
                    {
                        auctionList.Add(new AuctionItem(new Sculpture(substrings[0], Int32.Parse(substrings[1]), substrings[2], substrings[3])));
                    }
                    
                    numberAuction++;
                }
                for(int i = 0; i < auctionList.Count; i++)
                {
                    ListViewItem newListViewItem = new ListViewItem(auctionList[i].getName());
                    newListViewItem.SubItems.Add(auctionList[i].getValue().ToString());
                    newListViewItem.SubItems.Add(auctionList[i].getSpecialFeaturesItems());
                    listViewInformationAboutAllThings.Items.Add(newListViewItem);
                }
            }
        }
        /// <summary>
        /// Obsługa timera odmierzajacego czas do następnego licytowania przez komputer.
        /// Imituje gracza poprzez wykonywanie akcji co określony czas. 
        /// Decyzja czy zalicytować aukcje jest podejmowana co 10 sekund.
        /// Timer odmieża czas co 2 sekundy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBiddingComputer_Tick(object sender, EventArgs e)
        {
            int bidPrice;
            if (counterTimerBiddingComputer % 5 == 2)
            {
                bidPrice = playerComputer.licytuj(firstAuctionItem.getValue(), Int32.Parse(labelHighestOfferFirstAuction.Text));
                if (bidPrice != 0)
                {
                    if (labelCurrentWinnerFirstAuction.Text.Equals(playerHuman.name))
                    {
                        playerHuman.increaseWealth(Int32.Parse(labelHighestOfferFirstAuction.Text));
                        updateAccount();
                    }
                    labelHighestOfferFirstAuction.Text = bidPrice.ToString();
                    labelCurrentWinnerFirstAuction.Text = playerComputer.name;
                    playerComputer.decreaseWealth(bidPrice);
                }
                
            }
            if (counterTimerBiddingComputer % 5 == 3)
            {
                bidPrice = playerComputer.licytuj(secondAuctionItem.getValue(), Int32.Parse(labelHighestOfferSecondAuction.Text));
                if (bidPrice != 0)
                {
                    if (labelCurrentWinnerSecondAuction.Text.Equals(playerHuman.name))
                    {
                        playerHuman.increaseWealth(Int32.Parse(labelHighestOfferSecondAuction.Text));
                        updateAccount();
                    }
                    labelHighestOfferSecondAuction.Text = bidPrice.ToString();
                    labelCurrentWinnerSecondAuction.Text = playerComputer.name;
                    playerComputer.decreaseWealth(bidPrice);
                }
            }
            if (counterTimerBiddingComputer % 5 == 4)
            {
                bidPrice = playerComputer.licytuj(thirdAuctionItem.getValue(), Int32.Parse(labelHighestOfferThirdAuction.Text));
                if (bidPrice != 0)
                {
                    if (labelCurrentWinnerThirdAuction.Text.Equals(playerHuman.name))
                    {
                        playerHuman.increaseWealth(Int32.Parse(labelHighestOfferThirdAuction.Text));
                        updateAccount();
                    }
                    labelHighestOfferThirdAuction.Text = bidPrice.ToString();
                    labelCurrentWinnerThirdAuction.Text = playerComputer.name;
                    playerComputer.decreaseWealth(bidPrice);
                }
            }
            if (playerComputer.getWealth() <= 0)
            {
                MessageBox.Show("Komputer otrzymał niespodziewany zastrzyk gotówki.");
                playerComputer.odnowPortfel();
            }
            counterTimerBiddingComputer++;
        }

        /// <summary>
        /// Funkcja zmienia poziom gracza zgodnie z poanym argumentem. Sprawdza czy gracz nie wygrał albo nie przegrał.
        /// </summary>
        /// <param name="level"></param>
        private void changeLabelLevelPlayer(int level)
        {
            labelLevelPlayer1.Text = "Level: " + level;
            if (level == 0)
            {
                sellForm.Close();
                MessageBox.Show("Bankrut!");
                Close();
            }
            else if (level == 10)
            {
                sellForm.Close();
                MessageBox.Show("Wygrałeś! Gratuluje!");
                Close();
            }
        }

        /// <summary>
        /// Funkcja obsługuje zdarzenie wyboru przedmiotu który posiada gracz. Zdjęcie przedmiotu zostanie wyświetlone w pictureBoxSellItemPlayer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxItemsPlayer1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxSellItemPlayer1.Image = null;
            pictureBoxSellItemPlayer1.Image = playerHuman.getImageThing(comboBoxItemsPlayer1.Text);
            pictureBoxSellItemPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// Funkcja zarządza sprzedażą przedmiotów które posiada gracz. Otwiera okno do sprzedazy przedmiotu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSellItemPlayer1_Click(object sender, EventArgs e)
        {
           if (!comboBoxItemsPlayer1.Text.Equals("")){
                int numberFindRow = findIndexRowAuctionIndataGridViewThingsPlayer1(comboBoxItemsPlayer1.Text);
                textBoxFirstClientOffer.Text = dataGridViewThingsPlayer1[1, numberFindRow].Value.ToString();
                Enabled = false;
                sellForm = new SellForm(playerHuman.getItem(comboBoxItemsPlayer1.Text), Int32.Parse(dataGridViewThingsPlayer1[1, numberFindRow].Value.ToString()), this);
                sellForm.Show();
                pictureBoxSellItemPlayer1.Image = null;
            }
        }
        /// <summary>
        /// Funkcja odświeża wartość portfela gracza i sprawdza czy nie został on bankrutem.
        /// </summary>
        private void updateAccount()
        {
            labelFirstPlayerAccount.Text = playerHuman.getWealth().ToString();
            if (Int32.Parse(labelFirstPlayerAccount.Text) < 0)
            {
                MessageBox.Show("Bankrut! Czym chciałeś płacić skoro nie masz gotówki, na przyszłość pamiętaj, żeby się nie zadłużyć!");
                Close();
            }
            if (labelFirstPlayerAccount.Text.Equals("0") && comboBoxItemsPlayer1.Items.Count == 0
                && !labelCurrentWinnerFirstAuction.Text.Equals(playerHuman.name) && !labelCurrentWinnerSecondAuction.Text.Equals(playerHuman.name)
                && !labelCurrentWinnerThirdAuction.Text.Equals(playerHuman.name))
            {
                MessageBox.Show("Bankrut!");
                Close();
            }
        }
        /// <summary>
        /// Funkcja zatrzymuje działanie programu poprzez zatrzymanie wszystkich timerów realizujacych działanie programu.
        /// </summary>
        public void block()
        {
            timerBiddingComputer.Stop();
            timerFirstAuction.Stop();
            timerSecondAuction.Stop();
            timerThirdAuction.Stop();
        }

        /// <summary>
        /// Funkcj wznawia dziłanie programu poprzez uruchomienie wszystkich timerów nadzorujacych pracę programu.
        /// </summary>
        public void resume()
        {
            timerBiddingComputer.Start();
            timerFirstAuction.Start();
            timerSecondAuction.Start();
            timerThirdAuction.Start();
        }
        
        /// <summary>
        /// Funkcja znajduje w GridViewThingsPalyer wiersz którego nazwa przedmiotu jest identyczna z nazwą podaną jako argument.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private int findIndexRowAuctionIndataGridViewThingsPlayer1(string name)
        {
            int numberFindRow = 0;
            for (int i = 0; i < dataGridViewThingsPlayer1.Rows.Count - 1; i++)
            {
                if (dataGridViewThingsPlayer1[1, i].Value.ToString().Equals(name))
                {
                    numberFindRow = i;
                    break;
                }
            }
            return numberFindRow;
        }

        /// <summary>
        /// Rozpoczęcie dziłania programu poprzez uruchomienie okna ustawień.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            startForm = new StartForm(this);
            startForm.Show();
        }
    }
}
