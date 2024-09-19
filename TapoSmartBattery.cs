using System.Net;
using Smdn.TPSmartHomeDevices.Tapo;
using Microsoft.Win32;

namespace TapoSmartBattery
{
    public partial class TapoSmartBatteryForm : Form
    {
        private PlugManager plugManager;
        private bool quitFromSystemShutdown = false;

        public TapoSmartBatteryForm()
        {
            InitializeComponent();

            Resize += TapoSmartBatteryForm_Resize;
            FormClosing += TapoSmartBatteryForm_Closing;

            txtMinCharge.Text = Properties.Settings.Default.MinPct.ToString();
            txtMaxCharge.Text = Properties.Settings.Default.MaxPct.ToString();
            LblChargeBetween.Text = "Keep Charge At: " + txtMinCharge.Text + "% to " + txtMaxCharge.Text + "%";
            CboPlugType.Text = Properties.Settings.Default.PlugType;
            TxtIp.Text = Properties.Settings.Default.IP;
            TxtUsername.Text = Properties.Settings.Default.Username;
            TxtPassword.Text = Properties.Settings.Default.Password;

            try
            {
                chkStartOnBoot.Checked = PlugManager.IsSetToStartOnBoot();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Unable to read registry to check the status of Start On Boot. The application will continue to run as normal, but this option will be disabled.", "Start On Boot read failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkStartOnBoot.Checked = false;
                chkStartOnBoot.Enabled = false;
            }

            plugManager = new PlugManager(this);
            plugManager.Start();
        }

        private void TapoSmartBatteryForm_Resize(object? sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                NotifyIcon.Visible = true;
            }
        }

        protected override void WndProc(ref Message m)
        {
            // Intercept WM_QUERYENDSESSION events which happen when the machine shutsdown/reboots, and set a flag that allows the application to terminate without the usual user confirmation popup
            if (m.Msg == 0x11)  // WM_QUERYENDSESSION
            {
                quitFromSystemShutdown = true;
                Close();
            };
            base.WndProc(ref m);
        }

