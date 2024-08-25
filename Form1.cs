using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_01
{
    public partial class Form1 : Form
    {
        public static string name;
        public Form1()
        {
            InitializeComponent();
            this.Load+=Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text ="Deneme1";
            name = "name5";
            //label1.Text = Forms_01.math5.Deneme();
            label1.Text = Forms_01.math5.Deneme2(3).ToString();
            //label1 = label2;
            //this.Text = label1.Text;
        }

        public static string metin;
        private void button1_Click(object sender, EventArgs e)
        {
            metin = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

       
       public static String Yaz()
        {
            string name = "xxxx";
            return name;
        }

        public static void Uygula()
        {
            //Application.Exit();
            
        }
    }
}
