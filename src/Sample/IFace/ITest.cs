﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFace
{
    public interface ITest
    {
       
        string Get(string msg, int c);
        List<string> Good(string yun, string mm, string kkk);
        int GetInt(int i);
        Tuple<int> GetTuple(int i);

        float GetFloat(float i);
        List<Nvr> GetModel(int i);

        string ToList(List<Imodel> i);

        string R(ref int o);
        string M(ref bool o, string code);

        string X(out int m, out int x, ref bool o);



    }
}
