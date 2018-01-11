using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
（1）建立SqlConnection对象，指定SqlConnection对象的ConnectionString属性；
（2）打开数据库连接；
（3）指定SQL语句；
（4）建立SqlDataAdapter对象和DataSet对象；
（5）填充DataSet对象
（6）给DataGrid指定数据源
2.你的SQL Server 必须已经设置了需要用户名和密码来登录，否则不能用这样的方式来登录。
如果你的SQL SERVER设置为Windows登录，那么在这里就不需要使用uid和pwd这两个参数，需使用“Trusted_Connection=SSPI”来进行登录。
     
3.使用SqlConnection进行数据库的连接，然后使用SqlCommand定义SQL查询语句，再定义一个
DataSet存储查询的结果，而SqlDataAdapter是数据库和DataSet的转换桥梁。
     */
namespace shiyanqi
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
