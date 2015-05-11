namespace PPPOE_CYJH
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dx_Radio = new System.Windows.Forms.RadioButton();
            this.lt_Radio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_Bendi = new System.Windows.Forms.Label();
            this.Label_Zhuangtai = new System.Windows.Forms.Label();
            this.Label_Waiwang = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "刷新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dx_Radio
            // 
            this.dx_Radio.AutoSize = true;
            this.dx_Radio.Checked = true;
            this.dx_Radio.Location = new System.Drawing.Point(29, 29);
            this.dx_Radio.Name = "dx_Radio";
            this.dx_Radio.Size = new System.Drawing.Size(47, 16);
            this.dx_Radio.TabIndex = 2;
            this.dx_Radio.TabStop = true;
            this.dx_Radio.Text = "电信";
            this.dx_Radio.UseVisualStyleBackColor = true;
            // 
            // lt_Radio
            // 
            this.lt_Radio.AutoSize = true;
            this.lt_Radio.Location = new System.Drawing.Point(142, 29);
            this.lt_Radio.Name = "lt_Radio";
            this.lt_Radio.Size = new System.Drawing.Size(47, 16);
            this.lt_Radio.TabIndex = 3;
            this.lt_Radio.TabStop = true;
            this.lt_Radio.Text = "联通";
            this.lt_Radio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "本地IP：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "状态：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "外网IP：";
            // 
            // Label_Bendi
            // 
            this.Label_Bendi.AutoSize = true;
            this.Label_Bendi.Location = new System.Drawing.Point(73, 65);
            this.Label_Bendi.Name = "Label_Bendi";
            this.Label_Bendi.Size = new System.Drawing.Size(47, 12);
            this.Label_Bendi.TabIndex = 7;
            this.Label_Bendi.Text = "0.0.0.0";
            // 
            // Label_Zhuangtai
            // 
            this.Label_Zhuangtai.AutoSize = true;
            this.Label_Zhuangtai.Location = new System.Drawing.Point(73, 95);
            this.Label_Zhuangtai.Name = "Label_Zhuangtai";
            this.Label_Zhuangtai.Size = new System.Drawing.Size(41, 12);
            this.Label_Zhuangtai.TabIndex = 8;
            this.Label_Zhuangtai.Text = "未连接";
            // 
            // Label_Waiwang
            // 
            this.Label_Waiwang.AutoSize = true;
            this.Label_Waiwang.Location = new System.Drawing.Point(73, 125);
            this.Label_Waiwang.Name = "Label_Waiwang";
            this.Label_Waiwang.Size = new System.Drawing.Size(0, 12);
            this.Label_Waiwang.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBox1.Location = new System.Drawing.Point(267, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 219);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 239);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Label_Waiwang);
            this.Controls.Add(this.Label_Zhuangtai);
            this.Controls.Add(this.Label_Bendi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lt_Radio);
            this.Controls.Add(this.dx_Radio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网络线路切换客户端";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton dx_Radio;
        private System.Windows.Forms.RadioButton lt_Radio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_Bendi;
        private System.Windows.Forms.Label Label_Zhuangtai;
        private System.Windows.Forms.Label Label_Waiwang;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

