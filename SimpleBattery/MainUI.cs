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
using System.Diagnostics;

namespace SimpleBattery
{
    public partial class UI : Form
    {
        SimplBattery.NumberedPercentageUI NPUI = new SimplBattery.NumberedPercentageUI();
        SimplBattery.VisualBatteryUI VBUI = new SimplBattery.VisualBatteryUI();

        public UI()
        {
            InitializeComponent();
        }
        private void UI_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            AlertChecks.Start();
            GetPercent.Start();

            //Not Visible            
            NPUI.Visible = false;
            VBUI.Visible = false;
        }

        //Toggles
        private void AlertToggle_Click(object sender, EventArgs e)
        {

        }
        private void ToggleNumBattery_Click(object sender, EventArgs e)
        {
            if (NPUI.Visible == false)
            {
                NPUI.Visible = true;
                NPUI.Show();

                ToggleNumBattery.BackgroundImage = SimplBattery.Properties.Resources.icons8_toggle_on_96;
            }
            else if (NPUI.Visible == true)
            {
                ToggleNumBattery.BackgroundImage = SimplBattery.Properties.Resources.icons8_toggle_off_96;

                NPUI.Visible = false;
                NPUI.Hide();
            }
        }
        private void ToggleVisualBattery_Click(object sender, EventArgs e)
        {
            if (VBUI.Visible == false)
            {
                VBUI.Visible = true;
                VBUI.Show();

                ToggleVisualBattery.BackgroundImage = SimplBattery.Properties.Resources.icons8_toggle_on_96;
            }
            else if (VBUI.Visible == true)
            {
                ToggleVisualBattery.BackgroundImage = SimplBattery.Properties.Resources.icons8_toggle_off_96;

                VBUI.Visible = false;
                VBUI.Hide();
            }
        }
        private void Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/willhick/SimplBattery");
        }
        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By WillHick" + Environment.NewLine + "Icons By icons8 (Icons Links Are On The Github ReadME - As The Site Says)");
        }

        //Ticks
        private void AlertChecks_Tick(object sender, EventArgs e)
        {
            //Set Output
            PowerStatus PS = SystemInformation.PowerStatus;
            int PSOutput = (int)(PS.BatteryLifePercent * 100);

            if (PSOutput == 100)
            {
                MessageBox.Show("100");
            }
            if (PSOutput == 75)
            {
                MessageBox.Show("75");
            }
            if (PSOutput == 50)
            {
                MessageBox.Show("50");
            }
            if (PSOutput == 25)
            {
                MessageBox.Show("25");
            }
        }

        private void GetPercent_Tick(object sender, EventArgs e)
        {
            //Set Output
            PowerStatus PS = SystemInformation.PowerStatus;
            int PSOutput = (int)(PS.BatteryLifePercent * 100);

            HomePercent.Text = (PSOutput + "%");

            if (HomePercent.Text == "100%")
            {
                //Shift POS
            }
        }
    }
}
