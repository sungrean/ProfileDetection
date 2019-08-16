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
            this.btn_seting_file = new System.Windows.Forms.Button();
            this.panel_log = new System.Windows.Forms.Panel();
            this.tbx_log = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_log.SuspendLayout();
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
            // btn_seting_file
            // 
            this.btn_seting_file.BackgroundImage = global::ProfileDetection.Properties.Resources.文件;
            this.btn_seting_file.FlatAppearance.BorderSize = 0;
            this.btn_seting_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seting_file.Location = new System.Drawing.Point(444, 27);
            this.btn_seting_file.Name = "btn_seting_file";
            this.btn_seting_file.Size = new System.Drawing.Size(118, 36);
            this.btn_seting_file.TabIndex = 3;
            this.btn_seting_file.UseVisualStyleBackColor = true;
            // 
            // panel_log
            // 
            this.panel_log.BackgroundImage = global::ProfileDetection.Properties.Resources.中部背景;
            this.panel_log.Controls.Add(this.panel1);
            this.panel_log.Controls.Add(this.tbx_log);
            this.panel_log.Location = new System.Drawing.Point(0, 66);
            this.panel_log.Margin = new System.Windows.Forms.Padding(0);
            this.panel_log.Name = "panel_log";
            this.panel_log.Size = new System.Drawing.Size(920, 507);
            this.panel_log.TabIndex = 4;
            // 
            // tbx_log
            // 
            this.tbx_log.BackColor = System.Drawing.Color.LightYellow;
            this.tbx_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_log.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbx_log.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbx_log.Location = new System.Drawing.Point(110, 261);
            this.tbx_log.Multiline = true;
            this.tbx_log.Name = "tbx_log";
            this.tbx_log.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbx_log.Size = new System.Drawing.Size(708, 196);
            this.tbx_log.TabIndex = 0;
            this.tbx_log.Text = "tag:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProfileDetection.Properties.Resources.中部背景;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 507);
            this.panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(920, 581);
            this.Controls.Add(this.panel_log);
            this.Controls.Add(this.btn_seting_file);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_record);
            this.Controls.Add(this.btn_instrument);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel_log.ResumeLayout(false);
            this.panel_log.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_instrument;
        private System.Windows.Forms.Button btn_record;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_seting_file;
        private System.Windows.Forms.Panel panel_log;
        private System.Windows.Forms.TextBox tbx_log;
        private System.Windows.Forms.Panel panel1;
    }
}

