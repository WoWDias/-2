using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсач2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсач2
{
    public partial class Form9 : Form
    {
        private string text = String.Empty;
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataReader reader;
        public static string connectString = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb");
        private OleDbConnection Connection;
        public Form9()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string spl_Chars = "$%^&?!=+-_:";
            string quiril = "йцукенгшщзхъфывапролджэячсмитьбюёЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮЁ";
            string Reg = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string Exep = "12345";
            string Exep1 = "qwerty";
            string Exep2 = "admin";

                connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb");
                connection.Open();
                command = new OleDbCommand();
                string registr = "INSERT INTO login ([user], [password], [password_repetition]) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                string str = "SELECT*FROM login where user='" + textBox1.Text + "'";
                command.Connection = connection;
                command.CommandText = str;
                reader = command.ExecuteReader();
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Поля не должны быть пустыми!", "Внимание!");
            }
            else
            {
                if (textBox2.Text == Exep || textBox2.Text == Exep1 || textBox2.Text == Exep2)
                {
                    MessageBox.Show("Пароль слишком простой", "Внимание!");
                }
                else
                {
                    if (textBox2.Text.Intersect(quiril).Any())
                    {
                        MessageBox.Show("Нельзя использовать русские буквы в пароле!", "Внимание!");
                    }
                    else
                    {
                        if (textBox2.Text.Intersect(Reg).Any())
                        {
                            MessageBox.Show("Нельзя использовать заглавные английские буквы в пароле", "Внимание!");
                        }
                        else
                        {
                            if (textBox2.Text.Intersect(spl_Chars).Any())
                            {
                                MessageBox.Show("Вы использовали символы в пароле!", "Внимание!");
                            }
                            if (textBox2.Text.Length < 5)
                            {
                                MessageBox.Show("Пароль короткий", "Внимание!");
                            }
                            else
                            {
                                if (textBox2.Text != textBox3.Text)
                                {
                                    MessageBox.Show("Пароли не совпадают!", "Внимание!");
                                }
                                else
                                {
                                    if (reader.Read())
                                    {
                                        MessageBox.Show("Введённый Логин занят!", "Внимание!");
                                    }
                                    else
                                    {

                                        command = new OleDbCommand(registr, connection);
                                        command.ExecuteNonQuery();
                                        connection.Close();
                                        textBox1.Text = "";
                                        textBox2.Text = "";
                                        this.Hide();
                                        Form8 fr8 = new Form8();
                                        fr8.Show();
                                        Hide();

                                        MessageBox.Show("Ваш аккаунт успешно создан!", "Внимание!");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    


        private void button2_Click(object sender, EventArgs e)
        {
            Form8 fr8 = new Form8();
            fr8.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
        }
    }
}

/*AND password = '" + textBox2.Text + "'
 * 
 dbCommand = new OleDbCommand();

dbCommand.Connection = dbconnection;

private OleDbDataReader reader;

if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Поля не должны быть пустыми!", "Внимание!");
            }
            else if (textBox1.Text != "" && textBox2.Text == "")
            {
                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
                OleDbConnection dbconnection = new OleDbConnection(connectionString);
                dbconnection.Open();
                string reg = "INSERT INTO login (user, password) VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
                string str = "SELECT*FROM login where user='" + textBox1.Text + "'";
                OleDbCommand dbCommand = new OleDbCommand(reg, dbconnection);
                dbCommand.Connection = dbconnection;
                dbCommand.CommandText = str;
                reader = dbCommand.ExecuteReader();
                if (reader.Read())
                {
                    this.Hide();
                    Form8 fr8 = new Form8();
                    fr8.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Такой пользователь уже зарегистрирован", "Внимание!");
                }
                dbconnection.Close();
            }
OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb");
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO login ([user], [password]) VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
            conn.Open();
            try
            {
                MessageBox.Show("Поля не должны быть пустыми!", "Внимание!");
                int rowsAffected = cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show(rowsAffected.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован", "Внимание!");
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            conn.Close();*/




/*if (textBox2.Text.Intersect(spl_Chars).Any())
{
    if (textBox2.Text.Length < 5)
    {
        MessageBox.Show("Пароль короткий", "Внимание!");
    }
    else
    {
        if (reader.Read())
        {
            MessageBox.Show("Введённый Логин занят", "Внимание!");
            this.Hide();
            Form3 fr3 = new Form3();
            fr3.Show();
            Hide();
        }
        else
        {

            command = new OleDbCommand(registr, connection);
            command.ExecuteNonQuery();
            connection.Close();
            textBox1.Text = "";
            textBox2.Text = "";

            MessageBox.Show("Ваш аккаунт успешно создан", "Внимание!");
        }
    }
}
*/
/*if (textBox3.Text == textBox2.Text)
{
    MessageBox.Show("Пароли не совпадают", "Внимание!");
}*/