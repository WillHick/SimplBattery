
namespace SimplBattery
{
    partial class NumberedPercentageUI
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
            this.Output = new System.Windows.Forms.Label();
            this.UpdateOutput = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.BackColor = System.Drawing.Color.Transparent;
            this.Output.Font = new System.Drawing.Font("Segoe UI Symbol", 35F);
            this.Output.ForeColor = System.Drawing.Color.White;
            this.Output.Location = new System.Drawing.Point(11, 4);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(173, 93);
            this.Output.TabIndex = 0;
            this.Output.Text = "99%";
            // 
            // UpdateOutput
            // 
            this.UpdateOutput.Interval = 1;
            this.UpdateOutput.Tick += new System.EventHandler(this.UpdateOutput_Tick);
            // 
            // NumberedPercentageUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(227, 108);
            this.ControlBox = false;
            this.Controls.Add(this.Output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NumberedPercentageUI";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Percentage";
            this.Load += new System.EventHandler(this.NumberedPercentageUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Timer UpdateOutput;
    }
}