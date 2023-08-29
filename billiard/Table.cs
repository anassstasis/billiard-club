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
    public partial class Table : Form
    {
        ws20Entities conn = new ws20Entities();
        public static string name;
        public Table()
        {
            InitializeComponent();
        }

        private void Table_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            conn.SaveChanges();
        }

        private void seetable_b_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.pooltable.ToList();
        }
    }
}
