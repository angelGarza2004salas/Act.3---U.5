using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaSalida
{
    class Salida
    {
        public string[] Figura()
        {
            int a = 4;
            string f, s = "";
            string[] figura = new string[7];
            for (int i = 1; i <= 4; i++)
            {
                f = s + i;
                figura[i-1] = f;
                s = f + " ";
            }
            for (int j = 3; j >= 1; j--)
            {
                s = figura[j-1];
                figura[a] = s;
                a++;
            }
            return figura;
        }
    }
}
