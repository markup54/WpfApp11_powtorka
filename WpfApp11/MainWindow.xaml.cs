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

namespace WpfApp11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Samochod> Samochody {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            przygotujDane();
            List<String> list = new List<String>() { "BMW", "Audi", "Opel", "Mercedes" };
            listaMarek.ItemsSource = list;
        }

        private void przygotujDane()
        {
            Samochody = new List<Samochod>();
            Samochody.Add(new Samochod("Opel", "Astra", 2015, "czerwony", true));
            Samochody.Add(new Samochod("BMW", "Astra", 2015, "czerwony", true));
            Samochody.Add(new Samochod("BMW", "Astra", 2015, "czerwony", true));
            Samochody.Add(new Samochod("BMW", "Astra", 2015, "czerwony", true));
            Samochody.Add(new Samochod("BMW", "Astra", 2015, "czerwony", true));
            Samochody.Add(new Samochod("Audi", "Astra", 2015, "czerwony", true));
            Samochody.Add(new Samochod("Mercedes", "Astra", 2015, "czerwony", true));
        }
    }
}
