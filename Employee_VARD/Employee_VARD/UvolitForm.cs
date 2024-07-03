using Employee_VARD.Forms;
using Employee_VARD.Models;
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

namespace Employee_VARD
{
    public partial class UvolitForm : Form
    {
        public string login;
        public UvolitForm(string login_)
        {
            InitializeComponent();
            login = login_;

            List<Employee> employees = BD_Employee_VARDEntities.GetContext().Employees.ToList();
            foreach (Employee employee in employees)
            {
                cbSotrudniks.Items.Add(employee.employeeName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm(login);
            mf.Show();
            this.Close();
        }

        private void btnUvolit_Click(object sender, EventArgs e)
        {
            List<Employee> employees = BD_Employee_VARDEntities.GetContext().Employees.ToList();
            Employee emp = employees.FirstOrDefault(p => p.employeeName == cbSotrudniks.Text);

            if (emp != null)
            {
                string connectionString = @"Server=DESKTOP-8IK3L6Q;Database=BD_Employee_VARD;Trusted_Connection=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "delete FROM Employees WHERE employeeId = " + emp.employeeId;
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }

                MainForm mf = new MainForm(login);
                mf.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
