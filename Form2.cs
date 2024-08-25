using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load+=Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //this.Text = Form1.name;
            //this.Text =Form1.Yaz();
            Forms_01.Class2.deneme2("1");
            string school = Forms_01.Class2.deneme2("7");
            this.Text = school;
            string garden= Class2.deneme2("75");
            label1.Text = garden;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Form1.metin;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //Form1.delete1();
           //this.Text= Form1.Yaz();

        }
    }
}
