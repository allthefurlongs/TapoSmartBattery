namespace TapoSmartBattery
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void lblHelp2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ps = new System.Diagnostics.ProcessStartInfo("https://www.tapo.com/uk/product/smart-plug/")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            System.Diagnostics.Process.Start(ps);
        }
    }
}
