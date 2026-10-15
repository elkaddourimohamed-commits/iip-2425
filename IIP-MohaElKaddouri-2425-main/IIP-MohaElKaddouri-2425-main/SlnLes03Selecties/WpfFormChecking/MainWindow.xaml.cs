using System;
using System.Windows;

namespace WpfFormChecking
{
    /// <summary>
    /// Hier is the summary
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnRegistreren_Click(object sender, RoutedEventArgs e)
        {
            int aantalFouten = 0;

            lblMessageName.Text = "";
            lblMessageEmail.Text = "";
            lblMessageGeboortedatum.Text = "";
            lblMessageProfiel.Text = "";
            lblMessagePaswoord.Text = "";
            lblMessageGeslacht.Text = "";
            lblMessageInteresses.Text = "";

            if (string.IsNullOrEmpty(txtNaam.Text))
            {
                lblMessageName.Text = "naam moet ingevuld zijn";
                aantalFouten++;
            }

            if (string.IsNullOrEmpty(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                lblMessageEmail.Text = "email moet geldig zijn";
                aantalFouten++;
            }

            if (dtpGeboortedatum.SelectedDate == null)
            {
                lblMessageGeboortedatum.Text = "datum moet ingevuld zijn";
                aantalFouten++;
            }

            if (cmbProfiel.SelectedIndex == 0)
            {
                lblMessageProfiel.Text = "maak een keuze";
                aantalFouten++;
            }

            if (string.IsNullOrEmpty(pwdPaswoord.Password))
            {
                lblMessagePaswoord.Text = "kies een paswoord";
                aantalFouten++;
            }

            if (!rbnMan.IsChecked == true && !rbnVrouw.IsChecked == true)
            {
                lblMessageGeslacht.Text = "kies een geslacht";
                aantalFouten++;
            }

            if (!chkProgrammeren.IsChecked == true && !chkNetwerken.IsChecked == true && !chkBusiness.IsChecked == true)
            {
                lblMessageInteresses.Text = "kies minstens één interesse";
                aantalFouten++;
            }
            if (aantalFouten > 0)
            {
                lblAantalFouten.Text = $"dit formulier bevat {aantalFouten} fouten";
            }
            else
            {
                lblAantalFouten.Text = "";
            }
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            txtNaam.Text = "";
            txtEmail.Text = "";
            dtpGeboortedatum.SelectedDate = null;
            cmbProfiel.SelectedIndex = 0;
            pwdPaswoord.Password = "";
            rbnMan.IsChecked = false;
            rbnVrouw.IsChecked = false;
            chkProgrammeren.IsChecked = false;
            chkNetwerken.IsChecked = false;
            chkBusiness.IsChecked = false;

            lblMessageName.Text = "";
            lblMessageEmail.Text = "";
            lblMessageGeboortedatum.Text = "";
            lblMessageProfiel.Text = "";
            lblMessagePaswoord.Text = "";
            lblMessageGeslacht.Text = "";
            lblMessageInteresses.Text = "";
            lblAantalFouten.Text = "";
        }
    }
}