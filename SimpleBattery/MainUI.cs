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
            Process.Start("");
        }        
    }
}
