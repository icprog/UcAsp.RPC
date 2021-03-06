﻿/***************************************************
*创建人:TecD02
*创建时间:2016/8/5 13:52:27
*功能说明:<Function>
*版权所有:<Copyright>
*Frameworkversion:4.0
*CLR版本：4.0.30319.42000
***************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using UcAsp.RPC;
using IFace;
namespace Face
{


    /// <summary>
    /// 
    /// </summary>
    [Restful("TestClazz")]

    public class Test : ITest
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="im"></param>
        /// <returns></returns>
        [Restful("POST", "GetAll")]
        public string ToList(List<Imodel> im)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 2000; i++)
            {
                sb.Append(im[0].Code.ToString() + im[0].Message + im[0].Codes(im[0].Message));
            }
            return sb.ToString();
        }
        [Restful("POST", "TestPost")]
        public string Get(string msg, int c)
        {
            Event e = new Event { C = c };
            byte[] send = Encoding.UTF8.GetBytes("测试");

            return msg + c.ToString();
        }
        /// <summary>
        /// 获取过得
        /// </summary>
        /// <param name="yun">文字</param>
        /// <param name="mm">字符</param>
        /// <param name="kkk">表格</param>
        /// <returns>数据列</returns>
        /// 
        [Restful(Path = "PathGood", Method = "GET")]
        public List<string> Good(string yun, string mm, string kkk)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(yun.ToString());
                list.Add(mm);
                list.Add(kkk);
                
                // throw new Exception("错误");
            }
            Thread.Sleep(new Random().Next(500));
            return list;
        }

        public int GetInt(int i)
        {
            // Thread.Sleep(1500);
            return i;
        }
        public Tuple<int> GetTuple(int i)
        {
            //Thread.Sleep(3000);
            Tuple<int> t = new Tuple<int>(i + 100000);
            return t;
        }

        public float GetFloat(float i)
        {
            // Thread.Sleep(1200);
            return i;
        }
        public List<Nvr> GetModel(int i)
        {
            List<Nvr> m = new List<Nvr>();

            for (int x = 0; x < i; x++)
            {
                List<Imodel> list = new List<Imodel>();
                Imodel model = new Imodel { Code = i, Message = "测试" };
                list.Add(model);


                Nvr n = new Nvr();

                n.chanel = list;
                n.nv_ip = "129.0.0.1";

                m.Add(n);
            }
            return m;
        }


        public string R(ref int o)
        {
            o = 111 + o;
            return "mm";
        }

        public string M(ref bool o, string code)
        {
            o = true;
            return "s";
        }
        public string X(out int m, out int x, ref bool o)
        {
            x = 9;
            m = 2;
            m = m * x;
            o = false;
            return m.ToString();
        }
    }
}
