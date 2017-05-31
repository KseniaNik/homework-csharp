namespace Homework
{
    partial class EmployeeEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.TextBox();
            this.last = new System.Windows.Forms.TextBox();
            this.patr = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.hireDate = new System.Windows.Forms.DateTimePicker();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Номер телефона";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Зарплата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дата рождения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дата найма";
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(223, 10);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(186, 20);
            this.first.TabIndex = 8;
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(223, 37);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(186, 20);
            this.last.TabIndex = 9;
            // 
            // patr
            // 
            this.patr.Location = new System.Drawing.Point(223, 63);
            this.patr.Name = "patr";
            this.patr.Size = new System.Drawing.Size(186, 20);
            this.patr.TabIndex = 10;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(223, 92);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(186, 20);
            this.number.TabIndex = 11;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(223, 118);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(186, 20);
            this.salary.TabIndex = 12;
            // 
            // hireDate
            // 
            this.hireDate.Location = new System.Drawing.Point(187, 145);
            this.hireDate.Name = "hireDate";
            this.hireDate.Size = new System.Drawing.Size(200, 20);
            this.hireDate.TabIndex = 13;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(187, 168);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 20);
            this.dob.TabIndex = 14;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(3, 320);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(334, 320);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.delete_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoEllipsis = true;
            this.errorLabel.Location = new System.Drawing.Point(3, 294);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(406, 23);
            this.errorLabel.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.hireDate);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.number);
            this.Controls.Add(this.patr);
            this.Controls.Add(this.last);
            this.Controls.Add(this.first);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeEditor";
            this.Size = new System.Drawing.Size(412, 346);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.TextBox last;
        private System.Windows.Forms.TextBox patr;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.DateTimePicker hireDate;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button button1;
    }
}
