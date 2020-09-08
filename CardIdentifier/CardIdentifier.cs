using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardIdentifier
{
    public partial class CardIdentifier : Form
    {
        public CardIdentifier()
        {
            InitializeComponent();
        }

        // Click Events for each of the five cards
        private void cardOne_Click(object sender, EventArgs e)
        {
            selectedCardLabel.Text = "Eight of Diamonds";
        }

        private void cardTwo_Click(object sender, EventArgs e)
        {
            selectedCardLabel.Text = "Two of Clubs";
        }

        private void cardThree_Click(object sender, EventArgs e)
        {
            selectedCardLabel.Text = "King of Spades";
        }

        private void cardFour_Click(object sender, EventArgs e)
        {
            selectedCardLabel.Text = "Ace of Spades";
        }

        private void cardFive_Click(object sender, EventArgs e)
        {
            selectedCardLabel.Text = "Black Joker";
        }

        // Closes the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
