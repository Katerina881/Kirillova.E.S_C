using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_LABS
{
    interface IBus
    {
        void SetPosition(int x, int y, int width, int height);
        void MoveTransport(Bus.Direction direction);
        void DrawBus(Graphics g);
    }
}
