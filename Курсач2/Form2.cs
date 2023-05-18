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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void обПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На данной форме представлены клиенты и их данные!", "Внимание!");
        }

        private void button_download_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
            OleDbConnection dbconnection = new OleDbConnection(connectionString);

            dbconnection.Open();
            string query = "Select * FROM Customers";
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
                    dataGridView1.Rows.Add(dbReader["id"], dbReader["Name"], dbReader["Surname"], dbReader["phone_number"], dbReader["Yeat_of_birth"], dbReader["Order_id"]);
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
                dataGridView1.Rows[index].Cells[5].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string name = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string surname = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string phone_number = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string Yeat_of_birth = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string Order_id = dataGridView1.Rows[index].Cells[5].Value.ToString();

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
            OleDbConnection dbconnection = new OleDbConnection(connectionString);

            dbconnection.Open();
            string query = "Insert INTO Customers VALUES (" + id + ", '" + name + "', '" + surname + "', '" + phone_number + "', '" + Yeat_of_birth + "', " + Order_id + ")";
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
                dataGridView1.Rows[index].Cells[5].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string name = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string surname = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string phone_number = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string Yeat_of_birth = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string Order_id = dataGridView1.Rows[index].Cells[5].Value.ToString();

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database2.mdb";
            OleDbConnection dbconnection = new OleDbConnection(connectionString);

            dbconnection.Open();
            string query = "UPDATE Customers SET Name = '" + name + "',Surname='" + surname + "',phone_number='" + phone_number + "',Yeat_of_birth='" + Yeat_of_birth + "',Order_id=" + Order_id + " Where id = " + id;
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
            string query = "DELETE FROM Customers WHERE id = " + id;
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
