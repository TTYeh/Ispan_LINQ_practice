using Ispan_LinQPractice_WinApp.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ispan_LinQPractice_WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            DataSet1 dsNorthWind = new DataSet1();
            EmployeesTableAdapter taEmp = new EmployeesTableAdapter();
            taEmp.Fill(dsNorthWind.Employees);
            dataGridView1.DataSource = taEmp.GetData();
        }

        private void buttonQuery2_Click(object sender, EventArgs e)
        {
            DataSet1 dsNorthWind = new DataSet1();
            EmployeesTableAdapter taEmp = new EmployeesTableAdapter();
            taEmp.Fill(dsNorthWind.Employees);

            var qEmp = from emp in dsNorthWind.Employees
                       where emp.Country == "USA"
                       select emp;
            //dataGridView1.DataSource = qEmp.ToList();
            dataGridView1.DataSource = qEmp.AsDataView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = string.Empty;
            string[] arrCitys = { "Los Angeles", "Amsterdam", "Vilnius" };
            char[] arrChar = { 'A', 'V', 'P' };
            IEnumerable<string> qCity = from city in arrCitys
                                        where arrChar.Contains(city[0])
                                        select city;

            foreach (string a in qCity)
            {
                textBoxResult.Text += a + " \r\n";
            }
        }

        private void buttonLinQObj_Click(object sender, EventArgs e)
        {
            DataSet1 dsNorthWind = new DataSet1();
            EmployeesTableAdapter taEmp = new EmployeesTableAdapter();
            taEmp.Fill(dsNorthWind.Employees);

            //var qEmp0 = from emp in dsNorthWind.Employees
            //            where emp.Country != null
            //            select emp;
            //var data = qEmp0.ToList();
            var qEmp = from emp in dsNorthWind.Employees
                       where emp.Country == "USA"
                       select new
                       {
                           Name = emp.FirstName + " " + emp.LastName,
                           emp.City
                       };
            //dataGridView1.DataSource = qEmp.ToList();
            dataGridView1.DataSource = qEmp.ToList();
        }

        private void buttonQueryCategory_Click(object sender, EventArgs e)
        {
            DataSet1 dsNorthWind = new DataSet1();
            CategoriesTableAdapter taCategory = new CategoriesTableAdapter();
            taCategory.Fill(dsNorthWind.Categories);

            var qC = from c in dsNorthWind.Categories
                     select c.CategoryName into CC
                     from intoC in CC
                     select intoC;

            //var qC = from c in dsNorthWind.Categories
            //         select c.CategoryName ;
            var qC2 = from c in dsNorthWind.Categories
                      select new { CategoryName = c.CategoryName };
            dataGridView1.DataSource = qC2.ToList();
            string result = string.Empty;
            foreach (var c in qC) {
                result += c + "\n";
            }
            MessageBox.Show(result);

        }

        private void buttonGroupByLinQ_Click(object sender, EventArgs e)
        {
            DataSet1 dsNorthWind = new DataSet1();
            EmployeesTableAdapter taEmp = new EmployeesTableAdapter();
            taEmp.Fill(dsNorthWind.Employees);
            var qEmp = from emp in dsNorthWind.Employees
                       group emp by emp.Country into gEmp
                       select new
                       {
                           Country = gEmp.Key,
                           COUNT = gEmp.Count()
                       };
            dataGridView1.DataSource = qEmp.ToList();
        }
    }
}
