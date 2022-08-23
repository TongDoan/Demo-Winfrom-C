using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuaBaiKS;
namespace DeMoWinAppTuan1
{
    public partial class Form1 : Form
    {
        List<KHSDDIEN> lst = new List<KHSDDIEN>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //thêm thông tin vào ds sau khi ng dùng nhập đủ dl và ấn nút thêm vào DS
            string ma, ten, dc;
            DateTime nc;
            int st, ss;
            ma = textBox1.Text;
            ten = textBox2.Text;
            dc = textBox3.Text;
            nc = dateTimePicker1.Value;
            
            st =int.Parse( textBox4.Text);
             bool k=int.TryParse( textBox5.Text,out ss);
            //if(ma)
            KHSDDIEN x = new KHSDDIEN(ma,ten,dc,nc,st,ss);
            listBox1.Items.Add(x.ToString());
            lst.Add(x);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
