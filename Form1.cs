using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProfileDetection
{
    public partial class MainForm : Form
    {
        public Button[] btn_mains=new Button[4] ;
        private Point mPoint;
        Image tmpImgCom= ProfileDetection.Properties.Resources.com_normal;
        public MainForm()
        {
            InitializeComponent();
        } 

        private void btn_main_click(object sender,EventArgs e)
        {
            this.btn_instrument.BackgroundImage = ProfileDetection.Properties.Resources.设备;//this.btn_record,this.btn_setting, this.btn_setting_file
            this.btn_record.BackgroundImage = ProfileDetection.Properties.Resources.记录;
            this.btn_setting.BackgroundImage = ProfileDetection.Properties.Resources.设置;
            this.btn_setting_file.BackgroundImage = ProfileDetection.Properties.Resources.文件;

            this.panel_file.Visible = false;
            this.panel_log.Visible = false;
            this.panel_setting.Visible = false;

            int btn_index = 0;
            for(; btn_index < btn_mains.Length; btn_index++)
            {
                if (sender == btn_mains[btn_index])
                    break;
            }
            switch(btn_index)                   //将相应的按钮设置为激活状态，并显示对应的panel；
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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btn_mains[0] = this.btn_instrument;
            btn_mains[1] = this.btn_record;
            btn_mains[2] = this.btn_setting;
            btn_mains[3] = this.btn_setting_file ;
            for(int i=0;i<btn_mains.Length;i++)
            {
                btn_mains[i].Click += new System.EventHandler(this.btn_main_click);
            }
        }
        enum btn_index_main
        { 
             btn_instrument =0,
             btn_record=1,
             btn_setting=2,
             btn_setting_file=3
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
    }
}
