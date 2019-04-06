using csOEIS.csOEIS_Classes;

namespace csOEIS
{
    class Program
    {
        static void Main()
        {
            A000045 a000045 = new A000045();
            a000045.Sequence.SequenceToString().EndMessageLine();

            decimal.MaxValue.ToString("n0").EndMessageLine();
        }
    }
}