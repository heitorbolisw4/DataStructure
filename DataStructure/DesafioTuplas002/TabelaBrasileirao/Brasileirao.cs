using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelaBrasileirao
{
    internal class Brasileirao
    {
        private string[] TabelaBrasileirao = new string[20]
        {
            "Flamengo", "Palmeiras", "Cruzeiro", "Mirassol",
            "Fluminense", "Botafogo", "Bahia", "Sao Paulo",
            "Gremio", "RB Bragantino", "Aletico MG", "Santos",
            "Corinthias", "Vasco", "Vitoria", "Internacional",
            "Ceara", "Fortaleza", "Juventude", "Sport"
        };

        public string[] CincoPrimeiros()
        {
            string[] resultado = new string[5];
            for(int i = 0; i < 5; i++)
            {
                resultado[i] = TabelaBrasileirao[i];
            }
            return resultado;
        }
        public string[] Rebaixamento()
        {
            string[] resultado = new string[4];
            for(int i = 16; i <= 19; i++)
            {
                resultado[i - 16] = TabelaBrasileirao[i];
            }
            return resultado;

        }
        public string[] TimesOrdemAlf()
        {
            string[] copia = (string[])TabelaBrasileirao.Clone();
            Array.Sort(copia);
            return copia;

        }
        public int WhatPosition(string teamName)
        {
            for(int i = 0; i < TabelaBrasileirao.Length; i++)
            {
                if(teamName == TabelaBrasileirao[i])
                {
                    return i;
                    
                }
            }
            return -1;

        }
        //public int TimePosition(string teamName)
        //{
        //    return TabelaBrasileirao[teamName];
        //}
    }
}
