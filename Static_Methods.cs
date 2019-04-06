using static System.Console;
using System.Text;

namespace csOEIS.csOEIS_Classes
{
    public static class Static_Methods
    {
        public static void EndMessageLine(this string s)
        {
            WriteLine(s);
            ReadKey(true);
        }

        public static string SequenceToString(this decimal[] s, int values_per_line = 10)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length;)
            {
                sb.Append($"{s[i].ToString("n0"), 30} ");
                if (++i % values_per_line == 0)
                    sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
