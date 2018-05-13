using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Retry
{
    public partial class Guest_Form : Form
    {
        public Guest_Form(string data)
        {
            InitializeComponent();
            this.data = data;
        }
        string data;

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Login_Screen();
            this.Hide();
            f2.Show();
        }

        private void Teacher_G_Click(object sender, EventArgs e)
        {
            Form f2 = new Teacher(data);
            this.Hide();
            f2.Show();
        }

        private void Guest_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Class". При необходимости она может быть перемещена или удалена.
            this.classTableAdapter.Fill(this.dataSet.Class);


            if (data == "1")
            {
                label1.Text = "Здравствуй, Guest!";
                Add_Schoolboy.Visible = false;
            }
            if (data == "2") label1.Text = "Здравствуй, User!";
        }

        private void Add_Schoolboy_Click(object sender, EventArgs e)
        {
            Form f2 = new Schoolboy(data);
            this.Hide();
            f2.Show();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            List<string> Data = new List<string>();
            using (OleDbConnection connection = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:/DATA/Тимур данные/Coding/Retry/Retry.mdb"))
            {
                try
                {
                    connection.Open();
                    OleDbCommand select = new OleDbCommand();
                    select.Connection = connection;
                    select.CommandText = "SELECT Last_Name, First_Name, Fathers_Name, Waybill, B_Date FROM Schoolboy Where ID_Class =" + comboBox2.SelectedValue;
                    OleDbDataReader reader = select.ExecuteReader();
                    while (reader.Read())
                    {
                        Data.Add(reader[0].ToString());
                        Data.Add(reader[1].ToString());
                        Data.Add(reader[2].ToString());
                        Data.Add(reader[3].ToString());
                        string[] tmp = reader[4].ToString().Split(' ');
                        Data.Add(tmp[0]);
                    }
                    connection.Close();
                    reader.Close();
                    Form f2 = new Class_view(data,Data,comboBox2.Text.ToString());
                    this.Hide();
                    f2.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
