namespace Homework
{
    partial class OrderEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.TextBox();
            this.last = new System.Windows.Forms.TextBox();
            this.patr = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.isExecutedCheckBox = new System.Windows.Forms.CheckBox();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.articlesList = new System.Windows.Forms.ListBox();
            this.addArticle = new System.Windows.Forms.Button();
            this.saveArticle = new System.Windows.Forms.Button();
            this.deleteArticle = new System.Windows.Forms.Button();
            this.articleName = new System.Windows.Forms.TextBox();
            this.articleColor = new System.Windows.Forms.TextBox();
            this.articleComponents = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.employeeBox = new System.Windows.Forms.ComboBox();
            this.officeBox = new System.Windows.Forms.ComboBox();
            this.serviceBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(226, 20);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(273, 20);
            this.name.TabIndex = 0;
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(226, 46);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(273, 20);
            this.last.TabIndex = 1;
            // 
            // patr
            // 
            this.patr.Location = new System.Drawing.Point(226, 74);
            this.patr.Name = "patr";
            this.patr.Size = new System.Drawing.Size(273, 20);
            this.patr.TabIndex = 2;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(226, 100);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(273, 20);
            this.phone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия клиета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер телефона";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Работник";
            // 
            // isExecutedCheckBox
            // 
            this.isExecutedCheckBox.AutoSize = true;
            this.isExecutedCheckBox.Location = new System.Drawing.Point(201, 133);
            this.isExecutedCheckBox.Name = "isExecutedCheckBox";
            this.isExecutedCheckBox.Size = new System.Drawing.Size(116, 17);
            this.isExecutedCheckBox.TabIndex = 10;
            this.isExecutedCheckBox.Text = "Заказ выполнен?";
            this.isExecutedCheckBox.UseVisualStyleBackColor = true;
            // 
            // orderDate
            // 
            this.orderDate.Location = new System.Drawing.Point(226, 157);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(273, 20);
            this.orderDate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата заказа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Офис";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Услуга";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Предметы в заказе:";
            // 
            // articlesList
            // 
            this.articlesList.FormattingEnabled = true;
            this.articlesList.Location = new System.Drawing.Point(12, 298);
            this.articlesList.Name = "articlesList";
            this.articlesList.Size = new System.Drawing.Size(120, 95);
            this.articlesList.TabIndex = 18;
            // 
            // addArticle
            // 
            this.addArticle.Location = new System.Drawing.Point(151, 305);
            this.addArticle.Name = "addArticle";
            this.addArticle.Size = new System.Drawing.Size(75, 23);
            this.addArticle.TabIndex = 19;
            this.addArticle.Text = "Добавить";
            this.addArticle.UseVisualStyleBackColor = true;
            this.addArticle.Click += new System.EventHandler(this.addArticle_Click);
            // 
            // saveArticle
            // 
            this.saveArticle.Location = new System.Drawing.Point(151, 334);
            this.saveArticle.Name = "saveArticle";
            this.saveArticle.Size = new System.Drawing.Size(75, 23);
            this.saveArticle.TabIndex = 20;
            this.saveArticle.Text = "Сохранить";
            this.saveArticle.UseVisualStyleBackColor = true;
            this.saveArticle.Click += new System.EventHandler(this.saveArticle_Click);
            // 
            // deleteArticle
            // 
            this.deleteArticle.Location = new System.Drawing.Point(151, 363);
            this.deleteArticle.Name = "deleteArticle";
            this.deleteArticle.Size = new System.Drawing.Size(75, 23);
            this.deleteArticle.TabIndex = 21;
            this.deleteArticle.Text = "Удалить";
            this.deleteArticle.UseVisualStyleBackColor = true;
            this.deleteArticle.Click += new System.EventHandler(this.deleteArticle_Click);
            // 
            // articleName
            // 
            this.articleName.Location = new System.Drawing.Point(349, 301);
            this.articleName.Name = "articleName";
            this.articleName.Size = new System.Drawing.Size(150, 20);
            this.articleName.TabIndex = 22;
            // 
            // articleColor
            // 
            this.articleColor.Location = new System.Drawing.Point(349, 331);
            this.articleColor.Name = "articleColor";
            this.articleColor.Size = new System.Drawing.Size(150, 20);
            this.articleColor.TabIndex = 23;
            // 
            // articleComponents
            // 
            this.articleComponents.Location = new System.Drawing.Point(349, 358);
            this.articleComponents.Name = "articleComponents";
            this.articleComponents.Size = new System.Drawing.Size(150, 20);
            this.articleComponents.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Название";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Цвет";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(272, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Компоненты";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(3, 416);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 28;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(201, 416);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 29;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(424, 416);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 30;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // employeeBox
            // 
            this.employeeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeBox.FormattingEnabled = true;
            this.employeeBox.Location = new System.Drawing.Point(226, 193);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(273, 21);
            this.employeeBox.TabIndex = 31;
            // 
            // officeBox
            // 
            this.officeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.officeBox.FormattingEnabled = true;
            this.officeBox.Location = new System.Drawing.Point(226, 220);
            this.officeBox.Name = "officeBox";
            this.officeBox.Size = new System.Drawing.Size(273, 21);
            this.officeBox.TabIndex = 32;
            // 
            // serviceBox
            // 
            this.serviceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceBox.FormattingEnabled = true;
            this.serviceBox.Location = new System.Drawing.Point(226, 247);
            this.serviceBox.Name = "serviceBox";
            this.serviceBox.Size = new System.Drawing.Size(273, 21);
            this.serviceBox.TabIndex = 33;
            // 
            // OrderEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.serviceBox);
            this.Controls.Add(this.officeBox);
            this.Controls.Add(this.employeeBox);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.articleComponents);
            this.Controls.Add(this.articleColor);
            this.Controls.Add(this.articleName);
            this.Controls.Add(this.deleteArticle);
            this.Controls.Add(this.saveArticle);
            this.Controls.Add(this.addArticle);
            this.Controls.Add(this.articlesList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.isExecutedCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.patr);
            this.Controls.Add(this.last);
            this.Controls.Add(this.name);
            this.Name = "OrderEditor";
            this.Size = new System.Drawing.Size(502, 442);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox last;
        private System.Windows.Forms.TextBox patr;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox isExecutedCheckBox;
        private System.Windows.Forms.DateTimePicker orderDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox articlesList;
        private System.Windows.Forms.Button addArticle;
        private System.Windows.Forms.Button saveArticle;
        private System.Windows.Forms.Button deleteArticle;
        private System.Windows.Forms.TextBox articleName;
        private System.Windows.Forms.TextBox articleColor;
        private System.Windows.Forms.TextBox articleComponents;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ComboBox employeeBox;
        private System.Windows.Forms.ComboBox officeBox;
        private System.Windows.Forms.ComboBox serviceBox;
    }
}
