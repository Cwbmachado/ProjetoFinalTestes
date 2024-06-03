using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listahistorico;
        public Calculadora()
        {
            listahistorico = new List<string>();
        }
        public int Somar(int val1, int val2)

        {
            int res = val1 + val2;
            listahistorico.Insert(0, "Res:" + res);
            return res;

        }
        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            listahistorico.Insert(0, "Res:" + res);
            return res;

        }
        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            listahistorico.Insert(0, "Res:" + res);
            return res;

        }
        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;
            listahistorico.Insert(0, "Res:" + res);
            return res;

        }
        public List<string> Historico()
        {
            List<string> res;
            listahistorico.RemoveRange(3, listahistorico.Count -3);
            return listahistorico;
        }
    }
}
