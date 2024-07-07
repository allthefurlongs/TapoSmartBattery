using TapoSmartBattery.Properties;

namespace TapoSmartBattery
{
    partial class TapoSmartBatteryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows FormForm Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TapoSmartBatteryForm));
            LblOnOff = new Label();
            LblBatPct = new Label();
            chkPlugControlEnabled = new CheckBox();
            txtMinCharge = new TextBox();
            txtMaxCharge = new TextBox();
            lblMinCharge = new Label();
            lblMaxCharge = new Label();
            LblChargeBetween = new Label();
            grpSetCharge = new GroupBox();
            btnApplyNewCharge = new Button();
            grpStatus = new GroupBox();
            btnForceOff = new Button();
            btnForceOn = new Button();
            lnkHomepage = new LinkLabel();
            label1 = new Label();
            grpControl = new GroupBox();
            chkStartOnBoot = new CheckBox();
            grpPlugSettings = new GroupBox();
            btnHelp = new Button();
            CboPlugType = new ComboBox();
            lblPlugType = new Label();
            TxtPassword = new TextBox();
            btnSavePlugSettings = new Button();
            lblPassword = new Label();
            lblUser = new Label();
            lblIp = new Label();
            TxtIp = new TextBox();
            TxtUsername = new TextBox();
            lnkLicense = new LinkLabel();
            lblOwnRisk = new Label();
            NotifyIcon = new NotifyIcon(components);
            contextMenuStrip = new ContextMenuStrip(components);
            toolStripExit = new ToolStripMenuItem();
            grpSetCharge.SuspendLayout();
            grpStatus.SuspendLayout();
            grpControl.SuspendLayout();
            grpPlugSettings.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // LblOnOff
            // 
            LblOnOff.AutoSize = true;
            LblOnOff.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblOnOff.Location = new Point(6, 19);
            LblOnOff.Name = "LblOnOff";
            LblOnOff.Size = new Size(100, 20);
            LblOnOff.TabIndex = 0;
            LblOnOff.Text = "Plug is: <init>";
            // 
            // LblBatPct
            // 
            LblBatPct.AutoSize = true;
            LblBatPct.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblBatPct.Location = new Point(6, 51);
            LblBatPct.Name = "LblBatPct";
            LblBatPct.Size = new Size(155, 20);
            LblBatPct.TabIndex = 1;
            LblBatPct.Text = "Battery Charge: <init>";
            // 
            // chkPlugControlEnabled
            // 
            chkPlugControlEnabled.AutoSize = true;
            chkPlugControlEnabled.Checked = true;
            chkPlugControlEnabled.CheckState = CheckState.Checked;
            chkPlugControlEnabled.Location = new Point(10, 21);
            chkPlugControlEnabled.Name = "chkPlugControlEnabled";
            chkPlugControlEnabled.Size = new Size(138, 19);
            chkPlugControlEnabled.TabIndex = 4;
            chkPlugControlEnabled.Text = "Plug Control Enabled";
            chkPlugControlEnabled.UseVisualStyleBackColor = true;
            chkPlugControlEnabled.CheckedChanged += chkPlugControlEnabled_CheckedChanged;
            // 
            // txtMinCharge
            // 
            txtMinCharge.Location = new Point(95, 23);
            txtMinCharge.Name = "txtMinCharge";
            txtMinCharge.Size = new Size(37, 23);
            txtMinCharge.TabIndex = 1;
            // 
            // txtMaxCharge
            // 
            txtMaxCharge.Location = new Point(95, 53);
            txtMaxCharge.Name = "txtMaxCharge";
            txtMaxCharge.Size = new Size(37, 23);
            txtMaxCharge.TabIndex = 2;
            // 
            // lblMinCharge
            // 
            lblMinCharge.AutoSize = true;
            lblMinCharge.Location = new Point(6, 26);
            lblMinCharge.Name = "lblMinCharge";
            lblMinCharge.Size = new Size(83, 15);
            lblMinCharge.TabIndex = 5;
            lblMinCharge.Text = "Min charge %:";
            // 
            // lblMaxCharge
            // 
            lblMaxCharge.AutoSize = true;
            lblMaxCharge.Location = new Point(6, 56);
            lblMaxCharge.Name = "lblMaxCharge";
            lblMaxCharge.Size = new Size(85, 15);
            lblMaxCharge.TabIndex = 6;
            lblMaxCharge.Text = "Max charge %:";
            // 
            // LblChargeBetween
            // 
            LblChargeBetween.AutoSize = true;
            LblChargeBetween.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblChargeBetween.Location = new Point(6, 82);
            LblChargeBetween.Name = "LblChargeBetween";
            LblChargeBetween.Size = new Size(116, 20);
            LblChargeBetween.TabIndex = 7;
            LblChargeBetween.Text = "Keep Charge At:";
            // 
            // grpSetCharge
            // 
            grpSetCharge.Controls.Add(btnApplyNewCharge);
            grpSetCharge.Controls.Add(lblMaxCharge);
            grpSetCharge.Controls.Add(txtMinCharge);
            grpSetCharge.Controls.Add(txtMaxCharge);
            grpSetCharge.Controls.Add(lblMinCharge);
            grpSetCharge.Location = new Point(233, 12);
            grpSetCharge.Name = "grpSetCharge";
            grpSetCharge.Size = new Size(139, 110);
            grpSetCharge.TabIndex = 0;
            grpSetCharge.TabStop = false;
            grpSetCharge.Text = "Set Charge Range";
            // 
            // btnApplyNewCharge
            // 
            btnApplyNewCharge.Location = new Point(57, 82);
            btnApplyNewCharge.Name = "btnApplyNewCharge";
            btnApplyNewCharge.Size = new Size(75, 23);
            btnApplyNewCharge.TabIndex = 3;
            btnApplyNewCharge.Text = "Apply";
            btnApplyNewCharge.UseVisualStyleBackColor = true;
            btnApplyNewCharge.Click += btnApplyNewCharge_Click;
            // 
            // grpStatus
            // 
            grpStatus.Controls.Add(LblBatPct);
            grpStatus.Controls.Add(LblOnOff);
            grpStatus.Controls.Add(LblChargeBetween);
            grpStatus.Location = new Point(12, 12);
            grpStatus.Name = "grpStatus";
            grpStatus.Size = new Size(215, 110);
            grpStatus.TabIndex = 10;
            grpStatus.TabStop = false;
            grpStatus.Text = "Status";
            // 
            // btnForceOff
            // 
            btnForceOff.Location = new Point(256, 17);
            btnForceOff.Name = "btnForceOff";
            btnForceOff.Size = new Size(98, 23);
            btnForceOff.TabIndex = 7;
            btnForceOff.Text = "Force Plug Off";
            btnForceOff.UseVisualStyleBackColor = true;
            btnForceOff.Click += btnForceOff_Click;
            // 
            // btnForceOn
            // 
            btnForceOn.Location = new Point(154, 17);
            btnForceOn.Name = "btnForceOn";
            btnForceOn.Size = new Size(98, 23);
            btnForceOn.TabIndex = 6;
            btnForceOn.Text = "Force Plug On";
            btnForceOn.UseVisualStyleBackColor = true;
            btnForceOn.Click += btnForceOn_Click;
            // 
            // lnkHomepage
            // 
            lnkHomepage.AutoSize = true;
            lnkHomepage.Location = new Point(11, 371);
            lnkHomepage.Name = "lnkHomepage";
            lnkHomepage.Size = new Size(66, 15);
            lnkHomepage.TabIndex = 13;
            lnkHomepage.TabStop = true;
            lnkHomepage.Text = "Homepage";
            lnkHomepage.LinkClicked += lnkHomepage_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 43);
            label1.Name = "label1";
            label1.Size = new Size(198, 15);
            label1.TabIndex = 11;
            label1.Text = "(Forcing disables automatic control)";
            // 
            // grpControl
            // 
            grpControl.Controls.Add(chkStartOnBoot);
            grpControl.Controls.Add(label1);
            grpControl.Controls.Add(btnForceOff);
            grpControl.Controls.Add(chkPlugControlEnabled);
            grpControl.Controls.Add(btnForceOn);
            grpControl.Location = new Point(12, 128);
            grpControl.Name = "grpControl";
            grpControl.Size = new Size(360, 72);
            grpControl.TabIndex = 12;
            grpControl.TabStop = false;
            grpControl.Text = "Control";
            // 
            // chkStartOnBoot
            // 
            chkStartOnBoot.AutoSize = true;
            chkStartOnBoot.Location = new Point(10, 43);
            chkStartOnBoot.Name = "chkStartOnBoot";
            chkStartOnBoot.Size = new Size(97, 19);
            chkStartOnBoot.TabIndex = 5;
            chkStartOnBoot.Text = "Start On Boot";
            chkStartOnBoot.UseVisualStyleBackColor = true;
            chkStartOnBoot.CheckedChanged += chkStartOnBoot_CheckedChanged;
            // 
            // grpPlugSettings
            // 
            grpPlugSettings.Controls.Add(btnHelp);
            grpPlugSettings.Controls.Add(CboPlugType);
            grpPlugSettings.Controls.Add(lblPlugType);
            grpPlugSettings.Controls.Add(TxtPassword);
            grpPlugSettings.Controls.Add(btnSavePlugSettings);
            grpPlugSettings.Controls.Add(lblPassword);
            grpPlugSettings.Controls.Add(lblUser);
            grpPlugSettings.Controls.Add(lblIp);
            grpPlugSettings.Controls.Add(TxtIp);
            grpPlugSettings.Controls.Add(TxtUsername);
            grpPlugSettings.Location = new Point(12, 206);
            grpPlugSettings.Name = "grpPlugSettings";
            grpPlugSettings.Size = new Size(360, 162);
            grpPlugSettings.TabIndex = 13;
            grpPlugSettings.TabStop = false;
            grpPlugSettings.Text = "Plug Settings";
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(280, 132);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(75, 23);
            btnHelp.TabIndex = 13;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // CboPlugType
            // 
            CboPlugType.FormattingEnabled = true;
            CboPlugType.Items.AddRange(new object[] { "P110M", "P105", "L530", "L900" });
            CboPlugType.Location = new Point(79, 16);
            CboPlugType.Name = "CboPlugType";
            CboPlugType.Size = new Size(274, 23);
            CboPlugType.TabIndex = 8;
            // 
            // lblPlugType
            // 
            lblPlugType.AutoSize = true;
            lblPlugType.Location = new Point(6, 19);
            lblPlugType.Name = "lblPlugType";
            lblPlugType.Size = new Size(61, 15);
            lblPlugType.TabIndex = 12;
            lblPlugType.Text = "Plug Type:";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(79, 103);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(276, 23);
            TxtPassword.TabIndex = 11;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // btnSavePlugSettings
            // 
            btnSavePlugSettings.Location = new Point(79, 132);
            btnSavePlugSettings.Name = "btnSavePlugSettings";
            btnSavePlugSettings.Size = new Size(75, 23);
            btnSavePlugSettings.TabIndex = 12;
            btnSavePlugSettings.Text = "Save";
            btnSavePlugSettings.UseVisualStyleBackColor = true;
            btnSavePlugSettings.Click += btnSavePlugSettings_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(5, 106);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(6, 77);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(63, 15);
            lblUser.TabIndex = 4;
            lblUser.Text = "Username:";
            // 
            // lblIp
            // 
            lblIp.AutoSize = true;
            lblIp.Location = new Point(5, 48);
            lblIp.Name = "lblIp";
            lblIp.Size = new Size(65, 15);
            lblIp.TabIndex = 3;
            lblIp.Text = "IP Address:";
            // 
            // TxtIp
            // 
            TxtIp.Location = new Point(79, 45);
            TxtIp.Name = "TxtIp";
            TxtIp.Size = new Size(276, 23);
            TxtIp.TabIndex = 9;
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(79, 74);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(276, 23);
            TxtUsername.TabIndex = 10;
            // 
            // lnkLicense
            // 
            lnkLicense.AutoSize = true;
            lnkLicense.Location = new Point(325, 371);
            lnkLicense.Name = "lnkLicense";
            lnkLicense.Size = new Size(46, 15);
            lnkLicense.TabIndex = 14;
            lnkLicense.TabStop = true;
            lnkLicense.Text = "License";
            lnkLicense.LinkClicked += lnkLicense_LinkClicked;
            // 
            // lblOwnRisk
            // 
            lblOwnRisk.AutoSize = true;
            lblOwnRisk.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOwnRisk.Location = new Point(108, 371);
            lblOwnRisk.Name = "lblOwnRisk";
            lblOwnRisk.Size = new Size(182, 15);
            lblOwnRisk.TabIndex = 15;
            lblOwnRisk.Text = "Use this software at your own risk";
            // 
            // NotifyIcon
            // 
            NotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            NotifyIcon.BalloonTipText = "TapoSmartBattery";
            NotifyIcon.BalloonTipTitle = "TapoSmartBattery";
            NotifyIcon.ContextMenuStrip = contextMenuStrip;
            NotifyIcon.Icon = (Icon)resources.GetObject("NotifyIcon.Icon");
            NotifyIcon.Text = "TapoSmartBattery";
            NotifyIcon.Visible = true;
            NotifyIcon.MouseClick += NotifyIcon_MouseClick;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripExit });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(94, 26);
            // 
            // toolStripExit
            // 
            toolStripExit.Name = "toolStripExit";
            toolStripExit.Size = new Size(93, 22);
            toolStripExit.Text = "Exit";
            toolStripExit.Click += toolStripExit_Click;
            // 
            // TapoSmartBatteryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 394);
            Controls.Add(lblOwnRisk);
            Controls.Add(lnkLicense);
            Controls.Add(grpPlugSettings);
            Controls.Add(grpControl);
            Controls.Add(lnkHomepage);
            Controls.Add(grpStatus);
            Controls.Add(grpSetCharge);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(399, 433);
            MinimumSize = new Size(399, 433);
            Name = "TapoSmartBatteryForm";
            Text = "TapoSmartBattery";
            grpSetCharge.ResumeLayout(false);
            grpSetCharge.PerformLayout();
            grpStatus.ResumeLayout(false);
            grpStatus.PerformLayout();
            grpControl.ResumeLayout(false);
            grpControl.PerformLayout();
            grpPlugSettings.ResumeLayout(false);
            grpPlugSettings.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label LblOnOff;
        public Label LblBatPct;
        public CheckBox chkPlugControlEnabled;
        private TextBox txtMinCharge;
        private TextBox txtMaxCharge;
        private Label lblMinCharge;
        private Label lblMaxCharge;
        public Label LblChargeBetween;
        private GroupBox grpSetCharge;
        private Button btnApplyNewCharge;
        private GroupBox grpStatus;
        private LinkLabel lnkHomepage;
        private Button btnForceOff;
        private Button btnForceOn;
        private Label label1;
        private GroupBox grpControl;
        private GroupBox grpPlugSettings;
        private Label lblUser;
        private Label lblIp;
        public TextBox TxtUsername;
        public TextBox TxtIp;
        private Label lblPassword;
        private CheckBox chkStartOnBoot;
        private Button btnSavePlugSettings;
        private LinkLabel lnkLicense;
        private Label lblOwnRisk;
        public TextBox TxtPassword;
        public ComboBox CboPlugType;
        private Label lblPlugType;
        public NotifyIcon NotifyIcon;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem toolStripExit;
        private Button btnHelp;
    }
}