using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompositingTable
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {                            
            Bitmap image = new Bitmap(804,504);
            Graphics graphics = Graphics.FromImage(image);
            Pen pen = new Pen(Color.Blue,4);
            //横线粗加外边框
            graphics.DrawRectangle(pen,2,2,800,500);
            graphics.DrawLine(pen, 0,38,800,38);
            graphics.DrawLine(pen, 0, 152, 800, 152);
            graphics.DrawLine(pen, 0, 266, 800, 266);
            graphics.DrawLine(pen, 0, 380, 800, 380);
            //竖线粗
            graphics.DrawLine(pen, 402, 38, 402, 502);
            Pen pen2 = new Pen(Color.Blue, 2);
            //横线中等粗细
            graphics.DrawRectangle(pen2, 0, 76, 800, 76);
            graphics.DrawRectangle(pen2, 0, 114, 800, 114);
            graphics.DrawRectangle(pen2, 0, 190, 800, 190);
            graphics.DrawRectangle(pen2, 0, 228, 800, 228);
            graphics.DrawRectangle(pen2, 0, 304, 800, 304);
            graphics.DrawRectangle(pen2, 0, 342, 800, 342);
            graphics.DrawRectangle(pen2, 0, 418, 800, 418);
            graphics.DrawRectangle(pen2, 0, 456, 800, 456);
            //竖线中等粗细
            graphics.DrawLine(pen2, 201, 190, 201, 266);
            graphics.DrawLine(pen2, 201, 304, 201, 380);
            graphics.DrawLine(pen2, 201, 418, 201, 502);
            graphics.DrawLine(pen2, 603, 190, 603, 266);
            graphics.DrawLine(pen2, 603, 304, 603, 380);
            graphics.DrawLine(pen2, 603, 418, 603, 502);
            //画字
            Font font = new Font("宋体",20);
            Brush b = new SolidBrush(Color.Black);
            RectangleF rectangle = new RectangleF(0,2,800,38);
            RectangleF rectangle1 = new RectangleF(0, 38, 402, 38);
            RectangleF rectangle2 = new RectangleF(0, 76, 402, 38);
            RectangleF rectangle3 = new RectangleF(0, 114, 402, 38);
            //RectangleF rectangle4 = new RectangleF(0, 2, 402, 38);
            // rectangle5 = new RectangleF(0, 2, 402, 38);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            graphics.DrawString("Gil Zhang", font, b, rectangle, sf);
            graphics.DrawString("Gil Zhang", font, b, rectangle1, sf);
            graphics.DrawString("Gil Zhang", font, b, rectangle2, sf);
            graphics.DrawString("Gil Zhang", font, b, rectangle3, sf);
            //graphics.DrawString("测试数据", font, b, rectangle, sf);
            pictureBoxRet.Image = image;
        }
    }
}
