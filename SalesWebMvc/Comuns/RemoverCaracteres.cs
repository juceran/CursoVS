using System.Text;

namespace SalesWebMvc.Comuns
{
    class RemoverCaracteres
    {
        public static string StringNova(string str)
        {
            if (str != null)
            {
                var sb = new StringBuilder(str.Length);
                foreach (var chr in str) if (char.IsDigit(chr)) sb.Append(chr);
                return sb.ToString();
            }
            else
            {
                return str;
            }
        }
    }
}
