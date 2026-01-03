using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Class
{
    internal class Numbers
    {

        private (int, int, int, int, int) _numbers;
        private int[] _arrayNumbers = new int[0];

        public Numbers()
        {
            CarregarNumeros();
        }
        public (int, int, int, int, int) NumerosGerados => _numbers;
        public int[] ArrayNumbers => _arrayNumbers;


        public void CarregarNumeros()
        {
            Random rand = new Random();

            _numbers = (rand.Next(1, 101), rand.Next(1, 101), rand.Next(1, 101), rand.Next(1, 101), rand.Next(1, 101));

            _arrayNumbers = new int[]
            {
                _numbers.Item1,
                _numbers.Item2,
                _numbers.Item3,
                _numbers.Item4,
                _numbers.Item5
            };

        }

    }
}
