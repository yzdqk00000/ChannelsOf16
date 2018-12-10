using 延迟线收发组件_十六通道.Modules.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 延迟线收发组件_十六通道
{
    public class CommandAnalyzier
    {
        public static byte[] Writer(List<TestModel2> listTestModel,List<Test子阵Model> list子阵Model)
        {
            List<byte> OUTPUT = new List<byte>();

            //帧头+功能位校验位+帧尾
            byte CHK = 0X00;
            byte[] LAST = new byte[] { 0xee, 0xbb };
            byte[] HEADER = new byte[] { 0xff,0xaa,0x13,0x01,0x00};
            byte[] COMMAND = new byte[] { 0x01,0x00 };
            OUTPUT.AddRange(HEADER);
            OUTPUT.AddRange(COMMAND);

            //D1~N的协议处理部分
            List<byte> resBytes = new List<byte>();
            string sum = "";
            foreach (var model in listTestModel)
            {
                string 衰减 = Reverse(Convert.ToString(Convert.ToInt32(Convert.ToDecimal(model.衰减.Split('d')[0]) / 0.5m), 2).PadLeft(6,'0'));

                string 移相 = Reverse(Convert.ToString(Convert.ToInt32(Convert.ToDecimal(model.移相.Split('°')[0]) / 5.625m),2).PadLeft(6, '0'));

                string 通道开关 = model.通道开关?"1":"0";
                string 子阵开关  = list子阵Model[(Convert.ToInt32(model.通道号)-1)/2].子阵开关?"1":"0";

                sum += 衰减 + 移相 + 通道开关 + 子阵开关;

                if (model.通道号 == "8")
                {
                    string 子阵延迟 = "";
                    for (int i = 0; i < 4; i++)
                    {                     
                        子阵延迟 += Reverse(Convert.ToString(Convert.ToInt32(Convert.ToDecimal(list子阵Model[i].延时.Split('λ')[0])), 2).PadLeft(4, '0'));
                    }
                    sum += 子阵延迟;                  
                }

                if (model.通道号 == "16")
                {
                    string 子阵延迟 = "";
                    for (int i = 4; i < 8; i++)
                    {
                        子阵延迟 += Reverse(Convert.ToString(Convert.ToInt32(Convert.ToDecimal(list子阵Model[i].延时.Split('λ')[0])), 2).PadLeft(4, '0'));
                    }
                    sum += 子阵延迟;
                }
            }
            string temp = "";
            for (int i = 0; i < sum.Length; i++)
            {            
                if ((i+1)%8!=0)
                {
                    temp +=sum[i];
                }
                else
                {
                    temp += sum[i];
                    byte res = Convert.ToByte(temp, 2);
                    resBytes.Add(res);
                    temp = "";             
                }

                if (i == sum.Length -1 && temp != "")
                {
                    byte res = Convert.ToByte(temp, 2);
                    resBytes.Add(res);
                    temp = "";
                }
            }     

            OUTPUT.AddRange(resBytes);
            OUTPUT.Add(CHK);
            OUTPUT.AddRange(LAST);

            return OUTPUT.ToArray();
        }

        public string Reader(TestModel2 testModel)
        {
            return "";
        }
        private static string Reverse(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
