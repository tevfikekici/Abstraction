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

namespace Abstraction
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            InternationalCustomer IC = new InternationalCustomer();
            IC.Login();
            IC.Add();
            
            LocalCustomer LC = new LocalCustomer();
            LC.Add();
        }
    }

    abstract class CustomerBase
    {
        public CustomerBase()
        {
            MessageBox.Show("Constructor runs from abstract base class");
        }
        public abstract void Add();

        public void Login()
        {
            MessageBox.Show("Logged in");
        }
    }

    class InternationalCustomer : CustomerBase 
    {
        public override void Add()
        {
            MessageBox.Show("International Customer added");
        }
    }

    class LocalCustomer : CustomerBase
    {
        public override void Add()
        {
            MessageBox.Show("Local Customer added");
        }
    }
}
