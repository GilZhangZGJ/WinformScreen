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
        Bitmap image = new Bitmap(920, 600);
        double _printWidth;
        double _printHeight;
        public Main()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {                            
           
            Graphics graphics = Graphics.FromImage(image);
            Pen pen = new Pen(Color.Blue,2);
            //横线
            graphics.DrawLine(pen, 0, 0, 920, 0);
            graphics.DrawLine(pen, 0, 48, 920, 48);
            graphics.DrawLine(pen, 0, 96, 920, 96);
            graphics.DrawLine(pen, 0, 144, 920, 144);
            graphics.DrawLine(pen, 0, 168, 920, 168);
            graphics.DrawLine(pen, 0, 216, 920, 216);
            graphics.DrawLine(pen, 0, 264, 920, 264);
            graphics.DrawLine(pen, 0, 312, 920, 312);
            graphics.DrawLine(pen, 0, 360, 920, 360);
            graphics.DrawLine(pen, 0, 408, 920, 408);
            graphics.DrawLine(pen, 0, 456, 920, 456);
            graphics.DrawLine(pen, 0, 504, 920, 504);
            graphics.DrawLine(pen, 0, 552, 920, 552);
            graphics.DrawLine(pen, 0, 600, 920, 600);   
            //竖线
            graphics.DrawLine(pen, 0, 0, 0, 144);
            graphics.DrawLine(pen, 0, 168, 0, 600);
            graphics.DrawLine(pen, 210, 48, 210, 144);
            graphics.DrawLine(pen, 210, 168, 210, 600);
            graphics.DrawLine(pen, 410, 48, 410, 144);
            graphics.DrawLine(pen, 410, 168, 410, 600);
            graphics.DrawLine(pen, 685, 48, 685, 144);
            graphics.DrawLine(pen, 685, 168, 685, 600);
            graphics.DrawLine(pen, 920, 0, 920, 144);
            graphics.DrawLine(pen, 920, 168, 920, 600);
            Pen pen2 = new Pen(Color.Blue, 2);
           
            //画字
            Font fontBold = new Font("微软雅黑",17,FontStyle.Bold);
            Font fontR = new Font("微软雅黑", 16, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            

            //横行大标题
            RectangleF rectangle4 = new RectangleF(0, 312, 210, 48);
            RectangleF rectangle5 = new RectangleF(410, 168, 210, 48);
            RectangleF rectangle6 = new RectangleF(0, 456, 210, 48);
            RectangleF rectangle7 = new RectangleF(402, 266, 402, 38);
            RectangleF rectangle8 = new RectangleF(0, 380, 402, 38);
            RectangleF rectangle9 = new RectangleF(402, 380, 402, 38);
            //左边上三行矩形
            RectangleF rectangle1 = new RectangleF(0, 48, 210, 48);
            RectangleF rectangle2 = new RectangleF(0, 96, 210, 48);
            RectangleF rectangle3 = new RectangleF(410, 48, 210, 48);
            RectangleF studentID = new RectangleF(410, 96, 300, 48);
            RectangleF opening = new RectangleF(0, 168, 210, 48);
            RectangleF mar1 = new RectangleF(210, 168, 210, 48);
            RectangleF mar2 = new RectangleF(685, 168, 210, 48);
            RectangleF mar3 = new RectangleF(210, 312, 210, 48);
            RectangleF mar4 = new RectangleF(210, 456, 210, 48);
            RectangleF mar5 = new RectangleF(685, 456, 210, 48);
            RectangleF awarding = new RectangleF(410, 456, 300, 48);
            
            //小标题
            RectangleF rectangle10 = new RectangleF(0, 216, 210, 48);
            RectangleF rectangle11= new RectangleF(410, 216, 210, 48);
            RectangleF rectangle12= new RectangleF(0, 264, 210, 48);
            RectangleF rectangle13= new RectangleF(410, 264, 210, 48);
            RectangleF rectangle14= new RectangleF(410, 312, 210, 48);
            RectangleF rectangle15= new RectangleF(0, 360, 210, 48);
            RectangleF rectangle16 = new RectangleF(410, 360, 210, 48);
            RectangleF rectangle17 = new RectangleF(0, 408, 210, 48);
            RectangleF rectangle18 = new RectangleF(410, 408, 210, 48);
            RectangleF rectangle19 = new RectangleF(0, 504, 210, 48);
            RectangleF rectangle20 = new RectangleF(410, 504, 210, 48);
            RectangleF rectangle21 = new RectangleF(0, 552, 210, 48);
            RectangleF rectangle22 = new RectangleF(410, 552, 210, 48);



            //灵活数据
            //左边上三行矩形
            RectangleF rectangle = new RectangleF(0, 0, 920, 48);
            RectangleF diyData1 = new RectangleF(210, 48, 200, 48);
            RectangleF diyData2 = new RectangleF(685, 48, 235, 48);
            RectangleF diyData3 = new RectangleF(210, 96, 200, 48);
            //小标题
            RectangleF diyData4 = new RectangleF(685, 96, 235, 48);
            RectangleF diyData5 = new RectangleF(210, 216, 200, 48);
            RectangleF diyData6 = new RectangleF(685, 216, 235, 48);
            RectangleF diyData7 = new RectangleF(210, 264, 200, 48);
            RectangleF diyData8 = new RectangleF(685, 264, 235, 48);
            RectangleF diyData9 = new RectangleF(685, 312, 235, 48);
            RectangleF diyData10 = new RectangleF(210,360, 200, 48);
            RectangleF diyData11= new RectangleF(685, 360, 235, 48);
            RectangleF diyData12= new RectangleF(210, 408, 200, 48);
            RectangleF diyData13= new RectangleF(685, 408, 235, 48);
            RectangleF diyData14= new RectangleF(210, 504, 200, 48);
            RectangleF diyData15= new RectangleF(685, 504, 235, 48);
            RectangleF diyData16 = new RectangleF(210, 552, 200, 48);
            RectangleF diyData17 = new RectangleF(685, 552, 235, 48);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            sf.LineAlignment = StringAlignment.Center;
           
           
            
            //graphics.DrawString("Critical Thinking(Reading)", font, b, rectangle7, sf);
            //graphics.DrawString("Workshop", font, b, rectangle8, sf);
            //graphics.DrawString("Critical Thinking(Presentation)", font, b, rectangle9, sf);
            //需要匹配的栏位数据
            graphics.DrawString("Division", fontBold, b, rectangle1, sf);
            graphics.DrawString("Team ID", fontBold, b, rectangle2, sf);
            graphics.DrawString("Student ID", fontBold, b, rectangle3, sf);
            graphics.DrawString("Hotel Shuttle Bus Time", fontBold, b, studentID, sf);
            graphics.DrawString("Opening", fontBold, b, opening, sf);
            graphics.DrawString("Mar.16th", fontBold, b, mar1, sf);
            graphics.DrawString("Critical Thinking", fontBold, b, rectangle5, sf);
            graphics.DrawString("Mar.16th", fontBold, b, mar2, sf);
            graphics.DrawString("Qualifying Test", fontBold, b, rectangle4, sf);
            graphics.DrawString("Mar.16th", fontBold, b, mar3, sf);
            graphics.DrawString("Super Econ ！", fontBold, b, rectangle6, sf);
            graphics.DrawString("Mar.16th", fontBold, b, mar4, sf);
            graphics.DrawString("Awarding & Quiz Bowl", fontBold, b, awarding, sf);
            graphics.DrawString("Mar.17th", fontBold, b, mar5, sf);




            graphics.DrawString("Entry Time", fontR, b, rectangle10, sf);
            graphics.DrawString("Entry Time", fontR, b, rectangle11, sf);
            graphics.DrawString("Seat", fontR, b, rectangle12, sf);
            graphics.DrawString("Reading Time", fontR, b, rectangle13, sf);
            graphics.DrawString("Discussion Time", fontR, b, rectangle14, sf);
            graphics.DrawString("Entry Time", fontR, b, rectangle15, sf);
            graphics.DrawString("Presentation Time", fontR, b, rectangle16, sf);
            graphics.DrawString("Seat", fontR, b, rectangle17, sf);
            graphics.DrawString("Slot", fontR, b, rectangle18, sf);
            graphics.DrawString("Entry Time", fontR, b, rectangle19, sf);
            graphics.DrawString("Entry Time", fontR, b, rectangle20, sf);
            graphics.DrawString("Table", fontR, b, rectangle21, sf);
            graphics.DrawString("Seat", fontR, b, rectangle22, sf);
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

            StringFormat sfC = new StringFormat();
            sfC.Alignment = StringAlignment.Center;
            sfC.LineAlignment = StringAlignment.Center;
            string str= textBox1.Text;
            string[] vs = str.Split('|');
            if(vs!=null&&vs.Length>15)
            {
                graphics.DrawString(vs[0], fontR, diyDataB, rectangle, sfC);
                graphics.DrawString(vs[1], fontR, diyDataB, diyData1, sf);
                graphics.DrawString(vs[2], fontR, diyDataB, diyData2, sf);
                graphics.DrawString(vs[3], fontR, diyDataB, diyData3, sf);
                graphics.DrawString(vs[4], fontR, diyDataB, diyData4, sf);
                graphics.DrawString(vs[5], fontR, diyDataB, diyData5, sf);
                graphics.DrawString(vs[6], fontR, diyDataB, diyData6, sf);
                graphics.DrawString(vs[7], fontR, diyDataB, diyData7, sf);
                graphics.DrawString(vs[8], fontR, diyDataB, diyData8, sf);
                graphics.DrawString(vs[9], fontR, diyDataB, diyData9, sf);
                graphics.DrawString(vs[10], fontR, diyDataB, diyData10, sf);
                graphics.DrawString(vs[11], fontR, diyDataB, diyData11, sf);
                graphics.DrawString(vs[12], fontR, diyDataB, diyData12, sf);
                graphics.DrawString(vs[13], fontR, diyDataB, diyData13, sf);
                graphics.DrawString(vs[14], fontR, diyDataB, diyData14, sf);
                graphics.DrawString(vs[15], fontR, diyDataB, diyData15, sf);
                graphics.DrawString(vs[16], fontR, diyDataB, diyData16, sf);
                graphics.DrawString(vs[17], fontR, diyDataB, diyData17, sf);
            }
            graphics.Flush();
            pen.Dispose();
            pen2.Dispose();
            fontR.Dispose();
            fontBold.Dispose();
            b.Dispose();
            _printWidth = (double)80 / 25.40000;
            _printHeight = (double)50 / 25.40000;

            //graphics.DrawString("测试数据", font, b, rectangle, sf);
            PrintDocument printDocument = new PrintDocument();
            PrintController printController = new StandardPrintController();//禁止"打印中"弹窗
            printDocument.PrintController = printController;
            printDocument.PrintPage += PrintDocument_PrintPage;
            //printDocument.Print();
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
