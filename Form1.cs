using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static ProfileDetection.Protocol;

namespace ProfileDetection
{
    public partial class MainForm : Form
    {

        const UInt32 CFG_VALID = 0x55AA55AA;
        const Int32 MAX_MODEL_NUM = 2;         //#define MAX_MODEL_NUM	2	//最多线型数量
        const Int32 OUTPUT_NUM = 2;
        const Int32 INPUT_NUM = 4;
        bool isSetupModel = false;

        public Button[] btn_mains=new Button[4];
        public Button[] btn_settings = new Button[5];
        private Point mPoint;
        Image tmpImgCom= ProfileDetection.Properties.Resources.com_normal;
        public Protocol devProtocol = new Protocol();
        public REC devRec = new REC();
        public CFG_T devCfg = new CFG_T();

        const int RCV_BUF_SIZE = 1000000;
        const String bmpFileName = "D:\\IMG128.png"; 
        byte[] imgBuf = new byte[RCV_BUF_SIZE];

        const int imgScaleX = 4;
        const int imgScaleY = 1;
        const int imgWidth = imgScaleX * REC.PIX_NUM;
        const int imgHeight = imgWidth;

        Bitmap bmp = new Bitmap(imgWidth, imgHeight);

        COMM_FRAME_T frameRX = new COMM_FRAME_T();  //保存串口收到的数据
        long openDevCfgDlgTimeOut;
        public MainForm()
        {
            InitializeComponent();
        } 

        private void btn_main_click(object sender,EventArgs e)
        {
            //将四个设置按钮设置为未激活
            this.btn_instrument.BackgroundImage = ProfileDetection.Properties.Resources.设备;//this.btn_record,this.btn_setting, this.btn_setting_file
            this.btn_record.BackgroundImage = ProfileDetection.Properties.Resources.记录;
            this.btn_setting.BackgroundImage = ProfileDetection.Properties.Resources.设置;
            this.btn_setting_file.BackgroundImage = ProfileDetection.Properties.Resources.文件;


            //隐藏三个面板
            this.panel_file.Visible = false;
            this.panel_log.Visible = false;
            this.panel_setting.Visible = false;

            #region 激活对应的面板和按钮
            int btn_index = 0;
            for (; btn_index < btn_mains.Length; btn_index++)
            {
                if (sender == btn_mains[btn_index])      //获取到当前点击按钮的索引，配合switch使用
                    break;
            }
            switch (btn_index)                              //将相应的按钮设置为激活状态，并显示对应的panel；
            {
                case (int)btn_index_main.btn_instrument:
                    this.btn_instrument.BackgroundImage = ProfileDetection.Properties.Resources.设备激活;
                    break;
                case (int)btn_index_main.btn_record:
                    this.btn_record.BackgroundImage = ProfileDetection.Properties.Resources.记录激活;
                    this.panel_log.Visible = true;
                    break;
                case (int)btn_index_main.btn_setting:
                    this.btn_setting.BackgroundImage = ProfileDetection.Properties.Resources.设置激活;
                    this.panel_setting.Visible = true;
                    break;
                case (int)btn_index_main.btn_setting_file:
                    this.btn_setting_file.BackgroundImage = ProfileDetection.Properties.Resources.文件激活;
                    this.panel_file.Visible = true;
                    break;
            }
            #endregion
        }

