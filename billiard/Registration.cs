using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billiard
{
    public partial class Registration : Form
    {
        ws20Entities conn = new ws20Entities();
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                users user = new users();
                user.name = Convert.ToString(fio_tb.Text);
                user.login = Convert.ToString(log_tb.Text);
                user.password = Convert.ToString(pass_tb.Text);
                conn.users.Add(user);
                conn.SaveChanges();

            if (pass_tb.Text == "" || fio_tb.Text == "" || log_tb.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                MessageBox.Show("Регистрация прошла успешно.");
                Authorization authorization = new Authorization();
                this.Hide();
                authorization.ShowDialog();
            }
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Hide();
            authorization.ShowDialog();
        }

    }
}
