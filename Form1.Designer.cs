namespace WinFormsAppBooks
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabAllStaff = new TabPage();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            buttonStaffDelete = new Button();
            textBoxStaffValueDelete = new TextBox();
            label8 = new Label();
            comboBoxStaffTypeDelete = new ComboBox();
            groupBox2 = new GroupBox();
            buttonStaffEdit = new Button();
            textBoxStaffEditPrice = new TextBox();
            label7 = new Label();
            textBoxStaffEditCount = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            comboBoxStaffEditType = new ComboBox();
            textBoxStaffNameEdit = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            buttonStaffSearch = new Button();
            buttonStaffResetSearch = new Button();
            textBoxStaffSearch = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBoxStaffSeacch = new ComboBox();
            dataGridViewStaff = new DataGridView();
            tabBooks = new TabPage();
            tabMagazines = new TabPage();
            tabPostcards = new TabPage();
            tabStationery = new TabPage();
            tabControl1.SuspendLayout();
            tabAllStaff.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabAllStaff);
            tabControl1.Controls.Add(tabBooks);
            tabControl1.Controls.Add(tabMagazines);
            tabControl1.Controls.Add(tabPostcards);
            tabControl1.Controls.Add(tabStationery);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(784, 561);
            tabControl1.TabIndex = 0;
            // 
            // tabAllStaff
            // 
            tabAllStaff.Controls.Add(panel1);
            tabAllStaff.Controls.Add(dataGridViewStaff);
            tabAllStaff.Location = new Point(4, 24);
            tabAllStaff.Name = "tabAllStaff";
            tabAllStaff.Padding = new Padding(3);
            tabAllStaff.Size = new Size(776, 533);
            tabAllStaff.TabIndex = 0;
            tabAllStaff.Text = "Весь ассортимент";
            tabAllStaff.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(501, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 527);
            panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonStaffDelete);
            groupBox3.Controls.Add(textBoxStaffValueDelete);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(comboBoxStaffTypeDelete);
            groupBox3.Location = new Point(3, 413);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(266, 109);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Удаление данных:";
            // 
            // buttonStaffDelete
            // 
            buttonStaffDelete.Enabled = false;
            buttonStaffDelete.Location = new Point(5, 79);
            buttonStaffDelete.Name = "buttonStaffDelete";
            buttonStaffDelete.Size = new Size(260, 29);
            buttonStaffDelete.TabIndex = 13;
            buttonStaffDelete.Text = "Удалить";
            buttonStaffDelete.UseVisualStyleBackColor = true;
            buttonStaffDelete.Click += buttonStaffDelete_Click;
            // 
            // textBoxStaffValueDelete
            // 
            textBoxStaffValueDelete.Location = new Point(91, 51);
            textBoxStaffValueDelete.Name = "textBoxStaffValueDelete";
            textBoxStaffValueDelete.Size = new Size(161, 23);
            textBoxStaffValueDelete.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 54);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 14;
            label8.Text = "Значение:";
            // 
            // comboBoxStaffTypeDelete
            // 
            comboBoxStaffTypeDelete.FormattingEnabled = true;
            comboBoxStaffTypeDelete.Location = new Point(10, 22);
            comboBoxStaffTypeDelete.Name = "comboBoxStaffTypeDelete";
            comboBoxStaffTypeDelete.Size = new Size(250, 23);
            comboBoxStaffTypeDelete.TabIndex = 13;
            comboBoxStaffTypeDelete.SelectedIndexChanged += comboBoxStaffTypeDelete_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonStaffEdit);
            groupBox2.Controls.Add(textBoxStaffEditPrice);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBoxStaffEditCount);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBoxStaffEditType);
            groupBox2.Controls.Add(textBoxStaffNameEdit);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(3, 166);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 241);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Изменение данных";
            // 
            // buttonStaffEdit
            // 
            buttonStaffEdit.Enabled = false;
            buttonStaffEdit.Location = new Point(2, 206);
            buttonStaffEdit.Name = "buttonStaffEdit";
            buttonStaffEdit.Size = new Size(260, 29);
            buttonStaffEdit.TabIndex = 6;
            buttonStaffEdit.Text = "Внести изменения";
            buttonStaffEdit.UseVisualStyleBackColor = true;
            buttonStaffEdit.Click += buttonStaffEdit_Click;
            // 
            // textBoxStaffEditPrice
            // 
            textBoxStaffEditPrice.Location = new Point(109, 177);
            textBoxStaffEditPrice.Name = "textBoxStaffEditPrice";
            textBoxStaffEditPrice.Size = new Size(143, 23);
            textBoxStaffEditPrice.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 180);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 12;
            label7.Text = "Цена:";
            // 
            // textBoxStaffEditCount
            // 
            textBoxStaffEditCount.Location = new Point(109, 148);
            textBoxStaffEditCount.Name = "textBoxStaffEditCount";
            textBoxStaffEditCount.Size = new Size(143, 23);
            textBoxStaffEditCount.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 151);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 10;
            label6.Text = "Кол. в наличии:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 118);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 7;
            label5.Text = "Тип:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(65, 79);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 8;
            label4.Text = "Новые данные:";
            // 
            // comboBoxStaffEditType
            // 
            comboBoxStaffEditType.FormattingEnabled = true;
            comboBoxStaffEditType.Items.AddRange(new object[] { "Книга", "Журнал", "Открытка", "Канцелярия" });
            comboBoxStaffEditType.Location = new Point(110, 115);
            comboBoxStaffEditType.Name = "comboBoxStaffEditType";
            comboBoxStaffEditType.Size = new Size(142, 23);
            comboBoxStaffEditType.TabIndex = 6;
            // 
            // textBoxStaffNameEdit
            // 
            textBoxStaffNameEdit.Location = new Point(6, 47);
            textBoxStaffNameEdit.Name = "textBoxStaffNameEdit";
            textBoxStaffNameEdit.Size = new Size(254, 23);
            textBoxStaffNameEdit.TabIndex = 7;
            textBoxStaffNameEdit.TextChanged += textBoxStaffNameEdit_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 26);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 6;
            label3.Text = "Наименование";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonStaffSearch);
            groupBox1.Controls.Add(buttonStaffResetSearch);
            groupBox1.Controls.Add(textBoxStaffSearch);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxStaffSeacch);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 157);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск";
            // 
            // buttonStaffSearch
            // 
            buttonStaffSearch.Enabled = false;
            buttonStaffSearch.Location = new Point(6, 128);
            buttonStaffSearch.Name = "buttonStaffSearch";
            buttonStaffSearch.Size = new Size(254, 23);
            buttonStaffSearch.TabIndex = 5;
            buttonStaffSearch.Text = "Найти";
            buttonStaffSearch.UseVisualStyleBackColor = true;
            buttonStaffSearch.Click += buttonStaffSearch_Click;
            // 
            // buttonStaffResetSearch
            // 
            buttonStaffResetSearch.Enabled = false;
            buttonStaffResetSearch.Location = new Point(6, 99);
            buttonStaffResetSearch.Name = "buttonStaffResetSearch";
            buttonStaffResetSearch.Size = new Size(254, 23);
            buttonStaffResetSearch.TabIndex = 4;
            buttonStaffResetSearch.Text = " Сбросить поиск";
            buttonStaffResetSearch.UseVisualStyleBackColor = true;
            buttonStaffResetSearch.Click += buttonStaffResetSearch_Click;
            // 
            // textBoxStaffSearch
            // 
            textBoxStaffSearch.Location = new Point(6, 70);
            textBoxStaffSearch.Name = "textBoxStaffSearch";
            textBoxStaffSearch.Size = new Size(254, 23);
            textBoxStaffSearch.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 49);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "Параметр поиска:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Тип поиска:";
            // 
            // comboBoxStaffSeacch
            // 
            comboBoxStaffSeacch.FormattingEnabled = true;
            comboBoxStaffSeacch.Location = new Point(118, 22);
            comboBoxStaffSeacch.Name = "comboBoxStaffSeacch";
            comboBoxStaffSeacch.Size = new Size(142, 23);
            comboBoxStaffSeacch.TabIndex = 0;
            comboBoxStaffSeacch.SelectedIndexChanged += comboBoxStaffSeacch_SelectedIndexChanged;
            // 
            // dataGridViewStaff
            // 
            dataGridViewStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewStaff.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaff.Dock = DockStyle.Fill;
            dataGridViewStaff.Location = new Point(3, 3);
            dataGridViewStaff.Name = "dataGridViewStaff";
            dataGridViewStaff.Size = new Size(770, 527);
            dataGridViewStaff.TabIndex = 0;
            // 
            // tabBooks
            // 
            tabBooks.Location = new Point(4, 24);
            tabBooks.Name = "tabBooks";
            tabBooks.Padding = new Padding(3);
            tabBooks.Size = new Size(776, 533);
            tabBooks.TabIndex = 1;
            tabBooks.Text = "Книги";
            tabBooks.UseVisualStyleBackColor = true;
            // 
            // tabMagazines
            // 
            tabMagazines.Location = new Point(4, 24);
            tabMagazines.Name = "tabMagazines";
            tabMagazines.Size = new Size(776, 533);
            tabMagazines.TabIndex = 2;
            tabMagazines.Text = "Журналы";
            tabMagazines.UseVisualStyleBackColor = true;
            // 
            // tabPostcards
            // 
            tabPostcards.Location = new Point(4, 24);
            tabPostcards.Name = "tabPostcards";
            tabPostcards.Size = new Size(776, 533);
            tabPostcards.TabIndex = 3;
            tabPostcards.Text = "Открытки";
            tabPostcards.UseVisualStyleBackColor = true;
            // 
            // tabStationery
            // 
            tabStationery.Location = new Point(4, 24);
            tabStationery.Name = "tabStationery";
            tabStationery.Size = new Size(776, 533);
            tabStationery.TabIndex = 4;
            tabStationery.Text = "Канцелярские товары";
            tabStationery.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(tabControl1);
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Книжный магазин";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabAllStaff.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabAllStaff;
        private TabPage tabBooks;
        private TabPage tabMagazines;
        private TabPage tabPostcards;
        private TabPage tabStationery;
        private Panel panel1;
        private DataGridView dataGridViewStaff;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TextBox textBoxStaffNameEdit;
        private Label label3;
        private GroupBox groupBox1;
        private Button buttonStaffSearch;
        private Button buttonStaffResetSearch;
        private TextBox textBoxStaffSearch;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxStaffSeacch;
        private TextBox textBoxStaffEditPrice;
        private Label label7;
        private TextBox textBoxStaffEditCount;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox comboBoxStaffEditType;
        private Button buttonStaffEdit;
        private Button buttonStaffDelete;
        private TextBox textBoxStaffValueDelete;
        private Label label8;
        private ComboBox comboBoxStaffTypeDelete;
    }
}
