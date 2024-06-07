namespace Comandas
{
    partial class FrmComandaCad
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
            groupBox1 = new GroupBox();
            airButton1 = new ReaLTaiizor.Controls.AirButton();
            metroButton1 = new ReaLTaiizor.Controls.MetroButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(metroButton1);
            groupBox1.Controls.Add(airButton1);
            groupBox1.Location = new Point(46, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(676, 316);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // airButton1
            // 
            airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            airButton1.Font = new Font("Segoe UI", 9F);
            airButton1.Image = null;
            airButton1.Location = new Point(3, 23);
            airButton1.Name = "airButton1";
            airButton1.NoRounding = false;
            airButton1.Size = new Size(125, 56);
            airButton1.TabIndex = 0;
            airButton1.Text = "airButton1";
            airButton1.Transparent = false;
            // 
            // metroButton1
            // 
            metroButton1.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            metroButton1.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            metroButton1.DisabledForeColor = Color.Gray;
            metroButton1.Font = new Font("Microsoft Sans Serif", 10F);
            metroButton1.HoverBorderColor = Color.FromArgb(95, 207, 255);
            metroButton1.HoverColor = Color.FromArgb(95, 207, 255);
            metroButton1.HoverTextColor = Color.White;
            metroButton1.IsDerivedStyle = true;
            metroButton1.Location = new Point(182, 137);
            metroButton1.Name = "metroButton1";
            metroButton1.NormalBorderColor = Color.FromArgb(65, 177, 225);
            metroButton1.NormalColor = Color.FromArgb(65, 177, 225);
            metroButton1.NormalTextColor = Color.White;
            metroButton1.PressBorderColor = Color.FromArgb(35, 147, 195);
            metroButton1.PressColor = Color.FromArgb(35, 147, 195);
            metroButton1.PressTextColor = Color.White;
            metroButton1.Size = new Size(186, 86);
            metroButton1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroButton1.StyleManager = null;
            metroButton1.TabIndex = 1;
            metroButton1.Text = "metroButton1";
            metroButton1.ThemeAuthor = "Taiizor";
            metroButton1.ThemeName = "MetroLight";
            // 
            // FrmComandaCad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FrmComandaCad";
            Text = "FrmComandaCad";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MetroButton metroButton1;
        private ReaLTaiizor.Controls.AirButton airButton1;
    }
}