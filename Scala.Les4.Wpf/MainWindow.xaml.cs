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

namespace Scala.Les4.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbLand.Items.Add("België");
            cmbLand.Items.Add("Nederland");
            cmbLand.Items.Add("Frankrijk");
            cmbLand.Items.Add("Duitsland");
        }

        bool heeftBetaald;
        private void btnHeeftBetaald_Click(object sender, RoutedEventArgs e)
        {
            heeftBetaald = true;
            if (heeftBetaald == true)
                lblBetaald.Content = "Betaald : kom binnen";
        }

        private void btnHeeftNietBetaald_Click(object sender, RoutedEventArgs e)
        {
            heeftBetaald = false;
            if (heeftBetaald == false)
                lblBetaald.Content = "Niet betaald : blijf buiten";
        }

        bool isGroterDanEenMeter;
        private void btnKleinKind_Click(object sender, RoutedEventArgs e)
        {
            isGroterDanEenMeter = false;
            // alternatief voor if(isGroterDanEenMeter == false)
            if (!isGroterDanEenMeter)
                lblToegang.Content = "Te klein : wachten";
        }

        private void btnGrootKind_Click(object sender, RoutedEventArgs e)
        {
            isGroterDanEenMeter = true;
            // alternatief voor if (isGroterDanEenMeter == true)
            if (isGroterDanEenMeter)
                lblToegang.Content = "Groot genoeg : stap op";
        }



        private void btnGeta1GroterDanGetal2_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            if (getal1 > getal2)
                lblGroterKleinerOfGelijk.Content = "Getal 1 is groter dan getal 2";
            else
                lblGroterKleinerOfGelijk.Content = "Getal 1 is NIET groter dan getal 2";
        }

        private void btnGeta1KleinerDanGetal2_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            if (getal1 < getal2)
                lblGroterKleinerOfGelijk.Content = "Getal 1 is kleiner dan getal 2";
            else
                lblGroterKleinerOfGelijk.Content = "Getal 1 is NIET kleiner dan getal 2";
        }

        private void btnGeta1GelijkAanGetal2_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            if (getal1 == getal2)
                lblGroterKleinerOfGelijk.Content = "Getal 1 is gelijk aan getal 2";
            else
                lblGroterKleinerOfGelijk.Content = "Getal 1 is NIET gelijk getal 2";
        }

        private void btnAllesInEenKeer_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            if(getal1 < getal2)
            {
                lblGroterKleinerOfGelijk.Content = "Getal 1 is kleiner dan getal 2";
            }
            else
            {
                if(getal1 == getal2)
                {
                    lblGroterKleinerOfGelijk.Content = "Getal 1 is gelijk aan getal 2";
                }
                else
                {
                    lblGroterKleinerOfGelijk.Content = "Getal 1 is groter dan getal 2";
                }
            }

        }
        private void btnBerekenTotaalPrijs_Click(object sender, RoutedEventArgs e)
        {
            // indien totaalprijs > 500 en aantal > 5 => korting geven

            decimal prijs = decimal.Parse(txtPrijs.Text);
            int aantal = int.Parse(txtAantal.Text);
            decimal kortingPercantage = decimal.Parse(txtKorting.Text) / 100;
            decimal kortingBedrag;
            decimal teBetalen;

            decimal totaalPrijs = prijs * aantal;
            if (totaalPrijs > 500 && aantal > 5)
                kortingBedrag = totaalPrijs * kortingPercantage;
            else
                kortingBedrag = 0;

            teBetalen = totaalPrijs - kortingBedrag;

            lblBerekeningTotaalPrijs.Content = "Totaalprijs = " + totaalPrijs.ToString("#,##0.00") + Environment.NewLine;
            lblBerekeningTotaalPrijs.Content += "Korting = " + kortingBedrag.ToString("#,##0.00") + Environment.NewLine;
            lblBerekeningTotaalPrijs.Content += "Te betalen = " + teBetalen.ToString("#,##0.00");

        }
        private void btnBerekenTotaalPrijs2_Click(object sender, RoutedEventArgs e)
        {
            // indien totaalprijs > 500 EN aantal > 5 => korting geven
            // OF klant komt uit België => korting geven

            decimal prijs = decimal.Parse(txtPrijs2.Text);
            int aantal = int.Parse(txtAantal2.Text);
            decimal kortingPercantage = decimal.Parse(txtKorting2.Text) / 100;
            decimal kortingBedrag;
            decimal teBetalen;
            string landVanHerkomst = cmbLand.SelectedItem.ToString();

            decimal totaalPrijs = prijs * aantal;
            if (totaalPrijs > 500 && aantal > 5 || landVanHerkomst == "België")
                kortingBedrag = totaalPrijs * kortingPercantage;
            else
                kortingBedrag = 0;

            teBetalen = totaalPrijs - kortingBedrag;

            lblBerekeningTotaalPrijs2.Content = "Totaalprijs = " + totaalPrijs.ToString("#,##0.00") + Environment.NewLine;
            lblBerekeningTotaalPrijs2.Content += "Korting = " + kortingBedrag.ToString("#,##0.00") + Environment.NewLine;
            lblBerekeningTotaalPrijs2.Content += "Te betalen = " + teBetalen.ToString("#,##0.00");

        }
    }
}
