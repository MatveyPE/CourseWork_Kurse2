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
    public partial class MainChess : Form
    {
        
        public MainChess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("DataBase.txt"))
            {
                AddForm addForm = new AddForm();
                addForm.Show();
            }
        }
        private void Poisk()
        {
            Stream fs = new FileStream(@"DataBase.txt", FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(fs);
            List<string> lineHelp = new List<string>();
            int help = 1;
            while (!SR.EndOfStream)
            {
                lineHelp.Add(SR.ReadLine());
                help++;
            }
            string[] sMain1 = new string[3];
            string[] sDop3 = new string[2] { "0", "0" };
            string sMain0;
            string sMain2;
            string sMain3;
            string[] sDop4 = new string[2] { "0", "0" };

            for (int j = 0; j < help - 1; j++)
            {
                sMain0 = lineHelp[j];
                sMain1 = sMain0.Split(';');
                int cel = 0, row = 0;
                for (int i = 1; i < DataGridMain.Columns.Count; i++)
                {
                    sMain2 = DataGridMain.Columns[i].HeaderText.ToString();
                    sDop3 = sMain2.Split(' ');
                    if (sMain1[1] == sDop3[1])
                    {
                        for (int h = 0; h < DataGridMain.Rows.Count; h++)
                        {
                            sMain3 = DataGridMain.Rows[h].Cells[0].Value.ToString();
                            sDop4 = sMain3.Split(' ');
                            if (sMain1[0] == sDop4[0])
                            {
                                row = h;
                                break;
                            }
                        }
                        cel = i;
                        break;
                    }
                }
                DataGridMain.Rows[row].Cells[cel].Value = sMain0;
            }
            SR.Close();
            drawing();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Poisk();
        }
        DateTime dateTime = DateTime.Today;
        private void Main_Load(object sender, EventArgs e)
        {
           
            //Login&Pass: Admin
            string[] s0 = new string[] { "Time/Date",
                                        "ПН " + dateTime.Date.ToString("dd.MM.yyyy"),
                                        "ВТ " + dateTime.Date.AddDays(1).ToString("dd.MM.yyyy"),
                                        "СР " + dateTime.Date.AddDays(2).ToString("dd.MM.yyyy"), 
                                        "ЧТ " + dateTime.Date.AddDays(3).ToString("dd.MM.yyyy"), 
                                        "ПН " + dateTime.Date.AddDays(4).ToString("dd.MM.yyyy"),
                                        "CБ " + dateTime.Date.AddDays(5).ToString("dd.MM.yyyy"), 
                                        "ВС " + dateTime.Date.AddDays(6).ToString("dd.MM.yyyy") };

            string[] s1 = new string[] {"00:00", "01:00","02:00","03:00","04:00","05:00","06:00","07:00","08:00","09:00","10:00",
            "11:00","12:00","13:00","14:00","15:00","16:00","17:00","18:00","19:00","20:00","21:00","22:00","23:00"};
            for (int i=0; i < s0.Length; i++)
            {
                DataGridMain.Columns[i].HeaderText = s0[i];
            }
            
            for (int i = 0; i < s1.Length; i++)
            {
                DataGridMain.Rows.Add();
                DataGridMain.Rows[i].Cells[0].Value = s1[i];
            }
            if (System.IO.File.Exists("DataBase.txt"))
            {
                CreateTXT.Visible = false;
            }
            else
            {
                CreateTXT.Visible = true;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        { 
            CreateTXT.Visible = false;
            System.IO.File.Create("DataBase.txt");
            MessageBox.Show("The file was created successfully");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dateTime = dateTime.Date.AddDays(7);
            drawing();
            for (int i = 1; i < DataGridMain.ColumnCount; i++)
            {
                for (int j = 0; j < DataGridMain.Rows.Count; j++)
                {
                    DataGridMain.Rows[j].Cells[i].Value = "";
                }
            }
        }
        private void drawing()
        {
            string[] s0 = new string[] { "Time/Date",
                                        "ПН " + dateTime.ToString("dd.MM.yyyy"),
                                        "ВТ " + dateTime.Date.AddDays(1).ToString("dd.MM.yyyy"),
                                        "СР " + dateTime.Date.AddDays(2).ToString("dd.MM.yyyy"),
                                        "ЧТ " + dateTime.Date.AddDays(3).ToString("dd.MM.yyyy"),
                                        "ПН " + dateTime.Date.AddDays(4).ToString("dd.MM.yyyy"),
                                        "CБ " + dateTime.Date.AddDays(5).ToString("dd.MM.yyyy"),
                                        "ВС " + dateTime.Date.AddDays(6).ToString("dd.MM.yyyy") };
            string[] s1 = new string[] {"00:00", "01:00","02:00","03:00","04:00","05:00","06:00","07:00","08:00","09:00","10:00",
            "11:00","12:00","13:00","14:00","15:00","16:00","17:00","18:00","19:00","20:00","21:00","22:00","23:00"};
            for (int i = 0; i < s0.Length; i++)
            {
                DataGridMain.Columns[i].HeaderText = s0[i];
            }
            for (int i = 0; i < s1.Length; i++)
            {
                DataGridMain.Rows[i].Cells[0].Value = s1[i];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dateTime = dateTime.Date.AddDays(-7);
            drawing();
            for (int i = 1; i < DataGridMain.ColumnCount; i++)
            {
                for (int j = 0; j < DataGridMain.Rows.Count; j++)
                {
                    DataGridMain.Rows[j].Cells[i].Value = "";
                }
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataGridMain.CurrentCell.Value == null)
                MessageBox.Show("Free entry");
            else
                MessageBox.Show(DataGridMain.CurrentCell.Value.ToString());
        }

        private void ButDelete_Click(object sender, EventArgs e)
        {
            string Cell = DataGridMain.CurrentCell.Value.ToString();
            DataGridMain.CurrentCell.Value = "";
            var Lines = File.ReadAllLines(@"DataBase.txt");
            var newLines = Lines.Where(line => !line.Contains(Cell));
            File.WriteAllLines(@"DataBase.txt", newLines);
        }
    }
}
