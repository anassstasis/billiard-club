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
    public partial class Service : Form
    {
        ws20Entities conn = new ws20Entities();
        bool visitor_rb = false;
        bool bar_rb = false;
        bool souvenir_rb = false;

        public Service()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Visitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.SaveChanges();
        }
        private void button4_Click(object sender, EventArgs e)
        {
          
                visitor_rb = viritorrb.Checked;

                if (visitor_rb)
                {
                    table.DataSource = conn.visitors.ToList();
                    table.DataSource = conn.visitors.Where(c => c.fio.Contains(search_tb.Text)).ToList();
                }

                bar_rb = barrb.Checked;

                if (bar_rb)
                {
                    table.DataSource = conn.bar.ToList();
                    table.DataSource = conn.bar.Where(c => c.name.Contains(search_tb.Text)).ToList();
                }

                souvenir_rb = souvenirrb.Checked;

                if (souvenir_rb)
                {
                    table.DataSource = conn.souvenirs.ToList();
                    table.DataSource = conn.souvenirs.Where(c => c.name.Contains(search_tb.Text)).ToList();
                }
                   
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           visitor_rb = viritorrb.Checked;

            if (visitor_rb)
            {
                try
                {
                    int sum = 0;
                    for (int i = 0; i < table.SelectedCells.Count; i++)
                    {
                        sum += Convert.ToInt32(table.SelectedCells[i].Value);
                    }
                    vis_tb.Text = sum.ToString();
                }
                catch
                {
                    MessageBox.Show("Выберите значение стоимости услуги");
                }

            }

            bar_rb = barrb.Checked;

            if (bar_rb)
            {
                try
                {
                    int sum = 0;
                    for (int i = 0; i < table.SelectedCells.Count; i++)
                    {
                        sum += Convert.ToInt32(table.SelectedCells[i].Value);
                    }
                    bar_tb.Text = sum.ToString();
                }
                catch
                {
                    MessageBox.Show("Выберите значение стоимости услуги");
                }
            }

            souvenir_rb = souvenirrb.Checked;

            if (souvenir_rb)
            {
                try
                {
                    int sum = 0;
                    for (int i = 0; i < table.SelectedCells.Count; i++)
                    {
                        sum += Convert.ToInt32(table.SelectedCells[i].Value);
                    }
                    souvenir_tb.Text = sum.ToString();
                }
                catch
                {
                    MessageBox.Show("Выберите значение стоимости услуги");
                }
            }
        }

        private void viritorrb_CheckedChanged(object sender, EventArgs e)
        {
            table.DataSource = conn.visitors.ToList();
        }

        private void barrb_CheckedChanged(object sender, EventArgs e)
        {
            table.DataSource = conn.bar.ToList();
        }

        private void souvenirrb_CheckedChanged(object sender, EventArgs e)
        {
            table.DataSource = conn.souvenirs.ToList();
        }

        private void return_button_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            if (vis_tb.Text == "")
            {
                vis_tb.Text = "0";
            }
            if (bar_tb.Text == "")
            {
                bar_tb.Text = "0";
            }
            if (souvenir_tb.Text == "")
            {
                souvenir_tb.Text = "0";
            }
            payment.visitor_tb.Text = this.vis_tb.Text;
            payment.bar_tb.Text = this.bar_tb.Text;
            payment.souvenir_tb.Text = this.souvenir_tb.Text;
            payment.Show();
        }

    }
}
