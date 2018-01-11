using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace cnote
{
    class Save
    {
        public void savenote()
        {
            //Console.WriteLine("请输入笔记：");//
           // String text = Console.ReadLine();
            String text = New.text;
            string type = New.type;
            StreamWriter sw = new StreamWriter(@"E:\test.txt");
            sw.WriteLine(type);
            sw.WriteLine(text);
            Console.WriteLine("笔记已保存成功");
            sw.Close();
            Console.ReadKey();
        }
    }
}
