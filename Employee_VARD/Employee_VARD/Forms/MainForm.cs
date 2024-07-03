using Employee_VARD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_VARD.Forms
{
    public partial class MainForm : Form
    {
        public string login;
        public MainForm(string login_)
        {
            InitializeComponent();
            login = login_;
            UpdateInfo();

            var currentTable = BD_Employee_VARDEntities.GetContext().Employees.ToList();

            DGV.DataSource = currentTable;

            DGV.Columns[0].HeaderText = "Номер";
            DGV.Columns[1].HeaderText = "ФИО";
            DGV.Columns[2].HeaderText = "Ставка";
            DGV.Columns[3].HeaderText = "Выданная зарплата";
            DGV.Columns[4].HeaderText = "Квалификация работника";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void btnPopoln_Click(object sender, EventArgs e)
        {
            PopolnBalanceForm pbForm = new PopolnBalanceForm(this);
            pbForm.Show();
        }

        public void UpdateInfo()
        {
            List<User> users = BD_Employee_VARDEntities.GetContext().Users.ToList();
            User u = users.FirstOrDefault(p => p.userName == login);

            lblUser.Text = login + "\nБаланс: " + u.userPrice + " руб.";
        }

        private void btnZarplata_Click(object sender, EventArgs e)
        {
            Zarplata z = new Zarplata(login);
            z.Show();
            this.Close();
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex == 0)
            {
                var currentTable = BD_Employee_VARDEntities.GetContext().Employees.ToList();

                DGV.DataSource = currentTable;

                DGV.Columns[0].HeaderText = "Номер сотрудника";
                DGV.Columns[1].HeaderText = "ФИО сотрудника";
                DGV.Columns[2].HeaderText = "Ставка сотрудника";
                DGV.Columns[3].HeaderText = "Выданная зарплата";
                DGV.Columns[4].HeaderText = "Квалификация сотрудника";
            }
            else if (cbSort.SelectedIndex == 1)
            {
                var currentTable = BD_Employee_VARDEntities.GetContext().Employees.OrderByDescending(p => p.employeeRate).ToList();

                DGV.DataSource = currentTable;

                DGV.Columns[0].HeaderText = "Номер сотрудника";
                DGV.Columns[1].HeaderText = "ФИО сотрудника";
                DGV.Columns[2].HeaderText = "Ставка сотрудника";
                DGV.Columns[3].HeaderText = "Выданная зарплата";
                DGV.Columns[4].HeaderText = "Квалификация сотрудника";
            }
            else if (cbSort.SelectedIndex == 2)
            {
                var currentTable = BD_Employee_VARDEntities.GetContext().Employees.OrderBy(p => p.employeeRate).ToList();

                DGV.DataSource = currentTable;

                DGV.Columns[0].HeaderText = "Номер сотрудника";
                DGV.Columns[1].HeaderText = "ФИО сотрудника";
                DGV.Columns[2].HeaderText = "Ставка сотрудника";
                DGV.Columns[3].HeaderText = "Выданная зарплата";
                DGV.Columns[4].HeaderText = "Квалификация сотрудника";
            }
            else if (cbSort.SelectedIndex == 3)
            {
                var currentTable = BD_Employee_VARDEntities.GetContext().Employees.OrderBy(p => p.employeeName).ToList();

                DGV.DataSource = currentTable;

                DGV.Columns[0].HeaderText = "Номер сотрудника";
                DGV.Columns[1].HeaderText = "ФИО сотрудника";
                DGV.Columns[2].HeaderText = "Ставка сотрудника";
                DGV.Columns[3].HeaderText = "Выданная зарплата";
                DGV.Columns[4].HeaderText = "Квалификация сотрудника";
            }

        }

        private void btnUvol_Click(object sender, EventArgs e)
        {
            UvolitForm uf = new UvolitForm(login);
            uf.Show();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
