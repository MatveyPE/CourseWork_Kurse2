using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CousreWork
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "Admin" && maskedTextBox2.Text == "Admin")
            {
                MainChess main = new MainChess();
                main.Show();
            }
            else 
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login: Admin  Password: Admin");
        }
    }
}
