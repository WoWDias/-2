using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсач2
{
    public partial class Form8 : Form
    {
        private OleDbDataReader reader;

        public Form8()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            string captcha = txtcaptcha.Text;
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
            OleDbConnection dbconnection = new OleDbConnection(connectionString);

            dbconnection.Open();
            string query = "SELECT*FROM login where user='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
            OleDbCommand dbCommand = new OleDbCommand(query, dbconnection);
            dbCommand.CommandText = query;
            reader = dbCommand.ExecuteReader();
            if (textBox1.Text == "" || textBox2.Text == "" || txtcaptcha.Text == "")
            {
                MessageBox.Show("Поля не должны быть пустыми!", "Внимание!");
            }
            else
            {
                if (lbcaptcha.Text == txtcaptcha.Text)
                {
                    MessageBox.Show("Код проверки введён правильно!", "Внимание!");
                }
                else
                {
                    MessageBox.Show("Код проверки введён неправильно!", "Внимание!");
                    this.OnLoad(e);
                    return;
                }
                if (reader.Read())
                {
                    MessageBox.Show("Вы успешно авторизовались!", "Внимание!");
                    this.Hide();
                    Form3 fr3 = new Form3();
                    fr3.Show();
                    Hide();
                }
                else
                {
                    dbconnection.Close();
                    MessageBox.Show("Неверный логин или пароль!", "Внимание!");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 fr9 = new Form9();
            fr9.Show();
            Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(6, 8);
            string captcha = "";
            int totl = 0;
            do
            {
                int chr = rand.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha = captcha + (char)chr;
                    totl++;
                    if (totl == num)
                        break;
                    {

                    }
                }
            } while (true);
            lbcaptcha.Text = captcha;
        }

        private void lbcaptcha_Click(object sender, EventArgs e)
        {

        }
    }
}
/*this.OnLoad(e);*/