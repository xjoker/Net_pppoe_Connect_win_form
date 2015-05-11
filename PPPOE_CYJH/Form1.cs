using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PPPOE_CYJH
{
    public partial class Form1 : Form
    {

        GET_Internet_IP gii = new GET_Internet_IP();

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //拨号图标的写入
            var pathWithEnv = @"%userprofile%\AppData\Roaming\Microsoft\Network\Connections\Pbk\rasphone.pbk";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            if (!System.IO.File.Exists(filePath))
            {
                add_link.Create_link(filePath);
            }
            Label_Waiwang.Text = gii.GetIP();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Thread th = new Thread(gogo);
            th.IsBackground = true;
            th.Start();
        }


        //...主线程
        private void gogo()
        {

            if (button1.Text != "断开")
            {
                try
                {
                    button1.Enabled = false;

                    string pppoe_id = "ctcc";//默认电信线路的账号
                    string pppoe_pw = "123";
                    if (lt_Radio.Checked == true)
                    {
                        pppoe_id = "cucc";
                    }

                     pppoe.pppoe_on(pppoe_id, pppoe_pw);

                    Thread.Sleep(500);
                    NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();//获取本机所有网卡对象

                    foreach (NetworkInterface adapter in adapters)
                    {
                        Console.WriteLine("获取本地IP：" + adapter.NetworkInterfaceType + " " + adapter.Description.ToString());
                        if (adapter.Description.Contains("CYJH"))//枚举条件：描述中包含"CYJH""
                        {

                            IPInterfaceProperties ipProperties = adapter.GetIPProperties();//获取IP配置
                            UnicastIPAddressInformationCollection ipCollection = ipProperties.UnicastAddresses;//获取单播地址集
                            foreach (UnicastIPAddressInformation ip in ipCollection)
                            {
                                if (ip.Address.AddressFamily == AddressFamily.InterNetwork)//只要ipv4的
                                    Label_Bendi.Text = ip.Address.ToString();//获取ip
                            }
                            if (adapter.OperationalStatus == OperationalStatus.Up)
                            {
                                Label_Zhuangtai.Text = "已连接";
                                button1.Text = "断开";
                            }
                        }
                    }
                    button1.Enabled = true;
                    dx_Radio.Enabled = false;
                    lt_Radio.Enabled = false;
                    GetIP();

                    Console.WriteLine("--------Link-------OK");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                    //throw;
                }

            }
            else
            {
                button1.Enabled = false;
                button1.Text = "连接";
                pppoe.pppoe_off();
                GetIP();
                Label_Zhuangtai.Text = "未连接";
                button1.Enabled = true;
                dx_Radio.Enabled = true;
                lt_Radio.Enabled = true;
                Label_Bendi.Text = "0.0.0.0.";
            }
   
        }

        private void GetIP()
        {

            Label_Waiwang.Text = gii.GetIP();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetIP();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            pppoe.pppoe_off();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon1.Visible = true;
            } 
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }
    }
}
