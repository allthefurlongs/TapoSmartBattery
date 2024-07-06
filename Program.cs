namespace TapoSmartBattery
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            TapoSmartBatteryForm mainForm = new TapoSmartBatteryForm();
            Application.Run(mainForm);
        }
    }
}
