using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 0;
            trackBar2.Value = 900;
            speedLbl.Text = (trackBar2.Maximum - trackBar2.Value + 1).ToString()+"ms per step";
            setupPictureboxes();
        }
        PictureBox[,] storage;
        bool[,] previousValues;
        bool[,] currentValues;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            setupPictureboxes();
            steplbl.Text = "0";
        }

        private void setupPictureboxes()
        {
            if (storage != null)
            {
                //delete all previously generated pictureboxes
                foreach (PictureBox deleteBox in storage)
                {
                    this.Controls.Remove(deleteBox);
                    deleteBox.Dispose();
                }
            }
            int x = 12, y = 12, size = (int)Math.Floor((526f - 2 * (10 + trackBar1.Value)) / (10 + trackBar1.Value));
            storage = new PictureBox[10 + trackBar1.Value, 10 + trackBar1.Value];
            previousValues = new bool[10 + trackBar1.Value, 10 + trackBar1.Value];
            currentValues = new bool[10 + trackBar1.Value, 10 + trackBar1.Value];
            for (int i = 0; i < 10 + trackBar1.Value; i++)
            {
                for (int j = 0; j < 10 + trackBar1.Value; j++)
                {
                    PictureBox temp = new PictureBox();
                    temp.Location = new Point(x, y);
                    temp.Size = new Size(size, size);
                    temp.BackColor = Color.DarkGray;
                    temp.Click += (sendr, eTemp) =>
                    {
                        if (temp.BackColor == Color.DarkGray) temp.BackColor = Color.Yellow;
                        else temp.BackColor = Color.DarkGray;
                    };
                    storage[i, j] = temp;
                    this.Controls.Add(temp);

                    y += size + 2;
                }
                x += size + 2;
                y = 12;
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            speedLbl.Text = (trackBar2.Maximum - trackBar2.Value + 1).ToString()+"ms per step";
            timer1.Interval = trackBar2.Maximum - trackBar2.Value+1;
        }

        private void simBtn_Click(object sender, EventArgs e)
        {
            if (simBtn.Text == "Simulate")
            {
                simBtn.Text = "Stop simulation";
                for (int i = 0; i < Math.Sqrt(storage.Length); i++)
                {
                    for (int j = 0; j < Math.Sqrt(storage.Length); j++)
                    {
                        if (storage[i, j].BackColor == Color.Yellow) currentValues[i, j] = true;
                        else currentValues[i, j] = false;
                    }
                }
                //steplbl.Text = "0";
                timer1.Enabled = true;
            }
            else
            {
                simBtn.Text = "Simulate";
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int brojac;
            int boundary = (int)Math.Sqrt(storage.Length) - 1;
            Array.Copy(currentValues, previousValues, currentValues.Length);
            for (int i = 0; i < Math.Sqrt(storage.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(storage.Length); j++)
                {
                    brojac = 0;
                    if (i > 0)
                    {
                        if (previousValues[i - 1, j] == true) brojac++;
                        if (j > 0) if (previousValues[i - 1, j - 1] == true) brojac++;
                        if (j < boundary) if (previousValues[i - 1, j + 1] == true) brojac++;
                    }
                    if (i < boundary)
                    {
                        if (previousValues[i + 1, j] == true) brojac++;
                        if (j > 0) if (previousValues[i + 1, j - 1] == true) brojac++;
                        if (j < boundary) if (previousValues[i + 1, j + 1] == true) brojac++;
                        if (j > 0) if (previousValues[i, j - 1] == true) brojac++;
                        if (j < boundary) if (previousValues[i, j + 1] == true) brojac++;

                    }

                    if ((brojac < 2 || brojac > 3) && previousValues[i, j] == true) currentValues[i, j] = false;
                    else if (previousValues[i, j] == false && brojac == 3) currentValues[i, j] = true;

                    if (currentValues[i, j] == true) storage[i, j].BackColor = Color.Yellow;
                    else if (previousValues[i, j] == true && currentValues[i, j] == false && trailCbx.Checked == true) storage[i, j].BackColor = Color.DarkGreen;
                    else if (storage[i, j].BackColor != Color.DarkGreen) storage[i, j].BackColor = Color.DarkGray;
                }
            }
            steplbl.Text = (int.Parse(steplbl.Text) + 1).ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            simBtn.Text = "Simulate";
            timer1.Enabled = false;
            steplbl.Text = "0";
            if (comboBox1.SelectedIndex == 0) //glider
            {
                if (trackBar1.Value != 15)
                {
                    trackBar1.Value = 15;
                    setupPictureboxes();
                }
                else
                {
                    foreach (PictureBox temp in storage) temp.BackColor = Color.DarkGray;
                }
                storage[2, 1].BackColor = Color.Yellow;
                storage[3, 2].BackColor = Color.Yellow;
                storage[1, 3].BackColor = Color.Yellow;
                storage[2, 3].BackColor = Color.Yellow;
                storage[3, 3].BackColor = Color.Yellow;
            }
            else if (comboBox1.SelectedIndex == 1) //small exploder
            {
                if (trackBar1.Value != 5)
                {
                    trackBar1.Value = 5;
                    setupPictureboxes();
                }
                else
                {
                    foreach (PictureBox temp in storage) temp.BackColor = Color.DarkGray;
                }
                storage[7, 6].BackColor = Color.Yellow;
                storage[7, 7].BackColor = Color.Yellow;
                storage[6, 7].BackColor = Color.Yellow;
                storage[8, 7].BackColor = Color.Yellow;
                storage[6, 8].BackColor = Color.Yellow;
                storage[8, 8].BackColor = Color.Yellow;
                storage[7, 9].BackColor = Color.Yellow;

            }
            else if (comboBox1.SelectedIndex == 2) //exploder
            {
                   if (trackBar1.Value != 5)
                    {
                        trackBar1.Value = 5;
                        setupPictureboxes();
                    }
                    else
                    {
                        foreach (PictureBox temp in storage) temp.BackColor = Color.DarkGray;
                    }
                    storage[7, 5].BackColor = Color.Yellow;
                    storage[7, 9].BackColor = Color.Yellow;
                    for (int j = 0; j < 5; j++)
                    {
                        storage[5, 5 + j].BackColor = Color.Yellow;
                        storage[9, 5 + j].BackColor = Color.Yellow;
                    }

            }
            else if (comboBox1.SelectedIndex == 3) //10 cell row
            {
                if (trackBar1.Value != 6)
                {
                    trackBar1.Value = 6;
                    setupPictureboxes();
                }
                else
                {
                    foreach (PictureBox temp in storage) temp.BackColor = Color.DarkGray;
                }
                for (int i = 0; i < 10; i++) storage[3+i, 7].BackColor = Color.Yellow;

            }
            else if (comboBox1.SelectedIndex == 4) //Lightweight spaceship
            {
                if (trackBar1.Value !=20)
                {
                    trackBar1.Value = 20;
                    setupPictureboxes();
                }
                else
                {
                    foreach (PictureBox temp in storage) temp.BackColor = Color.DarkGray;
                }
                storage[0, 10].BackColor = Color.Yellow;
                storage[0, 12].BackColor = Color.Yellow;
                storage[1, 9].BackColor = Color.Yellow;
                storage[2, 9].BackColor = Color.Yellow;
                storage[3, 9].BackColor = Color.Yellow;
                storage[4, 9].BackColor = Color.Yellow;
                storage[4, 10].BackColor = Color.Yellow;
                storage[4, 11].BackColor = Color.Yellow;
                storage[3, 12].BackColor = Color.Yellow;

            }
            else if (comboBox1.SelectedIndex == 5) //Tumbler
            {
                if (trackBar1.Value != 5)
                {
                    trackBar1.Value = 5;
                    setupPictureboxes();
                }
                else
                {
                    foreach (PictureBox temp in storage) temp.BackColor = Color.DarkGray;
                }
                for(int j=0;j<5;j++)
                {
                    storage[6, 5 + j].BackColor = Color.Yellow;
                    storage[8, 5 + j].BackColor = Color.Yellow;
                }
                storage[5,5].BackColor = Color.Yellow;
                storage[5,6].BackColor = Color.Yellow;
                storage[9,5].BackColor = Color.Yellow;
                storage[9,6].BackColor = Color.Yellow;
                storage[5,10].BackColor = Color.Yellow;
                storage[4,10].BackColor = Color.Yellow;
                storage[4,9].BackColor = Color.Yellow;
                storage[4, 8].BackColor = Color.Yellow;
                storage[9, 10].BackColor = Color.Yellow;
                storage[10, 10].BackColor = Color.Yellow;
                storage[10, 9].BackColor = Color.Yellow;
                storage[10, 8].BackColor = Color.Yellow;

            }

            else if (comboBox1.SelectedIndex == 6) //Gosper glider gun
            {
                if (trackBar1.Value != 35)
                {
                    trackBar1.Value = 35;
                    setupPictureboxes();
                }
                else
                {
                    foreach (PictureBox temp in storage) temp.BackColor = Color.DarkGray;
                }
                int x = 2, y = 12;
                storage[x,y].BackColor = Color.Yellow;
                storage[x,y+1].BackColor = Color.Yellow;
                storage[x+1,y].BackColor = Color.Yellow;
                storage[x+1,y+1].BackColor = Color.Yellow;

                storage[x+9,y].BackColor = Color.Yellow;
                storage[x+10,y].BackColor = Color.Yellow;
                storage[x+10,y+1].BackColor = Color.Yellow;
                storage[x+8,y+1].BackColor = Color.Yellow;
                storage[x + 8, y + 2].BackColor = Color.Yellow;
                storage[x + 9, y + 2].BackColor = Color.Yellow;

                storage[x+16,y+2].BackColor = Color.Yellow;
                storage[x+16,y+3].BackColor = Color.Yellow;
                storage[x+16,y+4].BackColor = Color.Yellow;
                storage[x+17,y+2].BackColor = Color.Yellow;
                storage[x+18,y+3].BackColor = Color.Yellow;

                storage[x+22,y].BackColor = Color.Yellow;
                storage[x+23,y].BackColor = Color.Yellow;
                storage[x+22,y-1].BackColor = Color.Yellow;
                storage[x+23,y-2].BackColor = Color.Yellow;
                storage[x+24,y-2].BackColor = Color.Yellow;
                storage[x+24,y-1].BackColor = Color.Yellow;

                storage[x+24,y+10].BackColor = Color.Yellow;
                storage[x+25,y+10].BackColor = Color.Yellow;
                storage[x+26,y+10].BackColor = Color.Yellow;
                storage[x+24,y+11].BackColor = Color.Yellow;
                storage[x+25,y+12].BackColor = Color.Yellow;

                storage[x+34, y-1].BackColor = Color.Yellow;
                storage[x+35, y - 1].BackColor = Color.Yellow;
                storage[x+34, y-2].BackColor = Color.Yellow;
                storage[x +35, y -2].BackColor = Color.Yellow;

                storage[x+35,y+5].BackColor = Color.Yellow;
                storage[x+35,y+6].BackColor = Color.Yellow;
                storage[x+35,y+7].BackColor = Color.Yellow;
                storage[x+36,y+5].BackColor = Color.Yellow;
                storage[x+37,y+6].BackColor = Color.Yellow;

            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            simBtn.Text = "Simulate";
            timer1.Enabled = false;
            foreach (PictureBox clearBox in storage) clearBox.BackColor = Color.DarkGray;
        }

        private void linkBtn_Click(object sender, EventArgs e)
        {
            About aboutFom = new About();
            aboutFom.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
