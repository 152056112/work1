using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    SQLSERVER设置为Windows登录，那么在这里就不需要使用uid和pwd这两个参数，
    需使用“Trusted_Connection=SSPI”来进行登录。
使用SqlConnection进行数据库的连接，然后使用SqlCommand定义SQL查询语句，
再定义一个DataSet存储查询的结果，而SqlDataAdapter是数据库和DataSet的转换桥梁。
     */
namespace WindowsFormsMune
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

            //采用集成的Windows验证方式
            string str = "server=.;database=information;integrated security=SSPI";
            //1.建立SqlConnection对象，指定SqlConnection对象的ConnectionString属性；
            SqlConnection mconn = new SqlConnection(str);
            mconn.Open();
            String sql = "select * from jibenxinxi";
            SqlCommand smd = new SqlCommand(sql, mconn);
            smd.ExecuteNonQuery();
            SqlDataReader msr = smd.ExecuteReader();
            try { 
            while (msr.Read())
            {
                Console.WriteLine("菜号:{0}  菜名:{1} 价格:{2} 类别: {3} 备注:{4} 备注:{5}",
                    msr["no"], msr["name"], msr["price"], msr["tpe"], msr["remark1"], msr["remark2"]);
            }
        }
            catch(Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
            finally
            {
                msr.Close();
            }
            mconn.Close();
            Console.Read();
        }
    }
}