        private void TapoSmartBatteryForm_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!quitFromSystemShutdown)
            {
                DialogResult msgResult = MessageBox.Show("Are you sure you want to exit?", "TapoSmartBattery", MessageBoxButtons.YesNo);
                if (msgResult == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Visible)
                {
                    Hide();
                    NotifyIcon.Visible = true;
                }
                else
                {
                    Show();
                    WindowState = FormWindowState.Normal;
                }
            }
        }

        private void chkPlugControlEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPlugControlEnabled.Checked)
                plugManager.EnablePlugControl();
            else
                plugManager.DisablePlugControl();
        }

        private void lnkHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ps = new System.Diagnostics.ProcessStartInfo("https://github.com/allthefurlongs/TapoSmartBattery")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            System.Diagnostics.Process.Start(ps);
        }

        private void btnApplyNewCharge_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtMinCharge.Text, out double minCharge))
            {
                if (Double.TryParse(txtMaxCharge.Text, out double maxCharge))
                {
                    plugManager.MinPct = minCharge;
                    plugManager.MaxPct = maxCharge;
                    LblChargeBetween.Text = "Keep Charge At: " + txtMinCharge.Text + "% to " + txtMaxCharge.Text + "%";
                    // Also save as settings for the future
                    Properties.Settings.Default.MinPct = minCharge;
                    Properties.Settings.Default.MaxPct = maxCharge;
                    Properties.Settings.Default.Save();
                    if (chkPlugControlEnabled.Checked)
                        plugManager.RestartTimerImmediate();
                }
                else
                    MessageBox.Show("Please enter a number for \"Max charge %\"", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please enter a number for \"Min charge %\"", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lnkLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string licenseText = "MIT No Attribution\r\n\r\nCopyright 2024 Matt Hillman\r\n\r\nPermission is hereby granted, free of charge, to any person obtaining a copy of this\r\n" +
                                 "software and associated documentation files (the \"Software\"), to deal in the Software\r\nwithout restriction, including without limitation the rights to use, copy, modify,\r\n" +
                                 "merge, publish, distribute, sublicense, and/or sell copies of the Software, and to\r\npermit persons to whom the Software is furnished to do so.\r\n\r\n" +
                                 "THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,\r\nINCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A\r\n" +
                                 "PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT\r\nHOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION\r\n" +
                                 "OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE\r\nSOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.";
            MessageBox.Show(licenseText, "License", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSavePlugSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PlugType = CboPlugType.Text;
            Properties.Settings.Default.IP = TxtIp.Text;
            Properties.Settings.Default.Username = TxtUsername.Text;
            Properties.Settings.Default.Password = TxtPassword.Text;
            Properties.Settings.Default.Save();
            if (chkPlugControlEnabled.Checked)
                plugManager.RestartTimerImmediate();
        }

        private void btnForceOn_Click(object sender, EventArgs e)
        {
            plugManager.DisablePlugControl();
            chkPlugControlEnabled.Checked = false;
            try
            {
                _ = plugManager.TurnPlugOn();
            }
            catch (TapoAuthenticationException)
            {
                LblOnOff.Text = "AUTHENTICATION ERROR";
            }
            catch (HttpRequestException)
            {
                LblOnOff.Text = "COMMS ERROR";
            }
            catch (IOException)
            {
                LblOnOff.Text = "COMMS ERROR";
            }
            finally
            {
                plugManager.UpdateNotifyIconText();
            }
        }

        private void btnForceOff_Click(object sender, EventArgs e)
        {
            plugManager.DisablePlugControl();
            chkPlugControlEnabled.Checked = false;
            try
            {
                _ = plugManager.TurnPlugOff();
            }
            catch (TapoAuthenticationException)
            {
                LblOnOff.Text = "AUTHENTICATION ERROR";
            }
            catch (HttpRequestException)
            {
                LblOnOff.Text = "COMMS ERROR";
            }
            catch (IOException)
            {
                LblOnOff.Text = "COMMS ERROR";
            }
            finally
            {
                plugManager.UpdateNotifyIconText();
            }
        }

        private void chkStartOnBoot_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkStartOnBoot.Checked)
                    PlugManager.SetStartOnBoot();
                else
                    PlugManager.UnsetStartOnBoot();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save Start On Boot setting: " + ex.Message, "Setting Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkStartOnBoot.Checked = !chkStartOnBoot.Checked;
            }
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }

    class PlugManager
    {
        private bool isOn = false;
        private double batteryPctAtLastAutomatedOff = -1;
        private int plugStatusRefreshCounter = 0;
        public bool IsOn { get => isOn; }

        private double minPct = Properties.Settings.Default.MinPct / 100;
        public double MinPct {
            get => minPct * 100.0;
            set { minPct = value / 100.0; }
        }

        private double maxPct = Properties.Settings.Default.MaxPct / 100;
        public double MaxPct
        {
            get => maxPct * 100.0;
            set { maxPct = value / 100.0; }
        }

        private TapoSmartBatteryForm mainForm;
        private System.Windows.Forms.Timer poll = new System.Windows.Forms.Timer();
        private bool controlPlug;

        public PlugManager(TapoSmartBatteryForm mainForm)
        {
            this.mainForm = mainForm;
            controlPlug = mainForm.chkPlugControlEnabled.Checked;
            poll.Tick += new EventHandler(PollEvent);
            poll.Interval = 10000;
        }

        public static bool IsSetToStartOnBoot()
        {
            RegistryKey? regKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", false);
            if (regKey != null)
            {
                object? keyValue = regKey.GetValue("TapoSmartBattery");
                if (keyValue == null)
                    return false;
                else if (!((string)keyValue).ToLower().Equals(Application.ExecutablePath.ToLower()))
                    return false;
                else
                    return true;
            }
            else
                throw new InvalidOperationException(@"Could not read registry key check status of Start On Boot setting: SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
        }

        public static void SetStartOnBoot()
        {
            RegistryKey? regKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (regKey != null)
                regKey.SetValue("TapoSmartBattery", Application.ExecutablePath);
            else
                throw new InvalidOperationException(@"Could not open registry key to save Start On Boot setting: SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
        }

        public static void UnsetStartOnBoot()
        {
            RegistryKey? regKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (regKey != null)
                regKey.DeleteValue("TapoSmartBattery");
            else
                throw new InvalidOperationException(@"Could not open registry key to save Start On Boot setting: SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
        }

        public async void SynchronizeOnOffState()
        {
            mainForm.LblBatPct.Text = "Battery Charge: ";
            mainForm.LblOnOff.Text = "Plug is: ";
            if (GotPlugSettings())
            {
                try
                {
                    bool previousIsOn = isOn;
                    using (TapoDevice plug = CreateTapoService(mainForm.CboPlugType.Text))
                        isOn = await plug.GetOnOffStateAsync();
                    if (isOn && isOn != previousIsOn)
                        batteryPctAtLastAutomatedOff = -1;
                    else if (!isOn && isOn != previousIsOn && controlPlug)
                        batteryPctAtLastAutomatedOff = SystemInformation.PowerStatus.BatteryLifePercent;
                    UpdateLabels();
                }
                catch (TapoAuthenticationException)
                {
                    mainForm.LblOnOff.Text = "AUTHENTICATION ERROR";
                }
                catch (HttpRequestException)
                {
                    mainForm.LblOnOff.Text = "COMMS ERROR";
                }
                catch (IOException)
                {
                    mainForm.LblOnOff.Text = "COMMS ERROR";
                }
            }
            UpdateNotifyIconText();
        }

        public void DisablePlugControl()
        {
            batteryPctAtLastAutomatedOff = -1;
            controlPlug = false;
            RestartTimerImmediate();
        }

        public void EnablePlugControl()
        {
            batteryPctAtLastAutomatedOff = -1;
            controlPlug = true;
            RestartTimerImmediate();
        }

        public void Start()
        {
            SynchronizeOnOffState();
            if (GotPlugSettings() && !poll.Enabled)
                poll.Start();
        }

        public void Stop()
        {
            if (poll.Enabled)
                poll.Stop();
            mainForm.LblBatPct.Text = "Battery Charge: ";
            mainForm.LblOnOff.Text = "Plug is: ";
            UpdateNotifyIconText();
        }

        public void RestartTimerImmediate()
        {
            Stop();
            UpdateStatus();  // Quick immediate run before starting the timer
            Start();
        }

        private bool GotPlugSettings()
        {
            if (mainForm.CboPlugType.Text != "" && mainForm.TxtIp.Text != "" && mainForm.TxtUsername.Text != "" && mainForm.TxtPassword.Text != "")
                return true;
            else
            {
                mainForm.LblOnOff.Text = "PLEASE SET PLUG SETTINGS";
                return false;
            }
        }

        private void UpdateLabels(bool chargePctOnly = false)
        {
            mainForm.LblBatPct.Text = "Battery Charge: " + (SystemInformation.PowerStatus.BatteryLifePercent * 100).ToString("0") + "%";
            if (!chargePctOnly)
                mainForm.LblOnOff.Text = "Plug is: " + (isOn ? "On" : "Off") + (controlPlug ? " (automated)" : "");
            UpdateNotifyIconText();
        }

        private TapoDevice CreateTapoService(string tapoDeviceClassName)
        {
            Type? tapoDeviceType = Type.GetType("Smdn.TPSmartHomeDevices.Tapo." + tapoDeviceClassName + ",Smdn.TPSmartHomeDevices.Tapo");
            if (tapoDeviceType == null)
                throw new InvalidOperationException("Could not find Tapo Device Class: " + tapoDeviceClassName);
            var constructor = tapoDeviceType.GetConstructor([typeof(IPAddress), typeof(string), typeof(string), typeof(IServiceProvider)]);
            if (constructor == null)
                throw new InvalidOperationException("Could not find constructor for Tapo Device Class: " + tapoDeviceClassName);
            object device = constructor.Invoke([IPAddress.Parse(mainForm.TxtIp.Text), mainForm.TxtUsername.Text, mainForm.TxtPassword.Text, null]);
            if (device == null)
                throw new InvalidOperationException("Could not create instance of Tapo Device Class: " + tapoDeviceClassName);
            return (TapoDevice)device;
        }

        public async Task TurnPlugOn()
        {
            try
            {
                if (GotPlugSettings())
                {
                    using (TapoDevice plug = CreateTapoService(mainForm.CboPlugType.Text))
                    {
                        await plug.TurnOnAsync();
                        isOn = await plug.GetOnOffStateAsync();
                    }
                    UpdateLabels();
                }
                else
                    UpdateLabels(true);
            }
            catch (TapoAuthenticationException)
            {
                mainForm.LblOnOff.Text = "AUTHENTICATION ERROR";
            }
            catch (HttpRequestException)
            {
                mainForm.LblOnOff.Text = "COMMS ERROR";
            }
            catch (IOException)
            {
                mainForm.LblOnOff.Text = "COMMS ERROR";
            }
            finally
            {
                UpdateNotifyIconText();
            }
        }

        public async Task TurnPlugOff()
        {
            try
            {
                if (GotPlugSettings())
                {
                    using (TapoDevice plug = CreateTapoService(mainForm.CboPlugType.Text))
                    {
                        await plug.TurnOffAsync();
                        isOn = await plug.GetOnOffStateAsync();
                    }
                    UpdateLabels();
                }
                else
                    UpdateLabels(true);
            }
            catch (TapoAuthenticationException)
            {
                mainForm.LblOnOff.Text = "AUTHENTICATION ERROR";
            }
            catch (HttpRequestException)
            {
                mainForm.LblOnOff.Text = "COMMS ERROR";
            }
            catch (IOException)
            {
                mainForm.LblOnOff.Text = "COMMS ERROR";
            }
            finally
            {
                UpdateNotifyIconText();
            }
        }

        public void UpdateNotifyIconText()
        {
            mainForm.NotifyIcon.Text = "TapoSmartBattery:\n" + mainForm.LblBatPct.Text + "\n" + mainForm.LblOnOff.Text + "\n" + mainForm.LblChargeBetween.Text;
        }

        private async void UpdateStatus()
        {
            if (!isOn && batteryPctAtLastAutomatedOff != -1 && SystemInformation.PowerStatus.BatteryLifePercent  > batteryPctAtLastAutomatedOff)
                MessageBox.Show("The plug was automatically turned off, but the battery percentage keeps rising anyway.\n\nYou may need to check if the relay is stuck in the plug, preventing it from physically turning the power off.", "TapoSmartPlug - Stuck Relay?",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            UpdateLabels();
            if (controlPlug)
            {
                try
                {
                    if (SystemInformation.PowerStatus.BatteryLifePercent <= minPct)
                    {
                        if (!isOn)
                            await TurnPlugOn();
                        if (isOn)
                            batteryPctAtLastAutomatedOff = -1;
                    }
                    else if (SystemInformation.PowerStatus.BatteryLifePercent >= maxPct)
                    {
                        if (isOn)
                            await TurnPlugOff();
                        if (!isOn)
                            batteryPctAtLastAutomatedOff = SystemInformation.PowerStatus.BatteryLifePercent;
                    }
                }
                catch (TapoAuthenticationException)
                {
                    mainForm.LblOnOff.Text = "AUTHENTICATION ERROR";
                    mainForm.LblOnOff.Text = "Plug is: " + (isOn ? "On" : "Off") + (controlPlug ? " (automated)" : "");
                }
                catch (HttpRequestException)
                {
                    mainForm.LblOnOff.Text = "COMMS ERROR";
                }
                catch (IOException)
                {
                    mainForm.LblOnOff.Text = "COMMS ERROR";
                }
                finally
                {
                    UpdateNotifyIconText();
                }
            }
        }

        private void PollEvent(object? eventObj, EventArgs eventArgs)
        {
            poll.Stop();
            if (plugStatusRefreshCounter >= 5)
            {
                // Less often, synchronize the plug on/off state. This helps if the machine is put to sleep and wakes up with the plug in a different state than expected.
                SynchronizeOnOffState();
                plugStatusRefreshCounter = 0;
            }
            else
                plugStatusRefreshCounter++;
            UpdateStatus();
            poll.Start();
        }
    }
}
