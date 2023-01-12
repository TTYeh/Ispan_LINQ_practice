using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ispan_LinQPractice_WinApp
{
    public partial class FormEntityJoin : Form
    {
        private NorthwindEntities1 _repo;

        public FormEntityJoin()
        {
            InitializeComponent();
            this.Load += FormEntityJoin_Load;
        }

        private void FormEntityJoin_Load(object sender, EventArgs e)
        {

            _repo = new NorthwindEntities1();

        }

        private void buttonEntityJoin_Click(object sender, EventArgs e)
        {
            var linq = from c in _repo.Categories
                       join p in _repo.Products
                       on c.CategoryID equals p.CategoryID
                       select new {
                           ProductName = p.ProductName,
                           CategoryName = c.CategoryName,
                       };
            dataGridView1.DataSource = linq.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void buttonOuterJoin_Click(object sender, EventArgs e)
        {
            List<TestObj> listUser = new List<TestObj>() {
                new TestObj(){ ComNo = 1, UserName = "Jack"},
                new TestObj(){ ComNo = 2, UserName = "Kitty"},
                new TestObj(){ ComNo = 4, UserName = "Mike"},

            };

            List<TestObj> listCom = new List<TestObj>() {
                new TestObj(){ ComNo = 1, ComName = "TSMC"},
                new TestObj(){ ComNo = 2, ComName = "Wistron"},
                new TestObj(){ ComNo = 3, ComName = "Quanta"},
                new TestObj(){ ComNo = 4, ComName = "Amozon"},
            };


            var linq = from com in listCom
                       join user in listUser on com.ComNo equals user.ComNo into uc
                       from uccu in uc.DefaultIfEmpty(
                           new TestObj { ComNo = -1, UserName = "This is Null" }
                           )
                       select new { com.ComNo, com.ComName, uccu.UserName };

            //List<Contact> lsContact = new List<Contact>
            //{
            //    new Contact{ ComID = 1 , ContactName = "John"},
            //    new Contact {ComID = 3 , ContactName = "Jenna"},
            //    new Contact{ComID=4, ContactName="Eric"}
            //};

            //List<Company> lsCompany = new List<Company>
            //{
            //    new Company{ComID = 1 , CompanyName ="Apple"},
            //    new Company{ComID = 2 , CompanyName ="Microsoft"},
            //    new Company{ComID = 3 , CompanyName ="amazon"},
            //    new Company {ComID = 4 , CompanyName ="SpaceX"}
            //};

            //var q = from com in lsCompany
            //        join c in lsContact on com.ComID equals c.ComID into ls
            //        from c in ls.DefaultIfEmpty(new Contact { ComID = -1, ContactName = "Nobody" })
            //        select new
            //        {
            //            com.ComID,
            //            com.CompanyName,
            //            c.ContactName
            //        };



            dataGridView1.DataSource = linq.ToList();
        }

        private void buttonDirectJoin_Click(object sender, EventArgs e)
        {
            var linq = from pro in _repo.Products
                       select new
                       {
                           ProductName = pro.ProductName,
                           CategoryName = pro.Categories.CategoryName,
                       };
            dataGridView1.DataSource = linq.ToList();
        }
    }
    public class TestObj
    {
        public string UserName;
        public string ComName;
        public int ComNo;
    }
}
