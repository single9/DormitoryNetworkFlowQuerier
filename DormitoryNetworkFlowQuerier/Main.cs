using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

/* ------------------------------------------
 * 本區資料請留，最後編輯者請記得修改~
 * 程式名稱: DormitoryNetworkFlowQuerier
 * 製作者: Duye Chen
 * 網站: http://single9.net
 * 最近修改者: Duye Chen
 * 最近修改日: 2012/10/11
 * 程式說明: 本程式用於查詢樹德科技大學住宿者
 * 之網路使用量，資料來源為樹德科大電算中心的
 * 紀錄，為官方所統計資料，更新時間為每小時。
 * ------------------------------------------ */

namespace DormitoryNetworkFlowQuerier
{
    public partial class Main : Form
    {
        // 獲取使用者IP位址
        private IPAddress userIP = Dns.Resolve(Dns.GetHostName()).AddressList[0];
        public Main()
        {
            InitializeComponent();
        }

        // M = Month, D = Day, H = Hours
        string M, D, H;

        private void Main_Load(object sender, EventArgs e)
        {
            GetToday();
        }

        private HttpWebRequest request;
        private HttpWebResponse response;
        private Stream resStream;
        private StreamReader reader;
        private DateTime date = DateTime.Now;

        string today, hour, txtContent;

        // 讀取流量資料
        private void LoadFlow(string direct)
        {
            today = M + "-" + D;
            hour = "/dorm_" + direct + "-" + H;

            try
            {
                // 抓取網路資料
                request = (HttpWebRequest)WebRequest.Create("http://netflow2.stu.edu.tw/dorm_flow/" + today + hour + ".txt");
                request.Headers.Set("Pragma", "no-cache");
                response = (HttpWebResponse)request.GetResponse();
                resStream = response.GetResponseStream();
                reader = new StreamReader(resStream, Encoding.GetEncoding("BIG5"));

                // 資料存入字串
                txtContent = reader.ReadToEnd();

                resStream.Close();
                reader.Close();

                // 讀取與解析資料
                GetFlow(direct);
            }
            catch (Exception e)
            {
            }
            
        }

        // 取得今天使用者的資料
        private void GetToday()
        {
            Clean();

            tbIP.Text = userIP.ToString();

            int nM = date.Month, nD = date.Day, nH = date.Hour, nMin = date.Minute;

            // 資料更延遲時間
            if (nMin < 35) nH -= 1;

            // 0 時調整
            if (nH == 0)
            {
                nH = 0;
                nD = date.Day - 1;
            }
            else if (nH < 0)
            {
                nH = 23;
                nD = date.Day - 1;
            }

            M = date.Month.ToString();
            D = nD.ToString();

            if (nH < 10 && nH > 0)
                H = "0" + nH.ToString();
            else if (nH == 0)
                H = "daily";
            else
                H = nH.ToString();

            if (nD < 10)
                D = "0" + nD.ToString();
            else
                D = nD.ToString();

            if (nM < 10)
                M = "0" + nM.ToString();
            else
                M = nM.ToString();

            cbM.Text = M;
            cbD.Text = D;
            cbH.Text = H;

            LoadFlow("in");
            LoadFlow("out");
        }

        // 解析流量資料
        private void GetFlow(string direct)
        {
            int posIP, posEnd;
            posIP = txtContent.IndexOf(tbIP.Text);
            posEnd = txtContent.IndexOf('\n', posIP);
            posIP = (posIP + tbIP.Text.Length);
            switch(direct)
            {
                case "in":
                    rtbIn.Text = txtContent;
                    lbInValue.Text = txtContent.Trim().Substring(posIP, 15);
                    break;
                case "out":
                    rtbOut.Text = txtContent;
                    lbOutValue.Text = txtContent.Trim().Substring(posIP, 15);
                    break;
            }
        }

        // 查詢按鈕
        private void btnGet_Click(object sender, EventArgs e)
        {
            Clean();
            M = cbM.Text;
            D = cbD.Text;
            H = cbH.Text.ToString();

            LoadFlow("in");
            LoadFlow("out");
        }

        // 今天按鈕
        private void btnToday_Click(object sender, EventArgs e)
        {
            Clean();
            GetToday();
        }

        // 清空顯示區域資料
        private void Clean()
        {
            rtbIn.Text = "";
            rtbOut.Text = "";
            lbInValue.Text = "無資料";
            lbOutValue.Text = "無資料";
        }

        // 設計者連結，請不要更改
        private void lbSingle9_Click(object sender, EventArgs e)
        {
            Process.Start("http://single9.net");
        }
    }
}