
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace MedlemsRegistrering
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly MainViewViewModel mvvm;
        private DataContext dc = new DataContext();
        public MainWindow()
        {
            mvvm = new MainViewViewModel();
            InitializeComponent();
            DataContext = mvvm;
        }
        public List<Members> Men= new List<Members>();
        public List<Members> Women = new List<Members>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource membersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("membersViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            dc.Members.Load();
            membersViewSource.Source = dc.Members.Local;

            foreach (var member in dc.Members)
            {
                if (member.Gender == "Male")
                {
                    Men.Add(member);
                }
                if (member.Gender == "Female")
                {
                    Women.Add(member);
                }

            }
            MENNumber_Label.Content = Men.Count();
            WOMENNumer_Label.Content = Women.Count();
            MENNumberage12_Label.Content = Men.Where(x => x.Age > 0 && x.Age <= 12).Count();
            MENNumberage18_Label.Content = Men.Where(x => x.Age > 12 && x.Age <= 18).Count();
            MENNumberage24_Label.Content = Men.Where(x => x.Age > 18 && x.Age <= 24).Count();
            MENNumberage60_Label.Content = Men.Where(x => x.Age > 24 && x.Age <= 60).Count();
            WOMENNumberage12_Label.Content = Women.Where(x => x.Age > 0 && x.Age <= 12).Count();
            WOMENNumberage18_Label.Content = Women.Where(x => x.Age > 12 && x.Age <= 18).Count();
            WOMENNumberage24_Label.Content = Women.Where(x => x.Age > 18 && x.Age <= 24).Count();
            WOMENNumberage60_Label.Content = Women.Where(x => x.Age > 24 && x.Age <= 60).Count();
        }
    }
}
