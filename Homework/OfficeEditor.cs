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
    public partial class OfficeEditor : UserControl
    {
        private int idx;

        private InnerDatabase db;
        private MainForm form;

        public OfficeEditor(MainForm mainForm)
        {
            this.form = mainForm;
            InitializeComponent();
        }

        public void refresh()
        {
            this.db = form.db;
        }

        public void setCurrent(int idx) {
            if (idx < 0)
            {
                return;
            }
            this.idx = idx;
            name.Text = db.Offices[idx].name;
            address.Text = db.Offices[idx].address;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (db.Offices.Count - 1 < idx)
            {
                MessageBox.Show("Используй добавить");
                return;
            }
            db.saveOffice(idx, name.Text, address.Text);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (!MessageBox.Show(
                "Действительно удалить офис?", "delete", 
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                ).Equals(DialogResult.OK))
            {
                return;
            }
            if (!db.removeOffice(idx))
            {
                form.logWarning("Office was in use! " + idx);
            }
            setCurrent(idx + 1 < db.Offices.Count ? idx + 1 : idx - 1);
            form.refreshEntities(db);
        }

        private void add_Click(object sender, EventArgs e)
        {
            idx = db.addOffice();
            db.saveOffice(idx, name.Text, address.Text);
            setCurrent(idx);
            form.refreshEntities(db);
        }
    }
}