        private void btn_settings_click(object sender, EventArgs e)
        {
            //将四个设置按钮设置为未激活
            this.btn_setting_general.BackgroundImage = ProfileDetection.Properties.Resources.通用未激活; 
            this.btn_setting_output.BackgroundImage = ProfileDetection.Properties.Resources.输出未激活;
            this.btn_setting_input.BackgroundImage = ProfileDetection.Properties.Resources.输入未激活;
            this.btn_setting_wire1.BackgroundImage = ProfileDetection.Properties.Resources.线型参数未激活1;
            this.btn_setting_wire2.BackgroundImage = ProfileDetection.Properties.Resources.线型参数未激活1;


            //隐藏五个面板
            this.panel_setting_contaner.Visible = false;
            this.panel_setting_output.Visible = false;
            this.panel_setting_input.Visible = false;
            this.panel_setting_wire1.Visible = false;
            this.panel_setting_wire2.Visible = false;

            #region 激活对应的面板和按钮
            int btn_index = 0;
            for (; btn_index < btn_settings.Length; btn_index++)
            {
                if (sender == btn_settings[btn_index])      //获取到当前点击按钮的索引，配合switch使用
                    break;
            }
            switch (btn_index)                              //将相应的按钮设置为激活状态，并显示对应的panel；
            {
                case (int)btn_index_setting.btn_general:
                    this.btn_setting_general.BackgroundImage = ProfileDetection.Properties.Resources.通用激活;
                    this.panel_setting_contaner.Visible = true;
                    break;
                case (int)btn_index_setting.btn_output:
                    this.btn_setting_output.BackgroundImage = ProfileDetection.Properties.Resources.输出激活;
                    this.panel_setting_output.Visible = true;
                    break;
                case (int) btn_index_setting.btn_input:
                    this.btn_setting_input.BackgroundImage = ProfileDetection.Properties.Resources.输入激活;
                    this.panel_setting_input.Visible = true;
                    break;
                case (int)btn_index_setting.btn_wire1:
                    this.btn_setting_wire1.BackgroundImage = ProfileDetection.Properties.Resources.线型参数激活;
                    this.panel_setting_wire1.Visible = true;
                    break;
                case (int)btn_index_setting.btn_wire2:
                    this.btn_setting_wire2.BackgroundImage = ProfileDetection.Properties.Resources.线型参数激活;
                    this.panel_setting_wire2.Visible = true;
                    break;
            }
            #endregion
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            #region 绑定主界面按钮并添加统一监听事件：实现主面板切换功能。
            btn_mains[0] = this.btn_instrument;
            btn_mains[1] = this.btn_record;
            btn_mains[2] = this.btn_setting;
            btn_mains[3] = this.btn_setting_file ;
            for(int i=0;i<btn_mains.Length;i++)
            {
                btn_mains[i].Click += new System.EventHandler(this.btn_main_click);
            }
            #endregion 

            # region 绑定设置按钮并添加统一监听事件：实现设置面板切换功能。
            btn_settings[0] = this.btn_setting_general;
            btn_settings[1] = this.btn_setting_output;
            btn_settings[2] = this.btn_setting_input;
            btn_settings[3] = this.btn_setting_wire1;
            btn_settings[4] = this.btn_setting_wire2;
            for(int i=0;i<btn_settings.Length;i++)
            {
                btn_settings[i].Click += new System.EventHandler(this.btn_settings_click);
            }
            #endregion
            btn_settings[0].PerformClick();
            btn_mains[0].PerformClick();

            #region 绑定串口选项到串口下拉框
            string[] ports = SerialPort.GetPortNames();
            comboxCom.Items.AddRange(ports);
            comboxCom.Text = ports[ports.Length - 1];//"COM5";
            #endregion

            #region 开启计时器timer1
            timer1.Interval = 200;
            timer1.Enabled = true;
            #endregion

            //this.group_output2.Enabled = false;
        }
        /// <summary>
        /// 主界面按钮枚举
        /// </summary>
        enum btn_index_main
        {
            btn_instrument = 0,
            btn_record = 1,
            btn_setting = 2,
            btn_setting_file = 3
        }
        /// <summary>
        /// 设置界面按钮枚举
        /// </summary>
        enum btn_index_setting
        {
            btn_general = 0,
            btn_output = 1,
            btn_input = 2,
            btn_wire1 = 3,
            btn_wire2 = 4
        }

        //下面的mouseDown配合MouseMove实现窗口拖动
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void btnCom_MouseDown(object sender, MouseEventArgs e)     
        {
            tmpImgCom = this.btnCom.BackgroundImage;
            this.btnCom.BackgroundImage= ProfileDetection.Properties.Resources.com_press;

        }

        private void btn_instrument_Click(object sender, EventArgs e)
        {

        }

        private void btnCom_MouseUp(object sender, MouseEventArgs e)
        {
            this.btnCom.BackgroundImage = tmpImgCom;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                this.btnCom.BackgroundImage= ProfileDetection.Properties.Resources.com_activi;
            }
            else    //如果串口关闭，把串口开关设置为未激活状态。关闭设置模式
            {
                this.btnCom.BackgroundImage = ProfileDetection.Properties.Resources.com_normal;
                isSetupModel = false;
                btn_Sen.BackgroundImage = ProfileDetection.Properties.Resources.实时校准未激活;
            }

            long ms = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000;     //时间戳;

            if (openDevCfgDlgTimeOut > 0)       // is waiting device response
            {
                if (ms > openDevCfgDlgTimeOut)  //timeout
                {
                    openDevCfgDlgTimeOut = 0;
                    MessageBox.Show("等待设备响应超时");
                    //OpenDevCfgDlg();

                }
            }

