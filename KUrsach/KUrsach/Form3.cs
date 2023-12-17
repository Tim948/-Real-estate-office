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
    public partial class Dob : Form
    {
        public Dob()
        {
            InitializeComponent();
        }

        private void обьекты_НедвижимостиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.обьекты_НедвижимостиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.riealtor_kurDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riealtor_kurDataSet.Улицы". При необходимости она может быть перемещена или удалена.
            this.улицыTableAdapter.Fill(this.riealtor_kurDataSet.Улицы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riealtor_kurDataSet.Типы_Недвижимости". При необходимости она может быть перемещена или удалена.
            this.типы_НедвижимостиTableAdapter.Fill(this.riealtor_kurDataSet.Типы_Недвижимости);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riealtor_kurDataSet.Обьекты_Недвижимости". При необходимости она может быть перемещена или удалена.
            this.обьекты_НедвижимостиTableAdapter.Fill(this.riealtor_kurDataSet.Обьекты_Недвижимости);

        }

        private void тип_Недвижимости_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private F8 dob;
        private void button2_Click(object sender, EventArgs e)
        {
            dob = new F8();
            dob.Visible = true;
        }
    }
}
