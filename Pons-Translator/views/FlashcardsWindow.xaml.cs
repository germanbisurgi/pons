using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Pons_Translator.models;

namespace Pons_Translator.views
{
    /// <summary>
    /// Interaktionslogik für FlashcardsWindow.xaml
    /// </summary>
    public partial class FlashcardsWindow : Window
    {
        public FlashcardsWindow()
        {
            InitializeComponent();
            PrepareCards();
        }

        public void PrepareCards()
        {
            cbCategories.ItemsSource = Category.FindAll();
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
