using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Homework
{
    public partial class MainForm : Form
    {
        private const string EMPL_STRING = "employees";
        private const string ORDS_STRING = "orders";
        private const string SRVS_STRING = "services";
        private const string OFFS_STRING = "offices";

        private Control EMPL_COMP;
        private Control ORDS_COMP;
        private Control SRVS_COMP;
        private Control OFFS_COMP;

        private ExportedDatabase exDB;

        public InnerDatabase innerDB { get; set; }

        public MainForm()
        {
            InitializeComponent();
            EMPL_COMP = new EmployeeEditor(this);
            ORDS_COMP = new OrderEditor(this);
            SRVS_COMP = new ServiceEditor(this);
            OFFS_COMP = new OfficeEditor(this);
            comboBox1.Items.AddRange(new object[] {
                EMPL_STRING, OFFS_STRING, SRVS_STRING, ORDS_STRING
            });
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (openDB.ShowDialog().Equals(DialogResult.OK))
            {
                exDB = deserialize(openDB.FileName);
                innerDB = new InnerDatabase(exDB);
            }
            // now the db is exported, we can do what we want
        }

        private ExportedDatabase deserialize(string filename)
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "exportedDatabase";
            xRoot.IsNullable = true;
            XmlSerializer serializer = new XmlSerializer(typeof(ExportedDatabase), xRoot);
            using (XmlReader reader = XmlReader.Create(filename))
            {
                return (ExportedDatabase)serializer.Deserialize(reader);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string)comboBox1.SelectedItem;
            panel1.Controls.Clear();
            listBox1.Items.Clear();
            listBox1.DisplayMember = "id";
            switch (selected)
            {
                case EMPL_STRING:
                    panel1.Controls.Add(EMPL_COMP);
                    listBox1.Items.AddRange(
                        new ListBox.ObjectCollection(listBox1, exDB.employees));
                    break;
                case SRVS_STRING:
                    panel1.Controls.Add(SRVS_COMP);
                    listBox1.Items.AddRange(
                        new ListBox.ObjectCollection(listBox1, exDB.services));
                    break;
                case ORDS_STRING:
                    panel1.Controls.Add(ORDS_COMP);
                    listBox1.Items.AddRange(
                        new ListBox.ObjectCollection(listBox1, exDB.orders));
                    break;
                case OFFS_STRING:
                    panel1.Controls.Add(OFFS_COMP);
                    listBox1.Items.AddRange(
                        new ListBox.ObjectCollection(listBox1, exDB.offices));
                    break;
                default:
                    throw new Exception("unknown case");
                    // never?
            }
        }
    }
}
