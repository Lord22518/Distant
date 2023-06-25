using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace строки
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        enum Cats { Рыжик = 3, Барсик = 5, Мурзик, Васька, Пушок };
        private void button1_Click(object sender, EventArgs e)
        {
            // Перечисляем все элементы перечисления
            string[] catNames = Enum.GetNames(typeof(Cats));
            foreach (string s in catNames)
            {
                listBox1.Items.Add(s);
            }
            // Перечисляем все значения перечисления
            int[] valCats = (int[])Enum.GetValues(typeof(Cats));
            foreach (int val in valCats)
            {
                listBox1.Items.Add(val.ToString());
            }
            MessageBox.Show(catNames[3].ToString());
            MessageBox.Show(valCats[3].ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получаем массив строк, содержащих все цвета в системе
            string[] allcolors =
            Enum.GetNames(typeof(System.Drawing.KnownColor));
            listBox1.Items.Clear();
            // Выводим все имена в список
            listBox1.Items.AddRange(allcolors);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Object ColorEnum;
            ColorEnum = System.Enum.Parse(typeof(KnownColor), first.Text);
            KnownColor SelectedColor = (KnownColor)ColorEnum;
            this.BackColor = System.Drawing.Color.FromKnownColor(SelectedColor);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x= Convert.ToInt32(first.Text);
            int y = Convert.ToInt32(second.Text);
            int z = Convert.ToInt32(third.Text);
            listBox1.Items.Add(Math.Max(x, Math.Max(y, z)));
            listBox1.Items.Add(Math.Min(x, Math.Min(y, z)));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String[] s = Regex.Split("Январь Февраль Март Апрель Май Июнь Июль Август Сентябрь Октябрь Ноябрь Декабрь", " ");
            int k = Convert.ToInt32(first.Text);
            if (k >= 0 && k <= 11)
            { listBox1.Items.Add(s[k]); }
            else { first.Text = "Введите число от 0 до 11"; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double degrees = Convert.ToDouble(first.Text);
            double radians = (Math.PI / 180) * degrees;
            listBox1.Items.Add(radians);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double radians = Convert.ToDouble(first.Text);
            double degrees = (180 / Math.PI) * radians;
            listBox1.Items.Add(degrees);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int intValue = Convert.ToInt32(first.Text);
           if (intValue % 2 == 0) // четное число
            { listBox1.Items.Add("Число четное"); }
            else { listBox1.Items.Add("Число нечетное"); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int Fahrenheit = Convert.ToInt32(first.Text);
            double Celsius = (5.0 / 9.0) * (Fahrenheit - 32);
            listBox1.Items.Add(Math.Round(Celsius));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int Celsius = Convert.ToInt32(first.Text);
            double Fahrenheit = (9.0 / 5.0) * (Celsius + 32);
            listBox1.Items.Add(Fahrenheit);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int sum;
            int Value = Convert.ToInt32(first.Text);
            sum = 0; int p = 1;
            for (int i = 1; i <= Value; i++)
            {
                sum = sum+i ;
                p = p * i;
            }
            listBox1.Items.Add(sum);
            listBox1.Items.Add(p);
        }
        
    }
}
