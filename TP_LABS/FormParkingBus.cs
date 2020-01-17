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
        BigParkingBus parkingBus;
        private const int countLevel = 5;
        FormBusConfig form;

        public FormParkingBus()
        {
            InitializeComponent();
            parkingBus = new BigParkingBus(countLevel, pictureBoxParking.Width, pictureBoxParking.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBox.Items.Add("Уровень " + (i + 1));
            }
            listBox.SelectedIndex = 0;
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parkingBus[listBox.SelectedIndex].Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        
        private void buttonTakeBus_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex > -1)
            {
                if (maskedTextBoxBus.Text != "")
                {
                    var bus = parkingBus[listBox.SelectedIndex] - Convert.ToInt32(maskedTextBoxBus.Text);
                    if (bus != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxBus.Width, pictureBoxBus.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        bus.SetPosition(5, 5, pictureBoxBus.Width, pictureBoxBus.Height);
                        bus.DrawBus(gr);
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

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            Draw();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            form = new FormBusConfig();
            form.AddEvent(AddBus);
            form.Show();
        }

        private void AddBus(IBus bus)
        { if (bus != null && listBox.SelectedIndex > -1)
            {
                int place = parkingBus[listBox.SelectedIndex] + bus;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parkingBus.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parkingBus.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}
