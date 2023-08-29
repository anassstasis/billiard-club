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
    public partial class Payment : Form
    {       
        public Payment()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sum_tb.Text = (Convert.ToInt32(visitor_tb.Text) + Convert.ToInt32(bar_tb.Text) + Convert.ToInt32(souvenir_tb.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Вы ввели неккоректное значение!");
            }
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
