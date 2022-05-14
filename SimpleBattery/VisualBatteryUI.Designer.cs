
namespace SimplBattery
{
    partial class VisualBatteryUI
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
            this.BatteryBar = new System.Windows.Forms.ProgressBar();
            this.UpdateBattery = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BatteryBar
            // 
            this.BatteryBar.Location = new System.Drawing.Point(-2, -1);
            this.BatteryBar.Name = "BatteryBar";
            this.BatteryBar.Size = new System.Drawing.Size(229, 111);
            this.BatteryBar.TabIndex = 0;
            // 
            // UpdateBattery
            // 
            this.UpdateBattery.Interval = 1;
            this.UpdateBattery.Tick += new System.EventHandler(this.UpdateBattery_Tick);
            // 
            // VisualBatteryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(227, 108);
            this.ControlBox = false;
            this.Controls.Add(this.BatteryBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisualBatteryUI";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Battery";
            this.Load += new System.EventHandler(this.VisualBatteryUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar BatteryBar;
        private System.Windows.Forms.Timer UpdateBattery;
    }
}