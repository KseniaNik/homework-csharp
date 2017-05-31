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
    public partial class OrderEditor : UserControl
    {

        private int idx;
        private InnerDatabase db;
        private MainForm form;

        private List<Article> articles;

        public OrderEditor(MainForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        public void refresh()
        {
            db = form.db;
            // TODO FIXME OPTIMIZE!!!
            employeeBox.Items.Clear();
            employeeBox.Items.AddRange(db.Employees.ToArray());
            serviceBox.Items.Clear();
            serviceBox.Items.AddRange(db.Services.ToArray());
            officeBox.Items.Clear();
            officeBox.Items.AddRange(db.Offices.ToArray());
            articles = db.Orders[idx].articleList.ToList();
            articlesList.Items.AddRange(db.Orders[idx].articleList);
        }

        public void setCurrent(int idx)
        {
            if (idx < 0)
            {
                return;
            }
            this.idx = idx;
            Order order = db.Orders[idx];
            name.Text = order.clientFirstName;
            last.Text = order.clientLastName;
            patr.Text = order.clientPatronymicName;
            phone.Text = order.phoneNumber;
            isExecutedCheckBox.Checked = order.executed;
            orderDate.Value = order.orderDate;
            if (order.employee != null) 
            {
                employeeBox.SelectedIndex = db.findEmployeeIdxById(order.employee.id);
            }
            if (order.service != null)
            {
                serviceBox.SelectedIndex = db.findServiceIdxById(order.service.id);
            }
            if (order.office != null)
            {
                officeBox.SelectedIndex = db.findOfficeIdxById(order.office.id);
            }
            if (order.articleList != null)
            {
                articles = order.articleList.ToList();
                articlesList.Items.Clear();
                articlesList.Items.AddRange(order.articleList);
            }
            else
            {
                order.articleList = new Article[0];
                articles = new List<Article>();
            }
        }

        private void doSave()
        {
            db.saveOrder(idx, name.Text, last.Text, patr.Text, phone.Text, orderDate.Value,
                isExecutedCheckBox.Checked, serviceBox.SelectedIndex,
                officeBox.SelectedIndex,
                employeeBox.SelectedIndex,
                articles.ToArray()
                );
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (db.Orders.Count - 1 < idx)
            {
                MessageBox.Show("Используй добавить");
                return;
            }
            doSave();
        }

        private void add_Click(object sender, EventArgs e)
        {
            idx = db.addOrder();
            doSave();
            setCurrent(idx);
            form.refreshEntities(db);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (!MessageBox.Show("Действительно удалить заказ?", "delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question
                ).Equals(DialogResult.OK))
            {
                return;
            }
            if (!db.removeOrder(idx))
            {
                form.logWarning("Order was in use! " + idx);
            }
            setCurrent(idx + 1 < db.Orders.Count ? idx + 1 : idx - 1);
            form.refreshEntities(db);
        }

        private void setCurrentArticle(int idx)
        {
            if (idx > articles.Count - 1)
            {
                return;
            }
            articleName.Text = articles[idx].name;
            articleComponents.Text = articles[idx].components;
            articleColor.Text = articles[idx].color + "";
        }

        private void addArticle_Click(object sender, EventArgs e)
        {
            if (articleName.Text == "")
            {
                return;
            }
            if (articles == null)
            {
                articles = new List<Article>();
            }
            Article article = new Article();
            article.name = articleName.Text;
            article.color = 0;
            article.components = articleComponents.Text;
            articles.Add(article);
            refreshArticles();
            setCurrentArticle(articles.Count - 1);
        }

        private void saveArticle_Click(object sender, EventArgs e)
        {
            int col;
            if (!Int32.TryParse(articleColor.Text, out col))
            {
                return;
            }

            articles[idx].name = articleName.Text;
            articles[idx].components = this.articleComponents.Text;
            articles[idx].color = col;
        }

        private void deleteArticle_Click(object sender, EventArgs e)
        {
            if (!MessageBox.Show("Действительно удалить предмет из заказа?", "delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question
                ).Equals(DialogResult.OK))
            {
                return;
            }
            int idx = articlesList.SelectedIndex;
            if (idx < 0)
            {
                MessageBox.Show("Выберите предмет для удаления");
                return;
            }

            articles.RemoveAt(idx);
            refreshArticles();
            setCurrentArticle(idx + 1 < db.Orders.Count ? idx + 1 : idx - 1);
        }

        private void refreshArticles()
        {
            articlesList.Items.Clear();
            articlesList.Items.AddRange(articles.ToArray());
        }

        private void articlesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = articlesList.SelectedIndex;
            if (idx < 0) {
                return;
            }
            setCurrentArticle(idx);
        }
    }
}
