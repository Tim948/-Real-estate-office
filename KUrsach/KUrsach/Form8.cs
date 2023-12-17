using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUrsach
{
    public partial class F8 : Form
    {
        public F8()
        {
            InitializeComponent();
        }

        private void городаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.городаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.riealtor_kurDataSet);

        }

        private void F8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riealtor_kurDataSet.Улицы". При необходимости она может быть перемещена или удалена.
            this.улицыTableAdapter.Fill(this.riealtor_kurDataSet.Улицы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riealtor_kurDataSet.Города". При необходимости она может быть перемещена или удалена.
            this.городаTableAdapter.Fill(this.riealtor_kurDataSet.Города);

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private F9 dob;
        private void button2_Click(object sender, EventArgs e)
        {
            dob = new F9();
            dob.Visible = true;
        }
    }
}
