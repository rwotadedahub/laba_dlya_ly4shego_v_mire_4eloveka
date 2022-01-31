
namespace HR_department
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.TBFlat = new System.Windows.Forms.TextBox();
            this.TBHouse = new System.Windows.Forms.TextBox();
            this.TBStreet = new System.Windows.Forms.TextBox();
            this.TBPhoneNumber = new System.Windows.Forms.TextBox();
            this.TBDepartment = new System.Windows.Forms.TextBox();
            this.TBBirthday = new System.Windows.Forms.TextBox();
            this.TBPatronymic = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBSurname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TBFlat1 = new System.Windows.Forms.TextBox();
            this.TBHouse1 = new System.Windows.Forms.TextBox();
            this.TBStreet1 = new System.Windows.Forms.TextBox();
            this.TBPhoneNumber1 = new System.Windows.Forms.TextBox();
            this.TBDepartment1 = new System.Windows.Forms.TextBox();
            this.TBBirthday1 = new System.Windows.Forms.TextBox();
            this.TBPatronymic1 = new System.Windows.Forms.TextBox();
            this.TBName1 = new System.Windows.Forms.TextBox();
            this.TBSurname1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.comboBoxFilterDepartment = new System.Windows.Forms.ComboBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TBForIDDelete = new System.Windows.Forms.TextBox();
            this.labelFiltr = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(239, 473);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonInsert);
            this.tabPage1.Controls.Add(this.TBFlat);
            this.tabPage1.Controls.Add(this.TBHouse);
            this.tabPage1.Controls.Add(this.TBStreet);
            this.tabPage1.Controls.Add(this.TBPhoneNumber);
            this.tabPage1.Controls.Add(this.TBDepartment);
            this.tabPage1.Controls.Add(this.TBBirthday);
            this.tabPage1.Controls.Add(this.TBPatronymic);
            this.tabPage1.Controls.Add(this.TBName);
            this.tabPage1.Controls.Add(this.TBSurname);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(231, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(28, 359);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(181, 48);
            this.buttonInsert.TabIndex = 28;
            this.buttonInsert.Text = "Добавить в базу данных";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // TBFlat
            // 
            this.TBFlat.Location = new System.Drawing.Point(109, 323);
            this.TBFlat.Name = "TBFlat";
            this.TBFlat.Size = new System.Drawing.Size(100, 20);
            this.TBFlat.TabIndex = 27;
            // 
            // TBHouse
            // 
            this.TBHouse.Location = new System.Drawing.Point(109, 286);
            this.TBHouse.Name = "TBHouse";
            this.TBHouse.Size = new System.Drawing.Size(100, 20);
            this.TBHouse.TabIndex = 26;
            // 
            // TBStreet
            // 
            this.TBStreet.Location = new System.Drawing.Point(109, 242);
            this.TBStreet.Name = "TBStreet";
            this.TBStreet.Size = new System.Drawing.Size(100, 20);
            this.TBStreet.TabIndex = 25;
            // 
            // TBPhoneNumber
            // 
            this.TBPhoneNumber.Location = new System.Drawing.Point(109, 207);
            this.TBPhoneNumber.Name = "TBPhoneNumber";
            this.TBPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.TBPhoneNumber.TabIndex = 24;
            // 
            // TBDepartment
            // 
            this.TBDepartment.Location = new System.Drawing.Point(109, 171);
            this.TBDepartment.Name = "TBDepartment";
            this.TBDepartment.Size = new System.Drawing.Size(100, 20);
            this.TBDepartment.TabIndex = 23;
            // 
            // TBBirthday
            // 
            this.TBBirthday.Location = new System.Drawing.Point(109, 136);
            this.TBBirthday.Name = "TBBirthday";
            this.TBBirthday.Size = new System.Drawing.Size(100, 20);
            this.TBBirthday.TabIndex = 22;
            // 
            // TBPatronymic
            // 
            this.TBPatronymic.Location = new System.Drawing.Point(109, 101);
            this.TBPatronymic.Name = "TBPatronymic";
            this.TBPatronymic.Size = new System.Drawing.Size(100, 20);
            this.TBPatronymic.TabIndex = 21;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(109, 62);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 20;
            // 
            // TBSurname
            // 
            this.TBSurname.Location = new System.Drawing.Point(109, 27);
            this.TBSurname.Name = "TBSurname";
            this.TBSurname.Size = new System.Drawing.Size(100, 20);
            this.TBSurname.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Квартира";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Дом";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Улица";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Номер телефона";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Отдел";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Фамилия";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UpdateButton);
            this.tabPage2.Controls.Add(this.tbID);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.TBFlat1);
            this.tabPage2.Controls.Add(this.TBHouse1);
            this.tabPage2.Controls.Add(this.TBStreet1);
            this.tabPage2.Controls.Add(this.TBPhoneNumber1);
            this.tabPage2.Controls.Add(this.TBDepartment1);
            this.tabPage2.Controls.Add(this.TBBirthday1);
            this.tabPage2.Controls.Add(this.TBPatronymic1);
            this.tabPage2.Controls.Add(this.TBName1);
            this.tabPage2.Controls.Add(this.TBSurname1);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(231, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактирование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(30, 386);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(172, 40);
            this.UpdateButton.TabIndex = 30;
            this.UpdateButton.Text = "Редактировать по ID";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(111, 24);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 47;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 13);
            this.label21.TabIndex = 46;
            this.label21.Text = "ID";
            // 
            // TBFlat1
            // 
            this.TBFlat1.Location = new System.Drawing.Point(111, 355);
            this.TBFlat1.Name = "TBFlat1";
            this.TBFlat1.Size = new System.Drawing.Size(100, 20);
            this.TBFlat1.TabIndex = 45;
            // 
            // TBHouse1
            // 
            this.TBHouse1.Location = new System.Drawing.Point(111, 318);
            this.TBHouse1.Name = "TBHouse1";
            this.TBHouse1.Size = new System.Drawing.Size(100, 20);
            this.TBHouse1.TabIndex = 44;
            // 
            // TBStreet1
            // 
            this.TBStreet1.Location = new System.Drawing.Point(111, 274);
            this.TBStreet1.Name = "TBStreet1";
            this.TBStreet1.Size = new System.Drawing.Size(100, 20);
            this.TBStreet1.TabIndex = 43;
            // 
            // TBPhoneNumber1
            // 
            this.TBPhoneNumber1.Location = new System.Drawing.Point(111, 239);
            this.TBPhoneNumber1.Name = "TBPhoneNumber1";
            this.TBPhoneNumber1.Size = new System.Drawing.Size(100, 20);
            this.TBPhoneNumber1.TabIndex = 42;
            // 
            // TBDepartment1
            // 
            this.TBDepartment1.Location = new System.Drawing.Point(111, 203);
            this.TBDepartment1.Name = "TBDepartment1";
            this.TBDepartment1.Size = new System.Drawing.Size(100, 20);
            this.TBDepartment1.TabIndex = 41;
            // 
            // TBBirthday1
            // 
            this.TBBirthday1.Location = new System.Drawing.Point(111, 168);
            this.TBBirthday1.Name = "TBBirthday1";
            this.TBBirthday1.Size = new System.Drawing.Size(100, 20);
            this.TBBirthday1.TabIndex = 40;
            // 
            // TBPatronymic1
            // 
            this.TBPatronymic1.Location = new System.Drawing.Point(111, 133);
            this.TBPatronymic1.Name = "TBPatronymic1";
            this.TBPatronymic1.Size = new System.Drawing.Size(100, 20);
            this.TBPatronymic1.TabIndex = 39;
            // 
            // TBName1
            // 
            this.TBName1.Location = new System.Drawing.Point(111, 94);
            this.TBName1.Name = "TBName1";
            this.TBName1.Size = new System.Drawing.Size(100, 20);
            this.TBName1.TabIndex = 38;
            // 
            // TBSurname1
            // 
            this.TBSurname1.Location = new System.Drawing.Point(111, 59);
            this.TBSurname1.Name = "TBSurname1";
            this.TBSurname1.Size = new System.Drawing.Size(100, 20);
            this.TBSurname1.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Квартира";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 321);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Дом";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Улица";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Номер телефона";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Отдел";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 175);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Дата рождения";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Отчество";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Имя";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Фамилия";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(239, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 351);
            this.dataGridView1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Поиск";
            // 
            // TBSearch
            // 
            this.TBSearch.Location = new System.Drawing.Point(290, 409);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(204, 20);
            this.TBSearch.TabIndex = 3;
            this.TBSearch.TextChanged += new System.EventHandler(this.TBSearch_TextChanged);
            // 
            // comboBoxFilterDepartment
            // 
            this.comboBoxFilterDepartment.FormattingEnabled = true;
            this.comboBoxFilterDepartment.Items.AddRange(new object[] {
            "Все",
            "Аналитический",
            "Хозяйственный",
            "Рабочий",
            "Управляющий",
            "Охраняющий"});
            this.comboBoxFilterDepartment.Location = new System.Drawing.Point(290, 440);
            this.comboBoxFilterDepartment.Name = "comboBoxFilterDepartment";
            this.comboBoxFilterDepartment.Size = new System.Drawing.Size(156, 21);
            this.comboBoxFilterDepartment.TabIndex = 4;
            this.comboBoxFilterDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterDepartment_SelectedIndexChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(857, 365);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(172, 48);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Удалить из базы данных";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(541, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Введите ID удаляемого элемента";
            // 
            // TBForIDDelete
            // 
            this.TBForIDDelete.Location = new System.Drawing.Point(725, 381);
            this.TBForIDDelete.Name = "TBForIDDelete";
            this.TBForIDDelete.Size = new System.Drawing.Size(100, 20);
            this.TBForIDDelete.TabIndex = 29;
            // 
            // labelFiltr
            // 
            this.labelFiltr.AutoSize = true;
            this.labelFiltr.Location = new System.Drawing.Point(241, 448);
            this.labelFiltr.Name = "labelFiltr";
            this.labelFiltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelFiltr.Size = new System.Drawing.Size(47, 13);
            this.labelFiltr.TabIndex = 30;
            this.labelFiltr.Text = "Фильтр";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 473);
            this.Controls.Add(this.labelFiltr);
            this.Controls.Add(this.TBForIDDelete);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.comboBoxFilterDepartment);
            this.Controls.Add(this.TBSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TBFlat;
        private System.Windows.Forms.TextBox TBHouse;
        private System.Windows.Forms.TextBox TBStreet;
        private System.Windows.Forms.TextBox TBPhoneNumber;
        private System.Windows.Forms.TextBox TBDepartment;
        private System.Windows.Forms.TextBox TBBirthday;
        private System.Windows.Forms.TextBox TBPatronymic;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBSurname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.ComboBox comboBoxFilterDepartment;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBForIDDelete;
        private System.Windows.Forms.TextBox TBFlat1;
        private System.Windows.Forms.TextBox TBHouse1;
        private System.Windows.Forms.TextBox TBStreet1;
        private System.Windows.Forms.TextBox TBPhoneNumber1;
        private System.Windows.Forms.TextBox TBDepartment1;
        private System.Windows.Forms.TextBox TBBirthday1;
        private System.Windows.Forms.TextBox TBPatronymic1;
        private System.Windows.Forms.TextBox TBName1;
        private System.Windows.Forms.TextBox TBSurname1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label labelFiltr;
    }
}

