using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_LABS
{
    class Bus
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int carWidht = 100;
        private const int carHeight = 60;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool Roof { private set; get; }
        public bool SideImg { private set; get; }

        public Bus(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool roof, bool sideImg)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Roof = roof;
            SideImg = sideImg;
        }

        public enum Direction
        {
            Up,

            Down,

            Left,

            Right
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 180 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidht)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawBus(Graphics g)
        {


            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX, _startPosY, 85, 54);


            Brush brBlack = new SolidBrush(Color.Black);
            g.FillEllipse(brBlack, _startPosX + 13, _startPosY + 40, 20, 20);
            g.FillEllipse(brBlack, _startPosX + 55, _startPosY + 40, 20, 20);

            g.FillRectangle(brBlack, _startPosX, _startPosY + 25, 12, 30);

            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, _startPosX + 2, _startPosY + 26, 7, 15);
            g.FillRectangle(brBlue, _startPosX + 78, _startPosY + 26, 7, 15);

            g.FillRectangle(brBlue, _startPosX + 15, _startPosY + 26, 10, 10);
            g.FillRectangle(brBlue, _startPosX + 35, _startPosY + 26, 10, 10);
            g.FillRectangle(brBlue, _startPosX + 55, _startPosY + 26, 10, 10);

            g.FillRectangle(brBlue, _startPosX + 15, _startPosY + 3, 10, 10);
            g.FillRectangle(brBlue, _startPosX + 35, _startPosY + 3, 10, 10);
            g.FillRectangle(brBlue, _startPosX + 55, _startPosY + 3, 10, 10);
            g.FillRectangle(brBlue, _startPosX + 73, _startPosY + 3, 12, 10);

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