            while (devProtocol.GetRxFrame(ref frameRX))
            {
                ushort type = frameRX.type;
                type -= 0x2020; //两个字符转为大写
                switch (type)
                {
                    case Protocol.FRAME_TYPE_RP: ShowRec(devRec.RecFrameDeal(frameRX)); break;
                    case Protocol.FRAME_TYPE_NK: MessageBox.Show("设备忙"); break;
                    case Protocol.FRAME_TYPE_GC:
                        //if (null == dlgDevCfg)
                        //    dlgDevCfg = new DevCfgDlg(this);
                        //if (dlgDevCfg.IsDisposed)
                        //    dlgDevCfg = new DevCfgDlg(this);

                        //dlgDevCfg.CfgFreameDeal(frameRX);
                        //dlgDevCfg.UpdateShow(devCfg);
                        //if (openDevCfgDlgTimeOut > 0)
                        //{
                        //    dlgDevCfg.Show();
                        //    openDevCfgDlgTimeOut = 0;
                        //}
                        break;
                    case Protocol.FRAME_TYPE_SC: MessageBox.Show("更新设备信息成功！"); break;
                    case Protocol.FRAME_TYPE_LN:
                        //传感器实时采集数据帧
                        //if (null == dlgDevCfg)
                        //    dlgDevCfg = new DevCfgDlg(this);
                        //if (dlgDevCfg.IsDisposed)
                        //    dlgDevCfg = new DevCfgDlg(this); 
                        // this.btn_setting.PerformClick();//触发“设置”按钮的点击事件，切换面板到设置页面。
                        SensorFrameDeal(frameRX);
                        break; 
                    case Protocol.FRAME_TYPE_GS: 
                        ;
                        break; 
                    default: break;
                } 
            }

        }

        #region 配置相关
        //解析串口数据帧，更新显示
        public void CfgFreameDeal(COMM_FRAME_T frame)
        {
            CFG_T cfg = new CFG_T();

            cfg = (CFG_T)devProtocol.BytesToStruct(frame.data, Marshal.SizeOf(typeof(CFG_T)), typeof(CFG_T));

            if (CfgCheck(ref cfg))
            {
                devCfg = cfg;
               // UpdateShow(cfg);
            }
        }

