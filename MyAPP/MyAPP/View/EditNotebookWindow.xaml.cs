using MyAPP.Model;
using MyAPP.ViewModel;
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

namespace MyAPP.View
{
    /// <summary>
    /// Логика взаимодействия для EditNotebookWindow.xaml
    /// </summary>
    public partial class EditNotebookWindow : Window
    {
        public EditNotebookWindow(Notebook notebookToEdit)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.SelectedNotebook = notebookToEdit;
            DataManageVM.NotebookName = notebookToEdit.Name;
            DataManageVM.NotebookType = notebookToEdit.Type;
            DataManageVM.NotebookPrice = notebookToEdit.Price;
        }
    }
}
