
namespace OrderProccesing_Yudin_
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deaprtment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.normHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wageRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.responsible = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.necessaryEquipment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.consumablesMaterials = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countMaterials = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceMaterials = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.availability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.conumableMaterialsBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.responsibleBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.phoneNumberMaskBox = new System.Windows.Forms.MaskedTextBox();
            this.normHourNumeric = new System.Windows.Forms.NumericUpDown();
            this.countMaterialsNumeric = new System.Windows.Forms.NumericUpDown();
            this.priceMaterialsNumeric = new System.Windows.Forms.NumericUpDown();
            this.avaliabilityComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.wageRateNumeric = new System.Windows.Forms.NumericUpDown();
            this.necessaryEquipmentBox = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.idNumeric = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.normHourNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMaterialsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceMaterialsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageRateNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.fullName,
            this.deaprtment,
            this.phoneNumber,
            this.normHour,
            this.wageRate,
            this.responsible,
            this.necessaryEquipment,
            this.consumablesMaterials,
            this.countMaterials,
            this.priceMaterials,
            this.availability});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(533, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(576, 367);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 34;
            // 
            // fullName
            // 
            this.fullName.Text = "ФИО";
            this.fullName.Width = 127;
            // 
            // deaprtment
            // 
            this.deaprtment.Text = "Отдел";
            this.deaprtment.Width = 86;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Text = "Номер телефона";
            this.phoneNumber.Width = 126;
            // 
            // normHour
            // 
            this.normHour.Text = "Нормо-час";
            this.normHour.Width = 87;
            // 
            // wageRate
            // 
            this.wageRate.Text = "Ставка запрлаты";
            this.wageRate.Width = 151;
            // 
            // responsible
            // 
            this.responsible.Text = "Ответственный";
            this.responsible.Width = 119;
            // 
            // necessaryEquipment
            // 
            this.necessaryEquipment.Text = "Необходимое оборудование";
            this.necessaryEquipment.Width = 209;
            // 
            // consumablesMaterials
            // 
            this.consumablesMaterials.Text = "Расходные материалы";
            this.consumablesMaterials.Width = 160;
            // 
            // countMaterials
            // 
            this.countMaterials.Text = "Количество материалов";
            this.countMaterials.Width = 196;
            // 
            // priceMaterials
            // 
            this.priceMaterials.Text = "Стоимость материалов";
            this.priceMaterials.Width = 176;
            // 
            // availability
            // 
            this.availability.Text = "В наличии";
            this.availability.Width = 85;
            // 
            // fullNameBox
            // 
            this.fullNameBox.Location = new System.Drawing.Point(12, 12);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(137, 22);
            this.fullNameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отдел";
            // 
            // departmentBox
            // 
            this.departmentBox.Location = new System.Drawing.Point(12, 40);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(137, 22);
            this.departmentBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Нормо-час";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер телефона";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Количество материалов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Расходные материалы";
            // 
            // conumableMaterialsBox
            // 
            this.conumableMaterialsBox.Location = new System.Drawing.Point(12, 210);
            this.conumableMaterialsBox.Name = "conumableMaterialsBox";
            this.conumableMaterialsBox.Size = new System.Drawing.Size(137, 22);
            this.conumableMaterialsBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Необходимое оборудование";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ответственный";
            // 
            // responsibleBox
            // 
            this.responsibleBox.Location = new System.Drawing.Point(12, 154);
            this.responsibleBox.Name = "responsibleBox";
            this.responsibleBox.Size = new System.Drawing.Size(137, 22);
            this.responsibleBox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "В наличии";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(155, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Стоимость материалов";
            // 
            // phoneNumberMaskBox
            // 
            this.phoneNumberMaskBox.Location = new System.Drawing.Point(12, 68);
            this.phoneNumberMaskBox.Mask = "+7(000) 000-00-00";
            this.phoneNumberMaskBox.Name = "phoneNumberMaskBox";
            this.phoneNumberMaskBox.Size = new System.Drawing.Size(137, 22);
            this.phoneNumberMaskBox.TabIndex = 21;
            // 
            // normHourNumeric
            // 
            this.normHourNumeric.Location = new System.Drawing.Point(12, 97);
            this.normHourNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.normHourNumeric.Name = "normHourNumeric";
            this.normHourNumeric.Size = new System.Drawing.Size(137, 22);
            this.normHourNumeric.TabIndex = 22;
            // 
            // countMaterialsNumeric
            // 
            this.countMaterialsNumeric.Location = new System.Drawing.Point(12, 239);
            this.countMaterialsNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.countMaterialsNumeric.Name = "countMaterialsNumeric";
            this.countMaterialsNumeric.Size = new System.Drawing.Size(137, 22);
            this.countMaterialsNumeric.TabIndex = 23;
            // 
            // priceMaterialsNumeric
            // 
            this.priceMaterialsNumeric.Location = new System.Drawing.Point(12, 267);
            this.priceMaterialsNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.priceMaterialsNumeric.Name = "priceMaterialsNumeric";
            this.priceMaterialsNumeric.Size = new System.Drawing.Size(137, 22);
            this.priceMaterialsNumeric.TabIndex = 24;
            // 
            // avaliabilityComboBox
            // 
            this.avaliabilityComboBox.FormattingEnabled = true;
            this.avaliabilityComboBox.Items.AddRange(new object[] {
            "Есть",
            "Нету"});
            this.avaliabilityComboBox.Location = new System.Drawing.Point(12, 297);
            this.avaliabilityComboBox.Name = "avaliabilityComboBox";
            this.avaliabilityComboBox.Size = new System.Drawing.Size(137, 24);
            this.avaliabilityComboBox.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(155, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Ставка зарплаты";
            // 
            // wageRateNumeric
            // 
            this.wageRateNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.wageRateNumeric.Location = new System.Drawing.Point(12, 126);
            this.wageRateNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.wageRateNumeric.Name = "wageRateNumeric";
            this.wageRateNumeric.Size = new System.Drawing.Size(137, 22);
            this.wageRateNumeric.TabIndex = 29;
            // 
            // necessaryEquipmentBox
            // 
            this.necessaryEquipmentBox.Location = new System.Drawing.Point(12, 182);
            this.necessaryEquipmentBox.Name = "necessaryEquipmentBox";
            this.necessaryEquipmentBox.Size = new System.Drawing.Size(137, 22);
            this.necessaryEquipmentBox.TabIndex = 30;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(390, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(137, 22);
            this.searchBox.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(336, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Поиск";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Искать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Показать заказы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonDataShow_Click);
            // 
            // idNumeric
            // 
            this.idNumeric.Location = new System.Drawing.Point(465, 66);
            this.idNumeric.Name = "idNumeric";
            this.idNumeric.Size = new System.Drawing.Size(62, 22);
            this.idNumeric.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(438, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "ID";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(390, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 23);
            this.button4.TabIndex = 37;
            this.button4.Text = "Редактировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(390, 122);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 23);
            this.button5.TabIndex = 38;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(390, 356);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 23);
            this.button6.TabIndex = 39;
            this.button6.Text = "Сохранить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(390, 327);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 23);
            this.button7.TabIndex = 40;
            this.button7.Text = "Загрузить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1121, 392);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.idNumeric);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.necessaryEquipmentBox);
            this.Controls.Add(this.wageRateNumeric);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.avaliabilityComboBox);
            this.Controls.Add(this.priceMaterialsNumeric);
            this.Controls.Add(this.countMaterialsNumeric);
            this.Controls.Add(this.normHourNumeric);
            this.Controls.Add(this.phoneNumberMaskBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.conumableMaterialsBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.responsibleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullNameBox);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.normHourNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMaterialsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceMaterialsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wageRateNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader fullName;
        private System.Windows.Forms.ColumnHeader deaprtment;
        private System.Windows.Forms.ColumnHeader phoneNumber;
        private System.Windows.Forms.ColumnHeader normHour;
        private System.Windows.Forms.ColumnHeader responsible;
        private System.Windows.Forms.ColumnHeader necessaryEquipment;
        private System.Windows.Forms.ColumnHeader consumablesMaterials;
        private System.Windows.Forms.ColumnHeader countMaterials;
        private System.Windows.Forms.ColumnHeader priceMaterials;
        private System.Windows.Forms.ColumnHeader availability;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox conumableMaterialsBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox responsibleBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskBox;
        private System.Windows.Forms.NumericUpDown normHourNumeric;
        private System.Windows.Forms.NumericUpDown countMaterialsNumeric;
        private System.Windows.Forms.NumericUpDown priceMaterialsNumeric;
        private System.Windows.Forms.ComboBox avaliabilityComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown wageRateNumeric;
        private System.Windows.Forms.ColumnHeader wageRate;
        private System.Windows.Forms.TextBox necessaryEquipmentBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown idNumeric;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

