using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ispan_LinQPractice_WinApp
{
    public partial class FormEntityFramework : Form
    {
        public FormEntityFramework()
        {
            InitializeComponent();
        }

        private void buttonEntityEmplyees_Click(object sender, EventArgs e)
        {
            NorthwindEntities1 dbContent = new NorthwindEntities1();
            IQueryable<Employees> employees = from emp in dbContent.Employees
                                              where emp.Country == "USA"
                                              select emp;
            dataGridView1.DataSource = employees.ToList();

        }

        private void buttonCategoryCreate_Click(object sender, EventArgs e)
        {
            NorthwindEntities1 db = new NorthwindEntities1();
            var cate = new Categories();
            cate.CategoryName = "Drink";
            cate.Description = "AAAAA";
            db.Categories.Add(cate);
            db.SaveChanges();
            var categories = from cate1 in db.Categories
                             select cate1;
            dataGridView1.DataSource = categories.ToList();

        }

        private void buttonCategoryUpdate_Click(object sender, EventArgs e)
        {
            NorthwindEntities1 db = new NorthwindEntities1();
            var categories = from cate1 in db.Categories
                             where cate1.CategoryName == "Drink"
                             select cate1;

            foreach (var cate in categories)
            {
                cate.Description = "MyUpdate GO2";
            }
            db.SaveChanges();

            IQueryable<Categories> categoriesAll = from cate1 in db.Categories
                             select cate1;
            dataGridView1.DataSource = categoriesAll.ToList();
        }

        private void buttonCategoryDelete_Click(object sender, EventArgs e)
        {
            NorthwindEntities1 db = new NorthwindEntities1();
            //var deleteElement = (from cate1 in db.Categories
            //                 where cate1.CategoryName == "Drink"
            //                 select cate1).First();

            var deleteElement = db.Categories.First(c => c.CategoryName == "Drink");
            db.Categories.Remove(deleteElement);
            db.Categories.Remove(deleteElement);
            db.SaveChanges();

            var categoriesAll = from cate1 in db.Categories
                                select cate1;
            dataGridView1.DataSource = categoriesAll.ToList();
        }
    }
}
