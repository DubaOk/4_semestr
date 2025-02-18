using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(textBoxWeight.Text, out double ves1) || ves1 <= 20 || ves1 > 300 ||
                    !double.TryParse(textBoxHeight.Text, out double rost1) || rost1 < 100 || rost1 > 250 ||
                    !double.TryParse(textBoxAge.Text, out double vozrast1) || vozrast1 < 10 || vozrast1 > 100 ||
                    !double.TryParse(textBoxHiddenWeight.Text, out double zhelVes1) || zhelVes1 <= 20 || zhelVes1 > 300 ||
                    !double.TryParse(textBoxHiddenTime.Text, out double srok1) || srok1 < 1 || srok1 > 180 ||
                    !(radioButton1.Checked || radioButton2.Checked))
                {
                    MessageBox.Show("Ошибка: некорректный ввод данных. Проверьте возраст, вес, рост и срок.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double imt = ves1 / Math.Pow(rost1 / 100, 2);
                if (radioButton2.Checked)
                {
                    imt *= 0.95;
                }

                if (imt < 18.5)
                {
                    textBox1.Text = "Низкий вес";
                }
                else if (imt < 25)
                {
                    textBox1.Text = "Нормальный вес";
                }
                else
                {
                    textBox1.Text = "Ожирение";
                }

                double BMR;
                if (radioButton1.Checked)
                {
                    BMR = 66 + (13.7 * ves1) + (5 * rost1) - (6.8 * vozrast1);
                }
                else
                {
                    BMR = 665 + (9.6 * ves1) + (1.8 * rost1) - (4.7 * vozrast1);
                }

                double normKal = BMR;
                switch (comboBoxTarget.SelectedIndex)
                {
                    case 0:
                        normKal = BMR - 500;
                        break;
                    case 1:
                        normKal = BMR + 450;
                        break;
                    case 2:
                        normKal = BMR;
                        break;
                    default:
                        MessageBox.Show("Выберите цель.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                textBox3.Text = normKal.ToString("F0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHiddenWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelHiddenWeight_Click(object sender, EventArgs e)
        {

        }

        private void labelHiddenTime_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
