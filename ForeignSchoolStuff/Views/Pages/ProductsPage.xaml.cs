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

namespace ForeignSchoolStuff.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        MainWindow mainWindow;
        SchoolStuffDB db;
        public ProductsPage(MainWindow _mainWindow, SchoolStuffDB _schoolStuffDB)
        {
            InitializeComponent();

            mainWindow = _mainWindow;
            db = _schoolStuffDB;

            Item.DataContext = db.Products.ToList();

            //foreach(Product p in db.Products)
            //{
            //    StackPanel item = new StackPanel
            //    {
            //        Style = (Style)Resources["Item"]
            //    };

            //    string path = @"C:\Users\007\source\repos\ForeignSchoolStuff\ForeignSchoolStuff\Images\" + p.MainImagePath.Replace(" ", "");

            //    Image i = new Image
            //    {
            //        Source = new BitmapImage(new Uri(path))
            //    };

            //    TextBlock title = new TextBlock
            //    {
            //        Text = p.Title,
            //        Style = (Style)Resources["Title"]
            //    };

            //    item.Children.Add(i);
            //    item.Children.Add(title);

            //    ItemsPanel.Children.Add(item);
            //}
        }
    }
}
