using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CousreWork
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream fs = new FileStream(@"DataBase.txt", FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(fs);
            List<string> lineHelp = new List<string>();
            int help0 = 1;
            while (!SR.EndOfStream)
            {
                lineHelp.Add(SR.ReadLine());
                help0++;
            }
            string[] lineMas = new string[3];
            int kolvoSovpadenii = 0;
            for(int i=0; i < help0-1; i++)
            {
                lineMas = lineHelp[i].Split(';');
                if(lineMas[0] == comboBox1.Text)
                {
                    if(lineMas[1] == maskedTextBox2.Text)
                    {
                        kolvoSovpadenii++;
                    }
                }
            }
            if(kolvoSovpadenii >= 1)
            {
                MessageBox.Show("The record already exists");
                SR.Close();
                return;
            }
            else
            {
                SR.Close();
                goto Ok;
            }
       
        Ok:
            {
                string[] help = new string[3];
                string help1;
                help1 = maskedTextBox2.Text;
                help = help1.Split('.');
                try
                {
                    if (Convert.ToInt32(help[0]) > 31 || Convert.ToInt32(help[1]) > 12)
                    {
                        MessageBox.Show("Invalid date");
                    }
                    else
                    {
                        StreamWriter SW = new StreamWriter("DataBase.txt", true);
                        SW.WriteLine(comboBox1.Text + ";" + maskedTextBox2.Text + ";" + maskedTextBox3.Text);
                        SW.Close();
                        MessageBox.Show("Entry added");
                    }
                }
                catch { MessageBox.Show("Invalid date or one of the fields is empty"); }
            }
            
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            string[] s1 = new string[] {"00:00", "01:00","02:00","03:00","04:00","05:00","06:00","07:00","08:00","09:00","10:00",
            "11:00","12:00","13:00","14:00","15:00","16:00","17:00","18:00","19:00","20:00","21:00","22:00","23:00"};
            for(int i =0; i< s1.Length; i++)
            comboBox1.Items.Add(s1[i]);
        }

        private void ButHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter all the necessary information about the Tenant in the 'Special'. " +
                "If the Tenant wants to book a meeting room for less than an hour, " +
                "it should also be indicated in the column 'Special', from such a time, to such a time. " +
                "Example: booking 13:30 - 14:00, in the column 'Special' we write this time, and in the column 'Time' we indicate the full hour, 13:00");
        }
    }
}
