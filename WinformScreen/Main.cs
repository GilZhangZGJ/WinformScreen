using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformScreen
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            NextForm frm2 = new NextForm();
            //if (Screen.AllScreens.Count() != 1)
            //{
            //    frm2.Left = Screen.AllScreens[0].Bounds.Width;
            //    frm2.Left = 1080;
            //    frm2.Top = 0;
            //    frm2.Size = new System.Drawing.Size(Screen.AllScreens[1].Bounds.Width, Screen.AllScreens[1].Bounds.Height);
            //    frm2.Show();
            //}
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //int a= Convert.ToInt32(textBox1.Text);
            NextForm.instance.DataSetIndex(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // a = Convert.ToInt32(textBox1.Text);
            NextForm.instance.DataSetIndex(0);
        }
    }
}
