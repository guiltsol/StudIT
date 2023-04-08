using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudIT
{
    public class Stud: Inter
    {
        int age;
        string name;
        public void SetName(string s)
        {
            name = s;
        }
        public string GetName()
        {
            return name;
        }
        public void SetAge(int a)
        {
            age = a;
        }
        public int GetAge()
        {
            return age;
        } 
        public string prev()
        {
            return ("Hellow Student!");
        }
    }
}
