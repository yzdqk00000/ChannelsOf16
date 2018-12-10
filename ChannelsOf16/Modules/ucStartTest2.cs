using 延迟线收发组件_十六通道.Modules.Model;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 延迟线收发组件_十六通道.Modules
{
    public partial class ucStartTest2 : 延迟线收发组件_十六通道.Modules.BaseModule
    {
        public List<TestModel2> ListTestModel = new List<TestModel2>();
        public List<Test子阵Model> List子阵Model = new List<Test子阵Model>();

        List<string> List延时 = new List<string>();
        List<string> List衰减 = new List<string>();
        List<string> List移相 = new List<string>();

        public ucStartTest2()
        {
            InitializeComponent();

            if (Function_Module.GetConfig("模式") == "DEBUG")
            {
                for (decimal i = 0; i < 16; i++)
                {
                    List延时.Add(i + "λ");
                }

                //延时
                for (decimal i = 0; i < 32; i = i + 0.5m)
                {
                    List衰减.Add(i + "dB");
                }
                //移相选择项目初始化
                for (int i = 0; i <= 64; i++)
                {
                    List移相.Add(i * 5.625 + "°");
                }

                repositoryItemComboBox_延时.Items.AddRange(List延时);
                repositoryItemComboBox_衰减.Items.AddRange(List衰减);
                repositoryItemComboBox_移相.Items.AddRange(List移相);
                comboBoxEdit_延时.Properties.Items.AddRange(List延时);
                comboBoxEdit_移相.Properties.Items.AddRange(List移相);
                comboBoxEdit_衰减.Properties.Items.AddRange(List衰减);
                comboBoxEdit_延时.SelectedIndex = 0;
                comboBoxEdit_移相.SelectedIndex = 0;
                comboBoxEdit_衰减.SelectedIndex = 0;

                //加载数据模型
                for (int i = 1; i <= 16; i++)
                {
                    ListTestModel.Add(new TestModel2()
                    {
                        通道号 = i.ToString(),
                    });
                    if (i % 2 == 0)
                    {
                        List子阵Model.Add(new Test子阵Model()
                        {
                            延时 = "0λ",
                            子阵开关 = false,
                        });
                    }

                }
            }
            else
            {
                repositoryItemComboBox_延时.Items.AddRange(Function_Module.GetConfig("延迟").Split(';'));
                repositoryItemComboBox_衰减.Items.AddRange(Function_Module.GetConfig("衰减").Split(';'));
                repositoryItemComboBox_移相.Items.AddRange(Function_Module.GetConfig("移相").Split(';'));
                comboBoxEdit_延时.Properties.Items.AddRange(Function_Module.GetConfig("延迟").Split(';'));
                comboBoxEdit_移相.Properties.Items.AddRange(Function_Module.GetConfig("移相").Split(';'));
                comboBoxEdit_衰减.Properties.Items.AddRange(Function_Module.GetConfig("衰减").Split(';'));
                comboBoxEdit_延时.SelectedIndex = 0;
                comboBoxEdit_移相.SelectedIndex = 0;
                comboBoxEdit_衰减.SelectedIndex = 0;

                //加载数据模型
                for (int i = 1; i <= 16; i++)
                {
                    ListTestModel.Add(new TestModel2()
                    {
                        通道号 = i.ToString(),
                    });
                    if (i % 2 == 0)
                    {
                        List子阵Model.Add(new Test子阵Model()
                        {
                            延时 = "0λ",
                            子阵开关 = false,
                        });
                    }

                }
            }


            gridControl1.DataSource = ListTestModel;
            gridControl2.DataSource = List子阵Model;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {          
            SimpleButton simple = sender as SimpleButton;
            int[] s = gridView1.GetSelectedRows();
            int[] s2 = gridView2.GetSelectedRows();

            List<TestModel2> selModels = new List<TestModel2>();
            List<Test子阵Model> sel子阵Models = new List<Test子阵Model>();

            for (int i = 0; i < s.Length; i++)
            {
                selModels.Add(gridView1.GetRow(s[i]) as TestModel2);
            }
            for (int i = 0; i < s2.Length; i++)
            {
                sel子阵Models.Add(gridView2.GetRow(s2[i]) as Test子阵Model);
            }

            switch (simple.Text)
            {
                case "一键设置":
                    for (int i = 0; i < selModels.Count; i++)
                    {
                        selModels[i].移相 = comboBoxEdit_移相.Text;
                        selModels[i].衰减 = comboBoxEdit_衰减.Text;
                        selModels[i].通道开关 = toggleSwitch_通道开关.IsOn;
                    }
                    for (int i = 0; i < sel子阵Models.Count; i++)
                    {
                        sel子阵Models[i].子阵开关 = toggleSwitch_子阵开关.IsOn;
                        sel子阵Models[i].延时 = comboBoxEdit_延时.Text;
                    }
                    break;
                case "恢复默认":
                    comboBoxEdit_延时.SelectedIndex = 0;
                    comboBoxEdit_移相.SelectedIndex = 0;
                    comboBoxEdit_衰减.SelectedIndex = 0;

                    toggleSwitch_子阵开关.IsOn = false;
                    toggleSwitch_通道开关.IsOn = false;
                    break;
                default:
                    break;
            }

            gridView1.RefreshData();
            gridView2.RefreshData();
        }


        /// <summary>
        /// 合并子阵开关
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_CellMerge(object sender, CellMergeEventArgs e)
        {
          

        }

        /// <summary>
        /// 合并后选择情况
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            gridView1.RefreshData();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            int[] select = gridView1.GetSelectedRows();
            if (select.Length>1)
            {
                gridView2.ClearSelection();
                for (int i = 0; i < select.Length; i++)
                {
                    if (select[i] % 2 == 0 && (i+1)< select.Length)
                    {
                        if (select[i + 1] % 2 == 1)
                        {
                            gridView2.SelectRow((select[i + 1] + 1) / 2 - 1);
                        }
                       
                    }
                }
            }
            else
            {
                gridView2.ClearSelection();
            }

        }
    }
}
