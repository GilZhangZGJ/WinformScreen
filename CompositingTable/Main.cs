using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompositingTable
{
    public partial class Main : Form
    {
        Bitmap image = new Bitmap(804, 504);
        double _printWidth;
        double _printHeight;
        public Main()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {                            
           
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
            Font font = new Font("微软细雅黑",16,FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            RectangleF rectangle = new RectangleF(0,2,800,38);

            //横行大标题
            RectangleF rectangle4 = new RectangleF(0, 152, 402, 38);
            RectangleF rectangle5 = new RectangleF(402, 152, 402, 38);
            RectangleF rectangle6 = new RectangleF(0, 266, 402, 38);
            RectangleF rectangle7 = new RectangleF(402, 266, 402, 38);
            RectangleF rectangle8 = new RectangleF(0, 380, 402, 38);
            RectangleF rectangle9 = new RectangleF(402, 380, 402, 38);
            //左边上三行矩形
            RectangleF rectangle1 = new RectangleF(0, 38, 402, 38);
            RectangleF rectangle2 = new RectangleF(0, 76, 402, 38);
            RectangleF rectangle3 = new RectangleF(0, 114, 402, 38);
            //小标题
            RectangleF rectangle10 = new RectangleF(0, 190, 201, 38);
            RectangleF rectangle11= new RectangleF(402, 190, 201, 38);
            RectangleF rectangle12= new RectangleF(0, 228, 201, 38);
            RectangleF rectangle13= new RectangleF(402, 228, 201, 38);
            RectangleF rectangle14= new RectangleF(0, 304, 201, 38);
            RectangleF rectangle15= new RectangleF(402, 304, 201, 38);
            RectangleF rectangle16 = new RectangleF(0, 342, 201, 38);
            RectangleF rectangle17 = new RectangleF(402, 342, 201, 38);
            RectangleF rectangle18 = new RectangleF(0, 418, 201, 38);
            RectangleF rectangle19 = new RectangleF(402, 418, 201, 38);
            RectangleF rectangle20 = new RectangleF(0, 456, 201, 38);
            RectangleF rectangle21 = new RectangleF(402, 456, 201, 38);



            //灵活数据
            //左边上三行矩形
            RectangleF diyData1 = new RectangleF(402, 38, 402, 38);
            RectangleF diyData2 = new RectangleF(402, 76, 402, 38);
            RectangleF diyData3 = new RectangleF(402, 114, 402, 38);
            //小标题
            RectangleF diyData4 = new RectangleF(201, 190, 201, 38);
            RectangleF diyData5 = new RectangleF(603, 190, 201, 38);
            RectangleF diyData6 = new RectangleF(201, 228, 201, 38);
            RectangleF diyData7 = new RectangleF(603, 228, 201, 38);
            RectangleF diyData8 = new RectangleF(201, 304, 201, 38);
            RectangleF diyData9 = new RectangleF(603, 304, 201, 38);
            RectangleF diyData10 = new RectangleF(201, 342, 201, 38);
            RectangleF diyData11= new RectangleF(603, 342, 201, 38);
            RectangleF diyData12= new RectangleF(201, 418, 201, 38);
            RectangleF diyData13= new RectangleF(603, 418, 201, 38);
            RectangleF diyData14= new RectangleF(201, 456, 201, 38);
            RectangleF diyData15= new RectangleF(603, 456, 201, 38);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            graphics.DrawString("Qualifying Test", font, b, rectangle4, sf);
            graphics.DrawString("Critical Thinking(Waiting)", font, b, rectangle5, sf);
            graphics.DrawString("Super Econ ！", font, b, rectangle6, sf);
            graphics.DrawString("Critical Thinking(Reading)", font, b, rectangle7, sf);
            graphics.DrawString("Workshop", font, b, rectangle8, sf);
            graphics.DrawString("Critical Thinking(Presentation)", font, b, rectangle9, sf);
            //需要匹配的栏位数据
            graphics.DrawString("Division", font, b, rectangle1, sf);
            graphics.DrawString("Team ID", font, b, rectangle2, sf);
            graphics.DrawString("Candidate ID", font, b, rectangle3, sf);
            graphics.DrawString("Time", font, b, rectangle10, sf);
            graphics.DrawString("Time", font, b, rectangle11, sf);
            graphics.DrawString("Seat", font, b, rectangle12, sf);
            graphics.DrawString("Seat", font, b, rectangle13, sf);
            graphics.DrawString("Time", font, b, rectangle14, sf);
            graphics.DrawString("Time", font, b, rectangle15, sf);
            graphics.DrawString("Table", font, b, rectangle16, sf);
            graphics.DrawString("Table", font, b, rectangle17, sf);
            graphics.DrawString("Workshop 1 Time", font, b, rectangle18, sf);
            graphics.DrawString("Time", font, b, rectangle19, sf);
            graphics.DrawString("Workshop 2 Time", font, b, rectangle20, sf);
            graphics.DrawString("Room", font, b, rectangle21, sf);
            Brush diyDataB = new SolidBrush(Color.Red);
            //需要匹配的栏位数据
            /*
            graphics.DrawString("Gil Zhang", font, diyDataB, rectangle, sf);
            graphics.DrawString("Division", font, diyDataB, diyData1, sf);
            graphics.DrawString("Team ID", font, diyDataB, diyData2, sf);
            graphics.DrawString("Candidate ID", font, diyDataB, diyData3, sf);
            graphics.DrawString("Time", font, diyDataB, diyData4, sf);
            graphics.DrawString("Time", font, diyDataB, diyData5, sf);
            graphics.DrawString("Seat", font, diyDataB, diyData6, sf);
            graphics.DrawString("Seat", font, diyDataB, diyData7, sf);
            graphics.DrawString("Time", font, diyDataB, diyData8, sf);
            graphics.DrawString("Time", font, diyDataB, diyData9, sf);
            graphics.DrawString("Table", font, diyDataB, diyData10, sf);
            graphics.DrawString("Table", font, diyDataB, diyData11, sf);
            graphics.DrawString("Workshop 1 Time", font, diyDataB, diyData12, sf);
            graphics.DrawString("Time", font, diyDataB, diyData13, sf);
            graphics.DrawString("Workshop 2 Time", font, diyDataB, diyData14, sf);
            graphics.DrawString("Room", font, diyDataB, diyData15, sf);
            //graphics.DrawString("测试数据", font, b, rectangle, sf);
            */
           string str= textBox1.Text;
            string[] vs = str.Split(',');
            if(vs!=null&&vs.Length>15)
            {
                graphics.DrawString(vs[0], font, diyDataB, rectangle, sf);
                graphics.DrawString(vs[1], font, diyDataB, diyData1, sf);
                graphics.DrawString(vs[2], font, diyDataB, diyData2, sf);
                graphics.DrawString(vs[3], font, diyDataB, diyData3, sf);
                graphics.DrawString(vs[4], font, diyDataB, diyData4, sf);
                graphics.DrawString(vs[5], font, diyDataB, diyData5, sf);
                graphics.DrawString(vs[6], font, diyDataB, diyData6, sf);
                graphics.DrawString(vs[7], font, diyDataB, diyData7, sf);
                graphics.DrawString(vs[8], font, diyDataB, diyData8, sf);
                graphics.DrawString(vs[9], font, diyDataB, diyData9, sf);
                graphics.DrawString(vs[10], font, diyDataB, diyData10, sf);
                graphics.DrawString(vs[11], font, diyDataB, diyData11, sf);
                graphics.DrawString(vs[12], font, diyDataB, diyData12, sf);
                graphics.DrawString(vs[13], font, diyDataB, diyData13, sf);
                graphics.DrawString(vs[14], font, diyDataB, diyData14, sf);
                graphics.DrawString(vs[15], font, diyDataB, diyData15, sf);
            }
           _printWidth = (double)80 / 25.40000;
            _printHeight = (double)50 / 25.40000;

            //graphics.DrawString("测试数据", font, b, rectangle, sf);
            PrintDocument printDocument = new PrintDocument();
            PrintController printController = new StandardPrintController();//禁止"打印中"弹窗
            printDocument.PrintController = printController;
            printDocument.PrintPage += PrintDocument_PrintPage;
            printDocument.Print();
            pictureBoxRet.Image = image;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                //e.Graphics.DrawImage(bmp,
                //    0, 0, e.Graphics.VisibleClipBounds.Width, e.Graphics.VisibleClipBounds.Width / bmp.Width * bmp.Height);
                e.Graphics.DrawImage(image, 0, 0, (int)(_printWidth * 100), (int)(_printHeight * 100));
                //e.Graphics.DrawImage(bmp,
                //e.Graphics.VisibleClipBounds);
                e.HasMorePages = false;
            }
            catch (System.Exception ex)
            {
               // logger.Error("print page handler take error.", ex);
                //Log...
            }
        }
    }
}
