using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void обПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На данной форме представлены выполненные заказы клиентов!", "Внимание!");
        }

        private void button_download_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
            OleDbConnection dbconnection = new OleDbConnection(connectionString);

            dbconnection.Open();
            string query = "Select * FROM Completed_works";
            OleDbCommand dbCommand = new OleDbCommand(query, dbconnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены!", "Ошибка!");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridView1.Rows.Add(dbReader["id"], dbReader["id_orders"], dbReader["Name"], dbReader["Surname"], dbReader["Услуга"], dbReader["Запчасть"], dbReader["Return_date"], dbReader["Стоимость"]);
                }
            }
            dbReader.Close();
            dbconnection.Close();  
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите 1 строку!", "Внимание!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null ||
                dataGridView1.Rows[index].Cells[6].Value == null ||
                dataGridView1.Rows[index].Cells[7].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string id_orders = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string name = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string surname = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string услуга = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string запчасть = dataGridView1.Rows[index].Cells[5].Value.ToString();
            string Return_date = dataGridView1.Rows[index].Cells[6].Value.ToString();
            string стоимость = dataGridView1.Rows[index].Cells[7].Value.ToString();


            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
            OleDbConnection dbconnection = new OleDbConnection(connectionString);

            dbconnection.Open();
            string query = "Insert INTO Completed_works VALUES (" + id + ", " + id_orders + ", '" + name + "', '" + surname + "', '" + услуга + "', '" + запчасть + "', '" + Return_date + "', '" + стоимость + "')";
            OleDbCommand dbCommand = new OleDbCommand(query, dbconnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Внимание!");
            else
                MessageBox.Show("Данные добавлены!", "Внимание!");

            dbconnection.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите 1 строку!", "Внимание!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null ||
                dataGridView1.Rows[index].Cells[6].Value == null ||
                dataGridView1.Rows[index].Cells[7].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string id_orders = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string name = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string surname = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string услуга = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string запчасть = dataGridView1.Rows[index].Cells[5].Value.ToString();
            string Return_date = dataGridView1.Rows[index].Cells[6].Value.ToString();
            string стоимость = dataGridView1.Rows[index].Cells[7].Value.ToString();

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
            OleDbConnection dbconnection = new OleDbConnection(connectionString);

            dbconnection.Open();
            string query = "UPDATE Completed_works SET id_orders=" + id_orders + ",Name ='" + name + "',Surname='" + surname + "',Услуга='" + услуга + "',Запчасть='" + запчасть + "',Return_date='" + Return_date + "',Стоимость='" + стоимость + "' Where id = " + id;
            OleDbCommand dbCommand = new OleDbCommand(query, dbconnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Внимание!");
            else
            {
                MessageBox.Show("Данные изменены!", "Внимание!");
            }

            dbconnection.Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите 1 строку!", "Внимание!");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
            OleDbConnection dbconnection = new OleDbConnection(connectionString);

            dbconnection.Open();
            string query = "DELETE FROM Completed_works WHERE id = " + id;
            OleDbCommand dbCommand = new OleDbCommand(query, dbconnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Внимание!");
            else
            {
                MessageBox.Show("Данные удалены!", "Внимание!");
                dataGridView1.Rows.RemoveAt(index);
            }

            dbconnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            Hide();
        }
    }
}
