using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vereyon.Windows;

namespace WinformScreen
{
    public partial class NextForm : Form
    {
        public ScriptingBridge Bridge { get; private set; }
        static Timer timer = new Timer();
        //默认显示第一个人的照片
        private int p1 = 0;
        private bool bError;
        private List<Image> pictureList = new List<Image>();
        string _ImagePath = Path.Combine(Application.StartupPath, "Images");
        public NextForm()
        {
            InitializeComponent();
            this.Load += NextForm_Load;
            timer.Interval=110;
            timer.Tick += Timer_Tick;
            InitData();
            Bridge = new ScriptingBridge(webBrowser1, true);
           // Bridge.Initialized += new EventHandler(Bridge_Initialized);
        }
       
        private void InitData()
        {
            LoadFromFile();
            //if (bError)
            //{
            //    this.btnStart.Enabled = false;
            //    return;
            //}
        }

        //定义规则：把员工128*128大小的照片，并以名字命名放到Images下
        private void LoadFromFile()
        {
            //简单点，没有做递归查找图片
            pictureList.Clear();       
            try
            {
                DirectoryInfo folder = new DirectoryInfo(_ImagePath);

                FileInfo[] fiArr1 = folder.GetFiles("*.jpg");
                InitArrs(fiArr1);

                FileInfo[] fiArr2 = folder.GetFiles("*.png");
                InitArrs(fiArr2);

                FileInfo[] fiArr3 = folder.GetFiles("*.bmp");
                InitArrs(fiArr3);

             

                //初始化成功后默认显示第一个
                this.picEmp.Image = this.pictureList[p1];
            }
            catch (Exception)
            {
                bError = true;
                //MessageBox.Show(_TipError);
                return;
            }
        }

        private void InitArrs(FileInfo[] fiArr1)
        {
            if (null != fiArr1 && fiArr1.Length > 0)
            {
                foreach (FileInfo file in fiArr1)
                {
                   
                    pictureList.Add(Image.FromFile(file.FullName));
                }
            }
        }
        public  static NextForm instance = new NextForm();
        private void Timer_Tick(object sender, EventArgs e)
        {
            p1++;
            if (p1 >= pictureList.Count)
            {
                p1 = 0;
            }
            this.picEmp.Image = pictureList[p1];
        }

        public  void  DataSetIndex(int status)
        {
         if(status==1)
            {
                timer.Start();
               
            }
         else
            {          
                timer.Stop();
                //timer2.Stop();
                // this.label1.Text = "暂停";
            }
        }
        private void NextForm_Load(object sender, EventArgs e)
        { 
           //webBrowser1.Navigate(Application.StartupPath + @"\HTMLPageDemo.html");
            try
            {
                //设置窗体无边框
                this.FormBorderStyle = FormBorderStyle.None;
                //窗口置顶
                this.TopMost = true;
                //开始位置由 Location 决定
                this.StartPosition = FormStartPosition.Manual;

                Screen[] screens = System.Windows.Forms.Screen.AllScreens;
                if (screens.Length >= 2)
                {
                    //获取扩展屏
                    Screen childerScreen = screens[1];
                    //设置宽高
                    this.Width = childerScreen.Bounds.Width;
                    this.Height = childerScreen.Bounds.Height;
                    webBrowser1.Width = childerScreen.Bounds.Width;
                    webBrowser1.Height = childerScreen.Bounds.Height;
                    this.webBrowser1.Location= childerScreen.WorkingArea.Location;
                    this.picEmp.Width = childerScreen.Bounds.Width;
                    this.picEmp.Height = childerScreen.Bounds.Width;
                    this.picEmp.Top = 0;
                    this.picEmp.Left = 0;
                    //设置显示位置
                    this.Location = childerScreen.WorkingArea.Location;
                }
                else
                {
                    MessageBox.Show("只有一个显示器");
                }
            }
            catch (Exception ex)
            {
                //错误日志处理
            }
            Uri uri = new Uri(String.Format("file:///{0}/HTMLPageDemo.html", Directory.GetCurrentDirectory()));
            webBrowser1.Url = uri;
        }
    }
}
