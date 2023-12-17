using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUrsach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private OB ob;
        private void button1_Click(object sender, EventArgs e)
        {
            ob = new OB();
            ob.Visible = true;
        }
        private F4 alt;
        private void button2_Click(object sender, EventArgs e)
        {
            alt = new F4();
            alt.Visible = true;
        }
        private F6 Alt;
        private void button3_Click(object sender, EventArgs e)
        {
            Alt = new F6();
            Alt.Visible = true;
        }
    }
}