        /*********************************************************************************************************
           检验参数有效性。如果参数无效，设为默认参数
       */
        int CFG_CheckVal(int val, int defVal, int min, int max)
        {
            int ret = val;
            if (val < min)
                ret = defVal;
            if (val > max)
                ret = defVal;
            return ret;
        }
        float CFG_CheckVal(float val, float defVal, float min, float max)
        {
            if (Single.IsNaN(val)) //if(Single.IsInfinity(val)) //if (!IsFinite(val))
                return defVal;

            float ret = val;
            if (val < min)
                ret = defVal;
            if (val > max)
                ret = defVal;
            return ret;
        }
        //检查配置有效性
        bool CfgCheck(ref CFG_T cfg)
        {
            int i;

            if (CFG_VALID != cfg.valid)
                return false;

            cfg.modelNum = CFG_CheckVal(cfg.modelNum, 1, 1, MAX_MODEL_NUM); 
            //检测线型 
            for (i = 0; i < MAX_MODEL_NUM; i++)
            {
                cfg.wire[i].tol.sealPosP = CFG_CheckVal(cfg.wire[i].tol.sealPosP, (float)2.0, (float)0.0, (float)10.0);				//mm
                cfg.wire[i].tol.sealPosN = CFG_CheckVal(cfg.wire[i].tol.sealPosN, (float)2.0, (float)0.0, (float)10.0);				//mm
                cfg.wire[i].tol.corePosP = CFG_CheckVal(cfg.wire[i].tol.corePosP, (float)2.0, (float)0.0, (float)10.0);				//mm
                cfg.wire[i].tol.corePosN = CFG_CheckVal(cfg.wire[i].tol.corePosN, (float)2.0, (float)0.0, (float)10.0);				//mm
                cfg.wire[i].tol.stripPosP = CFG_CheckVal(cfg.wire[i].tol.stripPosP, (float)2.0, (float)0.0, (float)10.0);			//mm
                cfg.wire[i].tol.stripPosN = CFG_CheckVal(cfg.wire[i].tol.stripPosN, (float)2.0, (float)0.0, (float)10.0);			//mm
                cfg.wire[i].tol.stripLenP = CFG_CheckVal(cfg.wire[i].tol.stripLenP, (float)2.0, (float)0.0, (float)10.0);			//mm
                cfg.wire[i].tol.stripLenN = CFG_CheckVal(cfg.wire[i].tol.stripLenN, (float)2.0, (float)0.0, (float)10.0);			//mm

                cfg.wire[i].tol.sealWidthP = CFG_CheckVal(cfg.wire[i].tol.sealWidthP, (float)10.0, (float)5.0, (float)100.0);		//%
                cfg.wire[i].tol.sealWidthN = CFG_CheckVal(cfg.wire[i].tol.sealWidthN, (float)10.0, (float)5.0, (float)100.0);		//%
                cfg.wire[i].tol.coreWidthP = CFG_CheckVal(cfg.wire[i].tol.coreWidthP, (float)10.0, (float)5.0, (float)100.0);		//%
                cfg.wire[i].tol.coreWidthN = CFG_CheckVal(cfg.wire[i].tol.coreWidthN, (float)10.0, (float)5.0, (float)100.0);		//%

                cfg.wire[i].tol.wireSplay = CFG_CheckVal(cfg.wire[i].tol.wireSplay, (float)50.0, (float)5.0, (float)1000.0);		//%

                cfg.wire[i].tol.variationFilter = CFG_CheckVal(cfg.wire[i].tol.variationFilter, (float)1.25, (float)0.0, (float)10.0);//mm
                cfg.wire[i].tol.sealRatio = CFG_CheckVal(cfg.wire[i].tol.sealRatio, (float)85.0, (float)2.0, (float)500.0);			//%
                cfg.wire[i].tol.sealLimit = CFG_CheckVal(cfg.wire[i].tol.sealLimit, (float)5.0, (float)2.0, (float)800.0);			//%
                cfg.wire[i].tol.stripLimit = CFG_CheckVal(cfg.wire[i].tol.stripLimit, (float)15.0, (float)5.0, (float)800.0);		//%
            } 
            //输出
            //TYPE_OUTPUT outputMode[OUTPUT_NUM];	//输出模式
            for (i = 0; i < OUTPUT_NUM; i++)
            {
                cfg.outputWireIdx[i] = CFG_CheckVal(cfg.outputWireIdx[i], 1, 1, MAX_MODEL_NUM);		//输出对应的线型序号
                cfg.outputDelay[i] = CFG_CheckVal(cfg.outputDelay[i], 0, 0, 10000);					//输出延时ms
                cfg.outputWidth[i] = CFG_CheckVal(cfg.outputWidth[i], 50, 0, 60000);					//输出脉宽
            } 
            //输入
            //TYPE_INPUT inputMode[INPUT_NUM];
            cfg.firingTimeOut = CFG_CheckVal(cfg.firingTimeOut, 500, 10, 60000);						//触发信号超时设置
            cfg.minSetupDuration = CFG_CheckVal(cfg.minSetupDuration, 4000, 4000, 60000);				//进入setup模式前，输入信号有效的最小持续时间，用于在没有上位机时手动操作进入学习模式

            cfg.senThresh = CFG_CheckVal(cfg.senThresh, 500, 5, 4000);	//CCD sensor threshold
            cfg.learnNum = CFG_CheckVal(cfg.learnNum, 1, 1, 16);		//学习模式个数 1～16次 初值：1  设置在学习时以几根良品的波形平均值作为基准波形。
            return true;
        }


        public void SensorFrameDeal(COMM_FRAME_T frame)
        {
            UInt16[] line = new UInt16[REC.PIX_NUM]; 
            int i; 
            //这里怎样通过内存拷贝实现以下功能？？
            for (i = 0; i < REC.PIX_NUM; i++)
            {
                line[i] = (UInt16)frame.data[2 * i];
                line[i] += (UInt16)((UInt16)frame.data[2 * i + 1] * (UInt16)256);
            } 
            Graphics grfx = pBoxSen.CreateGraphics();
            int picWidth = pBoxSen.Size.Width;
            int picHeight = pBoxSen.Size.Height;

            const int SENSOR_RANGE = 1024;  //传感器输出最大值

            int X_SCALE = picWidth / REC.PIX_NUM;// 3;
            int Y_SCALE = SENSOR_RANGE / picHeight;// 4;

            Pen pen = new Pen(Color.Blue, 1);

            Point[] pts = new Point[REC.PIX_NUM + 1];
            pts[0] = new Point(0, 0);
            for (i = 0; i < REC.PIX_NUM; i++)
            {
                pts[i + 1].X = (i + 1) * X_SCALE;
                pts[i + 1].Y = picHeight - line[i] / Y_SCALE;
            }
            grfx.Clear(Color.White);
            grfx.DrawLines(pen, pts);

            grfx.Dispose(); 
        }
        #endregion 

