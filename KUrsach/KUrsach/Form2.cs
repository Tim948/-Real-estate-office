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
    public partial class OB : Form
    {
        public OB()
        {
            InitializeComponent();
        }

        private void обьекты_НедвижимостиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.обьекты_НедвижимостиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.riealtor_kurDataSet);

        }

        private void OB_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riealtor_kurDataSet.Обьекты_Недвижимости". При необходимости она может быть перемещена или удалена.
            this.обьекты_НедвижимостиTableAdapter.Fill(this.riealtor_kurDataSet.Обьекты_Недвижимости);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < обьекты_НедвижимостиDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < обьекты_НедвижимостиDataGridView.RowCount - 1; j++)
                {
                    обьекты_НедвижимостиDataGridView[i, j].Style.BackColor = Color.White;
                    обьекты_НедвижимостиDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < обьекты_НедвижимостиDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < обьекты_НедвижимостиDataGridView.RowCount - 1; j++)
                {
                    if (обьекты_НедвижимостиDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        обьекты_НедвижимостиDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        обьекты_НедвижимостиDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
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
                    COL = dataGridViewTextBoxColumn8;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn9;
                    break;
                
            }
            //Блок If выполняет следующую операцию: если включён

            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать
            //таблицу по полю, заданному в переменной Col по возрастанию
            //(studentsDataGridView.Sort (Col, System.ComponentModel.ListSortDirection.
            //Ascending)), иначе по убыванию (studentsDataGridView.Sort (Col, System.
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked) обьекты_НедвижимостиDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else обьекты_НедвижимостиDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            обьекты_НедвижимостиBindingSource.Filter = "Name='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            обьекты_НедвижимостиBindingSource.Filter = "";
        }
        private OB NNomer;
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            NNomer = new OB();
            NNomer.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Dob dob;
        private void button6_Click(object sender, EventArgs e)
        {
            dob = new Dob();
            dob.Visible = true;
        }
    }
}
