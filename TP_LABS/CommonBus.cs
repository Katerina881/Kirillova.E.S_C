using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_LABS
{
    public class CommonBus : OsnBus
    {
        protected const int carWidth = 100;
        protected const int carHeight = 60;

        public CommonBus(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
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

        public override void DrawBus(Graphics g)
        {
            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX, _startPosY + 24, 85, 26);

            Brush brBlack = new SolidBrush(Color.Black);
            g.FillEllipse(brBlack, _startPosX + 13, _startPosY + 40, 20, 20);
            g.FillEllipse(brBlack, _startPosX + 55, _startPosY + 40, 20, 20);

            g.FillRectangle(brBlack, _startPosX, _startPosY + 25, 12, 25);

            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, _startPosX + 2, _startPosY + 26, 7, 15);
            g.FillRectangle(brBlue, _startPosX + 78, _startPosY + 26, 7, 15);

            g.FillRectangle(brBlue, _startPosX + 15, _startPosY + 26, 10, 10);
            g.FillRectangle(brBlue, _startPosX + 35, _startPosY + 26, 10, 10);
            g.FillRectangle(brBlue, _startPosX + 55, _startPosY + 26, 10, 10);
        }
    }
}
