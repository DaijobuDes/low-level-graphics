using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_low_level_graphics
{
    public partial class Form1 : Form
    {
        Graphics g1;
        private int x = 10, y = 700;
        private bool run = true;

        public Form1()
        {
            InitializeComponent();
        }

        // Box size 929, 527
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g1 = e.Graphics;

            // House
            g1.DrawRectangle(Pens.White, new Rectangle(350, 225, 300, 200));
            g1.DrawRectangle(Pens.White, new Rectangle(475, 350, 50, 75));
            g1.DrawEllipse(Pens.White, new Rectangle(480, 375, 10, 10));
            // Window
            g1.DrawRectangle(Pens.White, new Rectangle(400, 250, 50, 50));
            g1.DrawRectangle(Pens.White, new Rectangle(550, 250, 50, 50));
            // Roof
            g1.DrawLine(Pens.White, new Point(350, 225), new Point(500, 0));
            g1.DrawLine(Pens.White, new Point(650, 225), new Point(500, 0));

            // Tree 1
            // Trunk
            g1.DrawArc(Pens.RosyBrown, new Rectangle(100, 300, 45, 100), -90, 180);
            g1.DrawArc(Pens.RosyBrown, new Rectangle(175, 300, 45, 100), 270, -180);

            // Leaves
            // Left
            g1.DrawArc(Pens.LimeGreen, new Rectangle(100, 250, 45, 45), 83, 180);
            g1.DrawArc(Pens.LimeGreen, new Rectangle(110, 225, 45, 45), 125, 180);
            // Center
            g1.DrawArc(Pens.LimeGreen, new Rectangle(135, 210, 45, 45), 180, 180);
            // Right
            g1.DrawArc(Pens.LimeGreen, new Rectangle(163, 225, 45, 45), 225, 180);
            g1.DrawArc(Pens.LimeGreen, new Rectangle(175, 252, 45, 45), 260, 180);

            // Tree 2
            // Trunk
            g1.DrawArc(Pens.RosyBrown, new Rectangle(700, 300, 45, 100), -90, 180);
            g1.DrawArc(Pens.RosyBrown, new Rectangle(775, 300, 45, 100), 270, -180);

            // Leaves
            // Left
            g1.DrawArc(Pens.LimeGreen, new Rectangle(700, 250, 45, 45), 83, 180);
            g1.DrawArc(Pens.LimeGreen, new Rectangle(710, 225, 45, 45), 125, 180);
            // Center
            g1.DrawArc(Pens.LimeGreen, new Rectangle(735, 210, 45, 45), 180, 180);
            // Right
            g1.DrawArc(Pens.LimeGreen, new Rectangle(763, 225, 45, 45), 225, 180);
            g1.DrawArc(Pens.LimeGreen, new Rectangle(775, 252, 45, 45), 260, 180);

            // Sun
            g1.DrawArc(Pens.Yellow, new Rectangle(840, -10, 100, 100), 0, 360);

            // Cloud
            g1.DrawArc(Pens.SkyBlue, new Rectangle(x, 100, 45, 45), 90, 180);
            g1.DrawArc(Pens.SkyBlue, new Rectangle(x + 20, 90, 45, 45), 155, 180);
            g1.DrawArc(Pens.SkyBlue, new Rectangle(x + 55, 90, 45, 45), 165, 180);
            g1.DrawArc(Pens.SkyBlue, new Rectangle(x + 85, 90, 45, 45), 190, 180);
            g1.DrawArc(Pens.SkyBlue, new Rectangle(x + 115, 105, 45, 45), 225, 180);
            g1.DrawArc(Pens.SkyBlue, new Rectangle(x + 115, 115, 45, 45), 300, 180);
            g1.DrawArc(Pens.SkyBlue, new Rectangle(x + 90, 125, 45, 45), 360, 180);
            g1.DrawArc(Pens.SkyBlue, new Rectangle(x + 55, 125, 45, 45), 360, 180);
            g1.DrawArc(Pens.SkyBlue, new Rectangle(x + 20, 120, 45, 45), 30, 180);

            // Cloud 2
            g1.DrawArc(Pens.SkyBlue, new Rectangle(y, 80, 45, 45), 90, 180);
            g1.DrawArc(Pens.SkyBlue, new Rectangle(y + 20, 70, 45, 45), 155, 180);
            g1.DrawArc(Pens.SkyBlue, new Rectangle(y + 55, 70, 45, 45), 165, 180);
            g1.DrawArc(Pens.SkyBlue, new Rectangle(y + 85, 70, 45, 45), 190, 180);
            g1.DrawArc(Pens.SkyBlue, new Rectangle(y + 115, 85, 45, 45), 225, 180);
            g1.DrawArc(Pens.SkyBlue, new Rectangle(y + 115, 95, 45, 45), 300, 180);
            g1.DrawArc(Pens.SkyBlue, new Rectangle(y + 90, 105, 45, 45), 360, 180);
            g1.DrawArc(Pens.SkyBlue, new Rectangle(y + 55, 105, 45, 45), 360, 180);
            g1.DrawArc(Pens.SkyBlue, new Rectangle(y + 20, 100, 45, 45), 30, 180);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (run)
            {
                timer1.Enabled = true;
                run = false;
                return;
            }
            timer1.Enabled = false;
            run = true;
        }

        // Exit
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 5;
            y -= 5;

            if (x >= 1000)
            {
                x = -100;
            }

            if (y <= -100)
            {
                y = 1000;
            }

            this.Refresh();
        }
    }
}
