using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeafioTuplas007.Class
{
    internal class Palavra
    {
        public string Nome{ get; set; }
        public Palavra(string nome)
        {
            Nome = nome;
        }

        public string ObterVogais()
        {
            
            List<char> caracteres = new List<char>();
            foreach (char c in Nome)
            {
                if (TextValidator.IsVocal(c))
                {
                    caracteres.Add(c); 
                }

            }
            return $"As vogais presentes: {string.Join(", ", caracteres)}";
        }
    }
}
