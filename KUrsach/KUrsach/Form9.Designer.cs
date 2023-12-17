namespace KUrsach
{
    partial class F9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F9));
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label города_IDLabel;
            this.riealtor_kurDataSet = new KUrsach.Riealtor_kurDataSet();
            this.улицыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.улицыTableAdapter = new KUrsach.Riealtor_kurDataSetTableAdapters.УлицыTableAdapter();
            this.tableAdapterManager = new KUrsach.Riealtor_kurDataSetTableAdapters.TableAdapterManager();
            this.улицыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.улицыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.города_IDComboBox = new System.Windows.Forms.ComboBox();
            this.городаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.городаTableAdapter = new KUrsach.Riealtor_kurDataSetTableAdapters.ГородаTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.городаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameLabel = new System.Windows.Forms.Label();
            города_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.riealtor_kurDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.улицыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.улицыBindingNavigator)).BeginInit();
            this.улицыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.городаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.городаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // riealtor_kurDataSet
            // 
            this.riealtor_kurDataSet.DataSetName = "Riealtor_kurDataSet";
            this.riealtor_kurDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // улицыBindingSource
            // 
            this.улицыBindingSource.DataMember = "Улицы";
            this.улицыBindingSource.DataSource = this.riealtor_kurDataSet;
            // 
            // улицыTableAdapter
            // 
            this.улицыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = KUrsach.Riealtor_kurDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГородаTableAdapter = this.городаTableAdapter;
            this.tableAdapterManager.Обьекты_НедвижимостиTableAdapter = null;
            this.tableAdapterManager.ОперацииTableAdapter = null;
            this.tableAdapterManager.ПодрядчикTableAdapter = null;
            this.tableAdapterManager.Типы_НедвижимостиTableAdapter = null;
            this.tableAdapterManager.Типы_ОперацииTableAdapter = null;
            this.tableAdapterManager.УлицыTableAdapter = this.улицыTableAdapter;
            // 
            // улицыBindingNavigator
            // 
            this.улицыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.улицыBindingNavigator.BindingSource = this.улицыBindingSource;
            this.улицыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.улицыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.улицыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.улицыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.улицыBindingNavigatorSaveItem});
            this.улицыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.улицыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.улицыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.улицыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.улицыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.улицыBindingNavigator.Name = "улицыBindingNavigator";
            this.улицыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.улицыBindingNavigator.Size = new System.Drawing.Size(734, 27);
            this.улицыBindingNavigator.TabIndex = 0;
            this.улицыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // улицыBindingNavigatorSaveItem
            // 
            this.улицыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.улицыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("улицыBindingNavigatorSaveItem.Image")));
            this.улицыBindingNavigatorSaveItem.Name = "улицыBindingNavigatorSaveItem";
            this.улицыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.улицыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.улицыBindingNavigatorSaveItem.Click += new System.EventHandler(this.улицыBindingNavigatorSaveItem_Click);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(103, 140);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(120, 16);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Название улицы:";
            nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.улицыBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(76, 171);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(177, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // города_IDLabel
            // 
            города_IDLabel.AutoSize = true;
            города_IDLabel.Location = new System.Drawing.Point(129, 56);
            города_IDLabel.Name = "города_IDLabel";
            города_IDLabel.Size = new System.Drawing.Size(72, 16);
            города_IDLabel.TabIndex = 3;
            города_IDLabel.Text = "ID города:";
            // 
            // города_IDComboBox
            // 
            this.города_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.улицыBindingSource, "Города_ID", true));
            this.города_IDComboBox.DataSource = this.городаBindingSource;
            this.города_IDComboBox.DisplayMember = "ID";
            this.города_IDComboBox.FormattingEnabled = true;
            this.города_IDComboBox.Location = new System.Drawing.Point(76, 86);
            this.города_IDComboBox.Name = "города_IDComboBox";
            this.города_IDComboBox.Size = new System.Drawing.Size(177, 24);
            this.города_IDComboBox.TabIndex = 4;
            // 
            // городаBindingSource
            // 
            this.городаBindingSource.DataMember = "Города";
            this.городаBindingSource.DataSource = this.riealtor_kurDataSet;
            // 
            // городаTableAdapter
            // 
            this.городаTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Перед закрытием не забудте сохранить!";
            // 
            // городаDataGridView
            // 
            this.городаDataGridView.AutoGenerateColumns = false;
            this.городаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.городаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.городаDataGridView.DataSource = this.городаBindingSource;
            this.городаDataGridView.Location = new System.Drawing.Point(349, 30);
            this.городаDataGridView.Name = "городаDataGridView";
            this.городаDataGridView.RowHeadersWidth = 51;
            this.городаDataGridView.RowTemplate.Height = 24;
            this.городаDataGridView.Size = new System.Drawing.Size(322, 303);
            this.городаDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // F9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 353);
            this.Controls.Add(this.городаDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(города_IDLabel);
            this.Controls.Add(this.города_IDComboBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.улицыBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F9";
            this.Text = "Улицы";
            this.Load += new System.EventHandler(this.F9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.riealtor_kurDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.улицыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.улицыBindingNavigator)).EndInit();
            this.улицыBindingNavigator.ResumeLayout(false);
            this.улицыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.городаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.городаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Riealtor_kurDataSet riealtor_kurDataSet;
        private System.Windows.Forms.BindingSource улицыBindingSource;
        private Riealtor_kurDataSetTableAdapters.УлицыTableAdapter улицыTableAdapter;
        private Riealtor_kurDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator улицыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton улицыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox города_IDComboBox;
        private Riealtor_kurDataSetTableAdapters.ГородаTableAdapter городаTableAdapter;
        private System.Windows.Forms.BindingSource городаBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView городаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}