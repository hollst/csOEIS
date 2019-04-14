using System;
using System.Collections.Generic;

namespace csOEIS.csOEIS_Classes
{
    public class A022441
    {
        public string Caption =
            "Odd Fibbinary numbers; also 4 * Fibbinary(n) + 1. " + Environment.NewLine +
            "Fibbinary numbers are positive integers whose binary representation contains no consecutive ones";
        public decimal[] Sequence;
        public int Nstart, Nmax;
        public A022441(int Nstart = 0, int Nmax = 256)
        {
            List<decimal> result = new List<decimal>();
            int i = 1;
            while (result.Count < Nmax)
            {
                int k = i;
                List<int> lk = new List<int>();
                int last_rest = 0, rest = 0;
                bool bo_double_1 = false;
                while (k > 0)
                {
                    rest = k % 2;
                    if (last_rest * rest == 1)
                    {
                        bo_double_1 = true;
                        break;
                    }
                    lk.Add(rest);
                    k /= 2;
                    last_rest = rest;
                }
                if (!bo_double_1)
                    result.Add(i);
                i += 2;
            }
            this.Sequence = new decimal[result.Count];
            result.ToArray().CopyTo(this.Sequence, 0);
        }
    }
}
