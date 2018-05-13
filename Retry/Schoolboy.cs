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
    public partial class Schoolboy : Form
    {
        public Schoolboy(string data)
        {
            InitializeComponent();
            this.data = data;
        }
        string data;
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                schoolboyBindingSource.EndEdit();
                schoolboyTableAdapter.Update(this.dataSet.Schoolboy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                schoolboyBindingSource.ResetBindings(false);
            }
        }

        private void Schoolboy_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Class". При необходимости она может быть перемещена или удалена.
            this.classTableAdapter.Fill(this.dataSet.Class);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Sex". При необходимости она может быть перемещена или удалена.
            this.sexTableAdapter.Fill(this.dataSet.Sex);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Schoolboy". При необходимости она может быть перемещена или удалена.
            this.schoolboyTableAdapter.Fill(this.dataSet.Schoolboy);

            this.dataSet.Schoolboy.AddSchoolboyRow(this.dataSet.Schoolboy.NewSchoolboyRow());
            schoolboyBindingSource.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Guest_Form(data);
            this.Hide();
            f2.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.schoolboyTableAdapter.FillBy(this.dataSet.Schoolboy);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