        //Show Record
        void ShowRec(REC_ITEM rec)
        {
            DrawRecImg(rec);    //显示记录录的图片

        }

        //将记录结构体中的图片绘制到窗口
        private void DrawRecImg(REC_ITEM rec)
        {
            int idx = 0;            //取图片中数据计数器。图片每行128个像素，保存在4个UInt32型数据中，每个bit表示一个像素。每取一行数据，idx加4，指向下一行
            uint w = rec.size.x;    //图片宽度 = 128
            uint h = rec.size.y;    //图片高度 = 80
            int x, y;
            Bitmap bmpOrg = new Bitmap(REC.PIX_NUM, REC.IMG_HEIGHT);    //保存记录中的原始图片。显示在界面上的图片是经过放大后的，保存在bmp中

            for (y = 0; y < h; y++)             //循环读取每一行
            {
                int[] line = new int[w];        //保存一行数据。将一行中每个像素展开，保存到line[]中
                int cnt = 0;                    //行内像素计数器，line[cnt]

                //从记录中取一行数据
                UInt32[] data = new UInt32[4];  //保存一行数据
                for (int i = 0; i < 4; i++)
                    data[i] = rec.img[i + idx];
                idx += 4;                       //指向下一行数据

                //将4个UInt32型数据展开到128个数据的数组line[]，表示一行数据
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 32; j++)
                    {
                        if ((data[i] & 0x00000001) != 0)
                        {
                            line[cnt] = 1;
                        }
                        else
                        {
                            line[cnt] = 0;
                        }
                        data[i] >>= 1;
                        cnt++;
                    }
                }

                //将这一行数据写入到bmpOrg中的第y行
                for (x = 0; x < w; x++)
                {
                    if (0 == line[x])
                        bmpOrg.SetPixel(x, y, Color.White);
                    else
                        bmpOrg.SetPixel(x, y, Color.Green);
                }
            }

            //scale img
            int xs, ys, xd, yd;     //xs ys 源图宽高   xd yd 目标图宽高
            int ydOffset = (imgHeight - y * imgScaleY) / 2;   //图片纵向居中
            for (yd = 0; yd < imgHeight; yd++)
            {
                for (xd = 0; xd < imgWidth; xd++)
                {
                    xs = xd / imgScaleX;         //源图中x
                    ys = yd / imgScaleY;         //源图中y

                    if (ys >= bmpOrg.Height)
                        break;

                    Color clr = bmpOrg.GetPixel(xs, ys);    //获取源图中像素
                    bmp.SetPixel(xd, yd + ydOffset, clr);  //填充到目标图中
                }
            }

            pictureBoxProfile.Image = bmp;        //将放大后的图片显示到界面
        }
        private void Receive(object sender, SerialDataReceivedEventArgs e)
        {
            int cnt = serialPort1.BytesToRead;
            byte[] rcvBuf = new byte[cnt]; 
            serialPort1.Read(rcvBuf, 0, cnt);
            //devProtocol.RxBuffAdd(rcvBuf, cnt);
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboxCom.Text;
                    serialPort1.BaudRate = 115200;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Parity = Parity.None;
                    serialPort1.Open();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btn_Sen_Click(object sender, EventArgs e)
        {
            if(!serialPort1.IsOpen)
            {
                MessageBox.Show("请先打开串口");
                return;
            }
            if(!isSetupModel)        //如果单前是非设置模式，进入设置模式
            {
                btn_Sen.BackgroundImage = ProfileDetection.Properties.Resources.实时校准激活;     //
                byte[] mode = new byte[Marshal.SizeOf(typeof(UInt32))];
                mode[0] = (byte)CH_MODE.SETUP;
                byte[] frm = devProtocol.GetCmdFrm(Protocol.FRAME_TYPE_SM, mode, (ushort)Marshal.SizeOf(typeof(UInt32)));
                 serialPort1.Write(frm, 0, frm.Length);
                isSetupModel = true;
            }
            else
            {
                btn_Sen.BackgroundImage = ProfileDetection.Properties.Resources.实时校准未激活;     //
                byte[] mode = new byte[Marshal.SizeOf(typeof(UInt32))];
                mode[0] = (byte)CH_MODE.WORK;
                byte[] frm = devProtocol.GetCmdFrm(Protocol.FRAME_TYPE_SM, mode, (ushort)Marshal.SizeOf(typeof(UInt32)));
                serialPort1.Write(frm, 0, frm.Length);
                isSetupModel = false;
            }
        }
    }
}
