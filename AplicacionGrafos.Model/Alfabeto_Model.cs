using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionGrafos.Model
{
    public class Alfabeto_Model : IAlfabeto
    {
        public string[] Vocales { get; set; } = new string[5] { "a", "e", "i", "o", "u" };
        public string[] VocalesCon { get; set; } = new string[5] { "á", "é", "í", "ó", "ú" };
        public bool isVocal(string letra)
        {
            bool presp = false;

            foreach (var item in Vocales)
            {
                if (item == letra.ToLower())
                    presp = true;
            }
            foreach (var item in VocalesCon)
            {
                if (item == letra.ToLower())
                    presp = true;
            }
            return presp;
        }
        public string[] Consonantes { get; set; } = new string[20] { "b", "d", "f", "g", "h", "j", "k", "l", "m", "n", "ñ", "p", "q", "r", "s", "t", "v", "x", "y", "z" };
    }
}
