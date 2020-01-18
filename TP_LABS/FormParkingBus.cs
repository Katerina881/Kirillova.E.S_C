using NLog;
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
        private Logger logger;

        public FormParkingBus()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            parkingBus = new BigParkingBus(countLevel, pictureBoxParking.Width, pictureBoxParking.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingBus[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
        
        private void buttonTakeBus_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    try
                    {
                        var bus = parkingBus[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox.Text);
                        Bitmap bmp = new Bitmap(pictureBoxBus.Width, pictureBoxBus.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        bus.SetPosition(5, 5, pictureBoxBus.Width, pictureBoxBus.Height);
                        bus.DrawBus(gr);
                        pictureBoxBus.Image = bmp;
                        logger.Info("Изъят автомобиль " + bus.ToString() + " с места " + maskedTextBox.Text);
                        Draw();
                    }
                    catch (ParkingNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                        pictureBoxParking.Image = bmp;
                        logger.Error("Не найден автомобиль на указанном месте");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.Error("Неизвестная ошибка");
                    }
                }
            }
        }
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void ButtonTakebus_Click(object sender, EventArgs e)
        {
            form = new FormBusConfig();
            form.AddEvent(AddBus);
            form.Show();
        }

        private void AddBus(IBus bus)
        {
            if (bus != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = parkingBus[listBoxLevels.SelectedIndex] + bus;
                    logger.Info("Добавлен автомобиль " + bus.ToString() + " на место " + place);
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Переполнение");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка");
                }
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parkingBus.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка при сохранении");
                }
            }
        }

        private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parkingBus.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Место занято");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка");
                }
                Draw();
            }
        }
    }
}
