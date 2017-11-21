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

namespace ShoppingList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Tuote> tuotteet;
        public  MainWindow()
        {
            InitializeComponent();
            tuotteet = Kauppalista.HaeTuotteet();
        }

        private void chkmilk_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)chkmilk.IsChecked)
                {
                    Tuote milk = new Tuote() { Name = "Milk" };
                    tuotteet.Add(milk);
                }
            }
           
          
             catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chkbutter_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)chkbutter.IsChecked)
                {
                    Tuote butter = new Tuote() { Name = "Butter" };
                    tuotteet.Add(butter);
                }
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chkbeer_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)chkbeer.IsChecked)
                {
                    Tuote beer = new Tuote() { Name = "Beer" };
                    tuotteet.Add(beer);
                }
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chklemonade_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)chklemonade.IsChecked)
                {
                    Tuote lemonade = new Tuote() { Name = "Lemonade" };
                    tuotteet.Add(lemonade);
                }
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chkchicken_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)chkchicken.IsChecked)
                {
                    Tuote chicken = new Tuote() { Name = "Chicken" };
                    tuotteet.Add(chicken);
                }
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnbuy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string test = "";
                foreach (Tuote item in tuotteet)
                {
                    test += item.ToString();
                }
                txtboxlist.Text = test;
            }
           

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
