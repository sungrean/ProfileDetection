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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_instrument = new System.Windows.Forms.Button();
            this.btn_record = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_setting_file = new System.Windows.Forms.Button();
            this.panel_log = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_setting = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_setting_contaner = new System.Windows.Forms.Panel();
            this.panel_file = new System.Windows.Forms.Panel();
            this.panel_file_contaner = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.panel_log.SuspendLayout();
            this.panel_setting.SuspendLayout();
            this.panel_file.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingle)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_instrument
            // 
            this.btn_instrument.BackgroundImage = global::ProfileDetection.Properties.Resources.设备激活;
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
            this.panel_log.Location = new System.Drawing.Point(-1, 67);
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
            this.panel_setting.Controls.Add(this.button5);
            this.panel_setting.Controls.Add(this.button4);
            this.panel_setting.Controls.Add(this.button3);
            this.panel_setting.Controls.Add(this.button2);
            this.panel_setting.Controls.Add(this.button1);
            this.panel_setting.Controls.Add(this.panel_setting_contaner);
            this.panel_setting.Location = new System.Drawing.Point(-1, 67);
            this.panel_setting.Name = "panel_setting";
            this.panel_setting.Size = new System.Drawing.Size(920, 507);
            this.panel_setting.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::ProfileDetection.Properties.Resources.线型参数未激活1;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(757, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::ProfileDetection.Properties.Resources.线型参数未激活1;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(679, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ProfileDetection.Properties.Resources.输出未激活;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(600, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ProfileDetection.Properties.Resources.输入未激活;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(523, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProfileDetection.Properties.Resources.通用激活;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(445, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel_setting_contaner
            // 
            this.panel_setting_contaner.BackgroundImage = global::ProfileDetection.Properties.Resources.panel_bg_setings;
            this.panel_setting_contaner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_setting_contaner.Location = new System.Drawing.Point(35, 167);
            this.panel_setting_contaner.Name = "panel_setting_contaner";
            this.panel_setting_contaner.Size = new System.Drawing.Size(857, 322);
            this.panel_setting_contaner.TabIndex = 0;
            // 
            // panel_file
            // 
            this.panel_file.BackgroundImage = global::ProfileDetection.Properties.Resources.中部背景;
            this.panel_file.Controls.Add(this.panel_file_contaner);
            this.panel_file.Location = new System.Drawing.Point(-1, 67);
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
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(48, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 227);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 178);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.btnCom.FlatAppearance.BorderSize = 0;
            this.btnCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCom.Location = new System.Drawing.Point(751, 84);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(75, 75);
            this.btnCom.TabIndex = 10;
            this.btnCom.UseVisualStyleBackColor = false;
            this.btnCom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCom_MouseDown);
            this.btnCom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCom_MouseUp);
            // 
            // comboxCom
            // 
            this.comboxCom.FormattingEnabled = true;
            this.comboxCom.Location = new System.Drawing.Point(832, 112);
            this.comboxCom.Name = "comboxCom";
            this.comboxCom.Size = new System.Drawing.Size(60, 20);
            this.comboxCom.TabIndex = 11;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel_log.ResumeLayout(false);
            this.panel_setting.ResumeLayout(false);
            this.panel_file.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel_file;
        private System.Windows.Forms.Panel panel_file_contaner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
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
    }
}

