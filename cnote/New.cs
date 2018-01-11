using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cnote
{
    class New
    {
        public  static string text; //内容
        public static string type;//笔记分类
        public void newnote()
        {
            Console.Write("请输入笔记分类：");
            type =Console.ReadLine();
            Console.WriteLine("请输入笔记：");
            text = Console.ReadLine(); 
            StreamWriter sw = new StreamWriter(@"E:\test.txt", true);
            //sw.WriteLine("内容：");
            //sw.WriteLine(Console.ReadLine());
            //sw.Flush();
            sw.Close();
            Console.WriteLine("笔记本已新建完成");
            Console.ReadKey();
           
        }
    }
}
