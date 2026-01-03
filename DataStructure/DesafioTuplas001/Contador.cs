using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTuplas001
{
    internal class Contador
    {
        private string[] NumExtenso = new string[21]
        {
            "zero","um", "dois",
            "tres","quatro", "cinco",
            "seis","sete", "oito",
            "nove","dez", "onze",
            "doze","treze","quatorze",
            "quinze", "dezesseis",
            "dezesete", "dezoito",
            "dezenove", "vinte"
        };

        public string WhatNumber(int n1)
        {

            return NumExtenso[n1];
            
        }
    }
}
