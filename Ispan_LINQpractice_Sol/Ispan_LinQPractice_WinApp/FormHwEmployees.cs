using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ispan_LinQPractice_WinApp
{
    public partial class FormHwEmployees : Form
    {
        private NorthwindEntities1 repo;

        public FormHwEmployees()
        {
            InitializeComponent();
            this.Load += FormHwEmployees_Load;
        }

        private void FormHwEmployees_Load(object sender, EventArgs e)
        {
            this.repo = new NorthwindEntities1();
            LoadStaticView();
        }

        public void LoadStaticView()
        {
            var linq = from emp in repo.Employees
                       group emp by emp.Country into g
                       select new
                       {
                           Country = g.Key,
                           Count = g.Count()
                       };
            dataGridViewLeft.DataSource = linq.ToList();
        
        }


        public void LoadCountryView(string country)
        {
            var linq = from emp in repo.Employees
                       where emp.Country == country
                       select emp;

            dataGridViewRight.DataSource = linq.ToList();
        }

        private void dataGridViewLeft_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string data = dataGridViewLeft.SelectedCells[0].Value.ToString();
            var d = dataGridViewLeft.SelectedCells[0];
            LoadCountryView(data);
        }
    }
}
