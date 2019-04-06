using static System.Console;

namespace csOEIS.csOEIS_Classes
{
    public class A000045
    {
        public string Caption =
            "Fibonacci numbers: F(n) = F(n-1) + F(n-2) with F(0) = 0 and F(1) = 1.";
        public decimal[] Sequence;
        public int Nstart, Nmax;
        public A000045(int Nstart = 0, int Nmax = 100)
        {
            this.Nstart = Nstart;
            this.Nmax = Nmax;
            Sequence = new decimal[Nmax - Nstart + 1];
            Sequence[0] = 0;
            Sequence[1] = 1;
            for (var i = 2; i < Sequence.Length; i++)
                Sequence[i] = Sequence[i - 1] + Sequence[i - 2];
        }
    }
}
