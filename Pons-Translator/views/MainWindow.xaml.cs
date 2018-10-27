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
using System.Windows.Navigation;
using System.Windows.Shapes;

using Pons_Translator.models;
using Pons_Translator.views;

namespace Pons_Translator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
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
    }
}
