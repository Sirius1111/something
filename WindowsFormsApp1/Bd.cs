using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_9._2
{
    class Bd
    {
        string path = @"E:\programming\c#\app\git\cs\data\";
        string line;



        //public string ReadBd(string name){
        //   var str =  File.ReadAllText(path + name);
        //     return str;
        // }

        public string ReadBd(string name)
        {
            string str = "";
            using (StreamReader sr = new StreamReader(path + name + ".txt"))
            {
                while (!sr.EndOfStream)
                {
                    str += sr.ReadLine();
                }
            }
            return str;
        }


        void WriteBd(string name, string str = "Value")
        {
            using (StreamWriter sw = new StreamWriter(path + "/" + name + ".txt", true, System.Text.Encoding.UTF8))
            {
                sw.WriteLine(str);
            }
        }
    }
}
