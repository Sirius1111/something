using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_2
{
    class Coffee
    {
       public string name { get; set; }
       public string category { get; set; }
       public string description { get; set; }
       public string urlImg { get; set; }

       public string [] info { get; set; }

        public string getInfo(string[] str)
        {
            string str1 = "";
            int i = 1;

            foreach (var item in str)
            {
                if(i!=str.Length)
                {
                    str1 += item + "|";
                } 
                else
                {
                    str1 += item;
                }
                i++;

            }

            return str1;
        }
    }
}
