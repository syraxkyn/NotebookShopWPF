using MyAPP.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace MyAPP.View
{
    /// <summary>
    /// Логика взаимодействия для MyView.xaml
    /// </summary>
    public partial class MyView : Window
    {
        public static ListBox AllNotebooksView;
        public MyView()
        {
            InitializeComponent();
            App.LanguageChanged += LanguageChanged;
            CultureInfo currLang = App.Language;
            DataContext = new DataManageVM();
            AllNotebooksView = ViewAllNotebooks;
        }

        private void Russian_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("ru-RU");
            App.Language = lang;
        }

        private void America_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("en-US");
            App.Language = lang;
        }
        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;
        }
    }
}
