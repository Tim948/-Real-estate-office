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
    public partial class F7 : Form
    {
        public F7()
        {
            InitializeComponent();
        }

        private void подрядчикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.подрядчикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.riealtor_kurDataSet);

        }

        private void F7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riealtor_kurDataSet.Подрядчик". При необходимости она может быть перемещена или удалена.
            this.подрядчикTableAdapter.Fill(this.riealtor_kurDataSet.Подрядчик);

        }

        private void тИПLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
