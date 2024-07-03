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

namespace Employee_VARD.Forms
{
    public partial class Zarplata : Form
    {
        public string login;
        public Zarplata(string login_)
        {
            InitializeComponent();
            List<Employee> employees = BD_Employee_VARDEntities.GetContext().Employees.ToList();
            foreach (Employee employee in employees)
            {
                cbSotrudniks.Items.Add(employee.employeeName);
            }

            login = login_;
        }

        private void btnPerech_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите перевести " + nudBalance.Value + " рублей на счёт " + cbSotrudniks.Text, "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                List<User> users = BD_Employee_VARDEntities.GetContext().Users.ToList();
                User u = users.FirstOrDefault(p => p.userName == login);

                if (nudBalance.Value > u.userPrice)
                {
                    MessageBox.Show("Недостаточно средств!\nПополните баланс!");
                }
                else
                {
                    List<Employee> employees = BD_Employee_VARDEntities.GetContext().Employees.ToList();
                    Employee emp = employees.FirstOrDefault(p => p.employeeName == cbSotrudniks.Text);

                    if (emp != null)
                    {
                        string connectionString = @"Server=DESKTOP-8IK3L6Q;Database=BD_Employee_VARD;Trusted_Connection=True";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "UPDATE Employees SET employeeTotalSalary = " + (emp.employeeTotalSalary + Convert.ToInt32(nudBalance.Value)) + " WHERE employeeId = " + emp.employeeId;
                            SqlCommand command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                        }

                        string connectionStringUser = @"Server=DESKTOP-8IK3L6Q;Database=BD_Employee_VARD;Trusted_Connection=True";
                        using (SqlConnection connection = new SqlConnection(connectionStringUser))
                        {
                            connection.Open();
                            string query = "UPDATE Users SET userPrice = " + (u.userPrice - Convert.ToInt32(nudBalance.Value)) + " WHERE userId = " + u.userId;
                            SqlCommand command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                        }

                        u.userPrice -= Convert.ToInt32(nudBalance.Value);

                        emp.employeeTotalSalary += Convert.ToInt32(nudBalance.Value);

                        MessageBox.Show("Деньги успешно перечислены");
                        MainForm mf = new MainForm(login);
                        mf.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при транзакции");
                    }
                }
            }
        }

        private void cbSotrudniks_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Employee> employees = BD_Employee_VARDEntities.GetContext().Employees.ToList();
            Employee emp = employees.FirstOrDefault(p => p.employeeName == cbSotrudniks.Text);

            nudBalance.Value = emp.employeeRate;
        }

        private void nudBalance_ValueChanged(object sender, EventArgs e)
        {
            List<Employee> employees = BD_Employee_VARDEntities.GetContext().Employees.ToList();
            Employee emp = employees.FirstOrDefault(p => p.employeeName == cbSotrudniks.Text);

            if (nudBalance.Value < emp.employeeRate)
            {
                nudBalance.ForeColor = Color.Red;
                //lblZarp.Text = "Запрлата ниже ставки сотрудника";
            }
            else if (nudBalance.Value > emp.employeeRate)
            {
                nudBalance.ForeColor = Color.Green;
                //lblZarp.Text = "Запрлата выше ставки сотрудника";
            }
            else
            {
                nudBalance.ForeColor = Color.Black;
                //lblZarp.Text = "";
            }
        }

        private void nudBalance_KeyUp(object sender, KeyEventArgs e)
        {
            List<Employee> employees = BD_Employee_VARDEntities.GetContext().Employees.ToList();
            Employee emp = employees.FirstOrDefault(p => p.employeeName == cbSotrudniks.Text);

            if (nudBalance.Value < emp.employeeRate)
            {
                nudBalance.ForeColor = Color.Red;
                //lblZarp.Text = "Запрлата ниже ставки сотрудника";
            }
            else if (nudBalance.Value > emp.employeeRate)
            {
                nudBalance.ForeColor = Color.Green;
                //lblZarp.Text = "Запрлата выше ставки сотрудника";
            }
            else
            {
                nudBalance.ForeColor = Color.Black;
                //lblZarp.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm(login);
            mf.Show();
            this.Close();
        }
    }
}
