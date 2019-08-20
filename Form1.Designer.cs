using System;
using System.IO.Ports;

namespace ProfileDetection
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_instrument = new System.Windows.Forms.Button();
            this.btn_record = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_setting_file = new System.Windows.Forms.Button();
            this.panel_log = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_setting = new System.Windows.Forms.Panel();
            this.panel_setting_wire1 = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.panel_setting_wire2 = new System.Windows.Forms.Panel();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tBoxSealRatio1 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tBoxStripLimit1 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tBoxSealLimit1 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tBoxVariationFilter1 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.gBoxModel1 = new System.Windows.Forms.GroupBox();
            this.ckBoxSealOri1 = new System.Windows.Forms.CheckBox();
            this.tBoxSprayP1 = new System.Windows.Forms.TextBox();
            this.tBoxStripLenP1 = new System.Windows.Forms.TextBox();
            this.tBoxStripLenN1 = new System.Windows.Forms.TextBox();
            this.tBoxSealWidthP1 = new System.Windows.Forms.TextBox();
            this.tBoxSealWidthN1 = new System.Windows.Forms.TextBox();
            this.tBoxCoreWidthP1 = new System.Windows.Forms.TextBox();
            this.tBoxCoreWidthN1 = new System.Windows.Forms.TextBox();
            this.tBoxStripPosP1 = new System.Windows.Forms.TextBox();
            this.tBoxStripPosN1 = new System.Windows.Forms.TextBox();
            this.tBoxSealPosP1 = new System.Windows.Forms.TextBox();
            this.tBoxSealPosN1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tBoxCorePosP1 = new System.Windows.Forms.TextBox();
            this.tBoxCorePosN1 = new System.Windows.Forms.TextBox();
            this.ckBoxSeal1 = new System.Windows.Forms.CheckBox();
            this.ckBoxSplay1 = new System.Windows.Forms.CheckBox();
            this.ckBoxStripLen1 = new System.Windows.Forms.CheckBox();
            this.ckBoxSealWidth1 = new System.Windows.Forms.CheckBox();
            this.ckBoxCoreWidth1 = new System.Windows.Forms.CheckBox();
            this.ckBoxStripPos1 = new System.Windows.Forms.CheckBox();
            this.ckBoxSealPos1 = new System.Windows.Forms.CheckBox();
            this.ckBoxCorePos1 = new System.Windows.Forms.CheckBox();
            this.panel_setting_input = new System.Windows.Forms.Panel();
            this.grb_settings_input4 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.grb_settings_input3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.grb_settings_input2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.tBoxMinSetupDuration = new System.Windows.Forms.TextBox();
            this.tBoxFiringTimeOut = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.grb_settings_input1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cBoxInputPolLvl1 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cBoxInputModeLvl1 = new System.Windows.Forms.ComboBox();
            this.panel_setting_output = new System.Windows.Forms.Panel();
            this.checkBoxOutIgnoreWhileOutActive = new System.Windows.Forms.CheckBox();
            this.group_output2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.group_output1 = new System.Windows.Forms.GroupBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rBtnIgnoreLearn1 = new System.Windows.Forms.RadioButton();
            this.rBtnIgnoreFirst1 = new System.Windows.Forms.RadioButton();
            this.rBtnNormal1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnNC1 = new System.Windows.Forms.RadioButton();
            this.rBtnNO1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tBoxDuration1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxOutDelay1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.btn_setting_wire2 = new System.Windows.Forms.Button();
            this.btn_setting_wire1 = new System.Windows.Forms.Button();
            this.btn_setting_output = new System.Windows.Forms.Button();
            this.btn_setting_input = new System.Windows.Forms.Button();
            this.btn_setting_general = new System.Windows.Forms.Button();
            this.panel_setting_contaner = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Sen = new System.Windows.Forms.Button();
            this.pBoxSen = new System.Windows.Forms.PictureBox();
            this.panel_file = new System.Windows.Forms.Panel();
            this.panel_file_contaner = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSingle = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCom = new System.Windows.Forms.Button();
            this.comboxCom = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label38 = new System.Windows.Forms.Label();
            this.btUpdateCfg = new System.Windows.Forms.Button();
            this.btUploadCfg = new System.Windows.Forms.Button();
            this.panel_log.SuspendLayout();
            this.panel_setting.SuspendLayout();
            this.panel_setting_wire1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.panel_setting_wire2.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.gBoxModel1.SuspendLayout();
            this.panel_setting_input.SuspendLayout();
            this.grb_settings_input4.SuspendLayout();
            this.grb_settings_input3.SuspendLayout();
            this.grb_settings_input2.SuspendLayout();
            this.grb_settings_input1.SuspendLayout();
            this.panel_setting_output.SuspendLayout();
            this.group_output2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.group_output1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel_setting_contaner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSen)).BeginInit();
            this.panel_file.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingle)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_instrument
            // 
            this.btn_instrument.BackgroundImage = global::ProfileDetection.Properties.Resources.设备激活;
            this.btn_instrument.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.btn_instrument.FlatAppearance.BorderSize = 0;
            this.btn_instrument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_instrument.Location = new System.Drawing.Point(31, 27);
            this.btn_instrument.Name = "btn_instrument";
            this.btn_instrument.Size = new System.Drawing.Size(118, 36);
            this.btn_instrument.TabIndex = 0;
            this.btn_instrument.UseVisualStyleBackColor = true;
            this.btn_instrument.Click += new System.EventHandler(this.btn_instrument_Click);
            // 
            // btn_record
            // 
            this.btn_record.BackgroundImage = global::ProfileDetection.Properties.Resources.记录;
            this.btn_record.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.btn_record.FlatAppearance.BorderSize = 0;
            this.btn_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_record.Location = new System.Drawing.Point(166, 27);
            this.btn_record.Name = "btn_record";
            this.btn_record.Size = new System.Drawing.Size(118, 36);
            this.btn_record.TabIndex = 1;
            this.btn_record.UseVisualStyleBackColor = true;
            // 
            // btn_setting
            // 
            this.btn_setting.BackgroundImage = global::ProfileDetection.Properties.Resources.设置;
            this.btn_setting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.btn_setting.FlatAppearance.BorderSize = 0;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Location = new System.Drawing.Point(307, 27);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(118, 36);
            this.btn_setting.TabIndex = 2;
            this.btn_setting.UseVisualStyleBackColor = true;
            // 
            // btn_setting_file
            // 
            this.btn_setting_file.BackgroundImage = global::ProfileDetection.Properties.Resources.文件;
            this.btn_setting_file.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.btn_setting_file.FlatAppearance.BorderSize = 0;
            this.btn_setting_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting_file.Location = new System.Drawing.Point(444, 27);
            this.btn_setting_file.Name = "btn_setting_file";
            this.btn_setting_file.Size = new System.Drawing.Size(118, 36);
            this.btn_setting_file.TabIndex = 3;
            this.btn_setting_file.UseVisualStyleBackColor = true;
            // 
            // panel_log
            // 
            this.panel_log.BackgroundImage = global::ProfileDetection.Properties.Resources.中部背景;
            this.panel_log.Controls.Add(this.label1);
            this.panel_log.Location = new System.Drawing.Point(0, 66);
            this.panel_log.Margin = new System.Windows.Forms.Padding(0);
            this.panel_log.Name = "panel_log";
            this.panel_log.Size = new System.Drawing.Size(920, 507);
            this.panel_log.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 200);
            this.label1.TabIndex = 2;
            this.label1.Text = "tag：";
            // 
            // panel_setting
            // 
            this.panel_setting.BackgroundImage = global::ProfileDetection.Properties.Resources.中部背景;
            this.panel_setting.Controls.Add(this.btUpdateCfg);
            this.panel_setting.Controls.Add(this.btUploadCfg);
            this.panel_setting.Controls.Add(this.panel_setting_wire1);
            this.panel_setting.Controls.Add(this.panel_setting_wire2);
            this.panel_setting.Controls.Add(this.panel_setting_input);
            this.panel_setting.Controls.Add(this.panel_setting_output);
            this.panel_setting.Controls.Add(this.btn_setting_wire2);
            this.panel_setting.Controls.Add(this.btn_setting_wire1);
            this.panel_setting.Controls.Add(this.btn_setting_output);
            this.panel_setting.Controls.Add(this.btn_setting_input);
            this.panel_setting.Controls.Add(this.btn_setting_general);
            this.panel_setting.Controls.Add(this.panel_setting_contaner);
            this.panel_setting.Location = new System.Drawing.Point(0, 66);
            this.panel_setting.Name = "panel_setting";
            this.panel_setting.Size = new System.Drawing.Size(920, 507);
            this.panel_setting.TabIndex = 1;
            // 
            // panel_setting_wire1
            // 
            this.panel_setting_wire1.BackgroundImage = global::ProfileDetection.Properties.Resources.panel_bg_setings;
            this.panel_setting_wire1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_setting_wire1.Controls.Add(this.groupBox11);
            this.panel_setting_wire1.Controls.Add(this.groupBox13);
            this.panel_setting_wire1.Location = new System.Drawing.Point(35, 167);
            this.panel_setting_wire1.Name = "panel_setting_wire1";
            this.panel_setting_wire1.Size = new System.Drawing.Size(857, 322);
            this.panel_setting_wire1.TabIndex = 45;
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.Transparent;
            this.groupBox11.Controls.Add(this.textBox4);
            this.groupBox11.Controls.Add(this.label26);
            this.groupBox11.Controls.Add(this.textBox5);
            this.groupBox11.Controls.Add(this.label27);
            this.groupBox11.Controls.Add(this.textBox6);
            this.groupBox11.Controls.Add(this.label28);
            this.groupBox11.Controls.Add(this.textBox7);
            this.groupBox11.Controls.Add(this.label29);
            this.groupBox11.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox11.Location = new System.Drawing.Point(548, 40);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox11.Size = new System.Drawing.Size(217, 254);
            this.groupBox11.TabIndex = 18;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "高级设置";
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.Color.Maroon;
            this.textBox4.Location = new System.Drawing.Point(150, 115);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 21);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "85";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(31, 118);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(113, 12);
            this.label26.TabIndex = 6;
            this.label26.Text = "防水栓方向判别系数";
            this.label26.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.Color.Maroon;
            this.textBox5.Location = new System.Drawing.Point(150, 88);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(56, 21);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "50";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(43, 91);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(101, 12);
            this.label27.TabIndex = 4;
            this.label27.Text = "剥切位置识别系数";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox6
            // 
            this.textBox6.ForeColor = System.Drawing.Color.Maroon;
            this.textBox6.Location = new System.Drawing.Point(150, 54);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(56, 21);
            this.textBox6.TabIndex = 3;
            this.textBox6.Text = "100";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(33, 57);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(113, 12);
            this.label28.TabIndex = 2;
            this.label28.Text = "防水栓位置识别系数";
            this.label28.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox7
            // 
            this.textBox7.ForeColor = System.Drawing.Color.Maroon;
            this.textBox7.Location = new System.Drawing.Point(150, 27);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(56, 21);
            this.textBox7.TabIndex = 1;
            this.textBox7.Text = "1.250mm";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(93, 30);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(53, 12);
            this.label29.TabIndex = 0;
            this.label29.Text = "分析步长";
            this.label29.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox13
            // 
            this.groupBox13.BackColor = System.Drawing.Color.Transparent;
            this.groupBox13.Controls.Add(this.checkBox2);
            this.groupBox13.Controls.Add(this.textBox8);
            this.groupBox13.Controls.Add(this.textBox9);
            this.groupBox13.Controls.Add(this.textBox10);
            this.groupBox13.Controls.Add(this.textBox11);
            this.groupBox13.Controls.Add(this.textBox12);
            this.groupBox13.Controls.Add(this.textBox13);
            this.groupBox13.Controls.Add(this.textBox14);
            this.groupBox13.Controls.Add(this.textBox15);
            this.groupBox13.Controls.Add(this.textBox16);
            this.groupBox13.Controls.Add(this.textBox17);
            this.groupBox13.Controls.Add(this.textBox18);
            this.groupBox13.Controls.Add(this.label36);
            this.groupBox13.Controls.Add(this.label37);
            this.groupBox13.Controls.Add(this.textBox19);
            this.groupBox13.Controls.Add(this.textBox20);
            this.groupBox13.Controls.Add(this.checkBox3);
            this.groupBox13.Controls.Add(this.checkBox4);
            this.groupBox13.Controls.Add(this.checkBox5);
            this.groupBox13.Controls.Add(this.checkBox6);
            this.groupBox13.Controls.Add(this.checkBox7);
            this.groupBox13.Controls.Add(this.checkBox8);
            this.groupBox13.Controls.Add(this.checkBox9);
            this.groupBox13.Controls.Add(this.checkBox10);
            this.groupBox13.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox13.Location = new System.Drawing.Point(82, 40);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(388, 254);
            this.groupBox13.TabIndex = 15;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "线型1检测参数";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(69, 232);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 16);
            this.checkBox2.TabIndex = 47;
            this.checkBox2.Text = "防水栓方向";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.ForeColor = System.Drawing.Color.Maroon;
            this.textBox8.Location = new System.Drawing.Point(288, 189);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(61, 21);
            this.textBox8.TabIndex = 46;
            this.textBox8.Text = "50%";
            // 
            // textBox9
            // 
            this.textBox9.ForeColor = System.Drawing.Color.Maroon;
            this.textBox9.Location = new System.Drawing.Point(288, 162);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(61, 21);
            this.textBox9.TabIndex = 45;
            this.textBox9.Text = "2.000mm";
            // 
            // textBox10
            // 
            this.textBox10.ForeColor = System.Drawing.Color.Maroon;
            this.textBox10.Location = new System.Drawing.Point(203, 162);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(61, 21);
            this.textBox10.TabIndex = 44;
            this.textBox10.Text = "2.000mm";
            // 
            // textBox11
            // 
            this.textBox11.ForeColor = System.Drawing.Color.Maroon;
            this.textBox11.Location = new System.Drawing.Point(288, 135);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(61, 21);
            this.textBox11.TabIndex = 43;
            this.textBox11.Text = "10%";
            // 
            // textBox12
            // 
            this.textBox12.ForeColor = System.Drawing.Color.Maroon;
            this.textBox12.Location = new System.Drawing.Point(203, 135);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(61, 21);
            this.textBox12.TabIndex = 42;
            this.textBox12.Text = "10%";
            // 
            // textBox13
            // 
            this.textBox13.ForeColor = System.Drawing.Color.Maroon;
            this.textBox13.Location = new System.Drawing.Point(288, 108);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(61, 21);
            this.textBox13.TabIndex = 41;
            this.textBox13.Text = "10%";
            // 
            // textBox14
            // 
            this.textBox14.ForeColor = System.Drawing.Color.Maroon;
            this.textBox14.Location = new System.Drawing.Point(203, 108);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(61, 21);
            this.textBox14.TabIndex = 40;
            this.textBox14.Text = "10%";
            // 
            // textBox15
            // 
            this.textBox15.ForeColor = System.Drawing.Color.Maroon;
            this.textBox15.Location = new System.Drawing.Point(288, 81);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(61, 21);
            this.textBox15.TabIndex = 39;
            this.textBox15.Text = "2.000mm";
            // 
            // textBox16
            // 
            this.textBox16.ForeColor = System.Drawing.Color.Maroon;
            this.textBox16.Location = new System.Drawing.Point(203, 81);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(61, 21);
            this.textBox16.TabIndex = 38;
            this.textBox16.Text = "2.000mm";
            // 
            // textBox17
            // 
            this.textBox17.ForeColor = System.Drawing.Color.Maroon;
            this.textBox17.Location = new System.Drawing.Point(288, 56);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(61, 21);
            this.textBox17.TabIndex = 37;
            this.textBox17.Text = "2.000mm";
            // 
            // textBox18
            // 
            this.textBox18.ForeColor = System.Drawing.Color.Maroon;
            this.textBox18.Location = new System.Drawing.Point(203, 56);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(61, 21);
            this.textBox18.TabIndex = 36;
            this.textBox18.Text = "2.000mm";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(298, 14);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(41, 12);
            this.label36.TabIndex = 35;
            this.label36.Text = "正偏差";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(216, 14);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(41, 12);
            this.label37.TabIndex = 34;
            this.label37.Text = "负偏差";
            // 
            // textBox19
            // 
            this.textBox19.ForeColor = System.Drawing.Color.Maroon;
            this.textBox19.Location = new System.Drawing.Point(288, 29);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(61, 21);
            this.textBox19.TabIndex = 33;
            this.textBox19.Text = "2.000mm";
            // 
            // textBox20
            // 
            this.textBox20.ForeColor = System.Drawing.Color.Maroon;
            this.textBox20.Location = new System.Drawing.Point(203, 29);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(61, 21);
            this.textBox20.TabIndex = 32;
            this.textBox20.Text = "2.000mm";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(69, 211);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(84, 16);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "有无防水栓";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(69, 189);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(96, 16);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "线芯分叉宽度";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(69, 162);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(72, 16);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "剥切长度";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(69, 135);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(84, 16);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "防水栓直径";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(69, 108);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(72, 16);
            this.checkBox7.TabIndex = 3;
            this.checkBox7.Text = "线芯直径";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(69, 81);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(72, 16);
            this.checkBox8.TabIndex = 2;
            this.checkBox8.Text = "剥切位置";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(69, 56);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(84, 16);
            this.checkBox9.TabIndex = 1;
            this.checkBox9.Text = "防水栓位置";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.Location = new System.Drawing.Point(69, 29);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(72, 16);
            this.checkBox10.TabIndex = 0;
            this.checkBox10.Text = "线端位置";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // panel_setting_wire2
            // 
            this.panel_setting_wire2.BackgroundImage = global::ProfileDetection.Properties.Resources.panel_bg_setings;
            this.panel_setting_wire2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_setting_wire2.Controls.Add(this.groupBox12);
            this.panel_setting_wire2.Controls.Add(this.gBoxModel1);
            this.panel_setting_wire2.Location = new System.Drawing.Point(35, 167);
            this.panel_setting_wire2.Name = "panel_setting_wire2";
            this.panel_setting_wire2.Size = new System.Drawing.Size(857, 322);
            this.panel_setting_wire2.TabIndex = 44;
            // 
            // groupBox12
            // 
            this.groupBox12.BackColor = System.Drawing.Color.Transparent;
            this.groupBox12.Controls.Add(this.tBoxSealRatio1);
            this.groupBox12.Controls.Add(this.label30);
            this.groupBox12.Controls.Add(this.tBoxStripLimit1);
            this.groupBox12.Controls.Add(this.label31);
            this.groupBox12.Controls.Add(this.tBoxSealLimit1);
            this.groupBox12.Controls.Add(this.label32);
            this.groupBox12.Controls.Add(this.tBoxVariationFilter1);
            this.groupBox12.Controls.Add(this.label33);
            this.groupBox12.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox12.Location = new System.Drawing.Point(548, 40);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox12.Size = new System.Drawing.Size(217, 254);
            this.groupBox12.TabIndex = 18;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "高级设置";
            // 
            // tBoxSealRatio1
            // 
            this.tBoxSealRatio1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxSealRatio1.Location = new System.Drawing.Point(150, 115);
            this.tBoxSealRatio1.Name = "tBoxSealRatio1";
            this.tBoxSealRatio1.Size = new System.Drawing.Size(56, 21);
            this.tBoxSealRatio1.TabIndex = 7;
            this.tBoxSealRatio1.Text = "85";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(31, 118);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(113, 12);
            this.label30.TabIndex = 6;
            this.label30.Text = "防水栓方向判别系数";
            this.label30.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tBoxStripLimit1
            // 
            this.tBoxStripLimit1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxStripLimit1.Location = new System.Drawing.Point(150, 88);
            this.tBoxStripLimit1.Name = "tBoxStripLimit1";
            this.tBoxStripLimit1.Size = new System.Drawing.Size(56, 21);
            this.tBoxStripLimit1.TabIndex = 5;
            this.tBoxStripLimit1.Text = "50";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(43, 91);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(101, 12);
            this.label31.TabIndex = 4;
            this.label31.Text = "剥切位置识别系数";
            this.label31.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tBoxSealLimit1
            // 
            this.tBoxSealLimit1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxSealLimit1.Location = new System.Drawing.Point(150, 54);
            this.tBoxSealLimit1.Name = "tBoxSealLimit1";
            this.tBoxSealLimit1.Size = new System.Drawing.Size(56, 21);
            this.tBoxSealLimit1.TabIndex = 3;
            this.tBoxSealLimit1.Text = "100";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(33, 57);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(113, 12);
            this.label32.TabIndex = 2;
            this.label32.Text = "防水栓位置识别系数";
            this.label32.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tBoxVariationFilter1
            // 
            this.tBoxVariationFilter1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxVariationFilter1.Location = new System.Drawing.Point(150, 27);
            this.tBoxVariationFilter1.Name = "tBoxVariationFilter1";
            this.tBoxVariationFilter1.Size = new System.Drawing.Size(56, 21);
            this.tBoxVariationFilter1.TabIndex = 1;
            this.tBoxVariationFilter1.Text = "1.250mm";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(93, 30);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(53, 12);
            this.label33.TabIndex = 0;
            this.label33.Text = "分析步长";
            this.label33.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gBoxModel1
            // 
            this.gBoxModel1.BackColor = System.Drawing.Color.Transparent;
            this.gBoxModel1.Controls.Add(this.ckBoxSealOri1);
            this.gBoxModel1.Controls.Add(this.tBoxSprayP1);
            this.gBoxModel1.Controls.Add(this.tBoxStripLenP1);
            this.gBoxModel1.Controls.Add(this.tBoxStripLenN1);
            this.gBoxModel1.Controls.Add(this.tBoxSealWidthP1);
            this.gBoxModel1.Controls.Add(this.tBoxSealWidthN1);
            this.gBoxModel1.Controls.Add(this.tBoxCoreWidthP1);
            this.gBoxModel1.Controls.Add(this.tBoxCoreWidthN1);
            this.gBoxModel1.Controls.Add(this.tBoxStripPosP1);
            this.gBoxModel1.Controls.Add(this.tBoxStripPosN1);
            this.gBoxModel1.Controls.Add(this.tBoxSealPosP1);
            this.gBoxModel1.Controls.Add(this.tBoxSealPosN1);
            this.gBoxModel1.Controls.Add(this.label24);
            this.gBoxModel1.Controls.Add(this.label25);
            this.gBoxModel1.Controls.Add(this.tBoxCorePosP1);
            this.gBoxModel1.Controls.Add(this.tBoxCorePosN1);
            this.gBoxModel1.Controls.Add(this.ckBoxSeal1);
            this.gBoxModel1.Controls.Add(this.ckBoxSplay1);
            this.gBoxModel1.Controls.Add(this.ckBoxStripLen1);
            this.gBoxModel1.Controls.Add(this.ckBoxSealWidth1);
            this.gBoxModel1.Controls.Add(this.ckBoxCoreWidth1);
            this.gBoxModel1.Controls.Add(this.ckBoxStripPos1);
            this.gBoxModel1.Controls.Add(this.ckBoxSealPos1);
            this.gBoxModel1.Controls.Add(this.ckBoxCorePos1);
            this.gBoxModel1.ForeColor = System.Drawing.Color.Maroon;
            this.gBoxModel1.Location = new System.Drawing.Point(82, 40);
            this.gBoxModel1.Name = "gBoxModel1";
            this.gBoxModel1.Size = new System.Drawing.Size(388, 254);
            this.gBoxModel1.TabIndex = 15;
            this.gBoxModel1.TabStop = false;
            this.gBoxModel1.Text = "线型2检测参数";
            // 
            // ckBoxSealOri1
            // 
            this.ckBoxSealOri1.AutoSize = true;
            this.ckBoxSealOri1.Checked = true;
            this.ckBoxSealOri1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxSealOri1.Location = new System.Drawing.Point(69, 232);
            this.ckBoxSealOri1.Name = "ckBoxSealOri1";
            this.ckBoxSealOri1.Size = new System.Drawing.Size(84, 16);
            this.ckBoxSealOri1.TabIndex = 47;
            this.ckBoxSealOri1.Text = "防水栓方向";
            this.ckBoxSealOri1.UseVisualStyleBackColor = true;
            // 
            // tBoxSprayP1
            // 
            this.tBoxSprayP1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxSprayP1.Location = new System.Drawing.Point(288, 189);
            this.tBoxSprayP1.Name = "tBoxSprayP1";
            this.tBoxSprayP1.Size = new System.Drawing.Size(61, 21);
            this.tBoxSprayP1.TabIndex = 46;
            this.tBoxSprayP1.Text = "50%";
            // 
            // tBoxStripLenP1
            // 
            this.tBoxStripLenP1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxStripLenP1.Location = new System.Drawing.Point(288, 162);
            this.tBoxStripLenP1.Name = "tBoxStripLenP1";
            this.tBoxStripLenP1.Size = new System.Drawing.Size(61, 21);
            this.tBoxStripLenP1.TabIndex = 45;
            this.tBoxStripLenP1.Text = "2.000mm";
            // 
            // tBoxStripLenN1
            // 
            this.tBoxStripLenN1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxStripLenN1.Location = new System.Drawing.Point(203, 162);
            this.tBoxStripLenN1.Name = "tBoxStripLenN1";
            this.tBoxStripLenN1.Size = new System.Drawing.Size(61, 21);
            this.tBoxStripLenN1.TabIndex = 44;
            this.tBoxStripLenN1.Text = "2.000mm";
            // 
            // tBoxSealWidthP1
            // 
            this.tBoxSealWidthP1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxSealWidthP1.Location = new System.Drawing.Point(288, 135);
            this.tBoxSealWidthP1.Name = "tBoxSealWidthP1";
            this.tBoxSealWidthP1.Size = new System.Drawing.Size(61, 21);
            this.tBoxSealWidthP1.TabIndex = 43;
            this.tBoxSealWidthP1.Text = "10%";
            // 
            // tBoxSealWidthN1
            // 
            this.tBoxSealWidthN1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxSealWidthN1.Location = new System.Drawing.Point(203, 135);
            this.tBoxSealWidthN1.Name = "tBoxSealWidthN1";
            this.tBoxSealWidthN1.Size = new System.Drawing.Size(61, 21);
            this.tBoxSealWidthN1.TabIndex = 42;
            this.tBoxSealWidthN1.Text = "10%";
            // 
            // tBoxCoreWidthP1
            // 
            this.tBoxCoreWidthP1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxCoreWidthP1.Location = new System.Drawing.Point(288, 108);
            this.tBoxCoreWidthP1.Name = "tBoxCoreWidthP1";
            this.tBoxCoreWidthP1.Size = new System.Drawing.Size(61, 21);
            this.tBoxCoreWidthP1.TabIndex = 41;
            this.tBoxCoreWidthP1.Text = "10%";
            // 
            // tBoxCoreWidthN1
            // 
            this.tBoxCoreWidthN1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxCoreWidthN1.Location = new System.Drawing.Point(203, 108);
            this.tBoxCoreWidthN1.Name = "tBoxCoreWidthN1";
            this.tBoxCoreWidthN1.Size = new System.Drawing.Size(61, 21);
            this.tBoxCoreWidthN1.TabIndex = 40;
            this.tBoxCoreWidthN1.Text = "10%";
            // 
            // tBoxStripPosP1
            // 
            this.tBoxStripPosP1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxStripPosP1.Location = new System.Drawing.Point(288, 81);
            this.tBoxStripPosP1.Name = "tBoxStripPosP1";
            this.tBoxStripPosP1.Size = new System.Drawing.Size(61, 21);
            this.tBoxStripPosP1.TabIndex = 39;
            this.tBoxStripPosP1.Text = "2.000mm";
            // 
            // tBoxStripPosN1
            // 
            this.tBoxStripPosN1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxStripPosN1.Location = new System.Drawing.Point(203, 81);
            this.tBoxStripPosN1.Name = "tBoxStripPosN1";
            this.tBoxStripPosN1.Size = new System.Drawing.Size(61, 21);
            this.tBoxStripPosN1.TabIndex = 38;
            this.tBoxStripPosN1.Text = "2.000mm";
            // 
            // tBoxSealPosP1
            // 
            this.tBoxSealPosP1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxSealPosP1.Location = new System.Drawing.Point(288, 56);
            this.tBoxSealPosP1.Name = "tBoxSealPosP1";
            this.tBoxSealPosP1.Size = new System.Drawing.Size(61, 21);
            this.tBoxSealPosP1.TabIndex = 37;
            this.tBoxSealPosP1.Text = "2.000mm";
            // 
            // tBoxSealPosN1
            // 
            this.tBoxSealPosN1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxSealPosN1.Location = new System.Drawing.Point(203, 56);
            this.tBoxSealPosN1.Name = "tBoxSealPosN1";
            this.tBoxSealPosN1.Size = new System.Drawing.Size(61, 21);
            this.tBoxSealPosN1.TabIndex = 36;
            this.tBoxSealPosN1.Text = "2.000mm";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(298, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 12);
            this.label24.TabIndex = 35;
            this.label24.Text = "正偏差";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(216, 14);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 12);
            this.label25.TabIndex = 34;
            this.label25.Text = "负偏差";
            // 
            // tBoxCorePosP1
            // 
            this.tBoxCorePosP1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxCorePosP1.Location = new System.Drawing.Point(288, 29);
            this.tBoxCorePosP1.Name = "tBoxCorePosP1";
            this.tBoxCorePosP1.Size = new System.Drawing.Size(61, 21);
            this.tBoxCorePosP1.TabIndex = 33;
            this.tBoxCorePosP1.Text = "2.000mm";
            // 
            // tBoxCorePosN1
            // 
            this.tBoxCorePosN1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxCorePosN1.Location = new System.Drawing.Point(203, 29);
            this.tBoxCorePosN1.Name = "tBoxCorePosN1";
            this.tBoxCorePosN1.Size = new System.Drawing.Size(61, 21);
            this.tBoxCorePosN1.TabIndex = 32;
            this.tBoxCorePosN1.Text = "2.000mm";
            // 
            // ckBoxSeal1
            // 
            this.ckBoxSeal1.AutoSize = true;
            this.ckBoxSeal1.Location = new System.Drawing.Point(69, 211);
            this.ckBoxSeal1.Name = "ckBoxSeal1";
            this.ckBoxSeal1.Size = new System.Drawing.Size(84, 16);
            this.ckBoxSeal1.TabIndex = 7;
            this.ckBoxSeal1.Text = "有无防水栓";
            this.ckBoxSeal1.UseVisualStyleBackColor = true;
            // 
            // ckBoxSplay1
            // 
            this.ckBoxSplay1.AutoSize = true;
            this.ckBoxSplay1.Location = new System.Drawing.Point(69, 189);
            this.ckBoxSplay1.Name = "ckBoxSplay1";
            this.ckBoxSplay1.Size = new System.Drawing.Size(96, 16);
            this.ckBoxSplay1.TabIndex = 6;
            this.ckBoxSplay1.Text = "线芯分叉宽度";
            this.ckBoxSplay1.UseVisualStyleBackColor = true;
            // 
            // ckBoxStripLen1
            // 
            this.ckBoxStripLen1.AutoSize = true;
            this.ckBoxStripLen1.Location = new System.Drawing.Point(69, 162);
            this.ckBoxStripLen1.Name = "ckBoxStripLen1";
            this.ckBoxStripLen1.Size = new System.Drawing.Size(72, 16);
            this.ckBoxStripLen1.TabIndex = 5;
            this.ckBoxStripLen1.Text = "剥切长度";
            this.ckBoxStripLen1.UseVisualStyleBackColor = true;
            // 
            // ckBoxSealWidth1
            // 
            this.ckBoxSealWidth1.AutoSize = true;
            this.ckBoxSealWidth1.Location = new System.Drawing.Point(69, 135);
            this.ckBoxSealWidth1.Name = "ckBoxSealWidth1";
            this.ckBoxSealWidth1.Size = new System.Drawing.Size(84, 16);
            this.ckBoxSealWidth1.TabIndex = 4;
            this.ckBoxSealWidth1.Text = "防水栓直径";
            this.ckBoxSealWidth1.UseVisualStyleBackColor = true;
            // 
            // ckBoxCoreWidth1
            // 
            this.ckBoxCoreWidth1.AutoSize = true;
            this.ckBoxCoreWidth1.Location = new System.Drawing.Point(69, 108);
            this.ckBoxCoreWidth1.Name = "ckBoxCoreWidth1";
            this.ckBoxCoreWidth1.Size = new System.Drawing.Size(72, 16);
            this.ckBoxCoreWidth1.TabIndex = 3;
            this.ckBoxCoreWidth1.Text = "线芯直径";
            this.ckBoxCoreWidth1.UseVisualStyleBackColor = true;
            // 
            // ckBoxStripPos1
            // 
            this.ckBoxStripPos1.AutoSize = true;
            this.ckBoxStripPos1.Location = new System.Drawing.Point(69, 81);
            this.ckBoxStripPos1.Name = "ckBoxStripPos1";
            this.ckBoxStripPos1.Size = new System.Drawing.Size(72, 16);
            this.ckBoxStripPos1.TabIndex = 2;
            this.ckBoxStripPos1.Text = "剥切位置";
            this.ckBoxStripPos1.UseVisualStyleBackColor = true;
            // 
            // ckBoxSealPos1
            // 
            this.ckBoxSealPos1.AutoSize = true;
            this.ckBoxSealPos1.Location = new System.Drawing.Point(69, 56);
            this.ckBoxSealPos1.Name = "ckBoxSealPos1";
            this.ckBoxSealPos1.Size = new System.Drawing.Size(84, 16);
            this.ckBoxSealPos1.TabIndex = 1;
            this.ckBoxSealPos1.Text = "防水栓位置";
            this.ckBoxSealPos1.UseVisualStyleBackColor = true;
            // 
            // ckBoxCorePos1
            // 
            this.ckBoxCorePos1.AutoSize = true;
            this.ckBoxCorePos1.Checked = true;
            this.ckBoxCorePos1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxCorePos1.Location = new System.Drawing.Point(69, 29);
            this.ckBoxCorePos1.Name = "ckBoxCorePos1";
            this.ckBoxCorePos1.Size = new System.Drawing.Size(72, 16);
            this.ckBoxCorePos1.TabIndex = 0;
            this.ckBoxCorePos1.Text = "线端位置";
            this.ckBoxCorePos1.UseVisualStyleBackColor = true;
            // 
            // panel_setting_input
            // 
            this.panel_setting_input.BackgroundImage = global::ProfileDetection.Properties.Resources.panel_bg_setings;
            this.panel_setting_input.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_setting_input.Controls.Add(this.grb_settings_input4);
            this.panel_setting_input.Controls.Add(this.grb_settings_input3);
            this.panel_setting_input.Controls.Add(this.grb_settings_input2);
            this.panel_setting_input.Controls.Add(this.tBoxMinSetupDuration);
            this.panel_setting_input.Controls.Add(this.tBoxFiringTimeOut);
            this.panel_setting_input.Controls.Add(this.label35);
            this.panel_setting_input.Controls.Add(this.label34);
            this.panel_setting_input.Controls.Add(this.grb_settings_input1);
            this.panel_setting_input.Location = new System.Drawing.Point(35, 167);
            this.panel_setting_input.Name = "panel_setting_input";
            this.panel_setting_input.Size = new System.Drawing.Size(857, 322);
            this.panel_setting_input.TabIndex = 21;
            // 
            // grb_settings_input4
            // 
            this.grb_settings_input4.BackColor = System.Drawing.Color.Transparent;
            this.grb_settings_input4.Controls.Add(this.label22);
            this.grb_settings_input4.Controls.Add(this.comboBox13);
            this.grb_settings_input4.Controls.Add(this.label23);
            this.grb_settings_input4.Controls.Add(this.comboBox14);
            this.grb_settings_input4.ForeColor = System.Drawing.Color.Maroon;
            this.grb_settings_input4.Location = new System.Drawing.Point(468, 153);
            this.grb_settings_input4.Name = "grb_settings_input4";
            this.grb_settings_input4.Size = new System.Drawing.Size(204, 68);
            this.grb_settings_input4.TabIndex = 37;
            this.grb_settings_input4.TabStop = false;
            this.grb_settings_input4.Text = "输入4";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 46);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 22;
            this.label22.Text = "输入极性";
            // 
            // comboBox13
            // 
            this.comboBox13.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Items.AddRange(new object[] {
            "上升沿触发",
            "下降沿触发"});
            this.comboBox13.Location = new System.Drawing.Point(74, 43);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(121, 20);
            this.comboBox13.TabIndex = 21;
            this.comboBox13.Text = "下降沿触发";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 20;
            this.label23.Text = "输入模式";
            // 
            // comboBox14
            // 
            this.comboBox14.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Items.AddRange(new object[] {
            "禁用",
            "进入学习模式",
            "触发采样",
            "进入设置模式"});
            this.comboBox14.Location = new System.Drawing.Point(74, 17);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(121, 20);
            this.comboBox14.TabIndex = 19;
            this.comboBox14.Text = "禁用";
            // 
            // grb_settings_input3
            // 
            this.grb_settings_input3.BackColor = System.Drawing.Color.Transparent;
            this.grb_settings_input3.Controls.Add(this.label18);
            this.grb_settings_input3.Controls.Add(this.comboBox11);
            this.grb_settings_input3.Controls.Add(this.label19);
            this.grb_settings_input3.Controls.Add(this.comboBox12);
            this.grb_settings_input3.ForeColor = System.Drawing.Color.Maroon;
            this.grb_settings_input3.Location = new System.Drawing.Point(173, 153);
            this.grb_settings_input3.Name = "grb_settings_input3";
            this.grb_settings_input3.Size = new System.Drawing.Size(204, 68);
            this.grb_settings_input3.TabIndex = 37;
            this.grb_settings_input3.TabStop = false;
            this.grb_settings_input3.Text = "输入3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 22;
            this.label18.Text = "输入极性";
            // 
            // comboBox11
            // 
            this.comboBox11.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "上升沿触发",
            "下降沿触发"});
            this.comboBox11.Location = new System.Drawing.Point(74, 43);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(121, 20);
            this.comboBox11.TabIndex = 21;
            this.comboBox11.Text = "下降沿触发";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 20;
            this.label19.Text = "输入模式";
            // 
            // comboBox12
            // 
            this.comboBox12.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "禁用",
            "进入学习模式",
            "触发采样",
            "进入设置模式"});
            this.comboBox12.Location = new System.Drawing.Point(74, 17);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(121, 20);
            this.comboBox12.TabIndex = 19;
            this.comboBox12.Text = "禁用";
            // 
            // grb_settings_input2
            // 
            this.grb_settings_input2.BackColor = System.Drawing.Color.Transparent;
            this.grb_settings_input2.Controls.Add(this.label16);
            this.grb_settings_input2.Controls.Add(this.comboBox9);
            this.grb_settings_input2.Controls.Add(this.label17);
            this.grb_settings_input2.Controls.Add(this.comboBox10);
            this.grb_settings_input2.ForeColor = System.Drawing.Color.Maroon;
            this.grb_settings_input2.Location = new System.Drawing.Point(468, 63);
            this.grb_settings_input2.Name = "grb_settings_input2";
            this.grb_settings_input2.Size = new System.Drawing.Size(204, 68);
            this.grb_settings_input2.TabIndex = 37;
            this.grb_settings_input2.TabStop = false;
            this.grb_settings_input2.Text = "输入2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 22;
            this.label16.Text = "输入极性";
            // 
            // comboBox9
            // 
            this.comboBox9.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "上升沿触发",
            "下降沿触发"});
            this.comboBox9.Location = new System.Drawing.Point(74, 43);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 20);
            this.comboBox9.TabIndex = 21;
            this.comboBox9.Text = "下降沿触发";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 20;
            this.label17.Text = "输入模式";
            // 
            // comboBox10
            // 
            this.comboBox10.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "禁用",
            "进入学习模式",
            "触发采样",
            "进入设置模式"});
            this.comboBox10.Location = new System.Drawing.Point(74, 17);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(121, 20);
            this.comboBox10.TabIndex = 19;
            this.comboBox10.Text = "禁用";
            // 
            // tBoxMinSetupDuration
            // 
            this.tBoxMinSetupDuration.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxMinSetupDuration.Location = new System.Drawing.Point(399, 280);
            this.tBoxMinSetupDuration.Name = "tBoxMinSetupDuration";
            this.tBoxMinSetupDuration.Size = new System.Drawing.Size(100, 21);
            this.tBoxMinSetupDuration.TabIndex = 43;
            this.tBoxMinSetupDuration.Text = "4000";
            // 
            // tBoxFiringTimeOut
            // 
            this.tBoxFiringTimeOut.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxFiringTimeOut.Location = new System.Drawing.Point(399, 244);
            this.tBoxFiringTimeOut.Name = "tBoxFiringTimeOut";
            this.tBoxFiringTimeOut.Size = new System.Drawing.Size(100, 21);
            this.tBoxFiringTimeOut.TabIndex = 41;
            this.tBoxFiringTimeOut.Text = "500";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.ForeColor = System.Drawing.Color.Maroon;
            this.label35.Location = new System.Drawing.Point(238, 283);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(149, 12);
            this.label35.TabIndex = 42;
            this.label35.Text = "按键进入设置模式延时(ms)";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.ForeColor = System.Drawing.Color.Maroon;
            this.label34.Location = new System.Drawing.Point(274, 247);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(113, 12);
            this.label34.TabIndex = 40;
            this.label34.Text = "触发有效期长度(ms)";
            // 
            // grb_settings_input1
            // 
            this.grb_settings_input1.BackColor = System.Drawing.Color.Transparent;
            this.grb_settings_input1.Controls.Add(this.label20);
            this.grb_settings_input1.Controls.Add(this.cBoxInputPolLvl1);
            this.grb_settings_input1.Controls.Add(this.label21);
            this.grb_settings_input1.Controls.Add(this.cBoxInputModeLvl1);
            this.grb_settings_input1.ForeColor = System.Drawing.Color.Maroon;
            this.grb_settings_input1.Location = new System.Drawing.Point(173, 63);
            this.grb_settings_input1.Name = "grb_settings_input1";
            this.grb_settings_input1.Size = new System.Drawing.Size(204, 68);
            this.grb_settings_input1.TabIndex = 36;
            this.grb_settings_input1.TabStop = false;
            this.grb_settings_input1.Text = "输入1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 22;
            this.label20.Text = "输入极性";
            // 
            // cBoxInputPolLvl1
            // 
            this.cBoxInputPolLvl1.ForeColor = System.Drawing.Color.Maroon;
            this.cBoxInputPolLvl1.FormattingEnabled = true;
            this.cBoxInputPolLvl1.Items.AddRange(new object[] {
            "上升沿触发",
            "下降沿触发"});
            this.cBoxInputPolLvl1.Location = new System.Drawing.Point(74, 43);
            this.cBoxInputPolLvl1.Name = "cBoxInputPolLvl1";
            this.cBoxInputPolLvl1.Size = new System.Drawing.Size(121, 20);
            this.cBoxInputPolLvl1.TabIndex = 21;
            this.cBoxInputPolLvl1.Text = "下降沿触发";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 12);
            this.label21.TabIndex = 20;
            this.label21.Text = "输入模式";
            // 
            // cBoxInputModeLvl1
            // 
            this.cBoxInputModeLvl1.ForeColor = System.Drawing.Color.Maroon;
            this.cBoxInputModeLvl1.FormattingEnabled = true;
            this.cBoxInputModeLvl1.Items.AddRange(new object[] {
            "禁用",
            "进入学习模式",
            "触发采样",
            "进入设置模式"});
            this.cBoxInputModeLvl1.Location = new System.Drawing.Point(74, 17);
            this.cBoxInputModeLvl1.Name = "cBoxInputModeLvl1";
            this.cBoxInputModeLvl1.Size = new System.Drawing.Size(121, 20);
            this.cBoxInputModeLvl1.TabIndex = 19;
            this.cBoxInputModeLvl1.Text = "禁用";
            // 
            // panel_setting_output
            // 
            this.panel_setting_output.BackgroundImage = global::ProfileDetection.Properties.Resources.panel_bg_setings;
            this.panel_setting_output.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_setting_output.Controls.Add(this.label38);
            this.panel_setting_output.Controls.Add(this.checkBoxOutIgnoreWhileOutActive);
            this.panel_setting_output.Controls.Add(this.group_output2);
            this.panel_setting_output.Controls.Add(this.group_output1);
            this.panel_setting_output.Location = new System.Drawing.Point(35, 167);
            this.panel_setting_output.Name = "panel_setting_output";
            this.panel_setting_output.Size = new System.Drawing.Size(857, 322);
            this.panel_setting_output.TabIndex = 12;
            // 
            // checkBoxOutIgnoreWhileOutActive
            // 
            this.checkBoxOutIgnoreWhileOutActive.AutoSize = true;
            this.checkBoxOutIgnoreWhileOutActive.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxOutIgnoreWhileOutActive.ForeColor = System.Drawing.Color.Maroon;
            this.checkBoxOutIgnoreWhileOutActive.Location = new System.Drawing.Point(489, 38);
            this.checkBoxOutIgnoreWhileOutActive.Name = "checkBoxOutIgnoreWhileOutActive";
            this.checkBoxOutIgnoreWhileOutActive.Size = new System.Drawing.Size(240, 16);
            this.checkBoxOutIgnoreWhileOutActive.TabIndex = 20;
            this.checkBoxOutIgnoreWhileOutActive.Text = "输出有效期间忽略输入（忽略返程阶段）";
            this.checkBoxOutIgnoreWhileOutActive.UseVisualStyleBackColor = false;
            // 
            // group_output2
            // 
            this.group_output2.BackColor = System.Drawing.Color.Transparent;
            this.group_output2.Controls.Add(this.groupBox5);
            this.group_output2.Controls.Add(this.comboBox3);
            this.group_output2.Controls.Add(this.groupBox6);
            this.group_output2.Controls.Add(this.label11);
            this.group_output2.Controls.Add(this.groupBox7);
            this.group_output2.Controls.Add(this.label14);
            this.group_output2.Controls.Add(this.comboBox4);
            this.group_output2.Controls.Add(this.comboBox5);
            this.group_output2.Controls.Add(this.label15);
            this.group_output2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group_output2.ForeColor = System.Drawing.Color.Maroon;
            this.group_output2.Location = new System.Drawing.Point(446, 77);
            this.group_output2.Name = "group_output2";
            this.group_output2.Size = new System.Drawing.Size(371, 217);
            this.group_output2.TabIndex = 19;
            this.group_output2.TabStop = false;
            this.group_output2.Text = "输出2";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox5.Location = new System.Drawing.Point(6, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(169, 83);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "输出选项";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 59);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 16);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "忽略所有学习";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 16);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "忽略学习第一条";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 16);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "始终有效";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "延时自动复位"});
            this.comboBox3.Location = new System.Drawing.Point(262, 143);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 20);
            this.comboBox3.TabIndex = 17;
            this.comboBox3.Text = "延时自动复位";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.radioButton4);
            this.groupBox6.Controls.Add(this.radioButton5);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox6.Location = new System.Drawing.Point(181, 30);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(181, 56);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "输出状态";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 31);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 16);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "常闭";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(16, 14);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(47, 16);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "常开";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(179, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "输出复位模式";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox7.Location = new System.Drawing.Point(6, 113);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(169, 91);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "复位时间";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2.Location = new System.Drawing.Point(89, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(62, 21);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "100";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "持续时间(ms)";
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.Color.Maroon;
            this.textBox3.Location = new System.Drawing.Point(89, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(62, 21);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "延时输出(ms)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(180, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 15;
            this.label14.Text = "线型";
            // 
            // comboBox4
            // 
            this.comboBox4.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "合格品输出脉冲",
            "不良品输出脉冲",
            "合格/不良品都输出脉冲"});
            this.comboBox4.Location = new System.Drawing.Point(239, 98);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(123, 20);
            this.comboBox4.TabIndex = 12;
            this.comboBox4.Text = "合格品输出脉冲";
            // 
            // comboBox5
            // 
            this.comboBox5.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox5.Location = new System.Drawing.Point(239, 173);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(123, 20);
            this.comboBox5.TabIndex = 14;
            this.comboBox5.Text = "1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(180, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 13;
            this.label15.Text = "输出模式";
            // 
            // group_output1
            // 
            this.group_output1.BackColor = System.Drawing.Color.Transparent;
            this.group_output1.Controls.Add(this.comboBox6);
            this.group_output1.Controls.Add(this.groupBox3);
            this.group_output1.Controls.Add(this.label8);
            this.group_output1.Controls.Add(this.groupBox2);
            this.group_output1.Controls.Add(this.label9);
            this.group_output1.Controls.Add(this.groupBox4);
            this.group_output1.Controls.Add(this.comboBox7);
            this.group_output1.Controls.Add(this.label10);
            this.group_output1.Controls.Add(this.comboBox8);
            this.group_output1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group_output1.ForeColor = System.Drawing.Color.Maroon;
            this.group_output1.Location = new System.Drawing.Point(37, 77);
            this.group_output1.Name = "group_output1";
            this.group_output1.Size = new System.Drawing.Size(371, 217);
            this.group_output1.TabIndex = 18;
            this.group_output1.TabStop = false;
            this.group_output1.Text = "输出1";
            // 
            // comboBox6
            // 
            this.comboBox6.Enabled = false;
            this.comboBox6.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "延时自动复位"});
            this.comboBox6.Location = new System.Drawing.Point(263, 140);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(100, 20);
            this.comboBox6.TabIndex = 23;
            this.comboBox6.Text = "延时自动复位";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.rBtnIgnoreLearn1);
            this.groupBox3.Controls.Add(this.rBtnIgnoreFirst1);
            this.groupBox3.Controls.Add(this.rBtnNormal1);
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(6, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 83);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输出选项";
            // 
            // rBtnIgnoreLearn1
            // 
            this.rBtnIgnoreLearn1.AutoSize = true;
            this.rBtnIgnoreLearn1.Location = new System.Drawing.Point(16, 59);
            this.rBtnIgnoreLearn1.Name = "rBtnIgnoreLearn1";
            this.rBtnIgnoreLearn1.Size = new System.Drawing.Size(95, 16);
            this.rBtnIgnoreLearn1.TabIndex = 3;
            this.rBtnIgnoreLearn1.Text = "忽略所有学习";
            this.rBtnIgnoreLearn1.UseVisualStyleBackColor = true;
            // 
            // rBtnIgnoreFirst1
            // 
            this.rBtnIgnoreFirst1.AutoSize = true;
            this.rBtnIgnoreFirst1.Location = new System.Drawing.Point(16, 40);
            this.rBtnIgnoreFirst1.Name = "rBtnIgnoreFirst1";
            this.rBtnIgnoreFirst1.Size = new System.Drawing.Size(107, 16);
            this.rBtnIgnoreFirst1.TabIndex = 2;
            this.rBtnIgnoreFirst1.Text = "忽略学习第一条";
            this.rBtnIgnoreFirst1.UseVisualStyleBackColor = true;
            // 
            // rBtnNormal1
            // 
            this.rBtnNormal1.AutoSize = true;
            this.rBtnNormal1.Checked = true;
            this.rBtnNormal1.Location = new System.Drawing.Point(16, 19);
            this.rBtnNormal1.Name = "rBtnNormal1";
            this.rBtnNormal1.Size = new System.Drawing.Size(71, 16);
            this.rBtnNormal1.TabIndex = 1;
            this.rBtnNormal1.TabStop = true;
            this.rBtnNormal1.Text = "始终有效";
            this.rBtnNormal1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(180, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "输出复位模式";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rBtnNC1);
            this.groupBox2.Controls.Add(this.rBtnNO1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(182, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出状态";
            // 
            // rBtnNC1
            // 
            this.rBtnNC1.AutoSize = true;
            this.rBtnNC1.Location = new System.Drawing.Point(16, 31);
            this.rBtnNC1.Name = "rBtnNC1";
            this.rBtnNC1.Size = new System.Drawing.Size(47, 16);
            this.rBtnNC1.TabIndex = 1;
            this.rBtnNC1.Text = "常闭";
            this.rBtnNC1.UseVisualStyleBackColor = true;
            // 
            // rBtnNO1
            // 
            this.rBtnNO1.AutoSize = true;
            this.rBtnNO1.Checked = true;
            this.rBtnNO1.Location = new System.Drawing.Point(16, 14);
            this.rBtnNO1.Name = "rBtnNO1";
            this.rBtnNO1.Size = new System.Drawing.Size(47, 16);
            this.rBtnNO1.TabIndex = 0;
            this.rBtnNO1.TabStop = true;
            this.rBtnNO1.Text = "常开";
            this.rBtnNO1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(181, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "线型";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.tBoxDuration1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tBoxOutDelay1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox4.Location = new System.Drawing.Point(6, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 91);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "复位时间";
            // 
            // tBoxDuration1
            // 
            this.tBoxDuration1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxDuration1.Location = new System.Drawing.Point(89, 53);
            this.tBoxDuration1.Name = "tBoxDuration1";
            this.tBoxDuration1.Size = new System.Drawing.Size(62, 21);
            this.tBoxDuration1.TabIndex = 13;
            this.tBoxDuration1.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "持续时间(ms)";
            // 
            // tBoxOutDelay1
            // 
            this.tBoxOutDelay1.ForeColor = System.Drawing.Color.Maroon;
            this.tBoxOutDelay1.Location = new System.Drawing.Point(89, 24);
            this.tBoxOutDelay1.Name = "tBoxOutDelay1";
            this.tBoxOutDelay1.Size = new System.Drawing.Size(62, 21);
            this.tBoxOutDelay1.TabIndex = 11;
            this.tBoxOutDelay1.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "延时输出(ms)";
            // 
            // comboBox7
            // 
            this.comboBox7.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "合格品输出脉冲",
            "不良品输出脉冲",
            "合格/不良品都输出脉冲"});
            this.comboBox7.Location = new System.Drawing.Point(240, 99);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(123, 20);
            this.comboBox7.TabIndex = 18;
            this.comboBox7.Text = "合格品输出脉冲";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(181, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "输出模式";
            // 
            // comboBox8
            // 
            this.comboBox8.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox8.Location = new System.Drawing.Point(240, 174);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(123, 20);
            this.comboBox8.TabIndex = 20;
            this.comboBox8.Text = "1";
            // 
            // btn_setting_wire2
            // 
            this.btn_setting_wire2.BackgroundImage = global::ProfileDetection.Properties.Resources.线型参数未激活1;
            this.btn_setting_wire2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.btn_setting_wire2.FlatAppearance.BorderSize = 0;
            this.btn_setting_wire2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting_wire2.Location = new System.Drawing.Point(728, 91);
            this.btn_setting_wire2.Name = "btn_setting_wire2";
            this.btn_setting_wire2.Size = new System.Drawing.Size(50, 50);
            this.btn_setting_wire2.TabIndex = 5;
            this.btn_setting_wire2.UseVisualStyleBackColor = true;
            // 
            // btn_setting_wire1
            // 
            this.btn_setting_wire1.BackgroundImage = global::ProfileDetection.Properties.Resources.线型参数未激活1;
            this.btn_setting_wire1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.btn_setting_wire1.FlatAppearance.BorderSize = 0;
            this.btn_setting_wire1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting_wire1.Location = new System.Drawing.Point(650, 91);
            this.btn_setting_wire1.Name = "btn_setting_wire1";
            this.btn_setting_wire1.Size = new System.Drawing.Size(50, 50);
            this.btn_setting_wire1.TabIndex = 4;
            this.btn_setting_wire1.UseVisualStyleBackColor = true;
            // 
            // btn_setting_output
            // 
            this.btn_setting_output.BackgroundImage = global::ProfileDetection.Properties.Resources.输出未激活;
            this.btn_setting_output.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.btn_setting_output.FlatAppearance.BorderSize = 0;
            this.btn_setting_output.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting_output.Location = new System.Drawing.Point(498, 91);
            this.btn_setting_output.Name = "btn_setting_output";
            this.btn_setting_output.Size = new System.Drawing.Size(50, 50);
            this.btn_setting_output.TabIndex = 3;
            this.btn_setting_output.UseVisualStyleBackColor = true;
            // 
            // btn_setting_input
            // 
            this.btn_setting_input.BackgroundImage = global::ProfileDetection.Properties.Resources.输入未激活;
            this.btn_setting_input.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.btn_setting_input.FlatAppearance.BorderSize = 0;
            this.btn_setting_input.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting_input.Location = new System.Drawing.Point(566, 91);
            this.btn_setting_input.Name = "btn_setting_input";
            this.btn_setting_input.Size = new System.Drawing.Size(50, 50);
            this.btn_setting_input.TabIndex = 2;
            this.btn_setting_input.UseVisualStyleBackColor = true;
            // 
            // btn_setting_general
            // 
            this.btn_setting_general.BackgroundImage = global::ProfileDetection.Properties.Resources.通用激活;
            this.btn_setting_general.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.btn_setting_general.FlatAppearance.BorderSize = 0;
            this.btn_setting_general.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting_general.Location = new System.Drawing.Point(416, 91);
            this.btn_setting_general.Name = "btn_setting_general";
            this.btn_setting_general.Size = new System.Drawing.Size(50, 50);
            this.btn_setting_general.TabIndex = 1;
            this.btn_setting_general.UseVisualStyleBackColor = true;
            // 
            // panel_setting_contaner
            // 
            this.panel_setting_contaner.BackgroundImage = global::ProfileDetection.Properties.Resources.panel_bg_setings;
            this.panel_setting_contaner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_setting_contaner.Controls.Add(this.checkBox1);
            this.panel_setting_contaner.Controls.Add(this.comboBox2);
            this.panel_setting_contaner.Controls.Add(this.label5);
            this.panel_setting_contaner.Controls.Add(this.comboBox1);
            this.panel_setting_contaner.Controls.Add(this.label3);
            this.panel_setting_contaner.Controls.Add(this.textBox1);
            this.panel_setting_contaner.Controls.Add(this.label4);
            this.panel_setting_contaner.Controls.Add(this.label2);
            this.panel_setting_contaner.Controls.Add(this.btn_Sen);
            this.panel_setting_contaner.Controls.Add(this.pBoxSen);
            this.panel_setting_contaner.Location = new System.Drawing.Point(35, 167);
            this.panel_setting_contaner.Name = "panel_setting_contaner";
            this.panel_setting_contaner.Size = new System.Drawing.Size(857, 322);
            this.panel_setting_contaner.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.ForeColor = System.Drawing.Color.Maroon;
            this.checkBox1.Location = new System.Drawing.Point(97, 253);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 26);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "使能速度补偿";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(201, 212);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 20);
            this.comboBox2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(44, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "学习数量：";
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(44, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "线型数量：";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(201, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(22, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "传感器灵敏度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(38, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "设置模式";
            // 
            // btn_Sen
            // 
            this.btn_Sen.BackgroundImage = global::ProfileDetection.Properties.Resources.实时校准未激活;
            this.btn_Sen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.btn_Sen.FlatAppearance.BorderSize = 0;
            this.btn_Sen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sen.Location = new System.Drawing.Point(177, 39);
            this.btn_Sen.Name = "btn_Sen";
            this.btn_Sen.Size = new System.Drawing.Size(148, 62);
            this.btn_Sen.TabIndex = 1;
            this.btn_Sen.UseVisualStyleBackColor = true;
            this.btn_Sen.Click += new System.EventHandler(this.btn_Sen_Click);
            // 
            // pBoxSen
            // 
            this.pBoxSen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pBoxSen.Location = new System.Drawing.Point(388, 35);
            this.pBoxSen.Name = "pBoxSen";
            this.pBoxSen.Size = new System.Drawing.Size(384, 256);
            this.pBoxSen.TabIndex = 0;
            this.pBoxSen.TabStop = false;
            // 
            // panel_file
            // 
            this.panel_file.BackgroundImage = global::ProfileDetection.Properties.Resources.中部背景;
            this.panel_file.Controls.Add(this.panel_file_contaner);
            this.panel_file.Location = new System.Drawing.Point(0, 66);
            this.panel_file.Name = "panel_file";
            this.panel_file.Size = new System.Drawing.Size(920, 507);
            this.panel_file.TabIndex = 6;
            // 
            // panel_file_contaner
            // 
            this.panel_file_contaner.BackgroundImage = global::ProfileDetection.Properties.Resources.panel_bg_setings;
            this.panel_file_contaner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_file_contaner.Location = new System.Drawing.Point(35, 167);
            this.panel_file_contaner.Name = "panel_file_contaner";
            this.panel_file_contaner.Size = new System.Drawing.Size(857, 322);
            this.panel_file_contaner.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProfileDetection.Properties.Resources.廓形背景;
            this.panel1.Controls.Add(this.pictureBoxProfile);
            this.panel1.Location = new System.Drawing.Point(48, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 227);
            this.panel1.TabIndex = 7;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(32, 21);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(344, 178);
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.dataGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Detected,
            this.Reference,
            this.min,
            this.Max});
            this.dataGridViewItems.GridColor = System.Drawing.Color.Lime;
            this.dataGridViewItems.Location = new System.Drawing.Point(48, 386);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowTemplate.Height = 23;
            this.dataGridViewItems.Size = new System.Drawing.Size(400, 150);
            this.dataGridViewItems.TabIndex = 8;
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item.HeaderText = "项目";
            this.Item.Name = "Item";
            // 
            // Detected
            // 
            this.Detected.HeaderText = "检测值";
            this.Detected.Name = "Detected";
            this.Detected.Width = 70;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "基准值";
            this.Reference.Name = "Reference";
            this.Reference.Width = 70;
            // 
            // min
            // 
            this.min.HeaderText = "最小值";
            this.min.Name = "min";
            this.min.Width = 70;
            // 
            // Max
            // 
            this.Max.HeaderText = "最大值";
            this.Max.Name = "Max";
            this.Max.Width = 70;
            // 
            // dataGridViewSingle
            // 
            this.dataGridViewSingle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.dataGridViewSingle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSingle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSingle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewSingle.GridColor = System.Drawing.Color.Lime;
            this.dataGridViewSingle.Location = new System.Drawing.Point(48, 326);
            this.dataGridViewSingle.Name = "dataGridViewSingle";
            this.dataGridViewSingle.RowHeadersVisible = false;
            this.dataGridViewSingle.RowTemplate.Height = 23;
            this.dataGridViewSingle.Size = new System.Drawing.Size(400, 44);
            this.dataGridViewSingle.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "基准序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "判定结果";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "判断项目";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "导线外径";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "缩放比例";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // btnCom
            // 
            this.btnCom.BackColor = System.Drawing.Color.White;
            this.btnCom.BackgroundImage = global::ProfileDetection.Properties.Resources.com_normal;
            this.btnCom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.btnCom.FlatAppearance.BorderSize = 0;
            this.btnCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCom.Location = new System.Drawing.Point(751, 84);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(75, 75);
            this.btnCom.TabIndex = 10;
            this.btnCom.UseVisualStyleBackColor = false;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            this.btnCom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCom_MouseDown);
            this.btnCom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCom_MouseUp);
            // 
            // comboxCom
            // 
            this.comboxCom.FormattingEnabled = true;
            this.comboxCom.Location = new System.Drawing.Point(831, 112);
            this.comboxCom.Name = "comboxCom";
            this.comboxCom.Size = new System.Drawing.Size(60, 20);
            this.comboxCom.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Receive);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("宋体", 22F);
            this.label38.ForeColor = System.Drawing.Color.Maroon;
            this.label38.Location = new System.Drawing.Point(327, 24);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(73, 30);
            this.label38.TabIndex = 21;
            this.label38.Text = "输出";
            // 
            // btUpdateCfg
            // 
            this.btUpdateCfg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btUpdateCfg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.btUpdateCfg.Location = new System.Drawing.Point(191, 112);
            this.btUpdateCfg.Name = "btUpdateCfg";
            this.btUpdateCfg.Size = new System.Drawing.Size(126, 39);
            this.btUpdateCfg.TabIndex = 47;
            this.btUpdateCfg.Text = "更新设备配置";
            this.btUpdateCfg.UseVisualStyleBackColor = true;
            // 
            // btUploadCfg
            // 
            this.btUploadCfg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btUploadCfg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(60)))), ((int)(((byte)(103)))));
            this.btUploadCfg.Location = new System.Drawing.Point(191, 67);
            this.btUploadCfg.Name = "btUploadCfg";
            this.btUploadCfg.Size = new System.Drawing.Size(126, 39);
            this.btUploadCfg.TabIndex = 46;
            this.btUploadCfg.Text = "读取设备配置";
            this.btUploadCfg.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(920, 581);
            this.Controls.Add(this.btn_setting_file);
            this.Controls.Add(this.panel_setting);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_record);
            this.Controls.Add(this.btn_instrument);
            this.Controls.Add(this.panel_log);
            this.Controls.Add(this.panel_file);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.dataGridViewSingle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboxCom);
            this.Controls.Add(this.btnCom);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel_log.ResumeLayout(false);
            this.panel_setting.ResumeLayout(false);
            this.panel_setting_wire1.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.panel_setting_wire2.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.gBoxModel1.ResumeLayout(false);
            this.gBoxModel1.PerformLayout();
            this.panel_setting_input.ResumeLayout(false);
            this.panel_setting_input.PerformLayout();
            this.grb_settings_input4.ResumeLayout(false);
            this.grb_settings_input4.PerformLayout();
            this.grb_settings_input3.ResumeLayout(false);
            this.grb_settings_input3.PerformLayout();
            this.grb_settings_input2.ResumeLayout(false);
            this.grb_settings_input2.PerformLayout();
            this.grb_settings_input1.ResumeLayout(false);
            this.grb_settings_input1.PerformLayout();
            this.panel_setting_output.ResumeLayout(false);
            this.panel_setting_output.PerformLayout();
            this.group_output2.ResumeLayout(false);
            this.group_output2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.group_output1.ResumeLayout(false);
            this.group_output1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel_setting_contaner.ResumeLayout(false);
            this.panel_setting_contaner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSen)).EndInit();
            this.panel_file.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_instrument;
        private System.Windows.Forms.Button btn_record;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_setting_file;
        private System.Windows.Forms.Panel panel_log;
        private System.Windows.Forms.Panel panel_setting;
        private System.Windows.Forms.Panel panel_setting_contaner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_setting_general;
        private System.Windows.Forms.Button btn_setting_wire1;
        private System.Windows.Forms.Button btn_setting_output;
        private System.Windows.Forms.Button btn_setting_input;
        private System.Windows.Forms.Button btn_setting_wire2;
        private System.Windows.Forms.Panel panel_file;
        private System.Windows.Forms.Panel panel_file_contaner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.DataGridView dataGridViewSingle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.ComboBox comboxCom;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_Sen;
        private System.Windows.Forms.PictureBox pBoxSen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_setting_output;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxOutIgnoreWhileOutActive;
        private System.Windows.Forms.GroupBox group_output2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox group_output1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rBtnIgnoreLearn1;
        private System.Windows.Forms.RadioButton rBtnIgnoreFirst1;
        private System.Windows.Forms.RadioButton rBtnNormal1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnNC1;
        private System.Windows.Forms.RadioButton rBtnNO1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tBoxDuration1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxOutDelay1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Panel panel_setting_wire1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Panel panel_setting_wire2;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox tBoxSealRatio1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tBoxStripLimit1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tBoxSealLimit1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tBoxVariationFilter1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox gBoxModel1;
        private System.Windows.Forms.CheckBox ckBoxSealOri1;
        private System.Windows.Forms.TextBox tBoxSprayP1;
        private System.Windows.Forms.TextBox tBoxStripLenP1;
        private System.Windows.Forms.TextBox tBoxStripLenN1;
        private System.Windows.Forms.TextBox tBoxSealWidthP1;
        private System.Windows.Forms.TextBox tBoxSealWidthN1;
        private System.Windows.Forms.TextBox tBoxCoreWidthP1;
        private System.Windows.Forms.TextBox tBoxCoreWidthN1;
        private System.Windows.Forms.TextBox tBoxStripPosP1;
        private System.Windows.Forms.TextBox tBoxStripPosN1;
        private System.Windows.Forms.TextBox tBoxSealPosP1;
        private System.Windows.Forms.TextBox tBoxSealPosN1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tBoxCorePosP1;
        private System.Windows.Forms.TextBox tBoxCorePosN1;
        private System.Windows.Forms.CheckBox ckBoxSeal1;
        private System.Windows.Forms.CheckBox ckBoxSplay1;
        private System.Windows.Forms.CheckBox ckBoxStripLen1;
        private System.Windows.Forms.CheckBox ckBoxSealWidth1;
        private System.Windows.Forms.CheckBox ckBoxCoreWidth1;
        private System.Windows.Forms.CheckBox ckBoxStripPos1;
        private System.Windows.Forms.CheckBox ckBoxSealPos1;
        private System.Windows.Forms.CheckBox ckBoxCorePos1;
        private System.Windows.Forms.Panel panel_setting_input;
        private System.Windows.Forms.GroupBox grb_settings_input4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.GroupBox grb_settings_input3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.GroupBox grb_settings_input2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.TextBox tBoxMinSetupDuration;
        private System.Windows.Forms.TextBox tBoxFiringTimeOut;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox grb_settings_input1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cBoxInputPolLvl1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cBoxInputModeLvl1;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button btUpdateCfg;
        private System.Windows.Forms.Button btUploadCfg;
    }
}

