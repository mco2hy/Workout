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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Topla(object sender, RoutedEventArgs e)
        {

            string parametre1 = Parametre1.Text;
            string parametre2 = Parametre2.Text;
            string parametre3 = Parametre3.Text;

            int x = Convert.ToInt32(parametre1);
            int y = Convert.ToInt32(parametre2);
            int z = Convert.ToInt32(parametre3);

            int toplam = x + y + z;

            Sonuc.Content = toplam;



        }


        private void Button_Cikart(object sender, RoutedEventArgs e)
        {

            string parametre1 = Parametre1.Text;
            string parametre2 = Parametre2.Text;
            string parametre3 = Parametre3.Text;

            int x = Convert.ToInt32(parametre1);
            int y = Convert.ToInt32(parametre2);
            int z = Convert.ToInt32(parametre3);

            int toplam = x - y - z;

            Sonuc.Content = toplam;



        }

        private void Button_Bol(object sender, RoutedEventArgs e)
        {

            string parametre1 = Parametre1.Text;
            string parametre2 = Parametre2.Text;
            string parametre3 = Parametre3.Text;

            double x = Convert.ToDouble(parametre1);
            double y = Convert.ToDouble(parametre2);
            double z = Convert.ToDouble(parametre3);

            double toplam = x / y / z;

            Sonuc.Content = toplam;



        }

        private void Button_Carp(object sender, RoutedEventArgs e)
        {

            string parametre1 = Parametre1.Text;
            string parametre2 = Parametre2.Text;
            string parametre3 = Parametre3.Text;

            int x = Convert.ToInt32(parametre1);
            int y = Convert.ToInt32(parametre2);
            int z = Convert.ToInt32(parametre3);

            int toplam = x * y * z;

            Sonuc.Content = toplam;



        }

        private void Button_Ustu(object sender, RoutedEventArgs e)
        {

            string parametre1 = Parametre1.Text;
            string parametre2 = Parametre2.Text;
            string parametre3 = Parametre3.Text;

            int x = Convert.ToInt32(parametre1);
            int y = Convert.ToInt32(parametre2);
            int z = Convert.ToInt32(parametre3);

            double toplam = Math.Pow(x, y);
            double toplam1 = Math.Pow(toplam, z); 

            Sonuc.Content = toplam1;



        }

        private void Button_Ortalama(object sender, RoutedEventArgs e)
        {

            string parametre1 = Parametre1.Text;
            string parametre2 = Parametre2.Text;
            string parametre3 = Parametre3.Text;

            double x = Convert.ToDouble(parametre1);
            double y = Convert.ToDouble(parametre2);
            double z = Convert.ToDouble(parametre3);

            double toplam = (x + y + z) / 3;

            Sonuc.Content = toplam;



        }

        private void Button_EnBuyuk(object sender, RoutedEventArgs e)
        {

            

            string parametre1 = Parametre1.Text;
            string parametre2 = Parametre2.Text;
            string parametre3 = Parametre3.Text;

            int x = Convert.ToInt32(parametre1);
            int y = Convert.ToInt32(parametre2);
            int z = Convert.ToInt32(parametre3);

            int[] array = { x, y, z};
            int enBuyuk = array.Max();
            //int enBuyuk = array.Min();

            Sonuc.Content = enBuyuk;
            
          
        }

        private void Button_EnKucuk(object sender, RoutedEventArgs e)
        {

            string parametre1 = Parametre1.Text;
            string parametre2 = Parametre2.Text;
            string parametre3 = Parametre3.Text;

            int x = Convert.ToInt32(parametre1);
            int y = Convert.ToInt32(parametre2);
            int z = Convert.ToInt32(parametre3);

            int[] array = { x, y, z };
            
            int enKucuk = array.Min();

            Sonuc.Content = enKucuk;



        }

    }
    }
