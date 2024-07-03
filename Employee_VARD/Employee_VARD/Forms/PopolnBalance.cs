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
    public partial class PopolnBalanceForm : Form
    {
        MainForm mainForm;
        string login;
        public PopolnBalanceForm(MainForm mf)
        {
            InitializeComponent();

            mainForm = mf;
            login = mainForm.login;
        }

        private void btnPopoln_Click(object sender, EventArgs e)
        {
            if (nudBalance.Value <= 0)
            {
                MessageBox.Show("Баланс должен быть больше 0");
            }
            else
            {
                List<User> users = BD_Employee_VARDEntities.GetContext().Users.ToList();
                User u = users.FirstOrDefault(p => p.userName == login);

                string connectionString = @"Server=DESKTOP-8IK3L6Q;Database=BD_Employee_VARD;Trusted_Connection=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Users SET userPrice = " + (u.userPrice + Convert.ToInt32(nudBalance.Value)) + " WHERE userId = " + u.userId;
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }

                u.userPrice += Convert.ToInt32(nudBalance.Value);

                mainForm.UpdateInfo();
                this.Close();
            }
        }
    }
}
