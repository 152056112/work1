using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMune
{
    public partial class addmune : Form
    {
        public addmune()
        {
            InitializeComponent();
        }
        //采用集成的Windows验证方式
        static string str = "server=.;database=information;integrated security=SSPI";
        //1.建立SqlConnection对象，指定SqlConnection对象的ConnectionString属性；
        SqlConnection mconn = new SqlConnection(str);

        private void button1_Click(object sender, EventArgs e)
        {
            String s1 = textBox1.Text;
            String s2 = textBox2.Text;
            String s3 = textBox3.Text;
            String s4 = textBox4.Text;
            String s5 = textBox5.Text;
            String s6 = textBox6.Text;

      string constr = "server=.;database=information;integrated security=SSPI";
            SqlConnection mcon = new SqlConnection(constr);
            mcon.Open();
            string sql = String.Format("insert into jibenxinxi values('{0}','{1}','{2}','{3}','{4}','{5}')", s1, s2, s3, s4, s5, s6);
            SqlCommand mcmd = new SqlCommand(sql,mcon);

            if (mcmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("添加成功");
                this.Visible = false;
                new Form1().Visible = true;
            }

            mcon.Close();
        }
    }
}
