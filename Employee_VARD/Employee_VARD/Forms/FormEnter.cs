using Employee_VARD.Forms;
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

namespace Employee_VARD
{
    public partial class FormEnter : Form
    {
        public FormEnter()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            List<User> users = BD_Employee_VARDEntities.GetContext().Users.ToList();

            User u = users.FirstOrDefault(p => p.userName == txtLogin.Text && p.userPassword == txtPassword.Text);

            if (u != null)
            {
                MainForm mf = new MainForm(u.userName);
                mf.Owner = this;
                this.Hide();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
