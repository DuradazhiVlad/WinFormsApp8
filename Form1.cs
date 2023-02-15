using System;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }    
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random random = new Random();

            int x = button1.Location.X;               

            int newX = random.Next(this.Width - button1.Width);
            
            int stepX = (newX - x) ;
            
            button1.Location = new Point(newX);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            date = dateTimePicker1.Value;
            if (date.DayOfWeek==DayOfWeek.Wednesday)
            {
                MessageBox.Show("Сьогодні середа");
            }
            if (date.DayOfWeek == DayOfWeek.Tuesday)
            {
                MessageBox.Show("Сьогодні вівторок");
            }
            if (date.DayOfWeek == DayOfWeek.Thursday)
            {
                MessageBox.Show("Сьогодні четвер");
            }
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Сьогодні неділя");
            }
            if (date.DayOfWeek == DayOfWeek.Saturday)
            {
                MessageBox.Show("Сьогодні субота");
            }
            if (date.DayOfWeek == DayOfWeek.Monday)
            {
                MessageBox.Show("Сьогодні понеділок");
            }
            if (date.DayOfWeek == DayOfWeek.Friday)
            {
                MessageBox.Show("Сьогодні п'ятниця");
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal date1 = numericUpDown1.Value;
            decimal date2 = numericUpDown2.Value;
            decimal date3 = numericUpDown3.Value;


            DateTime date = new DateTime(((int)date3),((int)date2),((int)date1));

            MessageBox.Show(date.ToString());
            if (date.DayOfWeek == DayOfWeek.Wednesday)
            {
                MessageBox.Show("Сьогодні середа");
            }
            if (date.DayOfWeek == DayOfWeek.Tuesday)
            {
                MessageBox.Show("Сьогодні вівторок");
            }
            if (date.DayOfWeek == DayOfWeek.Thursday)
            {
                MessageBox.Show("Сьогодні четвер");
            }
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Сьогодні неділя");
            }
            if (date.DayOfWeek == DayOfWeek.Saturday)
            {
                MessageBox.Show("Сьогодні субота");
            }
            if (date.DayOfWeek == DayOfWeek.Monday)
            {
                MessageBox.Show("Сьогодні понеділок");
            }
            if (date.DayOfWeek == DayOfWeek.Friday)
            {
                MessageBox.Show("Сьогодні п'ятниця");
            }
        }
    }
}