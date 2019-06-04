using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Zadatak9
{
    public class Konvertor
    {
        string latinica = "Dj|Lj|Nj|Dž|A|B|V|G|D|Đ|E|Ž|Z|I|J|K|L|M|N|O|P|R|S|T|Ć|U|F|H|C|Č|Š";
        string cirilica = "Ђ|Љ|Њ|Џ|А|Б|В|Г|Д|Ђ|Е|Ж|З|И|Ј|К|Л|М|Н|О|П|Р|С|Т|Ћ|У|Ф|Х|Ц|Ч|Ш";

        string[] latinicaArray;
        string[] cirilicaArray;

        public Konvertor()
        {
            latinica += '|' + latinica.ToLower();
            cirilica += '|' + cirilica.ToLower();

            latinicaArray = latinica.Split('|');
            cirilicaArray = cirilica.Split('|');
        }

        public string LatToCyr(string ulaz)
        {
            foreach (string s in latinicaArray)
            {
                if (ulaz.Contains(s))
                {
                    int charIndex = Array.IndexOf(latinicaArray, s);
                    ulaz = ulaz.Replace(s, cirilicaArray[charIndex]);
                }
            }
            return ulaz;
        }

        public string CyrToLat(string ulaz)
        {
            foreach (string s in cirilicaArray)
            {
                if (ulaz.Contains(s))
                {
                    int charIndex = Array.IndexOf(cirilicaArray, s);
                    ulaz = ulaz.Replace(s, latinicaArray[charIndex]);
                }
            }
            return ulaz;
        }


    }
}