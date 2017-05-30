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

        public OfficeEditor(MainForm mainForm)
        {
            this.db = mainForm.innerDB;
            InitializeComponent();
        }

        public void setCurrent(int idx) {
            this.idx = idx;
            name.Text = db.Offices[idx].name;
            address.Text = db.Offices[idx].address;
        }

        private void save_Click(object sender, EventArgs e)
        {
            db.Offices[idx].address = address.Text;
            db.Offices[idx].name = name.Text;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            long idToRemove = db.Offices[idx].id;
            setCurrent(idx + 1 < db.Offices.Count ? idx + 1 : idx - 1);
            db.Offices.RemoveAt(idx);
            foreach (Order order in db.Orders) {
                if (order.office.id == idToRemove)
                {
                    // TODO handle properly
                    order.office = null;
                }
            }
        }
    }
}
