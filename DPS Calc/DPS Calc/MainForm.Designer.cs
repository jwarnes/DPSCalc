namespace DPS_Calc
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.debuff = new System.Windows.Forms.CheckBox();
            this.bossHP = new System.Windows.Forms.TextBox();
            this.tankDPS = new System.Windows.Forms.TextBox();
            this.numDPS = new System.Windows.Forms.NumericUpDown();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textTTK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numDPS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boss &Health (in millions)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ta&nk DPS (in thousands)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of &DPS";
            // 
            // debuff
            // 
            this.debuff.AutoSize = true;
            this.debuff.Checked = true;
            this.debuff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.debuff.Location = new System.Drawing.Point(19, 76);
            this.debuff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.debuff.Name = "debuff";
            this.debuff.Size = new System.Drawing.Size(114, 21);
            this.debuff.TabIndex = 8;
            this.debuff.Text = "De&buff (30%)";
            this.toolTip1.SetToolTip(this.debuff, "Whether or not to apply the Dragon Soul debuff to the health pool.");
            this.debuff.UseVisualStyleBackColor = true;
            // 
            // bossHP
            // 
            this.bossHP.Location = new System.Drawing.Point(181, 7);
            this.bossHP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bossHP.Name = "bossHP";
            this.bossHP.Size = new System.Drawing.Size(105, 22);
            this.bossHP.TabIndex = 1;
            this.bossHP.Text = "85";
            this.toolTip1.SetToolTip(this.bossHP, "Amount of health that needs to be burned through in millions, (e.g. 85 for 85,000" +
                    ",000)");
            // 
            // tankDPS
            // 
            this.tankDPS.Location = new System.Drawing.Point(181, 41);
            this.tankDPS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tankDPS.Name = "tankDPS";
            this.tankDPS.Size = new System.Drawing.Size(105, 22);
            this.tankDPS.TabIndex = 3;
            this.tankDPS.Text = "34";
            this.toolTip1.SetToolTip(this.tankDPS, "Estimated total tank contribution of DPS, measured in thousands (e.g. 34 for 34k)" +
                    "");
            // 
            // numDPS
            // 
            this.numDPS.Location = new System.Drawing.Point(125, 116);
            this.numDPS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numDPS.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDPS.Name = "numDPS";
            this.numDPS.Size = new System.Drawing.Size(45, 22);
            this.numDPS.TabIndex = 7;
            this.toolTip1.SetToolTip(this.numDPS, "Number of dedicated DPS players to distribute the damage burden to.");
            this.numDPS.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblOutput.Location = new System.Drawing.Point(9, 165);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(283, 26);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.Text = "----";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculate.Location = new System.Drawing.Point(181, 112);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(103, 28);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textTTK
            // 
            this.textTTK.Location = new System.Drawing.Point(181, 74);
            this.textTTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textTTK.Name = "textTTK";
            this.textTTK.Size = new System.Drawing.Size(105, 22);
            this.textTTK.TabIndex = 5;
            this.textTTK.Text = "360";
            this.toolTip1.SetToolTip(this.textTTK, "Time-to-kill, or enrage timer. How long in seconds you have to burn through the h" +
                    "ealth pool.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "&TTK";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 80;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 40;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(304, 197);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTTK);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.numDPS);
            this.Controls.Add(this.tankDPS);
            this.Controls.Add(this.bossHP);
            this.Controls.Add(this.debuff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(322, 242);
            this.MinimumSize = new System.Drawing.Size(322, 242);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DPS Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numDPS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox debuff;
        private System.Windows.Forms.TextBox bossHP;
        private System.Windows.Forms.TextBox tankDPS;
        private System.Windows.Forms.NumericUpDown numDPS;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textTTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

