using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumber
{
    public partial class Form1 : Form
    {
        //veriables
        int year;
        int month;
        int day;
        int luckyNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //year
            int birthYear = 1930;
            for (int i = 1930; i <= 2021; i++)
            {
                comboBox1.Items.Add(birthYear);
                birthYear += 1;
            }
            
            //month
            int birthMonth = 1;
            for (int i = 1; i < 13; i++)
            {
                comboBox2.Items.Add(birthMonth);
                birthMonth++;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();

            int[] monthDays = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int daysInMonth = monthDays[comboBox2.SelectedIndex];
            for (int i = 1; i < daysInMonth + 1; i++)
            {
                comboBox3.Items.Add(i);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0 || comboBox3.SelectedIndex < 0)
            {
                MessageBox.Show("You must fill out the form to get a lucky number!");
            }
            else
            {

                year = int.Parse(comboBox1.SelectedItem.ToString());
                month = int.Parse(comboBox2.SelectedItem.ToString());
                day = int.Parse(comboBox3.SelectedItem.ToString());

                luckyNumber = (year / day) * ((month / year) ^ 2);

                //hide from1 
                this.Hide();
                //created a instance of results form
                Form2 f2 = new Form2();
                //show form2
                f2.luckyNumberLabel1.Text = luckyNumber.ToString();
                f2.ShowDialog();
                f2 = null;

                //show form1 after closing from2
                this.Show();


            }
        }
    }
}
