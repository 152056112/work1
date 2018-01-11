using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cnote
{
    class Open
    {
        public void opennote()
        {
            Console.WriteLine("已经打开笔记");
            String Opentext = string.Empty;
            StreamReader sr = new StreamReader(@"E:\test.txt");
            Opentext = sr.ReadToEnd();//调用该方法读取文件中的全部内容
            Console.WriteLine(Opentext);
            sr.Close();
            Console.ReadKey();
            
        }
    }
}
