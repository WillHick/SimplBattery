using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace SimplBattery
{
    public partial class NumberedPercentageUI : Form
    {
        public NumberedPercentageUI()
        {
            InitializeComponent();
        }
        private void NumberedPercentageUI_Load(object sender, EventArgs e)
        {
            //Set Window Pos
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - 8 - base.Size.Width, workingArea.Bottom - 6 - base.Size.Height);

            UpdateOutput.Start();
        }
        private void UpdateOutput_Tick(object sender, EventArgs e)
        {
            //Set Output
            PowerStatus PS = SystemInformation.PowerStatus;
            int PSOutput = (int)(PS.BatteryLifePercent * 100);
            Output.Text = (PSOutput + "%");
        }
    }
}
