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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.debuff = new System.Windows.Forms.CheckBox();
            this.bossHP = new System.Windows.Forms.TextBox();
            this.tankDPS = new System.Windows.Forms.TextBox();
            this.numDPS = new System.Windows.Forms.NumericUpDown();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.output = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDPS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boss Health (in millions)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tank DPS (in thousands)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of DPS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // debuff
            // 
            this.debuff.AutoSize = true;
            this.debuff.Checked = true;
            this.debuff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.debuff.Location = new System.Drawing.Point(9, 62);
            this.debuff.Name = "debuff";
            this.debuff.Size = new System.Drawing.Size(87, 17);
            this.debuff.TabIndex = 4;
            this.debuff.Text = "Debuff (30%)";
            this.debuff.UseVisualStyleBackColor = true;
            this.debuff.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bossHP
            // 
            this.bossHP.Location = new System.Drawing.Point(136, 6);
            this.bossHP.Name = "bossHP";
            this.bossHP.Size = new System.Drawing.Size(80, 20);
            this.bossHP.TabIndex = 5;
            // 
            // tankDPS
            // 
            this.tankDPS.Location = new System.Drawing.Point(136, 33);
            this.tankDPS.Name = "tankDPS";
            this.tankDPS.Size = new System.Drawing.Size(80, 20);
            this.tankDPS.TabIndex = 6;
            // 
            // numDPS
            // 
            this.numDPS.Location = new System.Drawing.Point(94, 94);
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
            this.numDPS.Size = new System.Drawing.Size(34, 20);
            this.numDPS.TabIndex = 7;
            this.numDPS.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(228, 161);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 19;
            this.lineShape1.X2 = 210;
            this.lineShape1.Y1 = 130;
            this.lineShape1.Y2 = 130;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(105, 141);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(19, 13);
            this.output.TabIndex = 9;
            this.output.Text = "----";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "TTK";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 161);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.numDPS);
            this.Controls.Add(this.tankDPS);
            this.Controls.Add(this.bossHP);
            this.Controls.Add(this.debuff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DPS Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}

