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

namespace LottoKone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> Rivit;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmbGame_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void btndraw_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cmbGame.SelectedItem == cmbilotto)
                {
                    Lotto lotto = new Lotto();
                    lotto.Numerot = new bool[40];
                    lotto.Hits = 7;
                    lotto.Lkm = int.Parse(txtdraws.Text);
                    lotto.Nro = 40;
                    lotto.Määrä = 40;
                    lotto.HitsMax = 7;
                    Rivit = LottoTesti.DrawLotto(lotto);
                    string nmr = "";
                    foreach (var item in Rivit)
                    {
                        nmr += item;
                    }
                    txtnumerot.Text = nmr;
                    Rivit = null;
                }

                if (cmbGame.SelectedItem == cmbiviking)
                {
                    Lotto viking = new Lotto();
                    viking.Numerot = new bool[48];
                    viking.Hits = 6;
                    viking.Lkm = int.Parse(txtdraws.Text);
                    viking.Nro = 48;
                    viking.Määrä = 48;
                    viking.HitsMax = 6;
                    Rivit = LottoTesti.DrawLotto(viking);
                    string nmr = "";
                    foreach (var item in Rivit)
                    {
                        nmr += item;
                    }
                    txtnumerot.Text = nmr;
                    Rivit = null;
                }

                if (cmbGame.SelectedItem == cmbieuro)
                {
                    Lotto euro = new Lotto();
                    euro.Numerot = new bool[50];
                    euro.Hits = 5;
                    euro.Lkm = int.Parse(txtdraws.Text);
                    euro.Nro = 50;
                    euro.Määrä = 50;
                    euro.HitsMax = 5;
                    Rivit = LottoTesti.DrawLotto(euro);
                    string nmr = "";
                    foreach (var item in Rivit)
                    {
                        nmr += item;
                    }
                    txtnumerot.Text = nmr;
                    Rivit = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           

        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            txtnumerot.Text = null;
            Rivit = null;
        }

        private void txtdraws_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtnumerot_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
