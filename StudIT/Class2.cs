using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudIT
{
    public class Studit : Stud, Inter
    {
        string lang;
        public void SetLang(string s)
        {
            lang = s;
        }
        public string GetLang()
        {
            return lang;
        }
        public string prev()
        {
            return ("Hellow Student IT!");
        }

    }
}
