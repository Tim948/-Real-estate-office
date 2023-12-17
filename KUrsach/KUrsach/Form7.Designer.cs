namespace KUrsach
{
    partial class F7
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
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label день_рожденияLabel;
            System.Windows.Forms.Label eMail1Label;
            System.Windows.Forms.Label eMail2Label;
            System.Windows.Forms.Label телефон_1Label;
            System.Windows.Forms.Label телефон_2Label;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label дата_созданияLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label тИПLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F7));
            this.riealtor_kurDataSet = new KUrsach.Riealtor_kurDataSet();
            this.подрядчикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.подрядчикTableAdapter = new KUrsach.Riealtor_kurDataSetTableAdapters.ПодрядчикTableAdapter();
            this.tableAdapterManager = new KUrsach.Riealtor_kurDataSetTableAdapters.TableAdapterManager();
            this.подрядчикBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.подрядчикBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.день_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eMail1TextBox = new System.Windows.Forms.TextBox();
            this.eMail2TextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.дата_созданияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.телефон_1MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.телефон_2MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.тИПMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            день_рожденияLabel = new System.Windows.Forms.Label();
            eMail1Label = new System.Windows.Forms.Label();
            eMail2Label = new System.Windows.Forms.Label();
            телефон_1Label = new System.Windows.Forms.Label();
            телефон_2Label = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            дата_созданияLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            тИПLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.riealtor_kurDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подрядчикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подрядчикBindingNavigator)).BeginInit();
            this.подрядчикBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(10, 36);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(69, 16);
            фамилияLabel.TabIndex = 1;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(43, 71);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(36, 16);
            имяLabel.TabIndex = 3;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(6, 110);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(73, 16);
            отчествоLabel.TabIndex = 5;
            отчествоLabel.Text = "Отчество:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(43, 149);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(36, 16);
            полLabel.TabIndex = 7;
            полLabel.Text = "Пол:";
            // 
            // день_рожденияLabel
            // 
            день_рожденияLabel.AutoSize = true;
            день_рожденияLabel.Location = new System.Drawing.Point(45, 190);
            день_рожденияLabel.Name = "день_рожденияLabel";
            день_рожденияLabel.Size = new System.Drawing.Size(34, 16);
            день_рожденияLabel.TabIndex = 9;
            день_рожденияLabel.Text = "Д.Р.:";
            // 
            // eMail1Label
            // 
            eMail1Label.AutoSize = true;
            eMail1Label.Location = new System.Drawing.Point(28, 229);
            eMail1Label.Name = "eMail1Label";
            eMail1Label.Size = new System.Drawing.Size(51, 16);
            eMail1Label.TabIndex = 11;
            eMail1Label.Text = "EMail1:";
            // 
            // eMail2Label
            // 
            eMail2Label.AutoSize = true;
            eMail2Label.Location = new System.Drawing.Point(28, 269);
            eMail2Label.Name = "eMail2Label";
            eMail2Label.Size = new System.Drawing.Size(51, 16);
            eMail2Label.TabIndex = 13;
            eMail2Label.Text = "EMail2:";
            // 
            // телефон_1Label
            // 
            телефон_1Label.AutoSize = true;
            телефон_1Label.Location = new System.Drawing.Point(-1, 311);
            телефон_1Label.Name = "телефон_1Label";
            телефон_1Label.Size = new System.Drawing.Size(80, 16);
            телефон_1Label.TabIndex = 15;
            телефон_1Label.Text = "Телефон 1:";
            // 
            // телефон_2Label
            // 
            телефон_2Label.AutoSize = true;
            телефон_2Label.Location = new System.Drawing.Point(-1, 349);
            телефон_2Label.Name = "телефон_2Label";
            телефон_2Label.Size = new System.Drawing.Size(80, 16);
            телефон_2Label.TabIndex = 17;
            телефон_2Label.Text = "Телефон 2:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(29, 386);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(50, 16);
            адресLabel.TabIndex = 19;
            адресLabel.Text = "Адрес:";
            // 
            // дата_созданияLabel
            // 
            дата_созданияLabel.AutoSize = true;
            дата_созданияLabel.Location = new System.Drawing.Point(467, 62);
            дата_созданияLabel.Name = "дата_созданияLabel";
            дата_созданияLabel.Size = new System.Drawing.Size(107, 16);
            дата_созданияLabel.TabIndex = 21;
            дата_созданияLabel.Text = "Дата создания:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(499, 104);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(75, 16);
            описаниеLabel.TabIndex = 23;
            описаниеLabel.Text = "Описание:";
            // 
            // тИПLabel
            // 
            тИПLabel.AutoSize = true;
            тИПLabel.Location = new System.Drawing.Point(544, 149);
            тИПLabel.Name = "тИПLabel";
            тИПLabel.Size = new System.Drawing.Size(35, 16);
            тИПLabel.TabIndex = 25;
            тИПLabel.Text = "Тип:";
            тИПLabel.Click += new System.EventHandler(this.тИПLabel_Click);
            // 
            // riealtor_kurDataSet
            // 
            this.riealtor_kurDataSet.DataSetName = "Riealtor_kurDataSet";
            this.riealtor_kurDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // подрядчикBindingSource
            // 
            this.подрядчикBindingSource.DataMember = "Подрядчик";
            this.подрядчикBindingSource.DataSource = this.riealtor_kurDataSet;
            // 
            // подрядчикTableAdapter
            // 
            this.подрядчикTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = KUrsach.Riealtor_kurDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГородаTableAdapter = null;
            this.tableAdapterManager.Обьекты_НедвижимостиTableAdapter = null;
            this.tableAdapterManager.ОперацииTableAdapter = null;
            this.tableAdapterManager.ПодрядчикTableAdapter = this.подрядчикTableAdapter;
            this.tableAdapterManager.Типы_НедвижимостиTableAdapter = null;
            this.tableAdapterManager.Типы_ОперацииTableAdapter = null;
            this.tableAdapterManager.УлицыTableAdapter = null;
            // 
            // подрядчикBindingNavigator
            // 
            this.подрядчикBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.подрядчикBindingNavigator.BindingSource = this.подрядчикBindingSource;
            this.подрядчикBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.подрядчикBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.подрядчикBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.подрядчикBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.подрядчикBindingNavigatorSaveItem});
            this.подрядчикBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.подрядчикBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.подрядчикBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.подрядчикBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.подрядчикBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.подрядчикBindingNavigator.Name = "подрядчикBindingNavigator";
            this.подрядчикBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.подрядчикBindingNavigator.Size = new System.Drawing.Size(809, 27);
            this.подрядчикBindingNavigator.TabIndex = 0;
            this.подрядчикBindingNavigator.Text = "bindingNavigator1";
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
            // подрядчикBindingNavigatorSaveItem
            // 
            this.подрядчикBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.подрядчикBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("подрядчикBindingNavigatorSaveItem.Image")));
            this.подрядчикBindingNavigatorSaveItem.Name = "подрядчикBindingNavigatorSaveItem";
            this.подрядчикBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.подрядчикBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.подрядчикBindingNavigatorSaveItem.Click += new System.EventHandler(this.подрядчикBindingNavigatorSaveItem_Click);
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подрядчикBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(85, 33);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(233, 22);
            this.фамилияTextBox.TabIndex = 2;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подрядчикBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(85, 68);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(233, 22);
            this.имяTextBox.TabIndex = 4;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подрядчикBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(85, 107);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(233, 22);
            this.отчествоTextBox.TabIndex = 6;
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подрядчикBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(85, 146);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(233, 22);
            this.полTextBox.TabIndex = 8;
            // 
            // день_рожденияDateTimePicker
            // 
            this.день_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.подрядчикBindingSource, "День рождения", true));
            this.день_рожденияDateTimePicker.Location = new System.Drawing.Point(85, 185);
            this.день_рожденияDateTimePicker.Name = "день_рожденияDateTimePicker";
            this.день_рожденияDateTimePicker.Size = new System.Drawing.Size(233, 22);
            this.день_рожденияDateTimePicker.TabIndex = 10;
            // 
            // eMail1TextBox
            // 
            this.eMail1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подрядчикBindingSource, "EMail1", true));
            this.eMail1TextBox.Location = new System.Drawing.Point(85, 226);
            this.eMail1TextBox.Name = "eMail1TextBox";
            this.eMail1TextBox.Size = new System.Drawing.Size(233, 22);
            this.eMail1TextBox.TabIndex = 12;
            // 
            // eMail2TextBox
            // 
            this.eMail2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подрядчикBindingSource, "EMail2", true));
            this.eMail2TextBox.Location = new System.Drawing.Point(85, 266);
            this.eMail2TextBox.Name = "eMail2TextBox";
            this.eMail2TextBox.Size = new System.Drawing.Size(233, 22);
            this.eMail2TextBox.TabIndex = 14;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подрядчикBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(85, 383);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(233, 22);
            this.адресTextBox.TabIndex = 20;
            // 
            // дата_созданияDateTimePicker
            // 
            this.дата_созданияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.подрядчикBindingSource, "Дата создания", true));
            this.дата_созданияDateTimePicker.Location = new System.Drawing.Point(589, 62);
            this.дата_созданияDateTimePicker.Name = "дата_созданияDateTimePicker";
            this.дата_созданияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_созданияDateTimePicker.TabIndex = 22;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подрядчикBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(589, 104);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(200, 22);
            this.описаниеTextBox.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 34);
            this.button1.TabIndex = 27;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // телефон_1MaskedTextBox
            // 
            this.телефон_1MaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подрядчикBindingSource, "Телефон_1", true));
            this.телефон_1MaskedTextBox.Location = new System.Drawing.Point(85, 305);
            this.телефон_1MaskedTextBox.Mask = "00000000000";
            this.телефон_1MaskedTextBox.Name = "телефон_1MaskedTextBox";
            this.телефон_1MaskedTextBox.Size = new System.Drawing.Size(233, 22);
            this.телефон_1MaskedTextBox.TabIndex = 29;
            // 
            // телефон_2MaskedTextBox
            // 
            this.телефон_2MaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подрядчикBindingSource, "Телефон_2", true));
            this.телефон_2MaskedTextBox.Location = new System.Drawing.Point(85, 346);
            this.телефон_2MaskedTextBox.Mask = "00000000000";
            this.телефон_2MaskedTextBox.Name = "телефон_2MaskedTextBox";
            this.телефон_2MaskedTextBox.Size = new System.Drawing.Size(233, 22);
            this.телефон_2MaskedTextBox.TabIndex = 30;
            // 
            // тИПMaskedTextBox
            // 
            this.тИПMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подрядчикBindingSource, "ТИП", true));
            this.тИПMaskedTextBox.Location = new System.Drawing.Point(589, 146);
            this.тИПMaskedTextBox.Mask = "0";
            this.тИПMaskedTextBox.Name = "тИПMaskedTextBox";
            this.тИПMaskedTextBox.Size = new System.Drawing.Size(200, 22);
            this.тИПMaskedTextBox.TabIndex = 31;
            // 
            // F7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.тИПMaskedTextBox);
            this.Controls.Add(this.телефон_2MaskedTextBox);
            this.Controls.Add(this.телефон_1MaskedTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(тИПLabel);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(дата_созданияLabel);
            this.Controls.Add(this.дата_созданияDateTimePicker);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(телефон_2Label);
            this.Controls.Add(телефон_1Label);
            this.Controls.Add(eMail2Label);
            this.Controls.Add(this.eMail2TextBox);
            this.Controls.Add(eMail1Label);
            this.Controls.Add(this.eMail1TextBox);
            this.Controls.Add(день_рожденияLabel);
            this.Controls.Add(this.день_рожденияDateTimePicker);
            this.Controls.Add(полLabel);
            this.Controls.Add(this.полTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(this.подрядчикBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F7";
            this.Text = "Подрядчик";
            this.Load += new System.EventHandler(this.F7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.riealtor_kurDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подрядчикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подрядчикBindingNavigator)).EndInit();
            this.подрядчикBindingNavigator.ResumeLayout(false);
            this.подрядчикBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Riealtor_kurDataSet riealtor_kurDataSet;
        private System.Windows.Forms.BindingSource подрядчикBindingSource;
        private Riealtor_kurDataSetTableAdapters.ПодрядчикTableAdapter подрядчикTableAdapter;
        private Riealtor_kurDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator подрядчикBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton подрядчикBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.DateTimePicker день_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox eMail1TextBox;
        private System.Windows.Forms.TextBox eMail2TextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.DateTimePicker дата_созданияDateTimePicker;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox телефон_1MaskedTextBox;
        private System.Windows.Forms.MaskedTextBox телефон_2MaskedTextBox;
        private System.Windows.Forms.MaskedTextBox тИПMaskedTextBox;
    }
}