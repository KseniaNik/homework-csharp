using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class EmployeeEditor : UserControl
    {
        private int idx;
        private InnerDatabase db;
        private MainForm form;

        public EmployeeEditor(MainForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        public void refresh()
        {
            db = form.db;
        }

        public void setCurrent(int idx)
        {
            if (idx < 0)
            {
                return;
            }
            this.idx = idx;
            Employee emp = db.Employees[idx];
            first.Text = emp.firstName;
            last.Text = emp.lastName;
            patr.Text = emp.patronymicName;
            number.Text = emp.phoneNumber;
            dob.Value = emp.dateOfBirth;
            hireDate.Value = emp.hireDate;
            salary.Text = emp.salary + "";
        }

        private void doSave()
        {
            double salary;
            if (!Double.TryParse(this.salary.Text, out salary))
            {
                if (salaryBase == null)
                {
                    salaryBase = this.salary.BackColor;
                }
                this.salary.BackColor = Color.Red;
                return;
            }

            this.salary.BackColor = salaryBase;

            db.saveEmployee(idx, first.Text, last.Text, patr.Text, number.Text,
                dob.Value, hireDate.Value, salary);
        }

        private Color salaryBase;

        private void save_Click(object sender, EventArgs e)
        {
            doSave();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (idx < 0)
            {
                return;
            }

            if (!MessageBox.Show("Действительно удалить работника?", "delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).Equals(DialogResult.OK))
            {
                return;
            }
            if (!db.removeEmployee(idx))
            {
                form.logWarning("Employee was in use! " + idx);
            }
            setCurrent(idx + 1 < db.Employees.Count ? idx + 1 : idx - 1);
            form.refreshEntities(db);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idx = db.addEmployee();
            doSave();
            setCurrent(idx);
            form.refreshEntities(db);
        }
    }
}
