using System;

namespace SalesWebMvc.Comuns
{
    public class FormatarString
    {
        public static string FormatCPForCNPJ(string str)
        {
            if (str.Length == 11 || str.Length == 14)
            {
                if (str.Length == 11)
                {
                    return Convert.ToUInt64(str).ToString(@"000\.000\.000\-00");
                }
                else
                {
                    return Convert.ToUInt64(str).ToString(@"00\.000\.000\/0000\-00");
                }

            }
            else
            {
                return str;
            }
        }
    }
}
