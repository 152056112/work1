
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace shiyanqi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //采用集成的Windows验证方式
        static string str = "server=.;database=information;integrated security=SSPI";
        //1.建立SqlConnection对象，指定SqlConnection对象的ConnectionString属性；
        SqlConnection mconn = new SqlConnection(str);

        private void Form1_Load(object sender, System.EventArgs e)
        {
            String sql = "select * from jibenxinxi";
            SqlDataAdapter da = new SqlDataAdapter(sql, mconn);
            DataSet ds = new DataSet();
            da.Fill(ds, "information");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "information";
            dataGridView1.Columns[0].HeaderText = "菜号";
            dataGridView1.Columns[1].HeaderText = "菜名";
            dataGridView1.Columns[2].HeaderText = "价格";
            dataGridView1.Columns[3].HeaderText = "类别";
            dataGridView1.Columns[4].HeaderText = "备注一";
            dataGridView1.Columns[4].HeaderText = "备注二";
            mconn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取输入的值
            string no = textBox1.Text;
            if (no == "")
            {
                String sql1 = "Select * from jibenxinxi";
                //4.建立SqlDataAdapter对象和DataSet对象；
                SqlDataAdapter da = new SqlDataAdapter(sql1, mconn);
                DataSet ds = new DataSet();
                da.Fill(ds, "emploees");
                //使用DataSet绑定时，必须同时指明DateMember 
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "emploees";
                mconn.Close();
                textBox1.Text = "";
            }
            else
            {
                string sql = string.Format("select * from jibenxinxi where no='{0}'", no);
                SqlDataAdapter mda = new SqlDataAdapter(sql, mconn);
                DataSet ds = new DataSet();
                mda.Fill(ds, "emploees");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "emploees";
                mconn.Close();
                textBox1.Text = "";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new addmune().Visible = true;
            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            String sql = String.Format("delete from jibenxinxi where name ={0}", name);
            SqlCommand sqlcommand = new SqlCommand(sql, mconn);
            mconn.Open();
            if (sqlcommand.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("删除成功！");
            }
            String sql1 = "select * from jibenxinxi ";
            SqlDataAdapter da = new SqlDataAdapter(sql1, mconn);
            DataSet ds = new DataSet();
    //ds是dataset类的对象，就是一个表的集合，是之前声明好的，fil l函数就是告诉电脑，把查询到的数据保存到哪个位置。
            //emploees为虚拟数据表的表名
            da.Fill(ds, "emploees");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "emploees";
            mconn.Close();
        }
    }
}
