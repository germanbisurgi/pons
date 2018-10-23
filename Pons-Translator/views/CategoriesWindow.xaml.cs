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

namespace Pons_Translator
{
    /// <summary>
    /// Interaktionslogik für CategoriesWindow.xaml
    /// </summary>
    public partial class CategoriesWindow : Window
    {
        public CategoriesWindow()
        {
            InitializeComponent();
            Refresh(true);
        }

        private void Refresh(Boolean resetInputs = false)
        {
            lbCategoryList.ItemsSource = Category.FindAll();
            if (resetInputs)
            {
                tbCategoryID.Text = "";
                tbCategoryName.Text = "";
            }
        }

        private void LbCategoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbCategoryList.SelectedItem != null)
            {
                Category category = Category.FindOne(lbCategoryList.SelectedItem.ToString());
                tbCategoryID.Text = category.id.ToString();
                tbCategoryName.Text = category.name.ToString();
            }
        }

        private void btnCreateCategory_Click(object sender, RoutedEventArgs e)
        {
            Category.Create(tbCategoryName.Text);
            Refresh(true);
        }

        private void btnUpdateCategory_Click_1(object sender, RoutedEventArgs e)
        {
            Category.Update(tbCategoryID.Text, tbCategoryName.Text);
            Refresh(false);
        }

        private void btnDeleteCategory_Click(object sender, RoutedEventArgs e)
        {
            Category.Delete(tbCategoryID.Text);
            Refresh(true);
        }
        
    }
}
