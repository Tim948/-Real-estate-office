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
    public partial class F4 : Form
    {
        public F4()
        {
            InitializeComponent();
        }

        private void операцииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.операцииBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.riealtor_kurDataSet);

        }

        private void F4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riealtor_kurDataSet.Операции". При необходимости она может быть перемещена или удалена.
            this.операцииTableAdapter.Fill(this.riealtor_kurDataSet.Операции);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < операцииDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < операцииDataGridView.RowCount - 1; j++)
                {
                    операцииDataGridView[i, j].Style.BackColor = Color.White;
                    операцииDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
        private System.Windows.Forms.DataGridViewColumn COL;
        private void button2_Click(object sender, EventArgs e)
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
                    COL = dataGridViewTextBoxColumn7;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn6;
                    break;
                case 3:
                    COL = dataGridViewTextBoxColumn5;
                    break;
            }
            //Блок If выполняет следующую операцию: если включён

            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать
            //таблицу по полю, заданному в переменной Col по возрастанию
            //(studentsDataGridView.Sort (Col, System.ComponentModel.ListSortDirection.
            //Ascending)), иначе по убыванию (studentsDataGridView.Sort (Col, System.
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked) операцииDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else операцииDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }
        private F4 alt;
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            alt = new F4();
            alt.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private F5 Alt;
        private void button6_Click(object sender, EventArgs e)
        {
            Alt = new F5();
            Alt.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            операцииBindingSource.Filter = "Name='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            операцииBindingSource.Filter = "";
        }
    }
}
