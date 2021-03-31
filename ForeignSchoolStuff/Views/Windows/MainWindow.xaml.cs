using ForeignSchoolStuff.Views.Pages;
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

namespace ForeignSchoolStuff
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SchoolStuffDB db;
        public MainWindow()
        {
            InitializeComponent();
            db = new SchoolStuffDB();

            OpenPages(Pages.ProductsPage);
        }

        public enum Pages
        {
            ProductsPage
        }

        public void OpenPages(Pages page)
        {
            switch(page)
            {
                case Pages.ProductsPage:
                    MainFrame.Navigate(new ProductsPage(this, db));
                    break;
            }
        }
    }
}
