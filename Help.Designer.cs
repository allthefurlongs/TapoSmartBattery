namespace TapoSmartBattery
{
    partial class Help
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            lblHelp3 = new Label();
            lblHelp1 = new Label();
            lblHelp2 = new LinkLabel();
            lblHelp4 = new Label();
            lblHelp5 = new Label();
            lblHelp6 = new Label();
            lblHelp7 = new Label();
            SuspendLayout();
            // 
            // lblHelp3
            // 
            lblHelp3.AutoSize = true;
            lblHelp3.Location = new Point(12, 102);
            lblHelp3.MaximumSize = new Size(751, 0);
            lblHelp3.Name = "lblHelp3";
            lblHelp3.Size = new Size(750, 90);
            lblHelp3.TabIndex = 0;
            lblHelp3.Text = resources.GetString("lblHelp3.Text");
            // 
            // lblHelp1
            // 
            lblHelp1.AutoSize = true;
            lblHelp1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHelp1.Location = new Point(12, 15);
            lblHelp1.Name = "lblHelp1";
            lblHelp1.Size = new Size(225, 30);
            lblHelp1.TabIndex = 1;
            lblHelp1.Text = "TapoSmartBattery Help";
            // 
            // lblHelp2
            // 
            lblHelp2.AutoSize = true;
            lblHelp2.LinkArea = new LinkArea(141, 15);
            lblHelp2.Location = new Point(12, 56);
            lblHelp2.MaximumSize = new Size(751, 0);
            lblHelp2.Name = "lblHelp2";
            lblHelp2.Size = new Size(722, 37);
            lblHelp2.TabIndex = 2;
            lblHelp2.TabStop = true;
            lblHelp2.Text = resources.GetString("lblHelp2.Text");
            lblHelp2.UseCompatibleTextRendering = true;
            lblHelp2.LinkClicked += lblHelp2_LinkClicked;
            // 
            // lblHelp4
            // 
            lblHelp4.AutoSize = true;
            lblHelp4.Location = new Point(12, 206);
            lblHelp4.MaximumSize = new Size(751, 0);
            lblHelp4.Name = "lblHelp4";
            lblHelp4.Size = new Size(744, 45);
            lblHelp4.TabIndex = 3;
            lblHelp4.Text = resources.GetString("lblHelp4.Text");
            // 
            // lblHelp5
            // 
            lblHelp5.AutoSize = true;
            lblHelp5.Location = new Point(12, 268);
            lblHelp5.MaximumSize = new Size(751, 0);
            lblHelp5.Name = "lblHelp5";
            lblHelp5.Size = new Size(730, 30);
            lblHelp5.TabIndex = 4;
            lblHelp5.Text = "Once you have setup the plug in the Tapo app, go to the device settings and select \"Device Info\" to get the IP address of the plug on your local home network.";
            // 
            // lblHelp6
            // 
            lblHelp6.AutoSize = true;
            lblHelp6.Location = new Point(12, 314);
            lblHelp6.MaximumSize = new Size(751, 0);
            lblHelp6.Name = "lblHelp6";
            lblHelp6.Size = new Size(720, 45);
            lblHelp6.TabIndex = 5;
            lblHelp6.Text = resources.GetString("lblHelp6.Text");
            // 
            // lblHelp7
            // 
            lblHelp7.AutoSize = true;
            lblHelp7.Location = new Point(12, 375);
            lblHelp7.MaximumSize = new Size(751, 0);
            lblHelp7.Name = "lblHelp7";
            lblHelp7.Size = new Size(522, 15);
            lblHelp7.TabIndex = 6;
            lblHelp7.Text = "If you do not see a plug status (On or Off), you may have the wrong IP address, or a network error.";
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 418);
            Controls.Add(lblHelp7);
            Controls.Add(lblHelp6);
            Controls.Add(lblHelp5);
            Controls.Add(lblHelp4);
            Controls.Add(lblHelp2);
            Controls.Add(lblHelp1);
            Controls.Add(lblHelp3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Help";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Help";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHelp3;
        private Label lblHelp1;
        private LinkLabel lblHelp2;
        private Label lblHelp4;
        private Label lblHelp5;
        private Label lblHelp6;
        private Label lblHelp7;
    }
}