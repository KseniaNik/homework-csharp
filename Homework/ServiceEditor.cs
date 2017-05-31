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
    public partial class ServiceEditor : UserControl
    {
        private int idx;
        private InnerDatabase db;
        private MainForm form;

        public ServiceEditor(MainForm form)
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
            name.Text = db.Services[idx].name;
            db.Services[idx].idSpecified = true;
            db.Services[idx].priceSpecified = true;
            address.Text = db.Services[idx].price + "";
        }

        private void doSave()
        {
            double result;
            if (!Double.TryParse(address.Text, out result))
            {
                return;
            }

            db.saveService(idx, name.Text, result);
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (db.Services.Count - 1 < idx)
            {
                MessageBox.Show("Используй добавить");
                return;
            }
            doSave();
        }

        private void add_Click(object sender, EventArgs e)
        {
            idx = db.addService();
            doSave();
            setCurrent(idx);
            form.refreshEntities(db);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (!MessageBox.Show(
                "Действительно удалить услугу?", "delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question
                ).Equals(DialogResult.OK))
            {
                return;
            }
            if (!db.removeService(idx))
            {
                form.logWarning("Service was in use! " + idx);
            }
            setCurrent(idx + 1 < db.Services.Count ? idx + 1 : idx - 1);
            form.refreshEntities(db);
        }
    }
}
