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

namespace Курсач2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void обПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На данной форме представлены все запчасти которые есть в наличии и их стоимость!", "Внимание!");
        }

        private void button_download_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
            OleDbConnection dbconnection = new OleDbConnection(connectionString);

            dbconnection.Open();
            string query = "Select * FROM Запчасти";
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
                    dataGridView1.Rows.Add(dbReader["id"], dbReader["Наименование"], dbReader["Цена"]);
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
                dataGridView1.Rows[index].Cells[2].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string Наименование = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string Цена = dataGridView1.Rows[index].Cells[2].Value.ToString();

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
            OleDbConnection dbconnection = new OleDbConnection(connectionString);

            dbconnection.Open();
            string query = "Insert INTO Запчасти VALUES (" + id + ", '" + Наименование + "', '" + Цена + "')";
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
                dataGridView1.Rows[index].Cells[2].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string Наименование = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string Цена = dataGridView1.Rows[index].Cells[2].Value.ToString();


            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
            OleDbConnection dbconnection = new OleDbConnection(connectionString);

            dbconnection.Open();
            string query = "UPDATE Запчасти SET Наименование = '" + Наименование + "',Цена='" + Цена + "' Where id = " + id;
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
            string query = "DELETE FROM Запчасти WHERE id = " + id;
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
