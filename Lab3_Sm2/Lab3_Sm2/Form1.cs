using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab3_Sm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            this.InitializeComponent();
            this.sh = (double)this.btnOk.Size.Height;
            this.sw = (double)this.btnOk.Size.Width;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            this.timer1.Interval = 1000;
            if (this.show)
            {
                this.Text = "Press 'OK' button";
                this.show = false;
            }
            else
            {
                this.Text = "";
                this.show = true;
            }
            ++this.numberOfBlinks;
            if (this.numberOfBlinks <= (byte)8)
                return;
            this.timer1.Enabled = false;
            this.show = false;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.show)
            {
                this.Text = "'OK' will never been pressed!!!";
                this.show = false;
            }
            else
            {
                this.Text = "";
                this.show = true;
            }
            ++this.numberOfBlinks;
        }
        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isClickable)
                return;
            int x1 = e.X;
            Point location = this.btnOk.Location;
            int num1 = location.X - 20;
            int num2;
            if (x1 > num1)
            {
                int y1 = e.Y;
                location = this.btnOk.Location;
                int num3 = location.Y - 20;
                if (y1 > num3)
                {
                    int x2 = e.X;
                    location = this.btnOk.Location;
                    int num4 = location.X + this.btnOk.Size.Width / 2;
                    if (x2 < num4)
                    {
                        int y2 = e.Y;
                        location = this.btnOk.Location;
                        int num5 = location.Y + this.btnOk.Size.Height / 2;
                        num2 = y2 < num5 ? 1 : 0;
                        goto label_6;
                    }
                }
            }
            num2 = 0;
        label_6:
            if (num2 != 0)
            {
                Button btnOk = this.btnOk;
                location = this.btnOk.Location;
                int x2 = location.X + 5;
                location = this.btnOk.Location;
                int y = location.Y + 5;
                Point point = new Point(x2, y);
                btnOk.Location = point;
                this.ChangeSizeButton(this.btnOk);
            }
            int x3 = e.X;
            location = this.btnOk.Location;
            int num6 = location.X - 15;
            int num7;
            if (x3 > num6)
            {
                int x2 = e.X;
                location = this.btnOk.Location;
                int num3 = location.X + this.btnOk.Size.Width / 2;
                if (x2 < num3)
                {
                    int y1 = e.Y;
                    location = this.btnOk.Location;
                    int num4 = location.Y + this.btnOk.Size.Height / 2;
                    if (y1 > num4)
                    {
                        int y2 = e.Y;
                        location = this.btnOk.Location;
                        int num5 = location.Y + this.btnOk.Size.Height + 20;
                        num7 = y2 < num5 ? 1 : 0;
                        goto label_13;
                    }
                }
            }
            num7 = 0;
        label_13:
            if (num7 != 0)
            {
                Button btnOk = this.btnOk;
                location = this.btnOk.Location;
                int x2 = location.X + 5;
                location = this.btnOk.Location;
                int y = location.Y - 5;
                Point point = new Point(x2, y);
                btnOk.Location = point;
                this.ChangeSizeButton(this.btnOk);
            }
            int x4 = e.X;
            location = this.btnOk.Location;
            int num8 = location.X + this.btnOk.Size.Width / 2;
            int num9;
            if (x4 > num8)
            {
                int x2 = e.X;
                location = this.btnOk.Location;
                int num3 = location.X + this.btnOk.Size.Width + 20;
                if (x2 < num3)
                {
                    int y1 = e.Y;
                    location = this.btnOk.Location;
                    int num4 = location.Y + this.btnOk.Size.Height / 2;
                    if (y1 > num4)
                    {
                        int y2 = e.Y;
                        location = this.btnOk.Location;
                        int num5 = location.Y + this.btnOk.Size.Height + 20;
                        num9 = y2 < num5 ? 1 : 0;
                        goto label_20;
                    }
                }
            }
            num9 = 0;
        label_20:
            if (num9 != 0)
            {
                Button btnOk = this.btnOk;
                location = this.btnOk.Location;
                int x2 = location.X - 5;
                location = this.btnOk.Location;
                int y = location.Y - 5;
                Point point = new Point(x2, y);
                btnOk.Location = point;
                this.ChangeSizeButton(this.btnOk);
            }
            int x5 = e.X;
            location = this.btnOk.Location;
            int num10 = location.X + this.btnOk.Size.Width / 2;
            int num11;
            if (x5 > num10)
            {
                int x2 = e.X;
                location = this.btnOk.Location;
                int num3 = location.X + this.btnOk.Size.Width + 20;
                if (x2 < num3)
                {
                    int y1 = e.Y;
                    location = this.btnOk.Location;
                    int num4 = location.Y + this.btnOk.Size.Height / 2;
                    if (y1 < num4)
                    {
                        int y2 = e.Y;
                        location = this.btnOk.Location;
                        int num5 = location.Y - 20;
                        num11 = y2 > num5 ? 1 : 0;
                        goto label_27;
                    }
                }
            }
            num11 = 0;
        label_27:
            if (num11 != 0)
            {
                Button btnOk = this.btnOk;
                location = this.btnOk.Location;
                int x2 = location.X - 5;
                location = this.btnOk.Location;
                int y = location.Y + 5;
                Point point = new Point(x2, y);
                btnOk.Location = point;
                this.ChangeSizeButton(this.btnOk);
            }
        }
        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            if (this.isClickable)
                return;
            Button btnOk = this.btnOk;
            Point location = this.btnCancel.Location;
            int x = location.X + 150;
            location = this.btnCancel.Location;
            int y = location.Y + 150;
            Point point = new Point(x, y);
            btnOk.Location = point;
        }
        private void btnOk_LocationChanged(object sender, EventArgs e)
        {
            if (this.btnOk.Location.X < 5)
                this.btnOk.Location = new Point(this.btnOk.Location.X + 175, this.btnOk.Location.Y);
            Point location = this.btnOk.Location;
            int num1 = location.X + this.btnOk.Size.Width + 5;
            Size size = this.Size;
            int width = size.Width;
            if (num1 > width)
            {
                Button btnOk = this.btnOk;
                size = this.Size;
                int num2 = size.Width - 100;
                size = this.btnOk.Size;
                int num3 = size.Width * 2;
                int x = num2 - num3;
                location = this.btnOk.Location;
                int y = location.Y;
                Point point = new Point(x, y);
                btnOk.Location = point;
            }
            location = this.btnOk.Location;
            if (location.Y < 5)
            {
                Button btnOk = this.btnOk;
                location = this.btnOk.Location;
                int x = location.X;
                location = this.btnOk.Location;
                int y = location.Y + 100;
                Point point = new Point(x, y);
                btnOk.Location = point;
            }
            location = this.btnOk.Location;
            int y1 = location.Y;
            size = this.btnOk.Size;
            int height1 = size.Height;
            int num4 = y1 + height1 + 25;
            size = this.Size;
            int height2 = size.Height;
            if (num4 <= height2)
                return;
            Button btnOk1 = this.btnOk;
            location = this.btnOk.Location;
            int x1 = location.X;
            size = this.Size;
            int num5 = size.Height - 100;
            size = this.btnOk.Size;
            int num6 = size.Height * 2;
            int y2 = num5 - num6;
            Point point1 = new Point(x1, y2);
            btnOk1.Location = point1;
        }

        private void ChangeSizeButton(Button b)
        {
            this.sw -= 0.2;
            this.sh -= 0.2;
            b.Size = new Size((int)(this.sw - 0.1), (int)(this.sh - 0.1));
            if (b.Size.Width > 0 && b.Size.Height > 0)
                return;
            this.MouseMove -= new MouseEventHandler(this.Form1_MouseMove);
            this.timer2.Enabled = true;
            this.timer2_Tick((object)null, (EventArgs)null);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int num = (int)MessageBox.Show("Button 'OK' has been clicked");
        }

        private void btnCancel_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.ch == ' ' && (ushort)e.KeyData == (ushort)65)
                this.ch = 'A';
            if (this.ch == 'A' && (ushort)e.KeyData == (ushort)68)
                this.ch = 'D';
            if (this.ch != 'D' || (ushort)e.KeyData != (ushort)88)
                return;
            this.isClickable = true;
        }

        private void btnCancel_KeyUp(object sender, KeyEventArgs e) => this.ch = ' ';


    }

}

