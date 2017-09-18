using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace PacMan
{
    public partial class PacMan : Form
    {
        public PacMan()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Graphics fg = this.CreateGraphics();
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Pen bluePen = new Pen(Color.Blue, 10);
            Pen yellowPen = new Pen(Color.Yellow, 10);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Font yellowFont = new Font("Arial", 20, FontStyle.Bold);

            fg.DrawRectangle(bluePen, 0, 200, 600, 80);
            fg.DrawRectangle(bluePen, 0, 0, 800, 80);
            fg.FillRectangle(blueBrush, 0, 200, 600, 80);
            fg.FillRectangle(blueBrush, 0, 0, 800, 80);
            fg.DrawRectangle(bluePen, 600, 200, 80, 400);
            fg.DrawRectangle(bluePen, 800, 0, 80, 600);
            fg.FillRectangle(blueBrush, 800, 0, 80, 600);
            fg.FillRectangle(blueBrush, 600, 200, 80, 400);
            fg.DrawPie(yellowPen, 0, 90, 100, 90, 30, 300);
            fg.FillPie(yellowBrush, 0, 90, 100, 90, 30, 300);
            Thread.Sleep(1000);
            fg.Clear(Color.White);
          
            fg.DrawRectangle(bluePen, 0, 200, 600, 80);
            fg.DrawRectangle(bluePen, 0, 0, 800, 80);
            fg.FillRectangle(blueBrush, 0, 200, 600, 80);
            fg.FillRectangle(blueBrush, 0, 0, 800, 80);
            fg.DrawRectangle(bluePen, 600, 200, 80, 400);
            fg.DrawRectangle(bluePen, 800, 0, 80, 600);
            fg.FillRectangle(blueBrush, 800, 0, 80, 600);
            fg.FillRectangle(blueBrush, 600, 200, 80, 400);
            fg.DrawPie(yellowPen, 200, 90, 100, 90, 30, 360);
            fg.FillPie(yellowBrush, 200, 90, 100, 90, 30, 360);
            Thread.Sleep(1000);
            fg.Clear(Color.White);

            fg.DrawRectangle(bluePen, 0, 200, 600, 80);
            fg.DrawRectangle(bluePen, 0, 0, 800, 80);
            fg.FillRectangle(blueBrush, 0, 200, 600, 80);
            fg.FillRectangle(blueBrush, 0, 0, 800, 80);
            fg.DrawRectangle(bluePen, 600, 200, 80, 400);
            fg.DrawRectangle(bluePen, 800, 0, 80, 600);
            fg.FillRectangle(blueBrush, 800, 0, 80, 600);
            fg.FillRectangle(blueBrush, 600, 200, 80, 400);
            fg.DrawPie(yellowPen, 400, 90, 100, 90, 30, 300);
            fg.FillPie(yellowBrush, 400, 90, 100, 90, 30, 300);
            Thread.Sleep(1000);
            fg.Clear(Color.White);

            fg.DrawRectangle(bluePen, 0, 200, 600, 80);
            fg.DrawRectangle(bluePen, 0, 0, 800, 80);
            fg.FillRectangle(blueBrush, 0, 200, 600, 80);
            fg.FillRectangle(blueBrush, 0, 0, 800, 80);
            fg.DrawRectangle(bluePen, 600, 200, 80, 400);
            fg.DrawRectangle(bluePen, 800, 0, 80, 600);
            fg.FillRectangle(blueBrush, 800, 0, 80, 600);
            fg.FillRectangle(blueBrush, 600, 200, 80, 400);
            fg.DrawPie(yellowPen, 680, 90, 100, 90, 30, 360);
            fg.FillPie(yellowBrush, 680, 90, 100, 90, 30, 360);
            Thread.Sleep(1000);
            fg.Clear(Color.White);

            fg.DrawRectangle(bluePen, 0, 200, 600, 80);
            fg.DrawRectangle(bluePen, 0, 0, 800, 80);
            fg.FillRectangle(blueBrush, 0, 200, 600, 80);
            fg.FillRectangle(blueBrush, 0, 0, 800, 80);
            fg.DrawRectangle(bluePen, 600, 200, 80, 400);
            fg.DrawRectangle(bluePen, 800, 0, 80, 600);
            fg.FillRectangle(blueBrush, 800, 0, 80, 600);
            fg.FillRectangle(blueBrush, 600, 200, 80, 400);
            fg.DrawPie(yellowPen, 690, 200, 100, 90, 120, 300);
            fg.FillPie(yellowBrush, 690, 200, 100, 90, 120, 300);
            Thread.Sleep(1000);
            fg.Clear(Color.White);

            fg.DrawRectangle(bluePen, 0, 200, 600, 80);
            fg.DrawRectangle(bluePen, 0, 0, 800, 80);
            fg.FillRectangle(blueBrush, 0, 200, 600, 80);
            fg.FillRectangle(blueBrush, 0, 0, 800, 80);
            fg.DrawRectangle(bluePen, 600, 200, 80, 400);
            fg.DrawRectangle(bluePen, 800, 0, 80, 600);
            fg.FillRectangle(blueBrush, 800, 0, 80, 600);
            fg.FillRectangle(blueBrush, 600, 200, 80, 400);
            fg.DrawPie(yellowPen, 690, 400, 100, 90, 120, 360);
            fg.FillPie(yellowBrush, 690, 400, 100, 90, 120, 360);
            Thread.Sleep(1000);
            fg.Clear(Color.White);

            fg.DrawRectangle(bluePen, 0, 200, 600, 80);
            fg.DrawRectangle(bluePen, 0, 0, 800, 80);
            fg.FillRectangle(blueBrush, 0, 200, 600, 80);
            fg.FillRectangle(blueBrush, 0, 0, 800, 80);
            fg.DrawRectangle(bluePen, 600, 200, 80, 400);
            fg.DrawRectangle(bluePen, 800, 0, 80, 600);
            fg.FillRectangle(blueBrush, 800, 0, 80, 600);
            fg.FillRectangle(blueBrush, 600, 200, 80, 400);
            fg.DrawPie(yellowPen, 690, 600, 100, 90, 120, 300);
            fg.FillPie(yellowBrush, 690, 600, 100, 90, 120, 300);
            Thread.Sleep(1000);
            fg.Clear(Color.White);

        }
    }
}
