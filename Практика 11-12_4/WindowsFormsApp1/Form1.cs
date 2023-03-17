using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string Error(string text)
        {
            string message = "";
            if (comboBox1.Text == "") message += "Поле Имя пустое\n";
            if (comboBox2.Text == "") message += "Поле Тип пустое\n";
            if (comboBox3.Text == "") message += "Поле Оттенка пустое\n";
            if (comboBox4.Text == "") message += "Поле Старны пустое\n";

            return message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Error(comboBox1.Text);
            string error = name;
            if (error == "")
            {
                Flowers flowers = new Flowers();
                flowers.name = comboBox1.Text;
                flowers.type = comboBox2.Text;
                flowers.color = comboBox3.Text;
                flowers.createCountry = comboBox4.Text;
                flowers.priceOneFlower = Convert.ToDouble(numericUpDown1.Value);
                flowers.GetLenght = Convert.ToDouble(numericUpDown2.Value);
                flowers.countFlowers = Convert.ToInt32(numericUpDown3.Value);
                flowers.dayWeek = Convert.ToInt32(numericUpDown4.Value);
                flowers.Sale();
                MessageBox.Show($"{flowers.GetInfo()}", "Информация");
            }
            else MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
