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

        private EmployeeEditor EMPL_COMP;
        private OrderEditor ORDS_COMP;
        private ServiceEditor SRVS_COMP;
        private OfficeEditor OFFS_COMP;

        private ExportedDatabase exDB;

        public InnerDatabase db { get; set; }

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
                db = new InnerDatabase(exDB);
            }
            comboBox1.SelectedIndex = 0;
            comboBox1.Enabled = true;
            refreshEntities(db);
            // now the db is exported, we can do what we want
        }

        private ExportedDatabase deserialize(string filename)
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "exportedDatabase";
            xRoot.IsNullable = true;
            XmlSerializer serializer = new XmlSerializer(typeof(ExportedDatabase), xRoot);
            ExportedDatabase result;
            using (XmlReader reader = XmlReader.Create(filename))
            {
                result = (ExportedDatabase)serializer.Deserialize(reader);
            }
            richTextBox1.BackColor = Color.LightGreen;
            richTextBox1.Text = "База данных импортирована успешно!";
            return result;
        }

        private void serialize(string filename)
        {
            ExportedDatabase outDatabase = db.toExported();
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "exportedDatabase";
            xRoot.IsNullable = true;

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            XmlWriterSettings settings = new XmlWriterSettings();
            //settings.OmitXmlDeclaration = true;

            XmlSerializer serializer = new XmlSerializer(typeof(ExportedDatabase), xRoot);
            using (XmlWriter writer = XmlWriter.Create(filename, settings))
            {
                serializer.Serialize(writer, outDatabase, ns);
            }
            richTextBox1.BackColor = Color.LightGreen;
            richTextBox1.Text = "База данных экспортирована успешно!";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (db == null)
            {
                richTextBox1.ForeColor = Color.Red;
                richTextBox1.Text = "DB not loaded!";
                return;
            }
            string selected = (string)comboBox1.SelectedItem;
            panel1.Controls.Clear();
            listBox1.Items.Clear();
            switch (selected)
            {
                case EMPL_STRING:
                    EMPL_COMP.refresh();
                    panel1.Controls.Add(EMPL_COMP);
                    break;
                case SRVS_STRING:
                    SRVS_COMP.refresh();
                    panel1.Controls.Add(SRVS_COMP);
                    break;
                case ORDS_STRING:
                    ORDS_COMP.refresh();
                    panel1.Controls.Add(ORDS_COMP);
                    break;
                case OFFS_STRING:
                    OFFS_COMP.refresh();
                    panel1.Controls.Add(OFFS_COMP);
                    break;
                default:
                    throw new Exception("unknown case");
                    // never?
            }
            refreshEntities(db);
        }

        public void logWarning(string message)
        {
            // todo implement
        }

        public void refreshEntities(InnerDatabase db)
        {
            string selected = (string)comboBox1.SelectedItem;
            listBox1.Items.Clear();
            switch (selected)
            {
                case EMPL_STRING:
                    listBox1.Items.AddRange(db.Employees.ToArray());
                    break;
                case SRVS_STRING:
                    listBox1.Items.AddRange(db.Services.ToArray());
                    break;
                case ORDS_STRING:
                    listBox1.Items.AddRange(db.Orders.ToArray());
                    break;
                case OFFS_STRING:
                    listBox1.Items.AddRange(db.Offices.ToArray());
                    break;
                default:
                    throw new Exception("unknown case");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string)comboBox1.SelectedItem;
            int idx = listBox1.SelectedIndex;
            if (idx < 0)
            {
                return;
            }
            switch (selected)
            {
                case EMPL_STRING:
                    EMPL_COMP.refresh();
                    EMPL_COMP.setCurrent(idx);
                    break;
                case SRVS_STRING:
                    SRVS_COMP.refresh();
                    SRVS_COMP.setCurrent(idx);
                    break;
                case ORDS_STRING:
                    ORDS_COMP.refresh();
                    ORDS_COMP.setCurrent(idx);
                    break;
                case OFFS_STRING:
                    OFFS_COMP.refresh();
                    OFFS_COMP.setCurrent(idx);
                    break;
                default:
                    throw new Exception("unknown case");
            }
        }

        private void saveDB_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK)) {
                serialize(saveFileDialog1.FileName);
            }
        }
    }
}
