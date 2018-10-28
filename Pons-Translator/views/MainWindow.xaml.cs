using Pons_Translator.models;
using Pons_Translator.views;
using System.Collections.Generic;
using System.Windows;

namespace Pons_Translator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            refresh();
        }

        public void refresh()
        {
            lbWordList.ItemsSource = Word.FindAll();
            cbLanguage.Items.Add("en");
            cbLanguage.Items.Add("it");
            cbLanguage.Items.Add("es");
            cbLanguage.SelectedValue = "en";
        }

        public void toWords_Click(object sender, RoutedEventArgs e)
        {
            WordWindow wordWindow = new WordWindow();
            wordWindow.Show();
        }

        public void toCategories_Click(object sender, RoutedEventArgs e)
        {
            FashcardsWindow categoriesWindow = new FashcardsWindow();
            categoriesWindow.Show();
        }

        public void toFlashcards_Click(object sender, RoutedEventArgs e)
        {
            FlashcardsWindow flashcardsWindow = new FlashcardsWindow();
            flashcardsWindow.Show();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string word = tbWord.Text;
            string language = cbLanguage.Text;
            List<string> translations = PonsApi.Translate(word, language);
        }
    }
}
