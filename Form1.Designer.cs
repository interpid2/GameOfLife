namespace GameOfLife
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.simBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trailCbx = new System.Windows.Forms.CheckBox();
            this.clrBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.steplbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkBtn = new System.Windows.Forms.Button();
            this.speedLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(8, 32);
            this.trackBar1.Maximum = 35;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(228, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(9, 89);
            this.trackBar2.Maximum = 999;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(227, 45);
            this.trackBar2.TabIndex = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // simBtn
            // 
            this.simBtn.Location = new System.Drawing.Point(9, 134);
            this.simBtn.Name = "simBtn";
            this.simBtn.Size = new System.Drawing.Size(227, 23);
            this.simBtn.TabIndex = 2;
            this.simBtn.Text = "Simulate";
            this.simBtn.UseVisualStyleBackColor = true;
            this.simBtn.Click += new System.EventHandler(this.simBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Glider",
            "Small Exploder",
            "Exploder",
            "10 Cell Row",
            "Lightweight spaceship",
            "Tumbler",
            "Gosper Glider Gun"});
            this.comboBox1.Location = new System.Drawing.Point(9, 236);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // trailCbx
            // 
            this.trailCbx.AutoSize = true;
            this.trailCbx.Location = new System.Drawing.Point(9, 264);
            this.trailCbx.Name = "trailCbx";
            this.trailCbx.Size = new System.Drawing.Size(103, 17);
            this.trailCbx.TabIndex = 4;
            this.trailCbx.Text = "Trail of the dead";
            this.trailCbx.UseVisualStyleBackColor = true;
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(9, 163);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(227, 23);
            this.clrBtn.TabIndex = 5;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.speedLbl);
            this.groupBox1.Controls.Add(this.steplbl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.exitBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trailCbx);
            this.groupBox1.Controls.Add(this.clrBtn);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.simBtn);
            this.groupBox1.Location = new System.Drawing.Point(539, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 286);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // steplbl
            // 
            this.steplbl.AutoSize = true;
            this.steplbl.Location = new System.Drawing.Point(156, 264);
            this.steplbl.Name = "steplbl";
            this.steplbl.Size = new System.Drawing.Size(13, 13);
            this.steplbl.TabIndex = 9;
            this.steplbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Step:";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(9, 193);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(227, 23);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select a predefined pattern:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select speed of the simulation:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select size of the matrix:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 234);
            this.label4.TabIndex = 7;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // linkBtn
            // 
            this.linkBtn.Location = new System.Drawing.Point(539, 243);
            this.linkBtn.Name = "linkBtn";
            this.linkBtn.Size = new System.Drawing.Size(242, 23);
            this.linkBtn.TabIndex = 8;
            this.linkBtn.Text = "Links";
            this.linkBtn.UseVisualStyleBackColor = true;
            this.linkBtn.Click += new System.EventHandler(this.linkBtn_Click);
            // 
            // speedLbl
            // 
            this.speedLbl.AutoSize = true;
            this.speedLbl.Location = new System.Drawing.Point(152, 73);
            this.speedLbl.Name = "speedLbl";
            this.speedLbl.Size = new System.Drawing.Size(35, 13);
            this.speedLbl.TabIndex = 10;
            this.speedLbl.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 561);
            this.ControlBox = false;
            this.Controls.Add(this.linkBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conway\'s Game of life";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button simBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox trailCbx;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button linkBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label steplbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label speedLbl;
    }
}

