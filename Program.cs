namespace TapoSmartBattery
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {

            using (Mutex mutex = new Mutex(false, "Global\\TapoSmartBattery-57234ac3-d875-4df5-9a5e-f6ad8b404138"))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("Another instance of TapoSmartBattery is already running", "TapoSmartBattery", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                ApplicationConfiguration.Initialize();
                TapoSmartBatteryForm mainForm = new TapoSmartBatteryForm();
                Application.Run(mainForm);
            }
        }
    }
}
