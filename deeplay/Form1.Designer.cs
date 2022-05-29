
namespace deeplay
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deeplayworker1DataSet = new deeplay.deeplayworker1DataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.workerfullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.workerpost = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.actionbox = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addsex = new System.Windows.Forms.ComboBox();
            this.adddob = new System.Windows.Forms.TextBox();
            this.addfullname = new System.Windows.Forms.TextBox();
            this.addpost = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.changeId = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.changesex = new System.Windows.Forms.ComboBox();
            this.changebirth = new System.Windows.Forms.TextBox();
            this.changefullname = new System.Windows.Forms.TextBox();
            this.changepost = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.delid = new System.Windows.Forms.TextBox();
            this.delfullname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.workersTableAdapter = new deeplay.deeplayworker1DataSetTableAdapters.workersTableAdapter();
            this.label15 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deeplayworker1DataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 88);
            this.button1.TabIndex = 0;
            this.button1.Text = "добавить сотрудника в базу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 697);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "post";
            this.postDataGridViewTextBoxColumn.HeaderText = "post";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "workers";
            this.workersBindingSource.DataSource = this.deeplayworker1DataSet;
            // 
            // deeplayworker1DataSet
            // 
            this.deeplayworker1DataSet.DataSetName = "deeplayworker1DataSet";
            this.deeplayworker1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(604, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(404, 697);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.workerfullname);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.workerpost);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.actionbox);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(396, 668);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Контроль";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "ФИО сотрудника";
            // 
            // workerfullname
            // 
            this.workerfullname.Location = new System.Drawing.Point(16, 192);
            this.workerfullname.Name = "workerfullname";
            this.workerfullname.Size = new System.Drawing.Size(368, 22);
            this.workerfullname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "должность сотрудника";
            // 
            // workerpost
            // 
            this.workerpost.FormattingEnabled = true;
            this.workerpost.Items.AddRange(new object[] {
            "Директор",
            "Руководитель подразделения",
            "Контролер",
            "Рабочий"});
            this.workerpost.Location = new System.Drawing.Point(16, 236);
            this.workerpost.Name = "workerpost";
            this.workerpost.Size = new System.Drawing.Size(368, 24);
            this.workerpost.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбирайте действия";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(368, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Выполнять";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // actionbox
            // 
            this.actionbox.FormattingEnabled = true;
            this.actionbox.Items.AddRange(new object[] {
            "выбор сотрудника",
            "повысить должность"});
            this.actionbox.Location = new System.Drawing.Point(16, 146);
            this.actionbox.Name = "actionbox";
            this.actionbox.Size = new System.Drawing.Size(368, 24);
            this.actionbox.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.addsex);
            this.tabPage1.Controls.Add(this.adddob);
            this.tabPage1.Controls.Add(this.addfullname);
            this.tabPage1.Controls.Add(this.addpost);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(396, 668);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Пол";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Должность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дата рождение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "ФИО сотрудника";
            // 
            // addsex
            // 
            this.addsex.FormattingEnabled = true;
            this.addsex.Items.AddRange(new object[] {
            "мужской",
            "женской"});
            this.addsex.Location = new System.Drawing.Point(6, 321);
            this.addsex.Name = "addsex";
            this.addsex.Size = new System.Drawing.Size(384, 28);
            this.addsex.TabIndex = 4;
            // 
            // adddob
            // 
            this.adddob.Location = new System.Drawing.Point(6, 152);
            this.adddob.Name = "adddob";
            this.adddob.Size = new System.Drawing.Size(384, 26);
            this.adddob.TabIndex = 3;
            // 
            // addfullname
            // 
            this.addfullname.Location = new System.Drawing.Point(6, 81);
            this.addfullname.Name = "addfullname";
            this.addfullname.Size = new System.Drawing.Size(384, 26);
            this.addfullname.TabIndex = 2;
            // 
            // addpost
            // 
            this.addpost.FormattingEnabled = true;
            this.addpost.Items.AddRange(new object[] {
            "Директор",
            "Руководитель подразделения",
            "Контролер",
            "Рабочий"});
            this.addpost.Location = new System.Drawing.Point(6, 235);
            this.addpost.Name = "addpost";
            this.addpost.Size = new System.Drawing.Size(384, 28);
            this.addpost.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.changeId);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.changesex);
            this.tabPage2.Controls.Add(this.changebirth);
            this.tabPage2.Controls.Add(this.changefullname);
            this.tabPage2.Controls.Add(this.changepost);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(396, 668);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Изменение";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 411);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Id сотрудника";
            // 
            // changeId
            // 
            this.changeId.Location = new System.Drawing.Point(6, 430);
            this.changeId.Name = "changeId";
            this.changeId.Size = new System.Drawing.Size(384, 22);
            this.changeId.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(6, 504);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(383, 47);
            this.button3.TabIndex = 14;
            this.button3.Text = "изменить данные сотрудника";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Пол";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Должность";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Дата рождение";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "ФИО сотрудника";
            // 
            // changesex
            // 
            this.changesex.FormattingEnabled = true;
            this.changesex.Items.AddRange(new object[] {
            "мужской",
            "женской"});
            this.changesex.Location = new System.Drawing.Point(6, 352);
            this.changesex.Name = "changesex";
            this.changesex.Size = new System.Drawing.Size(384, 24);
            this.changesex.TabIndex = 9;
            // 
            // changebirth
            // 
            this.changebirth.Location = new System.Drawing.Point(6, 225);
            this.changebirth.Name = "changebirth";
            this.changebirth.Size = new System.Drawing.Size(384, 22);
            this.changebirth.TabIndex = 8;
            // 
            // changefullname
            // 
            this.changefullname.Location = new System.Drawing.Point(6, 159);
            this.changefullname.Name = "changefullname";
            this.changefullname.Size = new System.Drawing.Size(384, 22);
            this.changefullname.TabIndex = 7;
            // 
            // changepost
            // 
            this.changepost.FormattingEnabled = true;
            this.changepost.Items.AddRange(new object[] {
            "Директор",
            "Руководитель подразделения",
            "Контролер",
            "Рабочий"});
            this.changepost.Location = new System.Drawing.Point(6, 282);
            this.changepost.Name = "changepost";
            this.changepost.Size = new System.Drawing.Size(384, 24);
            this.changepost.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(383, 63);
            this.label8.TabIndex = 0;
            this.label8.Text = "Замечания:\r\n        нажмите на датагридвю чтобы быстро \r\n        вводить данные н" +
    "а соответсвующие поля";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.delid);
            this.tabPage3.Controls.Add(this.delfullname);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(396, 668);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удаление";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(7, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(384, 73);
            this.button4.TabIndex = 22;
            this.button4.Text = "нажмите два раза, \r\nчтобы удалить данные сотрудника";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "Id сотрудника";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 16);
            this.label17.TabIndex = 21;
            this.label17.Text = "ФИО сотрудника";
            // 
            // delid
            // 
            this.delid.Location = new System.Drawing.Point(7, 210);
            this.delid.Name = "delid";
            this.delid.Size = new System.Drawing.Size(384, 22);
            this.delid.TabIndex = 16;
            // 
            // delfullname
            // 
            this.delfullname.Location = new System.Drawing.Point(7, 144);
            this.delfullname.Name = "delfullname";
            this.delfullname.Size = new System.Drawing.Size(384, 22);
            this.delfullname.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(3, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(383, 63);
            this.label13.TabIndex = 1;
            this.label13.Text = "Замечания:\r\n        нажмите на датагридвю чтобы быстро \r\n        вводить данные н" +
    "а соответсвующие поля";
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(3, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(383, 63);
            this.label15.TabIndex = 7;
            this.label15.Text = "Замечания:\r\n        нажмите на датагридвю чтобы быстро \r\n        вводить данные н" +
    "а соответсвующие поля";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(365, 57);
            this.button5.TabIndex = 8;
            this.button5.Text = "показать все данные из базы";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 721);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deeplayworker1DataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox workerfullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox workerpost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox actionbox;
        private deeplayworker1DataSet deeplayworker1DataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private deeplayworker1DataSetTableAdapters.workersTableAdapter workersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addsex;
        private System.Windows.Forms.TextBox adddob;
        private System.Windows.Forms.TextBox addfullname;
        private System.Windows.Forms.ComboBox addpost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox changesex;
        private System.Windows.Forms.TextBox changebirth;
        private System.Windows.Forms.TextBox changefullname;
        private System.Windows.Forms.ComboBox changepost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox delfullname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox delid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox changeId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button5;
    }
}

