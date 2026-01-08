using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTuplas.Class
{
    internal class Numbers
    {
        private int[] _num;

        public Numbers()
        {
            _num = new int[4];
        }
        public (int, int, int, int) TuplaNumeros => (_num[0], _num[1], _num[2], _num[3]);

        public int[] Num { get => _num; set => _num = value; }

        public void LerNumeros()
        {
            int n = _num.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(" > ");
                _num[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public int ContarOcorrencias(int n1)
        {
            int count = 0;
            foreach(int valor in _num)
            {
                if ( valor == n1) count++;
            }
            return count;
        }
        public int SeachPosition(int n1)
        {
            int index = Array.IndexOf(_num, n1);
            if(index == -1) return -1;

            return index + 1;

        }
        public List<int> Divisible()
        {
            List<int> list = new List<int>();

            foreach ( int valor in _num)
            {
                if((valor % 2) == 0)
                {
                   list.Add(valor);   
                }
            }
            return list;

        }

    }
}
