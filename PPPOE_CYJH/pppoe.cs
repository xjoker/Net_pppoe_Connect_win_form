﻿//    PPPOE的拨号和断开
//    使用的是rasdial这个命令来执行
//



using System.Diagnostics;

namespace PPPOE_CYJH
{
    class pppoe
    {

        /// <summary>
        /// PPPOE拨号指令,默认拨号CYJH这个
        /// </summary>
        /// <param name="pppoe_id">账号</param>
        /// <param name="pppoe_pw">密码</param>
        public static void  pppoe_on(string pppoe_id,string pppoe_pw)
        {
            Process p = new Process();


            p.StartInfo.FileName = "rasdial.exe";

            //几个必要的参数
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            //p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = " CYJH " + pppoe_id + " " + pppoe_pw;
            p.Start();
            //ras_log = p.StandardOutput.ReadToEnd();
            p.Close();
        }

        /// <summary>
        /// 关闭CYJH的PPPOE拨号
        /// </summary>
        public static void pppoe_off()
        {
            Process p = new Process();

            p.StartInfo.FileName = "rasdial.exe";

            //几个必要的参数
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = " CYJH /DISCONNECT";
            p.Start();
            //ras_log = p.StandardOutput.ReadToEnd();
            p.Close();
        }

    }
}
