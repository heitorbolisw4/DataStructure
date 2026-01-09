using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeafioTuplas007.Class
{
    static class TextValidator
    {
        
        public static char[] Vogais { get;}

        static TextValidator()
        {
            char[] vogais = ['a', 'e', 'i', 'o', 'u'];
            Vogais = vogais;
        }


        public static bool IsVocal(char c)
        {
            return Vogais.Contains(char.ToLower(c));
        }
    }
}
