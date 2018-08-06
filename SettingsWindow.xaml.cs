using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace SpeechTranslator
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
            ClientID.Text = Properties.Settings.Default.ClientID;
            if (Properties.Settings.Default.UseAzureGovernment) RbAzureGov.IsChecked = true;
            else RbAzurePublic.IsChecked = true;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.ClientID = ClientID.Text;
            Properties.Settings.Default.UseAzureGovernment = (bool)RbAzureGov.IsChecked;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void Label_MouseDown_Subscription(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("http://aka.ms/translatorazure");
        }

        private void Label_MouseDown_ClientID(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("http://aka.ms/translatorazure");
        }

        private void ObtainSubscription_MouseEnter(object sender, MouseEventArgs e)
        {
            ObtainSubscription.Foreground = Brushes.DarkBlue;
        }

        private void ObtainSubscription_MouseLeave(object sender, MouseEventArgs e)
        {
            ObtainSubscription.Foreground = Brushes.Blue;
        }

        private void ObtainClientID_MouseEnter(object sender, MouseEventArgs e)
        {
            ObtainClientID.Foreground = Brushes.DarkBlue;
        }

        private void ObtainClientID_MouseLeave(object sender, MouseEventArgs e)
        {
            ObtainClientID.Foreground = Brushes.Blue;
        }

    }
}
