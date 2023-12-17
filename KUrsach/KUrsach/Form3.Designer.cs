namespace KUrsach
{
    partial class Dob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dob));
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label тип_Недвижимости_IDLabel;
            System.Windows.Forms.Label улицы_IDLabel;
            System.Windows.Forms.Label номер_обьектаLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label дата_созданияLabel;
            this.riealtor_kurDataSet = new KUrsach.Riealtor_kurDataSet();
            this.обьекты_НедвижимостиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.обьекты_НедвижимостиTableAdapter = new KUrsach.Riealtor_kurDataSetTableAdapters.Обьекты_НедвижимостиTableAdapter();
            this.tableAdapterManager = new KUrsach.Riealtor_kurDataSetTableAdapters.TableAdapterManager();
            this.обьекты_НедвижимостиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.обьекты_НедвижимостиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.номер_обьектаTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.дата_созданияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.тип_Недвижимости_IDComboBox = new System.Windows.Forms.ComboBox();
            this.типыНедвижимостиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типы_НедвижимостиTableAdapter = new KUrsach.Riealtor_kurDataSetTableAdapters.Типы_НедвижимостиTableAdapter();
            this.улицы_IDComboBox = new System.Windows.Forms.ComboBox();
            this.улицыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.улицыTableAdapter = new KUrsach.Riealtor_kurDataSetTableAdapters.УлицыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.улицыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            тип_Недвижимости_IDLabel = new System.Windows.Forms.Label();
            улицы_IDLabel = new System.Windows.Forms.Label();
            номер_обьектаLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            дата_созданияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.riealtor_kurDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обьекты_НедвижимостиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обьекты_НедвижимостиBindingNavigator)).BeginInit();
            this.обьекты_НедвижимостиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типыНедвижимостиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.улицыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.улицыBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // riealtor_kurDataSet
            // 
            this.riealtor_kurDataSet.DataSetName = "Riealtor_kurDataSet";
            this.riealtor_kurDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // обьекты_НедвижимостиBindingSource
            // 
            this.обьекты_НедвижимостиBindingSource.DataMember = "Обьекты_Недвижимости";
            this.обьекты_НедвижимостиBindingSource.DataSource = this.riealtor_kurDataSet;
            // 
            // обьекты_НедвижимостиTableAdapter
            // 
            this.обьекты_НедвижимостиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = KUrsach.Riealtor_kurDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГородаTableAdapter = null;
            this.tableAdapterManager.Обьекты_НедвижимостиTableAdapter = this.обьекты_НедвижимостиTableAdapter;
            this.tableAdapterManager.ОперацииTableAdapter = null;
            this.tableAdapterManager.ПодрядчикTableAdapter = null;
            this.tableAdapterManager.Типы_НедвижимостиTableAdapter = this.типы_НедвижимостиTableAdapter;
            this.tableAdapterManager.Типы_ОперацииTableAdapter = null;
            this.tableAdapterManager.УлицыTableAdapter = this.улицыTableAdapter;
            // 
            // обьекты_НедвижимостиBindingNavigator
            // 
            this.обьекты_НедвижимостиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.обьекты_НедвижимостиBindingNavigator.BindingSource = this.обьекты_НедвижимостиBindingSource;
            this.обьекты_НедвижимостиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.обьекты_НедвижимостиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.обьекты_НедвижимостиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.обьекты_НедвижимостиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.обьекты_НедвижимостиBindingNavigatorSaveItem});
            this.обьекты_НедвижимостиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.обьекты_НедвижимостиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.обьекты_НедвижимостиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.обьекты_НедвижимостиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.обьекты_НедвижимостиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.обьекты_НедвижимостиBindingNavigator.Name = "обьекты_НедвижимостиBindingNavigator";
            this.обьекты_НедвижимостиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.обьекты_НедвижимостиBindingNavigator.Size = new System.Drawing.Size(913, 31);
            this.обьекты_НедвижимостиBindingNavigator.TabIndex = 0;
            this.обьекты_НедвижимостиBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
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
            // обьекты_НедвижимостиBindingNavigatorSaveItem
            // 
            this.обьекты_НедвижимостиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.обьекты_НедвижимостиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("обьекты_НедвижимостиBindingNavigatorSaveItem.Image")));
            this.обьекты_НедвижимостиBindingNavigatorSaveItem.Name = "обьекты_НедвижимостиBindingNavigatorSaveItem";
            this.обьекты_НедвижимостиBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.обьекты_НедвижимостиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.обьекты_НедвижимостиBindingNavigatorSaveItem.Click += new System.EventHandler(this.обьекты_НедвижимостиBindingNavigatorSaveItem_Click);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            nameLabel.Location = new System.Drawing.Point(451, 48);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(76, 16);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Название:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.обьекты_НедвижимостиBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(548, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // тип_Недвижимости_IDLabel
            // 
            тип_Недвижимости_IDLabel.AutoSize = true;
            тип_Недвижимости_IDLabel.Location = new System.Drawing.Point(382, 83);
            тип_Недвижимости_IDLabel.Name = "тип_Недвижимости_IDLabel";
            тип_Недвижимости_IDLabel.Size = new System.Drawing.Size(145, 16);
            тип_Недвижимости_IDLabel.TabIndex = 3;
            тип_Недвижимости_IDLabel.Text = "Типы Недвижимости:";
            тип_Недвижимости_IDLabel.Click += new System.EventHandler(this.тип_Недвижимости_IDLabel_Click);
            // 
            // улицы_IDLabel
            // 
            улицы_IDLabel.AutoSize = true;
            улицы_IDLabel.Location = new System.Drawing.Point(474, 129);
            улицы_IDLabel.Name = "улицы_IDLabel";
            улицы_IDLabel.Size = new System.Drawing.Size(68, 16);
            улицы_IDLabel.TabIndex = 5;
            улицы_IDLabel.Text = "Улицы ID:";
            // 
            // номер_обьектаLabel
            // 
            номер_обьектаLabel.AutoSize = true;
            номер_обьектаLabel.Location = new System.Drawing.Point(433, 169);
            номер_обьектаLabel.Name = "номер_обьектаLabel";
            номер_обьектаLabel.Size = new System.Drawing.Size(109, 16);
            номер_обьектаLabel.TabIndex = 7;
            номер_обьектаLabel.Text = "Номер обьекта:";
            // 
            // номер_обьектаTextBox
            // 
            this.номер_обьектаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.обьекты_НедвижимостиBindingSource, "Номер обьекта", true));
            this.номер_обьектаTextBox.Location = new System.Drawing.Point(548, 166);
            this.номер_обьектаTextBox.Name = "номер_обьектаTextBox";
            this.номер_обьектаTextBox.Size = new System.Drawing.Size(200, 22);
            this.номер_обьектаTextBox.TabIndex = 8;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(492, 211);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(50, 16);
            адресLabel.TabIndex = 9;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.обьекты_НедвижимостиBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(548, 208);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(200, 22);
            this.адресTextBox.TabIndex = 10;
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(467, 249);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(75, 16);
            описаниеLabel.TabIndex = 11;
            описаниеLabel.Text = "Описание:";
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.обьекты_НедвижимостиBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(548, 246);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(200, 22);
            this.описаниеTextBox.TabIndex = 12;
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(462, 337);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(80, 16);
            стоимостьLabel.TabIndex = 13;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.обьекты_НедвижимостиBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(548, 334);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(200, 22);
            this.стоимостьTextBox.TabIndex = 14;
            // 
            // дата_созданияLabel
            // 
            дата_созданияLabel.AutoSize = true;
            дата_созданияLabel.Location = new System.Drawing.Point(435, 294);
            дата_созданияLabel.Name = "дата_созданияLabel";
            дата_созданияLabel.Size = new System.Drawing.Size(107, 16);
            дата_созданияLabel.TabIndex = 15;
            дата_созданияLabel.Text = "Дата создания:";
            // 
            // дата_созданияDateTimePicker
            // 
            this.дата_созданияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.обьекты_НедвижимостиBindingSource, "Дата создания", true));
            this.дата_созданияDateTimePicker.Location = new System.Drawing.Point(548, 290);
            this.дата_созданияDateTimePicker.Name = "дата_созданияDateTimePicker";
            this.дата_созданияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_созданияDateTimePicker.TabIndex = 16;
            // 
            // тип_Недвижимости_IDComboBox
            // 
            this.тип_Недвижимости_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.обьекты_НедвижимостиBindingSource, "Тип_Недвижимости_ID", true));
            this.тип_Недвижимости_IDComboBox.DataSource = this.типыНедвижимостиBindingSource;
            this.тип_Недвижимости_IDComboBox.DisplayMember = "ID";
            this.тип_Недвижимости_IDComboBox.FormattingEnabled = true;
            this.тип_Недвижимости_IDComboBox.Location = new System.Drawing.Point(548, 83);
            this.тип_Недвижимости_IDComboBox.Name = "тип_Недвижимости_IDComboBox";
            this.тип_Недвижимости_IDComboBox.Size = new System.Drawing.Size(200, 24);
            this.тип_Недвижимости_IDComboBox.TabIndex = 17;
            // 
            // типыНедвижимостиBindingSource
            // 
            this.типыНедвижимостиBindingSource.DataMember = "Типы_Недвижимости";
            this.типыНедвижимостиBindingSource.DataSource = this.riealtor_kurDataSet;
            // 
            // типы_НедвижимостиTableAdapter
            // 
            this.типы_НедвижимостиTableAdapter.ClearBeforeFill = true;
            // 
            // улицы_IDComboBox
            // 
            this.улицы_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.обьекты_НедвижимостиBindingSource, "Улицы_ID", true));
            this.улицы_IDComboBox.DataSource = this.улицыBindingSource1;
            this.улицы_IDComboBox.DisplayMember = "ID";
            this.улицы_IDComboBox.FormattingEnabled = true;
            this.улицы_IDComboBox.Location = new System.Drawing.Point(548, 121);
            this.улицы_IDComboBox.Name = "улицы_IDComboBox";
            this.улицы_IDComboBox.Size = new System.Drawing.Size(200, 24);
            this.улицы_IDComboBox.TabIndex = 18;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // улицыBindingSource1
            // 
            this.улицыBindingSource1.DataMember = "Улицы";
            this.улицыBindingSource1.DataSource = this.riealtor_kurDataSet;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(23, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 37);
            this.button2.TabIndex = 20;
            this.button2.Text = "Добавить город";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.улицы_IDComboBox);
            this.Controls.Add(this.тип_Недвижимости_IDComboBox);
            this.Controls.Add(дата_созданияLabel);
            this.Controls.Add(this.дата_созданияDateTimePicker);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(номер_обьектаLabel);
            this.Controls.Add(this.номер_обьектаTextBox);
            this.Controls.Add(улицы_IDLabel);
            this.Controls.Add(тип_Недвижимости_IDLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.обьекты_НедвижимостиBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dob";
            this.Text = "Добавить обьект недвижимости";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.riealtor_kurDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обьекты_НедвижимостиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обьекты_НедвижимостиBindingNavigator)).EndInit();
            this.обьекты_НедвижимостиBindingNavigator.ResumeLayout(false);
            this.обьекты_НедвижимостиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типыНедвижимостиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.улицыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.улицыBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Riealtor_kurDataSet riealtor_kurDataSet;
        private System.Windows.Forms.BindingSource обьекты_НедвижимостиBindingSource;
        private Riealtor_kurDataSetTableAdapters.Обьекты_НедвижимостиTableAdapter обьекты_НедвижимостиTableAdapter;
        private Riealtor_kurDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator обьекты_НедвижимостиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton обьекты_НедвижимостиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private Riealtor_kurDataSetTableAdapters.Типы_НедвижимостиTableAdapter типы_НедвижимостиTableAdapter;
        private System.Windows.Forms.TextBox номер_обьектаTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.DateTimePicker дата_созданияDateTimePicker;
        private System.Windows.Forms.ComboBox тип_Недвижимости_IDComboBox;
        private System.Windows.Forms.BindingSource типыНедвижимостиBindingSource;
        private Riealtor_kurDataSetTableAdapters.УлицыTableAdapter улицыTableAdapter;
        private System.Windows.Forms.ComboBox улицы_IDComboBox;
        private System.Windows.Forms.BindingSource улицыBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource улицыBindingSource1;
        private System.Windows.Forms.Button button2;
    }
}