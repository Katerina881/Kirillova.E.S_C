using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_LABS
{
    public class Bus : CommonBus, IComparable<Bus>, IEquatable<Bus>
    {
        public Color DopColor { private set; get; }
        public bool Roof { private set; get; }
        public bool SideImg { private set; get; }

        public Bus(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool roof, bool sideImg) :
            base (maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Roof = roof;
            SideImg = sideImg;
        }

        public Bus(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Roof = Convert.ToBoolean(strs[4]);
                SideImg = Convert.ToBoolean(strs[5]);
            }
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Roof + ";" + SideImg;
        }

        public enum Direction
        {
            Up,

            Down,

            Left,

            Right
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

        public int CompareTo(Bus other)
        {
            var res = (this is CommonBus).CompareTo(other is CommonBus);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Roof != other.Roof)
            {
                return Roof.CompareTo(other.Roof);
            }
            if (SideImg != other.SideImg)
            {
                return SideImg.CompareTo(other.SideImg);
            }
            return 0;
        }

        public bool Equals(Bus other)
        {
            var res = (this as CommonBus).Equals(other as CommonBus);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Roof != other.Roof)
            {
                return false;
            }
            if (SideImg != other.SideImg)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Bus carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
