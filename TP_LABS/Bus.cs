using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_LABS
{
    public class Bus : CommonBus
    {
        public Color DopColor { private set; get; }
        public bool Roof { private set; get; }
        public bool SideImg { private set; get; }

        public Bus(int maxSpeed, float weight, Color mainColor, Color dopColor, bool roof, bool sideImg) :
            base (maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Roof = roof;
            SideImg = sideImg;
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override void DrawBus(Graphics g)
        {
            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX, _startPosY, 85, 54);

            Brush brBlue = new SolidBrush(Color.LightBlue);

            g.FillRectangle(brBlue, _startPosX + 15, _startPosY + 3, 10, 10);
            g.FillRectangle(brBlue, _startPosX + 35, _startPosY + 3, 10, 10);
            g.FillRectangle(brBlue, _startPosX + 55, _startPosY + 3, 10, 10);
            g.FillRectangle(brBlue, _startPosX + 73, _startPosY + 3, 12, 10);

            base.DrawBus(g);

            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, _startPosX, _startPosY + 24, 83, 1);

            if (SideImg)
            {
                Brush brdop = new SolidBrush(DopColor);
                g.FillRectangle(brdop, _startPosX + 15, _startPosY + 16, 50, 8);
            }

            if (!Roof)
            {
                Brush brWht = new SolidBrush(Color.WhiteSmoke);
                g.FillRectangle(brWht, _startPosX, _startPosY, 85, 3);
            }
        }
    }
}
