using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public partial class SalaryCalculator : Form
    {
        public SalaryCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;            
            int age = Int32.Parse(txtAge.Text);
            string company = txtCompany.Text;
            int years = Int32.Parse(txtYears.Text);
            double salary = double.Parse(txtSal.Text);

            //create objects
            Employee e1 = new Employee(company,years,salary);
            e1.setValues(name, age);

            //call method to calculate salary
            string cs = e1.calculateSalary();

            //Change label text
            lbSalEarned.Text = $"Salary Earned: {cs}";
            lbSalEarned.Visible = true;

            
        }

       
    }
}
