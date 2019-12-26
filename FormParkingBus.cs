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
    public partial class FormParkingBus : Form
    {
        ParkingBus<IBus> parking;

        public FormParkingBus()
        {
            InitializeComponent();
            parking = new ParkingBus<IBus>(20, pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void buttonSetCommonBus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new CommonBus(100, 1000, dialog.Color);
                int place = parking + car; Draw();
            }
        }

        private void buttonSetBus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new Bus(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    int place = parking + car; Draw();
                }
            }
        }

       private void buttonTakeBus_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBox.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxBus.Width, pictureBoxBus.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(5, 5, pictureBoxBus.Width, pictureBoxBus.Height);
                    car.DrawBus(gr);
                    pictureBoxBus.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxBus.Width, pictureBoxBus.Height);
                    pictureBoxBus.Image = bmp;
                }
                Draw();
            }
        }
    }
}
