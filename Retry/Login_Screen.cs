using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;

namespace Retry
{
    public partial class Login_Screen : Form
    {
        public Login_Screen()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string log, pass="",lvl="";
            int k = 0;
            using (OleDbConnection connection = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:/DATA/Тимур данные/Coding/Retry/Retry.mdb"))
            {
                if (Login_text.Text != "")
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand select = new OleDbCommand();
                        select.Connection = connection;
                        select.CommandText = "SELECT Login, Pass,Lvl_Access FROM Log_Pass Where Login ='" + Login_text.Text + "'";
                        //"Select * From Accounts Where Lastname  = '" + searchtb.Text + "'";
                        OleDbDataReader reader = select.ExecuteReader();
                        while (reader.Read())
                        {
                            k++;
                            log = reader[0].ToString();
                            pass = reader[1].ToString();
                            lvl = reader[2].ToString();
                        }
                        connection.Close();
                        reader.Close();
                        if (k == 0) incorrect_login.Visible = true;
                        if (pass != Password_text.Text) incorrect_pass.Visible = true;
                        else
                        {
                            if (lvl == "1")
                            {
                                Form f2 = new Guest_Form(lvl);
                                this.Hide();
                                f2.Show(); 
                            }
                            if (lvl == "2")
                            {
                                Form f2 = new Guest_Form(lvl);
                                this.Hide();
                                f2.Show();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Нет входных параметров!");
            }  
        }

        private void Login_text_Click(object sender, EventArgs e)
        {
            incorrect_login.Visible = false;
        }

        private void Password_text_Click(object sender, EventArgs e)
        {
            incorrect_pass.Visible = false;
        }

        private void Login_Screen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enter_Click(null,null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
