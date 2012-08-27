using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DPS_Calc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int necessaryDPS;
            int bossHP = Convert.ToInt16(this.bossHP.Text) * 1000000;
            int numDPS = (int)this.numDPS.Value;
            int tankDPS = Convert.ToInt16(this.tankDPS.Text) * 1000;
            int enrage = Convert.ToInt16(this.textTTK.Text);
            float debuff = this.debuff.Checked ? 0.3f : 0.0f;

            necessaryDPS = dpscalc.calculateNecessaryDPS(bossHP, numDPS, tankDPS, enrage, debuff);

            this.lblOutput.Text = "Required DPS per member: "+necessaryDPS.ToString();
        }
    }
}
