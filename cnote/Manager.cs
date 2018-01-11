using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace cnote
{
    class Manager
    {
        public void managernote()
        {
            StreamReader sr = new StreamReader(@"E:\test.txt");
            string type=sr.ReadLine();
            Console.WriteLine(type);
            sr.Close();
            Console.ReadKey();
            
            
        }
    }
}
