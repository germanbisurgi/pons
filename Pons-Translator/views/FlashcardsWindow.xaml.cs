using Pons_Translator.models;
using System.Collections.Generic;
using System.Windows;

namespace Pons_Translator.views
{
    public partial class FlashcardsWindow : Window
    {
        public FlashcardsWindow()
        {
            InitializeComponent();
            PrepareCards();
        }

        public void PrepareCards()
        {
            // playingCards = array of words from database filtered by category by category
            // removedCards = contains correct answered cards
            // LoadRandomCard()
        }

        public void LoadRandomCard()
        {
            // randomIndex = a random number from 0 to playingCards.length.
            // load playingCards[randomIndex] card
        }

        public void btnWrong_Click(object sender, RoutedEventArgs e)
        {
            // LoadRandomCard()
        }

        public void btnCorrect_Click(object sender, RoutedEventArgs e)
        {
            // remove the card from cards and add it to the removed cards.
            // LoadRandomCard()
        }

        public void btnFlip_Click(object sender, RoutedEventArgs e)
        {
            // flip card (switches between word and translation)
        }
    }
}
