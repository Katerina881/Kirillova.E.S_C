using System;
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
    public partial class FormBusConfig : Form
    {
        IBus bus = null;
        private event busDelegate eventAddBus;

        public FormBusConfig()
        {
            InitializeComponent();
            panelColor1.MouseDown += panelBus_MouseDown;
            panelColor2.MouseDown += panelBus_MouseDown;
            panelColor3.MouseDown += panelBus_MouseDown;
            panelColor4.MouseDown += panelBus_MouseDown;
            panelColor5.MouseDown += panelBus_MouseDown;
            panelColor6.MouseDown += panelBus_MouseDown;
            panelColor7.MouseDown += panelBus_MouseDown;
            panelColor8.MouseDown += panelBus_MouseDown;

            buttonOtm.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawBus()
        {
            if (bus != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxBus.Width, pictureBoxBus.Height);
                Graphics gr = Graphics.FromImage(bmp);
                bus.SetPosition(5, 5, pictureBoxBus.Width, pictureBoxBus.Height);
                bus.DrawBus(gr);
                pictureBoxBus.Image = bmp;
            }
        }

        public void AddEvent(busDelegate ev)
        {
            if (eventAddBus == null)
            {
                eventAddBus = new busDelegate(ev);
            }
            else
            {
                eventAddBus += ev;
            }
        }

        private void labelCommonBus_MouseDown(object sender, MouseEventArgs e)
        {
            labelCommonBus.DoDragDrop(labelCommonBus.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBus_MouseDown(object sender, MouseEventArgs e)
        {
            labelBus.DoDragDrop(labelBus.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelBus_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelBus_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelBus_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный автобус":
                    bus = new CommonBus(100, 500, Color.White);
                    break;
                case "Двухэтажный автобус":
                    bus = new Bus(100, 500, Color.White, Color.Black, true, true);
                    break;
            }
            DrawBus();
        }

        private void labelOsnColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelOsnColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null)
            {
                bus.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawBus();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null)
            {
                if (bus is Bus)
                {
                    (bus as Bus).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawBus();
                }
            }
        }

        private void buttonDob_Click(object sender, EventArgs e)
        {
            eventAddBus?.Invoke(bus);
            Close();
        }
    }
}
