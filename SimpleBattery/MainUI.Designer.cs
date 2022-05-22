
namespace SimpleBattery
{
    partial class UI
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
            this.components = new System.ComponentModel.Container();
            this.VisBatteryHeader = new System.Windows.Forms.Label();
            this.NumBatteryHeader = new System.Windows.Forms.Label();
            this.UIHeader = new System.Windows.Forms.Label();
            this.Github = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.Alerts = new System.Windows.Forms.Label();
            this.Header25 = new System.Windows.Forms.Label();
            this.Widgets = new System.Windows.Forms.Label();
            this.More = new System.Windows.Forms.Label();
            this.Toggle25 = new System.Windows.Forms.Button();
            this.ToggleNumBattery = new System.Windows.Forms.Button();
            this.ToggleVisualBattery = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.ToggleChargeStatus = new System.Windows.Forms.Button();
            this.CharBatteryHeader = new System.Windows.Forms.Label();
            this.Toggle50 = new System.Windows.Forms.Button();
            this.Header50 = new System.Windows.Forms.Label();
            this.Toggle75 = new System.Windows.Forms.Button();
            this.Header75 = new System.Windows.Forms.Label();
            this.Toggle100 = new System.Windows.Forms.Button();
            this.Header100 = new System.Windows.Forms.Label();
            this.AlertChecks = new System.Windows.Forms.Timer(this.components);
            this.ToggleRemain = new System.Windows.Forms.Button();
            this.RemainHeader = new System.Windows.Forms.Label();
            this.ToggleEnableAlerts = new System.Windows.Forms.Button();
            this.AlertsEnableHeader = new System.Windows.Forms.Label();
            this.HomePercent = new System.Windows.Forms.Label();
            this.GetPercent = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // VisBatteryHeader
            // 
            this.VisBatteryHeader.AutoSize = true;
            this.VisBatteryHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.VisBatteryHeader.ForeColor = System.Drawing.Color.White;
            this.VisBatteryHeader.Location = new System.Drawing.Point(353, 147);
            this.VisBatteryHeader.Name = "VisBatteryHeader";
            this.VisBatteryHeader.Size = new System.Drawing.Size(159, 30);
            this.VisBatteryHeader.TabIndex = 47;
            this.VisBatteryHeader.Text = "Visual Battery";
            // 
            // NumBatteryHeader
            // 
            this.NumBatteryHeader.AutoSize = true;
            this.NumBatteryHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.NumBatteryHeader.ForeColor = System.Drawing.Color.White;
            this.NumBatteryHeader.Location = new System.Drawing.Point(353, 92);
            this.NumBatteryHeader.Name = "NumBatteryHeader";
            this.NumBatteryHeader.Size = new System.Drawing.Size(247, 30);
            this.NumBatteryHeader.TabIndex = 45;
            this.NumBatteryHeader.Text = "Numbered Percentage";
            // 
            // UIHeader
            // 
            this.UIHeader.AutoSize = true;
            this.UIHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.UIHeader.ForeColor = System.Drawing.Color.White;
            this.UIHeader.Location = new System.Drawing.Point(17, 14);
            this.UIHeader.Name = "UIHeader";
            this.UIHeader.Size = new System.Drawing.Size(189, 38);
            this.UIHeader.TabIndex = 49;
            this.UIHeader.Text = "SimplBattery";
            // 
            // Github
            // 
            this.Github.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Github.FlatAppearance.BorderSize = 0;
            this.Github.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Github.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Github.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Github.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Github.ForeColor = System.Drawing.Color.White;
            this.Github.Location = new System.Drawing.Point(264, 362);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(94, 45);
            this.Github.TabIndex = 51;
            this.Github.Text = "Github";
            this.Github.UseVisualStyleBackColor = true;
            this.Github.Click += new System.EventHandler(this.Github_Click);
            // 
            // Restart
            // 
            this.Restart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Restart.FlatAppearance.BorderSize = 0;
            this.Restart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Restart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Restart.ForeColor = System.Drawing.Color.White;
            this.Restart.Location = new System.Drawing.Point(15, 362);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(96, 45);
            this.Restart.TabIndex = 50;
            this.Restart.Text = "Restart";
            this.Restart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Alerts
            // 
            this.Alerts.AutoSize = true;
            this.Alerts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Alerts.ForeColor = System.Drawing.Color.Gray;
            this.Alerts.Location = new System.Drawing.Point(19, 63);
            this.Alerts.Name = "Alerts";
            this.Alerts.Size = new System.Drawing.Size(132, 25);
            this.Alerts.TabIndex = 52;
            this.Alerts.Text = "Battery Alerts";
            // 
            // Header25
            // 
            this.Header25.AutoSize = true;
            this.Header25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Header25.ForeColor = System.Drawing.Color.White;
            this.Header25.Location = new System.Drawing.Point(19, 143);
            this.Header25.Name = "Header25";
            this.Header25.Size = new System.Drawing.Size(142, 30);
            this.Header25.TabIndex = 53;
            this.Header25.Text = "25% Battery";
            // 
            // Widgets
            // 
            this.Widgets.AutoSize = true;
            this.Widgets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Widgets.ForeColor = System.Drawing.Color.Gray;
            this.Widgets.Location = new System.Drawing.Point(353, 63);
            this.Widgets.Name = "Widgets";
            this.Widgets.Size = new System.Drawing.Size(82, 25);
            this.Widgets.TabIndex = 55;
            this.Widgets.Text = "Widgets";
            // 
            // More
            // 
            this.More.AutoSize = true;
            this.More.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.More.ForeColor = System.Drawing.Color.Gray;
            this.More.Location = new System.Drawing.Point(19, 339);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(57, 25);
            this.More.TabIndex = 56;
            this.More.Text = "More";
            // 
            // Toggle25
            // 
            this.Toggle25.BackgroundImage = global::SimplBattery.Properties.Resources.icons8_toggle_off_96;
            this.Toggle25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Toggle25.FlatAppearance.BorderSize = 0;
            this.Toggle25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Toggle25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Toggle25.Location = new System.Drawing.Point(269, 137);
            this.Toggle25.Name = "Toggle25";
            this.Toggle25.Size = new System.Drawing.Size(49, 49);
            this.Toggle25.TabIndex = 54;
            this.Toggle25.UseVisualStyleBackColor = true;
            this.Toggle25.Click += new System.EventHandler(this.AlertToggle_Click);
            // 
            // ToggleNumBattery
            // 
            this.ToggleNumBattery.BackgroundImage = global::SimplBattery.Properties.Resources.icons8_toggle_off_96;
            this.ToggleNumBattery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToggleNumBattery.FlatAppearance.BorderSize = 0;
            this.ToggleNumBattery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ToggleNumBattery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleNumBattery.Location = new System.Drawing.Point(653, 86);
            this.ToggleNumBattery.Name = "ToggleNumBattery";
            this.ToggleNumBattery.Size = new System.Drawing.Size(49, 49);
            this.ToggleNumBattery.TabIndex = 48;
            this.ToggleNumBattery.UseVisualStyleBackColor = true;
            this.ToggleNumBattery.Click += new System.EventHandler(this.ToggleNumBattery_Click);
            // 
            // ToggleVisualBattery
            // 
            this.ToggleVisualBattery.BackgroundImage = global::SimplBattery.Properties.Resources.icons8_toggle_off_96;
            this.ToggleVisualBattery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToggleVisualBattery.FlatAppearance.BorderSize = 0;
            this.ToggleVisualBattery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ToggleVisualBattery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleVisualBattery.Location = new System.Drawing.Point(653, 139);
            this.ToggleVisualBattery.Name = "ToggleVisualBattery";
            this.ToggleVisualBattery.Size = new System.Drawing.Size(49, 49);
            this.ToggleVisualBattery.TabIndex = 46;
            this.ToggleVisualBattery.UseVisualStyleBackColor = true;
            this.ToggleVisualBattery.Click += new System.EventHandler(this.ToggleVisualBattery_Click);
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(117, 362);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(63, 45);
            this.Exit.TabIndex = 57;
            this.Exit.Text = "Exit";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Help
            // 
            this.Help.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Help.FlatAppearance.BorderSize = 0;
            this.Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Help.ForeColor = System.Drawing.Color.White;
            this.Help.Location = new System.Drawing.Point(186, 362);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(80, 45);
            this.Help.TabIndex = 58;
            this.Help.Text = "Help";
            this.Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // ToggleChargeStatus
            // 
            this.ToggleChargeStatus.BackgroundImage = global::SimplBattery.Properties.Resources.icons8_toggle_off_96;
            this.ToggleChargeStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToggleChargeStatus.FlatAppearance.BorderSize = 0;
            this.ToggleChargeStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ToggleChargeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleChargeStatus.Location = new System.Drawing.Point(653, 190);
            this.ToggleChargeStatus.Name = "ToggleChargeStatus";
            this.ToggleChargeStatus.Size = new System.Drawing.Size(49, 49);
            this.ToggleChargeStatus.TabIndex = 59;
            this.ToggleChargeStatus.UseVisualStyleBackColor = true;
            // 
            // CharBatteryHeader
            // 
            this.CharBatteryHeader.AutoSize = true;
            this.CharBatteryHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.CharBatteryHeader.ForeColor = System.Drawing.Color.White;
            this.CharBatteryHeader.Location = new System.Drawing.Point(353, 198);
            this.CharBatteryHeader.Name = "CharBatteryHeader";
            this.CharBatteryHeader.Size = new System.Drawing.Size(157, 30);
            this.CharBatteryHeader.TabIndex = 60;
            this.CharBatteryHeader.Text = "Charge Status";
            // 
            // Toggle50
            // 
            this.Toggle50.BackgroundImage = global::SimplBattery.Properties.Resources.icons8_toggle_off_96;
            this.Toggle50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Toggle50.FlatAppearance.BorderSize = 0;
            this.Toggle50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Toggle50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Toggle50.Location = new System.Drawing.Point(269, 190);
            this.Toggle50.Name = "Toggle50";
            this.Toggle50.Size = new System.Drawing.Size(49, 49);
            this.Toggle50.TabIndex = 62;
            this.Toggle50.UseVisualStyleBackColor = true;
            // 
            // Header50
            // 
            this.Header50.AutoSize = true;
            this.Header50.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Header50.ForeColor = System.Drawing.Color.White;
            this.Header50.Location = new System.Drawing.Point(19, 196);
            this.Header50.Name = "Header50";
            this.Header50.Size = new System.Drawing.Size(142, 30);
            this.Header50.TabIndex = 61;
            this.Header50.Text = "50% Battery";
            // 
            // Toggle75
            // 
            this.Toggle75.BackgroundImage = global::SimplBattery.Properties.Resources.icons8_toggle_off_96;
            this.Toggle75.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Toggle75.FlatAppearance.BorderSize = 0;
            this.Toggle75.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Toggle75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Toggle75.Location = new System.Drawing.Point(269, 241);
            this.Toggle75.Name = "Toggle75";
            this.Toggle75.Size = new System.Drawing.Size(49, 49);
            this.Toggle75.TabIndex = 64;
            this.Toggle75.UseVisualStyleBackColor = true;
            // 
            // Header75
            // 
            this.Header75.AutoSize = true;
            this.Header75.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Header75.ForeColor = System.Drawing.Color.White;
            this.Header75.Location = new System.Drawing.Point(19, 247);
            this.Header75.Name = "Header75";
            this.Header75.Size = new System.Drawing.Size(142, 30);
            this.Header75.TabIndex = 63;
            this.Header75.Text = "75% Battery";
            // 
            // Toggle100
            // 
            this.Toggle100.BackgroundImage = global::SimplBattery.Properties.Resources.icons8_toggle_off_96;
            this.Toggle100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Toggle100.FlatAppearance.BorderSize = 0;
            this.Toggle100.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Toggle100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Toggle100.Location = new System.Drawing.Point(269, 290);
            this.Toggle100.Name = "Toggle100";
            this.Toggle100.Size = new System.Drawing.Size(49, 49);
            this.Toggle100.TabIndex = 66;
            this.Toggle100.UseVisualStyleBackColor = true;
            // 
            // Header100
            // 
            this.Header100.AutoSize = true;
            this.Header100.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Header100.ForeColor = System.Drawing.Color.White;
            this.Header100.Location = new System.Drawing.Point(19, 296);
            this.Header100.Name = "Header100";
            this.Header100.Size = new System.Drawing.Size(155, 30);
            this.Header100.TabIndex = 65;
            this.Header100.Text = "100% Battery";
            // 
            // AlertChecks
            // 
            this.AlertChecks.Interval = 1;
            this.AlertChecks.Tick += new System.EventHandler(this.AlertChecks_Tick);
            // 
            // ToggleRemain
            // 
            this.ToggleRemain.BackgroundImage = global::SimplBattery.Properties.Resources.icons8_toggle_off_96;
            this.ToggleRemain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToggleRemain.FlatAppearance.BorderSize = 0;
            this.ToggleRemain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ToggleRemain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleRemain.Location = new System.Drawing.Point(653, 239);
            this.ToggleRemain.Name = "ToggleRemain";
            this.ToggleRemain.Size = new System.Drawing.Size(49, 49);
            this.ToggleRemain.TabIndex = 67;
            this.ToggleRemain.UseVisualStyleBackColor = true;
            // 
            // RemainHeader
            // 
            this.RemainHeader.AutoSize = true;
            this.RemainHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.RemainHeader.ForeColor = System.Drawing.Color.White;
            this.RemainHeader.Location = new System.Drawing.Point(353, 247);
            this.RemainHeader.Name = "RemainHeader";
            this.RemainHeader.Size = new System.Drawing.Size(206, 30);
            this.RemainHeader.TabIndex = 68;
            this.RemainHeader.Text = "Remaining Battery";
            // 
            // ToggleEnableAlerts
            // 
            this.ToggleEnableAlerts.BackgroundImage = global::SimplBattery.Properties.Resources.icons8_toggle_on_96;
            this.ToggleEnableAlerts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToggleEnableAlerts.FlatAppearance.BorderSize = 0;
            this.ToggleEnableAlerts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ToggleEnableAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleEnableAlerts.Location = new System.Drawing.Point(269, 86);
            this.ToggleEnableAlerts.Name = "ToggleEnableAlerts";
            this.ToggleEnableAlerts.Size = new System.Drawing.Size(49, 49);
            this.ToggleEnableAlerts.TabIndex = 70;
            this.ToggleEnableAlerts.UseVisualStyleBackColor = true;
            // 
            // AlertsEnableHeader
            // 
            this.AlertsEnableHeader.AutoSize = true;
            this.AlertsEnableHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.AlertsEnableHeader.ForeColor = System.Drawing.Color.White;
            this.AlertsEnableHeader.Location = new System.Drawing.Point(19, 92);
            this.AlertsEnableHeader.Name = "AlertsEnableHeader";
            this.AlertsEnableHeader.Size = new System.Drawing.Size(150, 30);
            this.AlertsEnableHeader.TabIndex = 69;
            this.AlertsEnableHeader.Text = "Enable Alerts";
            // 
            // HomePercent
            // 
            this.HomePercent.AutoSize = true;
            this.HomePercent.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.HomePercent.ForeColor = System.Drawing.Color.White;
            this.HomePercent.Location = new System.Drawing.Point(549, 316);
            this.HomePercent.Name = "HomePercent";
            this.HomePercent.Size = new System.Drawing.Size(221, 93);
            this.HomePercent.TabIndex = 71;
            this.HomePercent.Text = "100%";
            // 
            // GetPercent
            // 
            this.GetPercent.Interval = 1;
            this.GetPercent.Tick += new System.EventHandler(this.GetPercent_Tick);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(724, 422);
            this.Controls.Add(this.HomePercent);
            this.Controls.Add(this.ToggleEnableAlerts);
            this.Controls.Add(this.AlertsEnableHeader);
            this.Controls.Add(this.ToggleRemain);
            this.Controls.Add(this.RemainHeader);
            this.Controls.Add(this.Toggle100);
            this.Controls.Add(this.Header100);
            this.Controls.Add(this.Toggle75);
            this.Controls.Add(this.Header75);
            this.Controls.Add(this.Toggle50);
            this.Controls.Add(this.Header50);
            this.Controls.Add(this.ToggleChargeStatus);
            this.Controls.Add(this.CharBatteryHeader);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.More);
            this.Controls.Add(this.Widgets);
            this.Controls.Add(this.Toggle25);
            this.Controls.Add(this.Header25);
            this.Controls.Add(this.Alerts);
            this.Controls.Add(this.Github);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.UIHeader);
            this.Controls.Add(this.ToggleNumBattery);
            this.Controls.Add(this.ToggleVisualBattery);
            this.Controls.Add(this.VisBatteryHeader);
            this.Controls.Add(this.NumBatteryHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UI";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.Text = "SimplBattery";
            this.Load += new System.EventHandler(this.UI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToggleVisualBattery;
        private System.Windows.Forms.Label VisBatteryHeader;
        private System.Windows.Forms.Label NumBatteryHeader;
        private System.Windows.Forms.Button ToggleNumBattery;
        private System.Windows.Forms.Label UIHeader;
        private System.Windows.Forms.Button Github;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Label Alerts;
        private System.Windows.Forms.Button Toggle25;
        private System.Windows.Forms.Label Header25;
        private System.Windows.Forms.Label Widgets;
        private System.Windows.Forms.Label More;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button ToggleChargeStatus;
        private System.Windows.Forms.Label CharBatteryHeader;
        private System.Windows.Forms.Button Toggle50;
        private System.Windows.Forms.Label Header50;
        private System.Windows.Forms.Button Toggle75;
        private System.Windows.Forms.Label Header75;
        private System.Windows.Forms.Button Toggle100;
        private System.Windows.Forms.Label Header100;
        private System.Windows.Forms.Timer AlertChecks;
        private System.Windows.Forms.Button ToggleRemain;
        private System.Windows.Forms.Label RemainHeader;
        private System.Windows.Forms.Button ToggleEnableAlerts;
        private System.Windows.Forms.Label AlertsEnableHeader;
        private System.Windows.Forms.Label HomePercent;
        private System.Windows.Forms.Timer GetPercent;
    }
}

