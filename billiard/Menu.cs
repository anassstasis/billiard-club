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
    public partial class Menu : Form
    {
       
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Hide();
            authorization.ShowDialog();
        }

        private void table_button_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            this.Hide();
            table.ShowDialog();
        }

        private void service_button_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            this.Hide();
            service.ShowDialog();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            this.Hide();
            add.ShowDialog();
        }
    }
}
