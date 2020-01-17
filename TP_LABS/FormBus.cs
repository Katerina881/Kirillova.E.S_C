﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_LABS
{
    public partial class FormBus : Form
    {
        private Bus bus;
        public FormBus()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBus.Width, pictureBoxBus.Height);
            Graphics gr = Graphics.FromImage(bmp);
            bus.DrawBus(gr);
            pictureBoxBus.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bus = new Bus(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Red,
 Color.Yellow, true, true);
            bus.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBus.Width, pictureBoxBus.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    bus.MoveTransport(Dir.Direction.Up);
                    break;
                case "buttonDown":
                    bus.MoveTransport(Dir.Direction.Down);
                    break;
                case "buttonLeft":
                    bus.MoveTransport(Dir.Direction.Left);
                    break;
                case "buttonRight":
                    bus.MoveTransport(Dir.Direction.Right);
                    break;
            }
            Draw();
        }

    }
}
