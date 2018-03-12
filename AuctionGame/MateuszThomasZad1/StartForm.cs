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
    public partial class StartForm : Form
    {
        /// <summary>
        /// Pole okna głównego. Wykorzystywane do odwołań do podstawowego okna aplikacji.
        /// </summary>
        MainForm mainForm;
        public StartForm(MainForm mainForm)
        {
            SetTopLevel(true);
            this.mainForm = mainForm;
            
            mainForm.Visible = false;
            InitializeComponent();
            Activate();
        }
        /// <summary>
        /// Reakcja na naciśnięcie przycisku start. Rozpoczęcie gry i przekazanie wybranych ustawień do okna głównego.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            mainForm.setSettings(textBoxNamePlayer1.Text, trackBarDifficultyLevel.Value);
            Close();
        }
    }
}
