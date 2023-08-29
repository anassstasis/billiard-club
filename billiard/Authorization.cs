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
    public partial class Authorization : Form
    {
        ws20Entities conn = new ws20Entities();

        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = conn.users.Where(c => (c.login == log_tb.Text) && (c.password == pass_tb.Text)).Count();

            if (count == 1)
            {
                users listGroup = conn.users.Where(c => (c.login == log_tb.Text) && (c.password == pass_tb.Text)).First();
                
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();
            }
            else MessageBox.Show("Неправильно указан логин и/или пароль.");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Registration registration = new Registration();
            this.Hide();
            registration.ShowDialog();
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
