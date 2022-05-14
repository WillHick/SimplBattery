using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplBattery
{
    public partial class VisualBatteryUI : Form
    {
        public VisualBatteryUI()
        {
            InitializeComponent();
        }
        private void VisualBatteryUI_Load(object sender, EventArgs e)
        {
            //Set Window Pos
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - 8 - base.Size.Width, workingArea.Bottom - 6 - base.Size.Height);

            UpdateBattery.Start();
        }
        private void UpdateBattery_Tick(object sender, EventArgs e)
        {
            //Set Battery
            PowerStatus PS = SystemInformation.PowerStatus;
            int PSOutput = (int)(PS.BatteryLifePercent * 100);
            BatteryBar.Value = PSOutput;
        }
    }
}
