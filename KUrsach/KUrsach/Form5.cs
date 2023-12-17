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
    public partial class F5 : Form
    {
        public F5()
        {
            InitializeComponent();
        }

        private void операцииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.операцииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.riealtor_kurDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riealtor_kurDataSet.Подрядчик". При необходимости она может быть перемещена или удалена.
            this.подрядчикTableAdapter.Fill(this.riealtor_kurDataSet.Подрядчик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riealtor_kurDataSet.Обьекты_Недвижимости". При необходимости она может быть перемещена или удалена.
            this.обьекты_НедвижимостиTableAdapter.Fill(this.riealtor_kurDataSet.Обьекты_Недвижимости);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riealtor_kurDataSet.Типы_Операции". При необходимости она может быть перемещена или удалена.
            this.типы_ОперацииTableAdapter.Fill(this.riealtor_kurDataSet.Типы_Операции);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riealtor_kurDataSet.Операции". При необходимости она может быть перемещена или удалена.
            this.операцииTableAdapter.Fill(this.riealtor_kurDataSet.Операции);

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
