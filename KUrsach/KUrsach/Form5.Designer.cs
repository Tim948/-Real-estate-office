namespace KUrsach
{
    partial class F5
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label типы_Операции_IDLabel;
            System.Windows.Forms.Label подрядчик_IDLabel;
            System.Windows.Forms.Label обьект_IDLabel;
            System.Windows.Forms.Label реальная_стоимостьLabel;
            System.Windows.Forms.Label дата_созданияLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F5));
            this.riealtor_kurDataSet = new KUrsach.Riealtor_kurDataSet();
            this.операцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.операцииTableAdapter = new KUrsach.Riealtor_kurDataSetTableAdapters.ОперацииTableAdapter();
            this.tableAdapterManager = new KUrsach.Riealtor_kurDataSetTableAdapters.TableAdapterManager();
            this.обьекты_НедвижимостиTableAdapter = new KUrsach.Riealtor_kurDataSetTableAdapters.Обьекты_НедвижимостиTableAdapter();
            this.подрядчикTableAdapter = new KUrsach.Riealtor_kurDataSetTableAdapters.ПодрядчикTableAdapter();
            this.типы_ОперацииTableAdapter = new KUrsach.Riealtor_kurDataSetTableAdapters.Типы_ОперацииTableAdapter();
            this.операцииBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.операцииBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.типы_Операции_IDComboBox = new System.Windows.Forms.ComboBox();
            this.типыОперацииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.подрядчик_IDComboBox = new System.Windows.Forms.ComboBox();
            this.подрядчикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типыОперацииBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.обьект_IDComboBox = new System.Windows.Forms.ComboBox();
            this.обьектыНедвижимостиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.реальная_стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.дата_созданияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            типы_Операции_IDLabel = new System.Windows.Forms.Label();
            подрядчик_IDLabel = new System.Windows.Forms.Label();
            обьект_IDLabel = new System.Windows.Forms.Label();
            реальная_стоимостьLabel = new System.Windows.Forms.Label();
            дата_созданияLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.riealtor_kurDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцииBindingNavigator)).BeginInit();
            this.операцииBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типыОперацииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подрядчикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типыОперацииBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обьектыНедвижимостиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(455, 78);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(76, 16);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Название:";
            nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // типы_Операции_IDLabel
            // 
            типы_Операции_IDLabel.AutoSize = true;
            типы_Операции_IDLabel.Location = new System.Drawing.Point(402, 116);
            типы_Операции_IDLabel.Name = "типы_Операции_IDLabel";
            типы_Операции_IDLabel.Size = new System.Drawing.Size(129, 16);
            типы_Операции_IDLabel.TabIndex = 3;
            типы_Операции_IDLabel.Text = "Типы Операции ID:";
            // 
            // подрядчик_IDLabel
            // 
            подрядчик_IDLabel.AutoSize = true;
            подрядчик_IDLabel.Location = new System.Drawing.Point(433, 156);
            подрядчик_IDLabel.Name = "подрядчик_IDLabel";
            подрядчик_IDLabel.Size = new System.Drawing.Size(98, 16);
            подрядчик_IDLabel.TabIndex = 5;
            подрядчик_IDLabel.Text = "Подрядчик ID:";
            // 
            // обьект_IDLabel
            // 
            обьект_IDLabel.AutoSize = true;
            обьект_IDLabel.Location = new System.Drawing.Point(458, 197);
            обьект_IDLabel.Name = "обьект_IDLabel";
            обьект_IDLabel.Size = new System.Drawing.Size(73, 16);
            обьект_IDLabel.TabIndex = 7;
            обьект_IDLabel.Text = "Обьект ID:";
            // 
            // реальная_стоимостьLabel
            // 
            реальная_стоимостьLabel.AutoSize = true;
            реальная_стоимостьLabel.Location = new System.Drawing.Point(387, 234);
            реальная_стоимостьLabel.Name = "реальная_стоимостьLabel";
            реальная_стоимостьLabel.Size = new System.Drawing.Size(144, 16);
            реальная_стоимостьLabel.TabIndex = 9;
            реальная_стоимостьLabel.Text = "Реальная стоимость:";
            // 
            // дата_созданияLabel
            // 
            дата_созданияLabel.AutoSize = true;
            дата_созданияLabel.Location = new System.Drawing.Point(424, 275);
            дата_созданияLabel.Name = "дата_созданияLabel";
            дата_созданияLabel.Size = new System.Drawing.Size(107, 16);
            дата_созданияLabel.TabIndex = 11;
            дата_созданияLabel.Text = "Дата создания:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(456, 319);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(75, 16);
            описаниеLabel.TabIndex = 13;
            описаниеLabel.Text = "Описание:";
            // 
            // riealtor_kurDataSet
            // 
            this.riealtor_kurDataSet.DataSetName = "Riealtor_kurDataSet";
            this.riealtor_kurDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // операцииBindingSource
            // 
            this.операцииBindingSource.DataMember = "Операции";
            this.операцииBindingSource.DataSource = this.riealtor_kurDataSet;
            // 
            // операцииTableAdapter
            // 
            this.операцииTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = KUrsach.Riealtor_kurDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГородаTableAdapter = null;
            this.tableAdapterManager.Обьекты_НедвижимостиTableAdapter = this.обьекты_НедвижимостиTableAdapter;
            this.tableAdapterManager.ОперацииTableAdapter = this.операцииTableAdapter;
            this.tableAdapterManager.ПодрядчикTableAdapter = this.подрядчикTableAdapter;
            this.tableAdapterManager.Типы_НедвижимостиTableAdapter = null;
            this.tableAdapterManager.Типы_ОперацииTableAdapter = this.типы_ОперацииTableAdapter;
            this.tableAdapterManager.УлицыTableAdapter = null;
            // 
            // обьекты_НедвижимостиTableAdapter
            // 
            this.обьекты_НедвижимостиTableAdapter.ClearBeforeFill = true;
            // 
            // подрядчикTableAdapter
            // 
            this.подрядчикTableAdapter.ClearBeforeFill = true;
            // 
            // типы_ОперацииTableAdapter
            // 
            this.типы_ОперацииTableAdapter.ClearBeforeFill = true;
            // 
            // операцииBindingNavigator
            // 
            this.операцииBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.операцииBindingNavigator.BindingSource = this.операцииBindingSource;
            this.операцииBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.операцииBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.операцииBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.операцииBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.операцииBindingNavigatorSaveItem});
            this.операцииBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.операцииBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.операцииBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.операцииBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.операцииBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.операцииBindingNavigator.Name = "операцииBindingNavigator";
            this.операцииBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.операцииBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.операцииBindingNavigator.TabIndex = 0;
            this.операцииBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // операцииBindingNavigatorSaveItem
            // 
            this.операцииBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.операцииBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("операцииBindingNavigatorSaveItem.Image")));
            this.операцииBindingNavigatorSaveItem.Name = "операцииBindingNavigatorSaveItem";
            this.операцииBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.операцииBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.операцииBindingNavigatorSaveItem.Click += new System.EventHandler(this.операцииBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.операцииBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(537, 75);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // типы_Операции_IDComboBox
            // 
            this.типы_Операции_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.операцииBindingSource, "Типы_Операции_ID", true));
            this.типы_Операции_IDComboBox.DataSource = this.типыОперацииBindingSource;
            this.типы_Операции_IDComboBox.DisplayMember = "ID";
            this.типы_Операции_IDComboBox.FormattingEnabled = true;
            this.типы_Операции_IDComboBox.Location = new System.Drawing.Point(537, 113);
            this.типы_Операции_IDComboBox.Name = "типы_Операции_IDComboBox";
            this.типы_Операции_IDComboBox.Size = new System.Drawing.Size(200, 24);
            this.типы_Операции_IDComboBox.TabIndex = 4;
            // 
            // типыОперацииBindingSource
            // 
            this.типыОперацииBindingSource.DataMember = "Типы_Операции";
            this.типыОперацииBindingSource.DataSource = this.riealtor_kurDataSet;
            // 
            // подрядчик_IDComboBox
            // 
            this.подрядчик_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.операцииBindingSource, "Подрядчик_ID", true));
            this.подрядчик_IDComboBox.DataSource = this.подрядчикBindingSource;
            this.подрядчик_IDComboBox.DisplayMember = "ID";
            this.подрядчик_IDComboBox.FormattingEnabled = true;
            this.подрядчик_IDComboBox.Location = new System.Drawing.Point(537, 153);
            this.подрядчик_IDComboBox.Name = "подрядчик_IDComboBox";
            this.подрядчик_IDComboBox.Size = new System.Drawing.Size(200, 24);
            this.подрядчик_IDComboBox.TabIndex = 6;
            // 
            // подрядчикBindingSource
            // 
            this.подрядчикBindingSource.DataMember = "Подрядчик";
            this.подрядчикBindingSource.DataSource = this.riealtor_kurDataSet;
            // 
            // типыОперацииBindingSource1
            // 
            this.типыОперацииBindingSource1.DataMember = "Типы_Операции";
            this.типыОперацииBindingSource1.DataSource = this.riealtor_kurDataSet;
            // 
            // обьект_IDComboBox
            // 
            this.обьект_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.операцииBindingSource, "Обьект_ID", true));
            this.обьект_IDComboBox.DataSource = this.обьектыНедвижимостиBindingSource;
            this.обьект_IDComboBox.DisplayMember = "ID";
            this.обьект_IDComboBox.FormattingEnabled = true;
            this.обьект_IDComboBox.Location = new System.Drawing.Point(537, 194);
            this.обьект_IDComboBox.Name = "обьект_IDComboBox";
            this.обьект_IDComboBox.Size = new System.Drawing.Size(200, 24);
            this.обьект_IDComboBox.TabIndex = 8;
            // 
            // обьектыНедвижимостиBindingSource
            // 
            this.обьектыНедвижимостиBindingSource.DataMember = "Обьекты_Недвижимости";
            this.обьектыНедвижимостиBindingSource.DataSource = this.riealtor_kurDataSet;
            // 
            // реальная_стоимостьTextBox
            // 
            this.реальная_стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.операцииBindingSource, "Реальная стоимость", true));
            this.реальная_стоимостьTextBox.Location = new System.Drawing.Point(537, 231);
            this.реальная_стоимостьTextBox.Name = "реальная_стоимостьTextBox";
            this.реальная_стоимостьTextBox.Size = new System.Drawing.Size(200, 22);
            this.реальная_стоимостьTextBox.TabIndex = 10;
            // 
            // дата_созданияDateTimePicker
            // 
            this.дата_созданияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.операцииBindingSource, "Дата создания", true));
            this.дата_созданияDateTimePicker.Location = new System.Drawing.Point(537, 271);
            this.дата_созданияDateTimePicker.Name = "дата_созданияDateTimePicker";
            this.дата_созданияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_созданияDateTimePicker.TabIndex = 12;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.операцииBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(537, 316);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(200, 22);
            this.описаниеTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(дата_созданияLabel);
            this.Controls.Add(this.дата_созданияDateTimePicker);
            this.Controls.Add(реальная_стоимостьLabel);
            this.Controls.Add(this.реальная_стоимостьTextBox);
            this.Controls.Add(обьект_IDLabel);
            this.Controls.Add(this.обьект_IDComboBox);
            this.Controls.Add(подрядчик_IDLabel);
            this.Controls.Add(this.подрядчик_IDComboBox);
            this.Controls.Add(типы_Операции_IDLabel);
            this.Controls.Add(this.типы_Операции_IDComboBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.операцииBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F5";
            this.Text = "Операции";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.riealtor_kurDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцииBindingNavigator)).EndInit();
            this.операцииBindingNavigator.ResumeLayout(false);
            this.операцииBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типыОперацииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подрядчикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типыОперацииBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обьектыНедвижимостиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Riealtor_kurDataSet riealtor_kurDataSet;
        private System.Windows.Forms.BindingSource операцииBindingSource;
        private Riealtor_kurDataSetTableAdapters.ОперацииTableAdapter операцииTableAdapter;
        private Riealtor_kurDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator операцииBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton операцииBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private Riealtor_kurDataSetTableAdapters.Типы_ОперацииTableAdapter типы_ОперацииTableAdapter;
        private System.Windows.Forms.ComboBox типы_Операции_IDComboBox;
        private System.Windows.Forms.BindingSource типыОперацииBindingSource;
        private System.Windows.Forms.ComboBox подрядчик_IDComboBox;
        private System.Windows.Forms.BindingSource типыОперацииBindingSource1;
        private Riealtor_kurDataSetTableAdapters.Обьекты_НедвижимостиTableAdapter обьекты_НедвижимостиTableAdapter;
        private System.Windows.Forms.ComboBox обьект_IDComboBox;
        private System.Windows.Forms.BindingSource обьектыНедвижимостиBindingSource;
        private System.Windows.Forms.TextBox реальная_стоимостьTextBox;
        private System.Windows.Forms.DateTimePicker дата_созданияDateTimePicker;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.Button button1;
        private Riealtor_kurDataSetTableAdapters.ПодрядчикTableAdapter подрядчикTableAdapter;
        private System.Windows.Forms.BindingSource подрядчикBindingSource;
    }
}