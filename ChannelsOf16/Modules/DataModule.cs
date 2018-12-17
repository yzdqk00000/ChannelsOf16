using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using InstrLibrary.InstrObect;

namespace 延迟线收发组件_十六通道.Modules
{
    public partial class DataModule : DevExpress.XtraEditors.XtraForm
    {
        public NetWorkAnalyzerBase NetWork = new NetWorkAnalyzerBase(Function_Module.GetConfig("矢网地址"));
        public Test数据采集 Test数据采集;
        private List<string> Path文件名组成 = new List<string>();

        public DataModule()
        {
            InitializeComponent();

            comboBoxEdit_类型选择.Properties.Items.AddRange(Function_Module.GetConfig("类型选择").Split(';'));
            comboBoxEdit_类型选择.SelectedIndex = 0;

            textEdit_矢网地址.Text = Function_Module.GetConfig("矢网地址");
            textEdit_保存路径.Text = Function_Module.GetConfig("保存路径");

            Test数据采集 = new Test数据采集(NetWork);

            //连接测试
            string res = Test数据采集.Test建立连接();
            if (res != "连接成功") { MessageBox.Show(res); }
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = false;
            this.Hide();
        }

        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton_连接测试_Click(object sender, EventArgs e)
        {
            NetWork = new NetWorkAnalyzerBase(textEdit_矢网地址.Text);
            Test数据采集 = new Test数据采集(NetWork);

            MessageBox.Show(Test数据采集.Test建立连接());       
        }

        /// <summary>
        /// 添加文件名组成
        /// </summary>
        /// <param name="res"></param>
        public void AddPath(string res)
        {
            Path文件名组成.Add(res);
        }

        /// <summary>
        /// 获取路径
        /// </summary>
        /// <returns></returns>
        public string GetPath()
        {
            string HEADER = textEdit_组件编号.Text + "." + textEdit_采集通道.Text + "."+comboBoxEdit_类型选择.Text + ".";
            string res = "";
            for (int i = 0; i < Path文件名组成.Count; i++)
            {
                res += Path文件名组成[i] + ".";
            }
            string LAST = "s2p";

            Path文件名组成.Clear();
            
            return textEdit_保存路径.Text + HEADER + res + LAST;
        }

        /// <summary>
        /// 保存文件
        /// </summary>
        /// <returns></returns>
        public bool SaveS2p(string path)
        {
            try
            {
                Test数据采集.Test开始测试(path);
                return true;
            }
            catch (Exception)
            {
                return false;
            }      
        }
    }

    public class Test数据采集
    {
        private NetWorkAnalyzerBase _NetWork;
        private NetWorkAnalyzerSCPIBase_Keysight _NetWork_SCPI = new NetWorkAnalyzerSCPIBase_Keysight();

        public Test数据采集(NetWorkAnalyzerBase network)
        {
            _NetWork = network;
        }

        public string Test建立连接()
        {
            try
            {
                _NetWork.VisaOpen();
                return "连接成功";
            }
            catch (Exception)
            {
                return "矢网连接失败，地址：" + Function_Module.GetConfig("矢网地址") + "，请尝试重新连接";
            }
        }

        public void Test开始测试(string path)
        {
            _NetWork.VisaWrite(_NetWork_SCPI.MEMM_SYSTEM.保存Memory(path));
        }
    }

}