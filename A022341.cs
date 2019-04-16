using System;
using System.Collections.Generic;

namespace csOEIS.csOEIS_Classes
{
    public class A022341
    {        
        static readonly string NL = Environment.NewLine;

        public string Caption =
            "A022341: Odd Fibbinary numbers; also 4 * Fibbinary(n) + 1.";
        public string Description =
            "Fibbinary numbers are positive integers whose binary representation contains no consecutive ones." + NL +
            "Odd Fibbinary numbers starts with an one and ends with an one (little-endian).";
        
        public int[] Sequence;
        
        public Dictionary<int, int> Dict = new Dictionary<int, int>(); //for later applications
        public int Nstart, N, Nmax; //maybe for checking N to have reached Nmax
        
        public A022441(int Nstart = 0, int Nmax = 256)
        {
            this.Nstart = Nstart; this.Nmax = Nmax; this.N = 1;
            int counter = 0;
            while (this.Dict.Keys.Count < Nmax)
            {                
                int K = this.N >> 1;
                if ((int)(K & this.N) == 0)
                    this.Dict.Add(this.N, counter++);
                this.N += 2;
            }
            this.Sequence = new int[this.Dict.Keys.Count];
            this.Dict.Keys.ToArray().CopyTo(Sequence, 0);
        }
    }
}
