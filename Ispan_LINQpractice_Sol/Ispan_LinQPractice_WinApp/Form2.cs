using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ispan_LinQPractice_WinApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public delegate void BirthYearMessageBox(int Age);
        public delegate void PrintString(int num);

        private void buttonDelegateInvoke_Click(object sender, EventArgs e)
        {
            // New的委派要塞值
            BirthYearMessageBox del2 = new BirthYearMessageBox(BirthYear);
            del2.Invoke(10);
        }

        private void buttonDelegate_Click(object sender, EventArgs e)
        {
            // 直接委派要實體指派
            BirthYearMessageBox del1 = BirthYear;
            del1(1);
        }
        public void BirthYear(int age)
        { 
            int year = DateTime.Now.Year - age;
            MessageBox.Show($"{ year}");
        }

        private void buttonDelegateInvoke2_Click(object sender, EventArgs e)
        {
            // 系結多個方法
            PrintString ps = new PrintString(PrintStringMethod1);
            ps += new PrintString(PrintStringMethod2);
            ps.Invoke(666);
        }

        void PrintStringMethod1(int i) {
            MessageBox.Show($"PrintStringMethod1: {i}");
        }
        void PrintStringMethod2(int i)
        {
            MessageBox.Show($"PrintStringMethod2: {i}");
        }



        private object CreateButton(int number)
        {
            Button newButton = new Button();
            newButton.Text = $"{number}";
            int eachRowNum = 3;
            int x = number % 3;
            int y = number / eachRowNum;
            newButton.Location = new Point(200 + x * 50 ,  y * 50 );
            newButton.Size = new Size(50, 25);
            newButton.BackColor = Color.AliceBlue;
            //newButton.Click += NewButton_Click;
            newButton.Click += delegate(Object ssender, EventArgs EE) {
                MessageBox.Show(newButton.Text);
            };
            return newButton;
        }

        //private void NewButton_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("aaaa");
        //    sender.ToString();
        //}

        public void AddButton(object obj) {
            this.Controls.Add((Control)obj);
        }

        delegate object ButtonDelegate(int number);


        private void buttonCreateButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int buttonNums) == false) return;
            for (int i = 0; i < buttonNums; i++)
            {
                ButtonDelegate del = CreateButton;
                AddButton(del(i));
            }
        }       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
