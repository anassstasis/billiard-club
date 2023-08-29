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
    public partial class Add : Form
    {
        ws20Entities conn = new ws20Entities();
        bool visitor_rb = false;
        bool bar_rb = false;
        bool souvenir_rb = false;
        public Add()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
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

        private void search_button_Click(object sender, EventArgs e)
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

        private void viritorrb_CheckedChanged(object sender, EventArgs e)
        {
            table.DataSource = conn.visitors.ToList();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void barrb_CheckedChanged(object sender, EventArgs e)
        {
            table.DataSource = conn.bar.ToList();
            panel2.Visible = true;
            panel3.Visible = false;

        }

        private void souvenirrb_CheckedChanged(object sender, EventArgs e)
        {
            table.DataSource = conn.souvenirs.ToList();
            panel3.Visible = true;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (panel1.Visible)
                {
                    visitors visitors = new visitors();
                    visitors.fio = Convert.ToString(fio_tb.Text);
                    visitors.parties = Convert.ToString(parties_tb.Text);
                    visitors.card_status = Convert.ToString(status_tb.Text);
                    visitors.visit_price = Convert.ToInt32(price_tb.Text);
                    conn.visitors.Add(visitors);
                    conn.SaveChanges();
                }

                if (panel2.Visible)
                {
                    bar bar = new bar();
                    bar.name = Convert.ToString(name_tb.Text);
                    bar.price = Convert.ToInt32(price_tb1.Text);
                    conn.bar.Add(bar);
                    conn.SaveChanges();
                }
                if (panel3.Visible)
                {
                    souvenirs souvenirs = new souvenirs();
                    souvenirs.name = Convert.ToString(name_tb2.Text);
                    souvenirs.price = Convert.ToInt32(price_tb2.Text);
                    conn.souvenirs.Add(souvenirs);
                    conn.SaveChanges();
                }
                MessageBox.Show("Запись добавлена.");
            }
            catch
            {
                MessageBox.Show("Заполните все поля!");
            }
                
        }

        private void delete_b_Click(object sender, EventArgs e)
        {
            visitor_rb = viritorrb.Checked;
            if (visitor_rb)
            {
                    try
                    {
                        visitors select = conn.visitors.Where(c => c.fio == search_tb.Text).First();
                        conn.visitors.Remove(select);
                        conn.SaveChanges();
                        table.DataSource = conn.visitors.ToList();
                    }
                    catch
                    {
                        MessageBox.Show("Неверно введены данные. ");

                    }
            }

            bar_rb = barrb.Checked;

            if (bar_rb)
            {
                try
                {
                    bar select = conn.bar.Where(c => c.name == search_tb.Text).First();
                    conn.bar.Remove(select);
                    conn.SaveChanges();
                    table.DataSource = conn.visitors.ToList();
                }
                catch
                {
                    MessageBox.Show("Неверно введены данные. ");
                }
            }

            souvenir_rb = souvenirrb.Checked;

            if (souvenir_rb)
            {
                try
                {
                    souvenirs select = conn.souvenirs.Where(c => c.name == search_tb.Text).First();
                    conn.souvenirs.Remove(select);
                    conn.SaveChanges();
                    table.DataSource = conn.visitors.ToList();
                }
                catch
                {
                    MessageBox.Show("Неверно введены данные. ");
                }
            }
        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
