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
    public partial class F6 : Form
    {
        public F6()
        {
            InitializeComponent();
        }

        private void подрядчикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.подрядчикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.riealtor_kurDataSet);

        }

        private void F6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riealtor_kurDataSet.Подрядчик". При необходимости она может быть перемещена или удалена.
            this.подрядчикTableAdapter.Fill(this.riealtor_kurDataSet.Подрядчик);

        }
        private System.Windows.Forms.DataGridViewColumn COL;
        private void button1_Click(object sender, EventArgs e)
        {
            //создает переменную COL для хранения имени выбранного столбца таблицы
            COL = new System.Windows.Forms.DataGridViewColumn();
            //блок switch, записывающий в
            //переменную Col имя выбранного столбца таблицы в зависимости от номера
            //выбранного пункта списка (ListBox1.SelectedIndex).
            //Нумерация пунктов списка начинается с нуля, а нумерация столбцов с единицы.
            //Первый столбец в списке ListBox1 - «Фамилия» носит в таблице имя
            // DataGridViewTextBoxColumn3, указанное в свойствах полей
            //в Меню действий таблицы.
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    COL = dataGridViewTextBoxColumn6;
                    break;
                case 4:
                    COL = dataGridViewTextBoxColumn11;
                    break;
                case 5:
                    COL = dataGridViewTextBoxColumn12;
                    break;
            }
            //Блок If выполняет следующую операцию: если включён

            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать
            //таблицу по полю, заданному в переменной Col по возрастанию
            //(studentsDataGridView.Sort (Col, System.ComponentModel.ListSortDirection.
            //Ascending)), иначе по убыванию (studentsDataGridView.Sort (Col, System.
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked) подрядчикDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else подрядчикDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            подрядчикBindingSource.Filter = "Фамилия='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            подрядчикBindingSource.Filter = "";
        }
        private F6 Alt;
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Alt = new F6();
            Alt.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private F7 aLt;
        private void button4_Click(object sender, EventArgs e)
        {
            aLt = new F7();
            aLt.Visible = true;
        }
    }
}
