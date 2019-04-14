using System;
using System.Collections.Generic;

namespace csOEIS.csOEIS_Classes
{
    public class A022441
    {
        static string NL = Environment.NewLine;
        
        public string Caption =
            "Odd Fibbinary numbers; also 4 * Fibbinary(n) + 1." + NL +
            
            "Fibbinary numbers are positive integers whose binary representation contains no consecutive ones." + NL +
            "Odd Fibbinary numbers starts with a one and ends with a one";
        
        public decimal[] Sequence;
        public int Nstart, N, Nmax; //maybe for checking N to have reached Nmax
        public A022441(int Nstart = 0, int Nmax = 256)
        {
            this.Nstart = Nstart; this.Nmax = Nmax; this.N = 1;
            List<decimal> result = new List<decimal>();

            while (result.Count < Nmax)
            {
                int k = this.N;
                List<int> lk = new List<int>();
                int last_rest = 0, rest = 0;
                bool bo_double_one = false;
                while (k > 0)
                {
                    rest = k % 2;
                    if (last_rest * rest == 1)
                    {
                        bo_double_one = true;
                        break;
                    }
                    lk.Add(rest);
                    k /= 2;
                    last_rest = rest;
                }
                if (!bo_double_one)
                    result.Add(this.N);
                this.N += 2;
            }
            
            this.Sequence = new decimal[result.Count];
            result.ToArray().CopyTo(this.Sequence, 0);
        }
    }
}
