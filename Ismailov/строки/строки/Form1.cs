using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace строки
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tankman = "4";
            string dog = "1";
             // получим 41
            int all = int.Parse(tankman) + int.Parse(dog);
            first.Text += Environment.NewLine ; // получим 5
            string all1 = Convert.ToString(all);
            MessageBox.Show(all1);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string bookTitle = first.Text;
            string insertText = second.Text + " ";
            bookTitle = bookTitle.Substring(5, 3);
            MessageBox.Show(bookTitle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int charCode1 = 169;
            int charCode2 = 0x00AE;
            char specialChar1 = Convert.ToChar(charCode1);
            char specialChar2 = Convert.ToChar(charCode2);
            first.Text = specialChar1.ToString()+ specialChar2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.String FiveStars = new System.String('*', 5);
            first.Text = FiveStars;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string AutoName;
            AutoName = "BMW";
            first.Text =
            String.Format("Стоимость {0} равна {1:0.0;c}", AutoName, 12000);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Задаем цвет
            Color clr = Color.Green;
            // Получим имя выбранного цвета
            first.Text =
            (TypeDescriptor.GetConverter(clr).ConvertToString(clr));
            // Обратная задача. Конвертируем название цвета Green в объект Color
            clr = (Color)TypeDescriptor.GetConverter(
            typeof(Color)).ConvertFromString("Green");
            // Закрашиваем форму в выбранный цвет
            this.BackColor = clr;
        }
        public void SayHello(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
            MessageBox.Show(string.Concat("Hello, ", name));
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //first.Text = SayHello(first.Text);
        }

        public static string ReverseString(string str)
        {
            // Проверка на непустоту строки.
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            // Создадим объект StringBuilder с нужной длиной.
            StringBuilder revStr = new StringBuilder(str.Length);
            // Перебираем в цикле все символы
            // и присоединяем каждый символ к StringBuilder
            for (int count = str.Length - 1; count > -1; count--)
            {
                revStr.Append(str[count]);
            }
            // Возвращаем перевернутую строку
            return revStr.ToString();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            first.Text = ReverseString(first.Text);

        }

        [DllImport("shlwapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool PathCompactPathEx(System.Text.StringBuilder pszOut, string pszSrc, Int32 cchMax, Int32 dwFlags);

        private void button8_Click(object sender, EventArgs e)
        {
            // длинный путь к файлу
            string strPathFile =
            @"C:\Users\Пользователь\AppData\Local\FactoryGame\Saved\SaveGames\common\ssample.txt";
            StringBuilder sb = new StringBuilder(260);
            // оставляем 20 символов, остальное заменяем многоточием
            bool b = PathCompactPathEx(sb, strPathFile, 20 + 1, 0);
            // Выводим результат в текстовое поле
            first.Text = sb.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("строка 1");
            sb.Append("строка 2");
            first.Text = sb.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            MessageBox.Show(today.Date.ToLongDateString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            listBox1.Items.Clear();
            listBox1.Items.Add("d: " + dt.ToString("d"));
            listBox1.Items.Add("D: " + dt.ToString("D"));
            listBox1.Items.Add("f: " + dt.ToString("f"));
            listBox1.Items.Add("F: " + dt.ToString("F"));
            listBox1.Items.Add("g: " + dt.ToString("g"));
            listBox1.Items.Add("G: " + dt.ToString("G"));
            listBox1.Items.Add("m: " + dt.ToString("m"));
            listBox1.Items.Add("r: " + dt.ToString("r"));
            listBox1.Items.Add("s: " + dt.ToString("s"));
            listBox1.Items.Add("u: " + dt.ToString("u"));
            listBox1.Items.Add("U: " + dt.ToString("U"));
            listBox1.Items.Add("y: " + dt.ToString("y"));
            listBox1.Items.Add("MMMM dd: " + dt.ToString("MMMM dd"));
            listBox1.Items.Add("MM/dd/yyyy: " + dt.ToString("MM/dd/yyyy"));
            listBox1.Items.Add("MM/dd/yyyy HH:mm: " +
            dt.ToString("MM/dd/yyyy HH:mm"));
            listBox1.Items.Add("MM/dd/yyyy hh:mm tt: " +
            dt.ToString("MM/dd/yyyy hh:mm tt"));
            listBox1.Items.Add("MM/dd/yyyy H:mm: " +
            dt.ToString("MM/dd/yyyy H:mm"));
            listBox1.Items.Add("MM/dd/yyyy h:mm tt: " +
            dt.ToString("MM/dd/yyyy h:mm tt"));
            listBox1.Items.Add("MM/dd/yyyy HH:mm:ss: " +
            dt.ToString("MM/dd/yyyy HH:mm:ss"));

            listBox1.Items.Add("dddd, dd MMMM yyyy: " +
            dt.ToString("dddd, dd MMMM yyyy"));
            listBox1.Items.Add("dddd, dd MMMM yyyy HH:mm:ss: " +
            dt.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            listBox1.Items.Add("ddd, dd MMM yyyy HH':'mm':'ss 'GMT': " +
            dt.ToString("ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"));

            listBox1.Items.Add("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK: " +
            dt.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"));
            listBox1.Items.Add("yyyy'-'MM'-'dd'T'HH':'mm':'ss: " +
            dt.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            listBox1.Items.Add("yyyy MMMM: " + dt.ToString("yyyy MMMM"));
            listBox1.Items.Add("H:mm: " + dt.ToString("H:mm"));
            listBox1.Items.Add("HH:mm: " + dt.ToString("HH:mm"));
            listBox1.Items.Add("HH:mm:ss: " + dt.ToString("HH:mm:ss"));
            listBox1.Items.Add("h:mm tt: " + dt.ToString("h:mm tt"));
            listBox1.Items.Add("hh:mm tt: " + dt.ToString("hh:mm tt"));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DateTime curdate = DateTime.Now;
            // Прибавляем семь дней к текущей дате
            DateTime mydate = curdate.AddDays(8);
            listBox1.Items.Add(mydate.ToShortDateString());
        }
        public static int DaysDiff(DateTime date1, DateTime date2)
        {
            return date1.Subtract(date2.Date).Days;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            string howdays = DaysDiff(DateTime.Today,new DateTime(2003, 12, 04)).ToString();
            listBox1.Items.Add("Со дня моего дня рождения прошло: " + howdays);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bool leapYear = DateTime.IsLeapYear(DateTime.Now.Year);
            listBox1.Items.Add(String.Format("{0} является високосным годом: {1}", DateTime.Now.Year, leapYear));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int parrots = Convert.ToInt32(first.Text);
            second.Text = parrots.ToString("X8");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int myvalue = Convert.ToInt32(first.Text); 
            second.Text = Convert.ToString(myvalue, 2); // возвратит 100 
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int myValue = Convert.ToInt32(first.Text);
            // Преобразуем в восьмеричное значение
            listBox1.Items.Add(Convert.ToString(myValue, 8));
            // Преобразуем в шестнадцатеричное значение
            listBox1.Items.Add(Convert.ToString(myValue, 16));
        }
    }
}
