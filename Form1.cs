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

namespace njme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = "najme";
            string password = "mosavi";
            if (textBox1.Text == username && textBox2.Text == password)
            {
                Form2 i = new Form2();
                i.Show();
                Hide();
                MessageBox.Show("welcome");
            }
            else
            {
                MessageBox.Show("user name or password is wrong");
            }
            File.WriteAllText(@"E:\name", "name:" + textBox1.Text + "\r\n" + "password:" + textBox2.Text);
        }
    }
}
