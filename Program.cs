using csOEIS.csOEIS_Classes;

namespace csOEIS
{
    class Program
    {
        static void Main()
        {
            A000045 a000045 = new A000045();
            a000045.Sequence.SequenceToString().EndMessageLine();
            
            A022441 a022441 = new A022441();
            for (var i = 0; i < a022441.Sequence.Length; i++)
                WriteLine($"i: {i,4} {a022441.Sequence[i].ToString("n0"),8}");
            "a022441 ready".EndMessageLine();
            
            decimal.MaxValue.ToString("n0").EndMessageLine();
        }
    }
}
