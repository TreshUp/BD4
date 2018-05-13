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
    public partial class Teacher : Form
    {
        public Teacher(string data)
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.data = data;
        }
        string data;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Speciality". При необходимости она может быть перемещена или удалена.
            this.specialityTableAdapter.Fill(this.dataSet.Speciality);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Sex". При необходимости она может быть перемещена или удалена.
            this.sexTableAdapter.Fill(this.dataSet.Sex);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Teacher". При необходимости она может быть перемещена или удалена.
            this.teacherTableAdapter.Fill(this.dataSet.Teacher);
            if (data == "1")
            {
                Add.Enabled = false;
                Save.Enabled = false;
                Delete.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataSet.Teacher.AddTeacherRow(this.dataSet.Teacher.NewTeacherRow());
                teacherBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                teacherBindingSource.ResetBindings(false);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                teacherBindingSource.EndEdit();
                teacherTableAdapter.Update(this.dataSet.Teacher);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                teacherBindingSource.ResetBindings(false);
            }
        }
        private void first_Click(object sender, EventArgs e)
        {
            teacherBindingSource.MoveFirst();
        }

        private void pred_Click(object sender, EventArgs e)
        {
            teacherBindingSource.MovePrevious();
        }

        private void next_Click(object sender, EventArgs e)
        {
            teacherBindingSource.MoveNext();
        }

        private void last_Click(object sender, EventArgs e)
        {
            teacherBindingSource.MoveLast();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    teacherBindingSource.RemoveCurrent();
                    teacherBindingSource.EndEdit();
                    teacherTableAdapter.Update(this.dataSet.Teacher);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    teacherBindingSource.ResetBindings(false);
                }
            
        }

        private void Teacher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
               if (data!="1") Delete_Click(null, null);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f2 = new Guest_Form(data);
            this.Hide();
            f2.Show();
        }
    }
}
