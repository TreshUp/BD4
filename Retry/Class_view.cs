using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retry
{
    public partial class Class_view : Form
    {
        public Class_view(string data, List<string> Data, string Name_cl)
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            textbox1.Text = Name_cl;
            this.data = data;
            dataGridView1.RowCount = Data.Count / 5;
            int k = 0;
            for (int i=0;i< Data.Count/5;i++)
            {
                for (int j=0;j<5;j++)
                {
                    
                    dataGridView1.Rows[i].Cells[j].Value = Data[k];
                    k++;
                }
            }  
        }
        string data;
        public static void Update_text(Class_view f)
        {
            int i = f.dataGridView1.CurrentCell.RowIndex;
            f.textBox4.Text = f.dataGridView1.Rows[i].Cells[0].Value.ToString();
            f.textBox2.Text = f.dataGridView1.Rows[i].Cells[1].Value.ToString();
            f.textBox3.Text = f.dataGridView1.Rows[i].Cells[2].Value.ToString();
            f.textBox6.Text = f.dataGridView1.Rows[i].Cells[3].Value.ToString();
            f.textBox5.Text = f.dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
        private void Class_view_Load(object sender, EventArgs e)
        {
            Update_text(this);
        }

        private void next_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            if (i < dataGridView1.RowCount-1)
            {
                i++;
                dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                Update_text(this);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Guest_Form(data);
            this.Hide();
            f2.Show();
        }

        private void first_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            Update_text(this);
        }

        private void pred_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            if (i >0)
            {
                i--;
                dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                Update_text(this);
            }
        }

        private void last_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];
            Update_text(this);
        }
    }
}
