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
using System.Data.SQLite;

namespace Iskitim2023.Pages
{
    /// <summary>
    /// Логика взаимодействия для DB.xaml
    /// </summary>
    public partial class DB : Page
    {
        AppContext database;
        public DB()
        {
            InitializeComponent();

            database = new AppContext();
            List<polution> polutions = database.polutions.ToList();

            Listofpolutions.ItemsSource = polutions;
        }
    }
}
