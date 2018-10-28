using Pons_Translator.models;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Pons_Translator.views
{
    public partial class WordWindow : Window
    {
        public WordWindow()
        {
            InitializeComponent();
            Refresh(true);
        }

        private void Refresh(Boolean resetInputs = false)
        {
            lbWordList.ItemsSource = Word.FindAll();
            if (resetInputs)
            {
                tbWordId.Text = "";
                cbWordCategory.ItemsSource = Category.FindAll(); ;
                tbWordCount.Text = "";
                tbWordName.Text = "";
                tbWordLanguage.Text = "";
                tbWordTranslation.Text = "";
            }
        }

        private void LbWordList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbWordList.SelectedItem != null)
            {
                Word word = (Word)lbWordList.SelectedItem;
                Category category = Category.FindById(word.categoryId);
                tbWordId.Text = word.id.ToString();
                cbWordCategory.ItemsSource = Category.FindAll();
                foreach (var item in cbWordCategory.Items)
                if (item.ToString() == category.name)
                {
                    cbWordCategory.SelectedValue = item;
                    break;
                }
                tbWordCount.Text = word.count.ToString();
                tbWordName.Text = word.name.ToString();
                tbWordLanguage.Text = word.language.ToString();
                tbWordTranslation.Text = word.translation.ToString();
            }
        }

        private void btnCreateWord_Click(object sender, RoutedEventArgs e)
        {
            Category category = (Category)cbWordCategory.SelectedItem;
            int categoryId = category.id;
            int count;
            if (tbWordCount.Text != "")
            {
                count = int.Parse(tbWordCount.Text);
            }
            else
            {
                count = 0;
            }
            string name = tbWordName.Text;
            string language = tbWordLanguage.Text;
            string translation = tbWordTranslation.Text;
            Word.Create(categoryId, count, name, language, translation);
            Refresh(true);
        }

        private void btnDeleteWord_Click(object sender, RoutedEventArgs e)
        {
            Category.Delete(tbWordId.Text);
            Refresh(true);
        }

        private void btnDeleteWord_Click_1(object sender, RoutedEventArgs e)
        {
            int wordId = int.Parse(tbWordId.Text);
            Word.Delete(wordId);
            Refresh(true);
        }

        private void btnUpdateWord_Click(object sender, RoutedEventArgs e)
        {
            Category category = (Category)cbWordCategory.SelectedItem;
            int wordId = int.Parse(tbWordId.Text);
            int categoryId = category.id;
            int count;
            if (tbWordCount.Text != "")
            {
                count = int.Parse(tbWordCount.Text);
            }
            else
            {
                count = 0;
            }
            string name = tbWordName.Text;
            string language = tbWordLanguage.Text;
            string translation = tbWordTranslation.Text;
            Word.Update(wordId, categoryId, count, name, language, translation);
            Refresh(false);
        }
    }
        
}
